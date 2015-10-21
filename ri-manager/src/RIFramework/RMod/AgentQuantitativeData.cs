using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using at.ac.tuwien.dsg.PRINGL;


namespace at.ac.tuwien.dsg.PRINGL
{
    public enum PRINGLBasicDataType { OBJECT, STRING, DOUBLE, INT, LONG, COMPOSITE }
}

/// <summary>
/// Serves to represent quantitative data at the agent level. 
/// Treba jos vidjeti da li ce da se stvara kompajlovanjem ili pak nekako dinamicki.
/// Za sad je opcija da se prilikom stvaranja sistema navede neki xml, a na osnovu njega izgenerise ova klasa, odnosno neka izvedena iz nje.
/// </summary>
namespace at.ac.tuwien.dsg.RIFramework.RMod {

    public abstract class WorkerQuantitativeData_ {
        abstract public Object GetData(string name);
        abstract public Object GetData(string name, PRINGLBasicDataType dataType );
        abstract public void SetData(string name, Object value);
    }

    //so this should be compiler-generated
    public class WorkerQuantitativeData : WorkerQuantitativeData_ {

        public Dictionary<string, object> values; //actually the types contained will also depend on the compiler

        void importData(Dictionary<string,object> initialValues) {
            values = initialValues;
        }

        public override Object GetData(string name) {
            Object toReturn;
            try {
                toReturn = values[name];
            } catch (KeyNotFoundException) {
                toReturn = null;
            }
            return toReturn;
        }

        /// <summary>
        /// In case of non-existing name-value pair returns the default (neutral) value. In case you want a nullable return value, use GetData(string).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public override object GetData(string name, PRINGLBasicDataType dataType) {
            
            object toReturn = GetData(name);
            
            switch (dataType) {
                case PRINGLBasicDataType.STRING:
                    return (toReturn==null)?(""):(string) toReturn;
                case PRINGLBasicDataType.INT:
                    return (toReturn == null) ? 0 : (int)toReturn;
                case PRINGLBasicDataType.LONG:
                    return (toReturn == null) ? 0 : (long)toReturn;
                case PRINGLBasicDataType.DOUBLE:
                    return (toReturn == null) ? 0 : (double)toReturn;
                case PRINGLBasicDataType.COMPOSITE:
                case PRINGLBasicDataType.OBJECT:
                default:
                    return toReturn;

            }
        }

        public override void SetData(string name, Object value) {
            values[name] = value; //casting also to be compiler generated
        }

        public WorkerQuantitativeData(Dictionary<string, object> initialValues) {
            values = initialValues;
        }

    } //end WorkerQuantitativeData class



}
