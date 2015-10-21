using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using de.unika.ipd.grGen.libGr;
using de.unika.ipd.grGen.lgsp;
using at.ac.tuwien.dsg.RIFramework.RMod;
using at.ac.tuwien.dsg.RIFramework.MMod;

//redefinicije tipova
//postavljanje (auto) varijabli
//dodavanje IncLogic._<bilosta>
//def _parent
//parametri moraju biti ekspozovani kao public fields

using DICT = System.Collections.Generic.Dictionary<string, object>; //default dictionary
using _timeline = at.ac.tuwien.dsg.RIFramework.RMod.Timeline;

using de.unika.ipd.grGen.Action_ReplaceManager;
using de.unika.ipd.grGen.Model_ReplaceManager;




#region InterlayerInterfacingCode
namespace at.ac.tuwien.dsg.RIFramework.RMod
{
    
    #region Attributes

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class TreatAsIncentiveMechanismAttribute : Attribute
    {
        public int priority;

        public TreatAsIncentiveMechanismAttribute() { }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class TreatAsIncentiveStrategyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class P_Logic : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class S_Logic : Attribute
    {

    }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class F_Logic : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class T_Logic : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class A_Logic : Attribute
    {

    }


    #endregion Attributes

    public static class IncentiveStrategyManager
    {

        private static Dictionary<int, IncentiveStrategy_RMod> strategies = new Dictionary<int, IncentiveStrategy_RMod>();

        public static void AddStrategy(int id, IncentiveStrategy_RMod s)
        {
            strategies.Add(id, s);
            foreach (var incmech in IncentiveStrategy_RMod.getIncentiveMechanismMethods(s))
            {
                IncentiveMechanismManager.activateIncentiveMechanism(s, incmech, id.ToString());
            }
        }

        public static void RemoveStrategy(int id)
        {
            IncentiveStrategy_RMod toRemove = (from s in strategies where s.Key == id select s.Value).FirstOrDefault();

            if (toRemove == null) return;

            IncentiveMechanismManager.deactivateIncentiveMechanism(toRemove.Id.ToString());

            strategies.Remove(id);
        }
    }

    public class IncentiveMechanismManager
    {

        private static List<MechanismExecutionInfo> incentiveMechanismList = new List<MechanismExecutionInfo>();

        public static void activateIncentiveMechanism(IncentiveStrategy_RMod strategy, MethodInfo mechanism, string prettyName)
        {
            incentiveMechanismList.Add(new MechanismExecutionInfo { Strategy = strategy, Mechanism = mechanism, Name = prettyName });
            incentiveMechanismList.Sort(new SortByPriorityAscending());
        }

        public static void deactivateIncentiveMechanism(string mechanismName)
        {
            var m = (from incm in incentiveMechanismList
                     where incm.Name.Equals(mechanismName)
                     select incm).FirstOrDefault();
            if (m != null)
            {
                incentiveMechanismList.Remove(m);
            }
        }

        public static void triggerMechanismExecution()
        {
            foreach (var m in incentiveMechanismList)
            {

                m.Mechanism.Invoke(m.Strategy, new object[] { });

            }

        }

        #region InnerTypes
        class MechanismExecutionInfo
        {
            public IncentiveStrategy_RMod Strategy;
            public MethodInfo Mechanism;
            public string Name;
        }

        class SortByPriorityAscending : IComparer<MechanismExecutionInfo>
        {
            public int Compare(MechanismExecutionInfo x, MechanismExecutionInfo y)
            {
                var attX = Attribute.GetCustomAttribute(x.Mechanism, typeof(TreatAsIncentiveMechanismAttribute));
                var attY = Attribute.GetCustomAttribute(y.Mechanism, typeof(TreatAsIncentiveMechanismAttribute));

                if (attX == null || attY == null) return 0;

                int priorityX = ((TreatAsIncentiveMechanismAttribute)attX).priority;
                int priorityY = ((TreatAsIncentiveMechanismAttribute)attY).priority;

                if (priorityX < priorityY) return -1;
                if (priorityX > priorityY) return 1;
                return 0;
            }
        }
        #endregion InnerTypes
    }



    public abstract class IncentiveStrategy_RMod
    {



        protected LGSPGraphProcessingEnvironment GRG_environment = Structure.instance.environment;
        
        public ReplaceManagerActions GRGactions = (ReplaceManagerActions)Structure.instance.actions;


        public int Id { get; private set; }

        protected IncentiveStrategy_RMod(int UId) { this.Id = UId; }

        public void MARK(IEnumerable<Worker> workers, int mark)
        {
            foreach (Worker w in workers)
            {
                w.Node.SetAttribute("marked", mark);
            }
        }


        public static IEnumerable<MethodInfo> getIncentiveMechanismMethods(IncentiveStrategy_RMod strategy)
        {
            List<MethodInfo> mechanisms = new List<MethodInfo>();
            foreach (MethodInfo mInfo in strategy.GetType().GetMethods())
            {
                // Iterate through all the attributes of the method. 
                foreach (Attribute attr in Attribute.GetCustomAttributes(mInfo))
                {
                    if (attr.GetType() == typeof(TreatAsIncentiveMechanismAttribute))
                    {
                        //Console.WriteLine("Method {0} of strategy {1} is an incentiveMechanism. ", mInfo.Name, strategy.GetType().Name);
                        mechanisms.Add(mInfo);
                    }
                }
            }
            return mechanisms;
        }

    } //end class IncentiveStrategy_RMod




} //end namespace at.ac.tuwien.dsg.RIFramework.RMod
#endregion InterlayerInterfacingCode


namespace at.ac.tuwien.dsg.PRINGL.RotatingPresidency
{

