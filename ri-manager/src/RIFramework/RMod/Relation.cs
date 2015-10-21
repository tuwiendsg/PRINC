using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;

namespace at.ac.tuwien.dsg.RIFramework.RMod {
    interface IRelation {

        //todo 

    }


    class Relation : IRelation {
        public readonly int UID;
        private LGSPEdge edge { get; set; }

        private Object Type { get; set; } //promijeni da bude zaista nekog tipa koji cu kasnije definisati

        public Worker GetSource() {
            return Structure.instance.getWorker((int)edge.lgspSource.GetAttribute("id"));
        }

        public Worker GetTarget() {
            return Structure.instance.getWorker((int) edge.lgspTarget.GetAttribute("id"));
        }
        
        public Relation() {
            UID = Utils.getNewUID();
        }
    }
}
