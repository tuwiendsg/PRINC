using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using de.unika.ipd.grGen.libGr;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.Action_ReplaceManager;
using de.unika.ipd.grGen.Model_ReplaceManager;


using at.ac.tuwien.dsg.PRINGL.RotatingPresidency;
using at.ac.tuwien.dsg.RIFramework.RMod;
using at.ac.tuwien.dsg.RIFramework.MMod;

using at.ac.tuwien.dsg.PRINGL;

namespace at.ac.tuwien.dsg.RIFramework {
    
           

    
    class Program {

        public static int TEAMID = 5;
        
       
        #region NekiKomentari1
        //IAction_SET_MANAGER SET_MANAGER = Action_SET_MANAGER.Instance;
        //IMatchesExact<Rule_SET_MANAGER.IMatch_SET_MANAGER> matches = SET_MANAGER.Match(environment, 4, 0, 1);

        //for (int i = 0; i < 3; i++) {
        //    SET_MANAGER.Modify(environment, (Rule_SET_MANAGER.IMatch_SET_MANAGER)matches.GetMatch(i));
        //}

        //pojedinacna akcija kao objekat:
        //IAction_replaceBadManager actionReplaceOldManager = Action_replaceBadManager.Instance;

        //i njena primjena:
        //IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> matchovi = actionReplaceOldManager.Match(environment, -1); //nadji sve matchove
        //actionReplaceOldManager.Modify(environment, matchovi.FirstExact);

        //var worker = new MMWorker {id=1,rank=2,performance=3};
        //var artifact = new MMArtifact {id=1,type=2,importance=3};
        //var action = new MMAction {
        //    id = 1,
        //    value = 2.0,
        //    type = 3,
        //    difficulty = 4.0,
        //    weight = 5.0,
        //    timestamp = 777,
        //    workers = new List<MMWorker>(),
        //    artifact = artifact,
        //    teams = null
        //};
        //action.workers.Add(worker);

        //using (var file = System.IO.File.Create("test.bin")) {
        //    Serializer.serialize(file, action);
        //}

        //MMAction newMsg;
        //using (var file = System.IO.File.OpenRead("test.bin")) {
        //    newMsg = Serializer.deserialize(file);
        //}


        //MMArtifact artf = new MMArtifact();
        //artf.id = 1;

        //RModDBManager.insertWorker(Structure.instance.workers.Min);
        //RModDBManager.insertWorker(Structure.instance.workers.Max);

        //return;

        //RModDBManager.executeSQLScript(RModDBManager.Scripts.SQLScript_DB_CREATE);

        // MMod.MappingModule.msgReceived(); //simulates receiving a msg from the underlying system.
        #endregion



        [STAThread] 
        static void Main(string[] args) {



            GetWrkBestMetric_Inst a = new GetWrkBestMetric_Inst();

            a.setParam("metricName", "neko ime");
            var x = (string)a.getParam("metricName");

            Console.Write(x);
            //RotatingPresidencySetup();

            //Console.WriteLine(Structure.instance);

            if (1 + 1 == 2) return;

            //var list = IncentiveStrategy_RMod.getIncentiveMechanismMethods(rotatingPresidencyStrategy);
            var k = new MMAction();
            k.type = (int)MMActionType_RotatingPresidency.ENABLE_INCENTIVE;
            k.value = 1234; //id of the incentive
            MappingModule.msgReceived(k);

            IncentiveMechanismManager.triggerMechanismExecution();

            if (1+1 == 2) return;

            RotatingPresidencySetup();          

			Timeline.initialize();

            int choice = 0;
            bool endProgram = false;
            for (; ; ) 
            { 
                System.Threading.Thread.Sleep(1000); 
                //just temporary for this simulation, simulate arrival of external messages
                switch (choice++) 
                { 
                    case 0:
                        var m = new MMAction();
                        m.type = (int) MMActionType_RotatingPresidency.ENABLE_INCENTIVE;
                        m.value = 1234; //id of the incentive
                        MappingModule.msgReceived(m);
                        break;
                    case 32:
                        m = new MMAction();
                        m.type = (int) MMActionType_RotatingPresidency.DISABLE_INCENTIVE;
                        m.value = 1234;  //id of the incentive
                        MappingModule.msgReceived(m);
                        break;
                    case 40:
                        endProgram = true;
                        break;
                    default:
                        break;
                }//end switch

                if ((choice) % 10 == 1 || (choice) % 10 == 9)
                {
                    Console.WriteLine("Clock tick: " + Timeline.now());
                    Console.WriteLine(Structure.instance.ToString());
                    Console.WriteLine("\n################################\n\n\n");
                }

                if (endProgram)
                {
                    Timeline.endTimeline();
                    return; //end program
                }
            }
			
        } //end Main()