    public interface IHasParameters
    {
        object getParam(string name);
        void setParam(string name, object value);
    }

    #region IncentiveLogic
    public static partial class IncLogic
    {
        public static Worker _w; 
        public static IEnumerable<Worker> _ws; 
        public static IHasParameters _parent;

        //static fields of WasTooLong
        //*
        static Dictionary<Worker, int> leaderHistory = new Dictionary<Worker, int>(); //static(.)+; gets moved out of method in IncLogic
        //*
        [P_Logic]
        public static bool WasTooLong(int iters)
        {
             if (_ws.Count() == 2) {
	            if (leaderHistory.ContainsKey(_ws.First())){
	              leaderHistory.Clear();
	              leaderHistory[_ws.Last()] = 1;
  	            }else{
	              leaderHistory.Clear();
	              leaderHistory[_ws.First()] = 1;
	            }  
            }
            else   
             {
                if (leaderHistory[_ws.First()]< iters) 
                {
	              leaderHistory[_ws.First()]++;
	              return false;
	            }
             }
            return true;
        }



        [A_Logic]
        public static IEnumerable<Worker> SetManager(int teamID)
        {
            /*KOD_SetManager */
            return null;
        }

        [P_Logic]
        public static bool IsTeamMember(int teamID)
        {
            var teams = (DICT)IncLogic._w.GetData("teams", PRINGLBasicDataType.COMPOSITE); 
            return teams.ContainsKey(teamID.ToString());
           
        }

        [S_Logic]
        public static IEnumerable<Worker> SET_MANAGER(int teamID, int newMgrID)
        {
            /*KOD_SET_MANAGER */
            return null;
        }

        [F_Logic]
        public static void GetMgrByRelations(int teamID)
        {
            /*KOD_GetMgrByRelations */
        }

        [P_Logic]
        public static bool NotSame()
        {
            if (IncLogic._ws.Count() > 1)
                return true;
            else
                return false;
        }

        //static fields of WasTooLong
        //*
        public static Worker theBest;
        //*
        [F_Logic]
        public static void GetWrkBestMetric(string metricName)
        {
            double bestResult = IncLogic._ws.Max(x => (double) x.GetData(metricName, PRINGLBasicDataType.DOUBLE));
            theBest = IncLogic._ws.First(x => (double) x.GetData(metricName, PRINGLBasicDataType.DOUBLE) == bestResult);

            

        }

        [P_Logic]
        public static bool IsManager(int teamID)
        {
            /*KOD_IsManager */
            return true;
        }

        [P_Logic]
        public static bool IsBest()
        {
            /*KOD_IsBest */
            return true;
        }

        [S_Logic]
        public static IEnumerable<Worker> GET_MANAGER(int teamID)
        {
            /*KOD_GET_MANAGER */
            return null;
        }

    }
    #endregion IncentiveLogic

    #region Filters

    public abstract class Filter : IHasParameters
    {
        public HashSet<Worker> inputWorkers = new HashSet<Worker>();

