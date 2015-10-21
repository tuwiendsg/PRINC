using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using de.unika.ipd.grGen.libGr;
using de.unika.ipd.grGen.lgsp;

using at.ac.tuwien.dsg.PRINGL;

namespace at.ac.tuwien.dsg.RIFramework.RMod {
    public interface IWorker : IComparable<IWorker> {

    //todo 

        long getID();
       // void SetData(string name, Object value);
        Object GetData(string name, PRINGLBasicDataType dataType);
        //Object GetData(string name);
    }


    public class Worker : IWorker {

        private readonly long UID;
        private WorkerQuantitativeData LocalAttributes; //should be private and accessed through propetrties. But for now let it stay public.
        public LGSPNode Node { get; set; } //for now.


        public Worker(LGSPNode node)
        {
            UID = Utils.getNewUID();
            Node = node;
            LocalAttributes = new WorkerQuantitativeData(new Dictionary<string,object>(5));
        }

        public Worker(LGSPNode node, WorkerQuantitativeData localAttributes) {
            UID = Utils.getNewUID();
            Node = node;
            LocalAttributes = localAttributes;
        }

        public long getID() { return UID; }

        public long ID { get { return UID; }  }

        public int CompareTo(IWorker other) {
            return this.UID.CompareTo(other.getID());
        }


        //WorkerID, ObjectUID and Name are the equally-named columns in the DB. That's why we expose them them here separately via properties
        //which are needed to do reflection when writing these fields in the DB.
        public int WorkerID {
            get { return (int) UID; }
        }
        public long ObjectUID {
            get { return UID; }
        }
        public string Name {
            get {
                string s = "";
                try {
                    s = (string)LocalAttributes.GetData("Name");
                } catch (Exception e) {
                    System.Console.WriteLine(e);
                }
                return s;
            }
            set { LocalAttributes.SetData("Name", value); }
        }

        /// <summary>
        /// Stores the attribute to the local in-memory structure and the DB as well.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void SetData(string name, object value, PRINGLBasicDataType dataType) {

            if (dataType == PRINGLBasicDataType.COMPOSITE) {
                if (value.GetType() != typeof(Dictionary<string, object>)) throw new RewardingManagerException("Trying to store an unsupported type");
                SetData(name, (Dictionary<string, object>)value);
            } else {
                LocalAttributes.SetData(name, value);
                //RModDBManager.insertWorkerAttribute(this, name, value);
            }
        }

        /// <summary>
        /// Stores the attribute to the local in-memory structure and the DB as well.
        /// </summary>
        /// <param name="compositeValue"></param>
        private void SetData(string attributeName, Dictionary<string, object> compositeValue) {

            if (LocalAttributes.values.ContainsKey(attributeName)) {
                LocalAttributes.values[attributeName] = compositeValue;
            }else{
                LocalAttributes.values.Add(attributeName, compositeValue); //add to memory structure
            }
            
            //add to DB. U bazu zasad dodajemo uvijek inkrementalno. 
            //Zato ne nalazimo staru vrijednost koju cemo da apdejtujemo, vec samo dodajemo najnoviji podatak.
            List<string> keys = new List<string>(compositeValue.Keys.Count);
            List<object> values = new List<object>(compositeValue.Keys.Count);
            List<Worker> workers  = new List<Worker>(1);
            workers.Add(this);

            foreach (string key in compositeValue.Keys) {
                keys.Add(key);
                values.Add(compositeValue[key]);
            }

            //RModDBManager.insertWorkerAttribute(workers, attributeName, keys, values);
            
        }

        public object GetData(string name, PRINGLBasicDataType dataType) {
            //TODO: for now we don't read from the DB, because we expect that once the system is up and running, and the latest values
            //are read into the memory, all subsequent attribute changes to go into the db are first passed through this method, which
            //updates the in-mamory state as well, so no need to read the DB to obtain the current value. We will change this later on.
            return LocalAttributes.GetData(name, dataType);
        }


    }//end class Worker

}