        static void RotatingPresidencySetup()
        {


            //Timeline.addIteration(new Iteration(0,  0,  9, "firstIteration"));
            //Timeline.addIteration(new Iteration(1, 10, 19, "secondIteration"));
            //Timeline.addIteration(new Iteration(2, 20, 29, "thirdIteration"));
            //Timeline.addIteration(new Iteration(3, 30, 39, "fourthIteration"));


            //Iteration[] iters = new Iteration[] {
            //            Timeline.getIterationByName("firstIteration"),
            //            Timeline.getIterationByName("secondIteration"), 
            //            Timeline.getIterationByName("thirdIteration"),
            //            Timeline.getIterationByName("fourthIteration")
            //};

            //long[] simulatedExternalTriggers = new long[] { 
            //            Iteration.END_OF(iters[0]),
            //            Iteration.END_OF(iters[1]),
            //            Iteration.END_OF(iters[2]),
            //            Iteration.END_OF(iters[3])
                                                            
            //};

            ////schedule triggering of execution of all active incentive mechanisms at the end of each iteration
            //foreach (var t in simulatedExternalTriggers)
            //{
            //    Timeline.addEvent(new ActionEvent(IncentiveMechanismManager.triggerMechanismExecution,t));
            //}

            
            //simulate change of effort metrics
            //Timeline.addEvent(new ActionEvent(simulateChangeMetrics, Iteration.MIDDLE_OF(iters[1])));


            //set up initial GrGen structure, then associate with PRINC Workers 
            Employee[] graphNodes = new Employee[4];       
            graphNodes[0] = Employee.CreateNode(Structure.instance.graph);
            graphNodes[1] = Employee.CreateNode(Structure.instance.graph);
            graphNodes[2] = Employee.CreateNode(Structure.instance.graph);
            graphNodes[3] = Employee.CreateNode(Structure.instance.graph);

            graphNodes[0].id = 0;
            graphNodes[1].id = 1;
            graphNodes[2].id = 2;
            graphNodes[3].id = 3;
            
            ManagedBy.CreateEdge(Structure.instance.graph, graphNodes[0], graphNodes[3]);
            ManagedBy.CreateEdge(Structure.instance.graph, graphNodes[1], graphNodes[3]);
            ManagedBy.CreateEdge(Structure.instance.graph, graphNodes[2], graphNodes[3]);
            

            for (int i = 0; i < 4; i++)
            {
                Worker w = new Worker(graphNodes[i]);
                w.Name = "Worker " + i;

                w.SetData("effort", i + 1, PRINGLBasicDataType.INT);

                var teams = new Dictionary<string, object>();
                teams.Add(TEAMID.ToString(), TEAMID);
                w.SetData("teams", teams, PRINGLBasicDataType.COMPOSITE);

                Structure.instance.workers.Add(w);
            }

          

        } //end RotatingPresidencySetup()

        public static void simulateChangeMetrics()
        {
            var toBecomeNewMgr = Structure.instance.workers.SingleOrDefault(w => w.Name.Equals("Worker1"));
            int currentlyHighestMetric = (from w in Structure.instance.workers
                                         select (int)w.GetData("effort", PRINGLBasicDataType.INT)).Max();

            toBecomeNewMgr.SetData("effort", ++currentlyHighestMetric, PRINGLBasicDataType.INT); 
        }

    } //end class Program


} //end namespace