        public HashSet<Filter> incoming = new HashSet<Filter>();
        public HashSet<Filter> outgoing = new HashSet<Filter>();

        //public delegate IEnumerate<PoiT> timeRestriction
        //public delegate COLLECTION_NAME <PoiT> + " " + l.Name + "(");

        
        public abstract object getParam(string name);
        public abstract void setParam(string name, object value);


        
        
        public Filter(HashSet<Worker> inputWorkers)
        {
            this.inputWorkers = inputWorkers;
        }

        public Filter() { }

        protected HashSet<Worker> inputUnionOfWorkers()
        {
            HashSet<Worker> allInputWorkers = new HashSet<Worker>(inputWorkers); //add my workers (needed for the first filter in a composite one
            

            foreach (var inputFilter in this.incoming)
            {
                allInputWorkers.UnionWith(inputFilter.output());
            }

            return allInputWorkers;
        }

        abstract public HashSet<Worker> output();

    } //end base class Filter

    public class Passthru : Filter
    {
        override public object getParam(string name) { return null; /*TODO*/ }
        override public void setParam(string name, object value) { /*TODO*/}


        public override HashSet<Worker> output()
        {
            return inputUnionOfWorkers();

        }

    }

    public partial class GetTeam : Filter
    {

        override public object getParam(string name) { return null; /*TODO*/ }
        override public void setParam(string name, object value) { /*TODO*/}

        override public HashSet<Worker> output() { return null; /* TODO*/}

        public GetTeam(HashSet<Worker> inputWorkers)
        {
        }
    }
    public partial class GetBest : Filter
    {

        override public object getParam(string name) { return null; /*TODO*/ }
        override public void setParam(string name, object value) { /*TODO*/}

        override public HashSet<Worker> output() { return null; /* TODO*/}
        
        public GetBest(HashSet<Worker> inputWorkers)
        {
        }
    }
    public partial class GetManager : Filter
    {

        override public object getParam(string name) { return null; /*TODO*/ }
        override public void setParam(string name, object value) { /*TODO*/}

        override public HashSet<Worker> output() { return null; /* TODO*/}
        
        public GetManager(HashSet<Worker> inputWorkers)
        {
        }
    }
    #endregion Filters

    #region Actions

    #endregion Actions

    #region CompositeFilters

    #endregion CompositeFilters

    #region CompositeActions

    #endregion CompositeActions

    #region IncentiveMechanisms



    #endregion IncentiveMechanisms




    #region ReferencedInstances


    public abstract class LogicInstanceBase : IHasParameters
    {

        public Worker _w;
        public IEnumerable<Worker> _ws;
        public IHasParameters _parent;

        protected void setAutoParams()
        {
            IncLogic._ws = this._ws;
            IncLogic._w = this._w;
            IncLogic._parent = this._parent;
        }

         public object getParam(string name)
        {
            FieldInfo fi = this.GetType().GetField(name, BindingFlags.Public | BindingFlags.Instance);
            if (fi != null)
            {
                return fi.GetValue(this);
            }
            return null;
        }

         public void setParam(string name, object value)
        {
            FieldInfo fi = this.GetType().GetField(name, BindingFlags.Public | BindingFlags.Instance);
            if (fi != null)
            {
                fi.SetValue(this, value);
            }
        }
    }

    public abstract class TLogicInstance : LogicInstanceBase
    {
        public abstract IEnumerable<PoiT> invoke();
    }

    public abstract class SLogicInstance : LogicInstanceBase
    {
        public abstract IEnumerable<Worker> invoke();
    }

    public abstract class PLogicInstance : LogicInstanceBase
    {
        public abstract bool invoke();
    }

    public abstract class ALogicInstance : LogicInstanceBase
    {
        public abstract IEnumerable<Worker> invoke();
    }

    public abstract class FLogicInstance : LogicInstanceBase
    {
        public abstract object invoke();
    }

//NON-abstract IncLogic INSTANCES


    class IsTeamMember_Inst : PLogicInstance
    {
        public int teamID;

        override public bool invoke()
        {
            setAutoParams();
            return IncLogic.IsTeamMember(teamID);
        }
    }

    
    class IsBest_Inst : PLogicInstance
    {

        override public bool invoke()
        {

            setAutoParams();
            return IncLogic.IsBest();
        }
    }

    
    class IsManager_Inst : PLogicInstance
    {

   
        public int teamID;


