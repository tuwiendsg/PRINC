using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;

using de.unika.ipd.grGen.Action_ReplaceManager;
using de.unika.ipd.grGen.Model_ReplaceManager;

namespace at.ac.tuwien.dsg.RIFramework.RMod {
    
    public class Structure {
        //singleton

        private static Structure _inst; 

        public static Structure instance {
            get {
                if (_inst == null)
                    _inst = new Structure();
                
                return _inst;
            }

            private set {}
        }

        public LGSPGraph graph { get; private set; } //za sad naravno
        public LGSPActions actions { get; private set; }
        public LGSPGraphProcessingEnvironment environment { get; private set; }
        public HashSet<Worker> workers { get; set; }

        private Structure() {
            
            graph = new ReplaceManagerGraph();
            actions = new ReplaceManagerActions(graph);
            environment = new LGSPGraphProcessingEnvironment(graph, actions);
            workers = new HashSet<Worker>();
        }




        //public void performTransformation(LGSPAction action) { }
        
        


        public Worker getWorker(int id) {
            return workers.SingleOrDefault(w => w.WorkerID == id);
        }

        //public void insertWorker(Worker w)
        //{
        //    //if (RModDB.RModDBManager.insertWorker(w))
        //    workers.Add(w);
        //}

		public override string ToString() {

			string s = "digraph {\n";

			foreach (INode n in graph.Nodes) {
				string name = "Worker" + (int)n.GetAttribute("id");
				s += name + " [label=\"" + name + ":" + n.ToString() + "\"];\n";
			}

			foreach (IEdge e in graph.Edges) {
				s += "Worker" + ((int)e.Source.GetAttribute("id")) + " -> Worker" + ((int)e.Target.GetAttribute("id")) + /*" [label=\"" + e.ToString() + "\"] +*/ ";\n";
			}

			return s + "}";
		}

    }

    
}
