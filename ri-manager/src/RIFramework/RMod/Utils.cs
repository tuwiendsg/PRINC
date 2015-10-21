using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections;

namespace at.ac.tuwien.dsg.RIFramework {
    public class Utils {

        public static int getNewUID() {
            //in reality, everything should be ulong, but for easier reading in the development phase, we set now everything to int.
            byte[] buffer = Guid.NewGuid().ToByteArray();

            return Math.Abs((int)BitConverter.ToInt64(buffer, 0) % Int32.MaxValue);
        }

        public class Reflection {

            /// <summary>
            /// Copies the data of one object to another. The target object gets properties of the first. 
            /// Any matching properties (by name) are written to the target.
            /// </summary>
            /// <param name="source">The source object to copy from</param>
            /// <param name="target">The target object to copy to</param>
            public static void CopyObjectData(object source, object target) {
                CopyObjectData(source, target, String.Empty, BindingFlags.Public | BindingFlags.Instance);
            }

            /// <summary>
            /// Copies the data of one object to another. The target object gets properties of the first. 
            /// Any matching properties (by name) are written to the target.
            /// </summary>
            /// <param name="source">The source object to copy from</param>
            /// <param name="target">The target object to copy to</param>
            /// <param name="excludedProperties">A comma delimited list of properties that should not be copied</param>
            /// <param name="memberAccess">Reflection binding access</param>
            public static void CopyObjectData(object source, object target, string excludedProperties, BindingFlags memberAccess) {
                string[] excluded = null;
                if (!string.IsNullOrEmpty(excludedProperties)) {
                    excluded = excludedProperties.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                }

                MemberInfo[] miT = target.GetType().GetMembers(memberAccess);
                foreach (MemberInfo Field in miT) {
                    string name = Field.Name;

                    // Skip over excluded properties
                    if (string.IsNullOrEmpty(excludedProperties) == false
                        && excluded.Contains(name)) {
                        continue;
                    }


                    if (Field.MemberType == MemberTypes.Field) {
                        FieldInfo sourcefield = source.GetType().GetField(name);
                        if (sourcefield == null) { continue; }

                        object SourceValue = sourcefield.GetValue(source);
                        ((FieldInfo)Field).SetValue(target, SourceValue);
                    } else if (Field.MemberType == MemberTypes.Property) {
                        PropertyInfo piTarget = Field as PropertyInfo;
                        PropertyInfo sourceField = source.GetType().GetProperty(name, memberAccess);
                        if (sourceField == null) { continue; }

                        if (piTarget.CanWrite && sourceField.CanRead) {
                            object targetValue = piTarget.GetValue(target, null);
                            object sourceValue = sourceField.GetValue(source, null);

                            if (sourceValue == null) { continue; }

                            if (sourceField.PropertyType.IsArray
                                && piTarget.PropertyType.IsArray
                                && sourceValue != null) {
                                CopyArray(source, target, memberAccess, piTarget, sourceField, sourceValue);
                            } else {
                                CopySingleData(source, target, memberAccess, piTarget, sourceField, targetValue, sourceValue);
                            }
                        }
                    }
                }
            }

            public static void CopyObjectProperties(object source, object target, string excludedProperties) {
                string[] excluded = null;
                BindingFlags memberAccess = BindingFlags.Public | BindingFlags.Instance;

                

                if (!string.IsNullOrEmpty(excludedProperties)) {
                    excluded = excludedProperties.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                }

                PropertyInfo[] miT = target.GetType().GetProperties(memberAccess);
                foreach (PropertyInfo targetField in miT) {
                    string name = targetField.Name;

                    // Skip over excluded properties
                    if (string.IsNullOrEmpty(excludedProperties) == false
                        && excluded.Contains(name)) {
                        continue;
                    }

                    PropertyInfo sourceField = source.GetType().GetProperty(name, memberAccess);
                    if (sourceField == null) { continue; }

                    if (targetField.CanWrite && sourceField.CanRead) {
                        
                        object targetValue = targetField.GetValue(target, null);
                        object sourceValue = sourceField.GetValue(source, null);


                        if (sourceValue == null) { continue; }

                        if (sourceField.PropertyType.IsArray
                            && targetField.PropertyType.IsArray
                            && sourceValue != null) {
                            CopyArray(source, target, memberAccess, targetField, sourceField, sourceValue);
                        } else {
                            CopySingleData(source, target, memberAccess, targetField, sourceField, targetValue, sourceValue);
                        }
                    }
                    


                }
            }

            public static bool isCollection(object o) {
                if (!o.GetType().IsGenericType) {
                    if (o is ICollection) return true;
                    return false;
                }
                //it is generic:
                Type t = o.GetType().GetGenericTypeDefinition();
                if (typeof(IEnumerable<>).IsAssignableFrom(t)) return true;
                return false;
            }

            #region privateStuff

            private static Type GetCoreType(Type type) {
                if (type.IsGenericType &&
                    type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    return Nullable.GetUnderlyingType(type);
                else
                    return type;
            }

            private static void CopySingleData(object source, object target, BindingFlags memberAccess, PropertyInfo piTarget, PropertyInfo sourceField, object targetValue, object sourceValue) {
                
               
                //instantiate target if needed
                if (targetValue == null
                    && piTarget.PropertyType.IsValueType == false
                    && piTarget.PropertyType != typeof(string)) {
                    if (piTarget.PropertyType.IsArray) {
                        targetValue = Activator.CreateInstance(piTarget.PropertyType.GetElementType());
                    } else {
                        targetValue = Activator.CreateInstance(piTarget.PropertyType);
                    }
                }

                if (piTarget.PropertyType.IsValueType == false
                    && piTarget.PropertyType != typeof(string)) {
                    CopyObjectData(sourceValue, targetValue, "", memberAccess);
                    piTarget.SetValue(target, targetValue, null);
                } else {
                    //this with GetCoreType() is a hack around the problem that the type is "Nullable`1" when LINQ returns a type that is nullable in the DB
                    if (GetCoreType(piTarget.PropertyType).FullName == GetCoreType(sourceField.PropertyType).FullName) {
                        object tempSourceValue = sourceField.GetValue(source, null);
                        piTarget.SetValue(target, tempSourceValue, null);
                    } else {
                        CopyObjectData(piTarget, target, "", memberAccess);
                    }
                }
            }

            private static void CopyArray(object source, object target, BindingFlags memberAccess, PropertyInfo piTarget, PropertyInfo sourceField, object sourceValue) {
                int sourceLength = (int)sourceValue.GetType().InvokeMember("Length", BindingFlags.GetProperty, null, sourceValue, null);
                Array targetArray = Array.CreateInstance(piTarget.PropertyType.GetElementType(), sourceLength);
                Array array = (Array)sourceField.GetValue(source, null);

                for (int i = 0; i < array.Length; i++) {
                    object o = array.GetValue(i);
                    object tempTarget = Activator.CreateInstance(piTarget.PropertyType.GetElementType());
                    CopyObjectData(o, tempTarget, "", memberAccess);
                    targetArray.SetValue(tempTarget, i);
                }
                piTarget.SetValue(target, targetArray, null);
            }
            

            
            #endregion privateStuff
        }

    }
}
