using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using at.ac.tuwien.dsg.RIFramework.RMod;

namespace at.ac.tuwien.dsg.RIFramework.MMod {
    class MappingModule {
        protected static long iterationId = 1;

        
        /// <summary>
        /// Main method that gets called when message (at the time equal to MMAction and with it seralized MM___ objects) arrives from the
        /// underlying system.
        /// </summary>
        /// <param name="action"></param>
        public static void msgReceived(MMAction action) {

            //List<Worker> workers = new List<Worker>();
            //List<long> teams = new List<long>(); //list of team identifiers

            //foreach (MMWorker w in action.workers) {
            //    workers.Add(Structure.instance.getWorker((int)w.id)); //worker is our in-memory representation
            //}
            //foreach (MMTeam t in action.teams) {
            //    teams.Add(t.id); //we have no internal representation for teams, but rather query each time, because teams are not constants. Team IDs are just used as a worker-independent way of targeting workers.
            //}

            
            switch (action.type) {
                case (int)MMActionType_RotatingPresidency.ENABLE_INCENTIVE:

                    IncentiveStrategyManager.AddStrategy((int)action.value, new at.ac.tuwien.dsg.PRINGL.RotatingPresidency.IncStrategy_RotatingPresidency((int)action.value));
                    break;
                case (int)MMActionType_RotatingPresidency.DISABLE_INCENTIVE:
                    IncentiveStrategyManager.RemoveStrategy((int)action.value);
                    break;
            }



            
        }

        public static void toInitializeDemo() {




        }


    
    }

    
}
