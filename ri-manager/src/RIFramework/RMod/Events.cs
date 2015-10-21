using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;
using System.Data.SqlClient;

namespace at.ac.tuwien.dsg.RIFramework.RMod {
    public delegate void EventAction();
    public delegate long EventExecutionTimeInIterations();  //a closure.

    public abstract class Event {
        public long executionTime { 
            get { return calculateExecutionTime(); } 
            set { expressedInIterations = false; 
                executionTime = value; 
            } 
        }  
        public readonly int EvtID;
        //public Query selectQuery;
        //public Query modifyQuery;
        public EventAction action;
        public bool expressedInIterations;
        public EventExecutionTimeInIterations executionTimeInIterations = () => { return -1; };

		public abstract void execute();

		protected Event(EventAction act) {
            action = act;
            EvtID = Utils.getNewUID();
        }

        /// <summary>
        /// Constructor for Events whose execution time is expressed in fixed clock ticks.
        /// </summary>
        /// <param name="act"></param>
        /// <param name="execTime"></param>
        public Event(EventAction act, long execTime) {
            expressedInIterations = false;
            action = act;
            EvtID = Utils.getNewUID();
            executionTime = execTime;
		}

        /// <summary>
        /// Constructor for events whose execution time is expressed in Iterations
        /// </summary>
        /// <param name="act"></param>
        /// <param name="execTimeInIters"></param>
        public Event(EventAction act, EventExecutionTimeInIterations execTimeInIters) {
            expressedInIterations = true;
            action = act;
            EvtID = Utils.getNewUID();
            executionTimeInIterations = execTimeInIters;
        }

        protected long calculateExecutionTime() {
            if (!expressedInIterations)
                return executionTime;
            else
                return executionTimeInIterations();
        }

    }

	//TODO: vidjeti koji sve tacno podtipovi evenata mi trebaju
	public class EvaluationEvent : Event {

        public EvaluationEvent(EventAction act, long execTime) : base(act, execTime) {}
        public EvaluationEvent(EventAction act, EventExecutionTimeInIterations execTimeInIters) : base(act, execTimeInIters) { }

        public override void execute() {
            action();
		}
	}

	public class ActionEvent : Event
	{

       public ActionEvent(EventAction act, long execTime) : base(act, execTime) {}
       public ActionEvent(EventAction act, EventExecutionTimeInIterations execTimeInIters) : base(act, execTimeInIters) { }

		public override void execute() {

            action(); //this action must also store the results in the database. 
		}
	}

	public class ByEventTimes : IComparer<Event> {
		public int Compare(Event x, Event y) {
			return Comparer<long>.Default.Compare(x.executionTime, y.executionTime);
		}
	}

}