        override public bool invoke()
        {
            setAutoParams();
            return IncLogic.IsManager(teamID);
        }
    }

    
    class NotSame_Inst : PLogicInstance
    {

        override public bool invoke()
        {
            setAutoParams();
            return IncLogic.NotSame();
        }
    }

    
    class WasTooLong_Inst : PLogicInstance
    {

   
        public int iters;

        override public bool invoke()
        {
            setAutoParams();
            return IncLogic.WasTooLong(iters);
        }
    }

    
    class SetManager_Inst : ALogicInstance
    {

   
        public int teamID;

        override public IEnumerable<Worker> invoke()
        {
            setAutoParams();
            return IncLogic.SetManager(teamID);
        }
    }

    
    class GetWrkBestMetric_Inst : FLogicInstance
    {

        public string metricName;

   

        override public object invoke()
        {
            IncLogic.GetWrkBestMetric(metricName);
            return null;
        }
    }

    
    class GetMgrByRelations_Inst : FLogicInstance
    {
        
        public int teamID;


        override public object invoke()
        {
            IncLogic.GetMgrByRelations(teamID);
            return null;
        }
    }

    #endregion ReferencedInstances












    public class IncStrategy_RotatingPresidency : IncentiveStrategy_RMod
    {

        

        public IncStrategy_RotatingPresidency(int UId) : base(UId) { }

        [TreatAsIncentiveMechanism(priority = 0)]
        public void RewardBest()
        {
            System.Console.WriteLine("pozvan RewardBest");
        }

        [TreatAsIncentiveMechanism(priority = 0)]
        public void PreventTooLong()
        {
            System.Console.WriteLine("pozvan preventTooLong");
        }



        #region relocate
        public void DISABLE_ROTATE_PRESIDENT()
        {
            //todo - do cleanup of scheduled actions. Main thread and Timeline thread will keep running.

        }

        public void ENABLE_ROTATE_PRESIDENT()
        {

            //int iterationId
            //Event evt1 = new ActionEvent(Program.rotatingPresidencyStrategy.ROTATE_PRESIDENT, 
            //                             delegate() {
            //                                return Iteration.END_OF(Timeline.getIteration(iterationId));
            //                             }
            //);

            //Timeline.addEvent(evt1);




        }

        public void ROTATE_PRESIDENT()
        {

            //Iteration myIteration = Timeline.getCurrentIteration();

            Console.WriteLine("Clock tick: " + Timeline.now());
            Console.WriteLine(Structure.instance.ToString());

            Worker currMgr = GetManager(GetTeam("T5"));
            Console.WriteLine("Current Manager = " + currMgr.WorkerID);

            //Worker bestWrk = GetBest(5, "effort");
            //SET_MANAGER("T5", bestWrk);

            Console.WriteLine(Structure.instance.ToString());
            //Console.WriteLine("New Manager = " + bestWrk.WorkerID);
        }

        public HashSet<Worker> GetTeam(string teamID)
        {

            //todo:kasnije ce ovo ici u bazu
            HashSet<Worker> set = new HashSet<Worker>();

            foreach (Worker w in Structure.instance.workers)
            {
                if ((string)w.GetData("team", PRINGLBasicDataType.STRING) == "T5")
                {
                    set.Add(w);
                }
            }
            return set;
        }

        public Worker GetManager(HashSet<Worker> team)
        {
            const int ACTION_ID = 66;

            MARK(team, ACTION_ID);
            IEmployee mgr = null;
            GRGactions.MANAGER.Apply(GRG_environment, ACTION_ID, ref mgr);
            MARK(team, 0);
            return Structure.instance.getWorker(mgr.id);
        }

        public void SET_MANAGER(string teamID, Worker newMgr)
        {
            const int ACTION_ID = 77;

            HashSet<Worker> team = GetTeam(teamID); //read from our DB/memory, not raph structure.

            MARK(team, ACTION_ID);
            while (GRGactions.SET_MANAGER.Apply(GRG_environment, ACTION_ID, newMgr.WorkerID)) { } //do the replacing while there are matches
            MARK(team, 0);
        }

        public IEnumerable<Worker> GetBest(int teamID, string metricName)
        {

            var result = new HashSet<Worker>();

            foreach (Worker w in Structure.instance.workers)
            {

            }

            return result;

        }
        #endregion relocate


        

    }//end class IncStrategy_<strategy name>


} //end namespace