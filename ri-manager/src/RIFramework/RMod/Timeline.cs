using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace at.ac.tuwien.dsg.RIFramework.RMod {
	
	public static class Timeline {

        

		public static readonly long timerInterval = 1000;

		private static long tickCount = 0;

		private static Timer timer = new Timer(Timeline.tick);
		private static SortedSet<Event> futureEvents = new SortedSet<Event>(new ByEventTimes());
        private static SortedSet<Iteration> iterations = new SortedSet<Iteration>(new ByStartTimes());

		static Timeline() {
			timer.Change(timerInterval, timerInterval);
			
		}

        public static long now() { return tickCount; }

		static void tick(Object t) {
			lock (typeof(Timeline)){
				tickCount++;
				
				Event evt;
				do {
					if (futureEvents.Count == 0) break;
					evt = futureEvents.First<Event>();
					if (evt.executionTime > tickCount) break;
					evt.execute();
					//in case of an action event, it is also stored in DB at this point
					futureEvents.Remove(evt);
				} while (true);

			}//end lock
		}

        internal static void endTimeline()
        {
            futureEvents.Clear(); //alternatively store somewhere for later reuse
            iterations.Clear();
            timer.Dispose();
        } 

		public static void addEvent(Event e) {
			//future events are not supposed to be used in evaluations, therefore they are kept in a memory data structure
 			//past events need to be kept in the database, so that we can reason over them.

			if (e.executionTime <= tickCount) {
                store(e);
			} else {
				futureEvents.Add(e);
			}
		}

        public static void store(Event e) {
            //todo store in DB
        }

		public static void initialize() {
			Console.WriteLine("timeline init\n");
		}

        public static void addIteration(Iteration i) {
            foreach (Iteration it in iterations) {
                if (it.id == i.id) {
                    throw new System.ApplicationException("Iteration already exists"); //todo - change with our exception
                }
            }
            if (!iterations.Add(i)) throw new System.ApplicationException("Iteration not added"); 
        }



        /// <summary>
        /// Alter information about iterations.
        /// </summary>
        /// <param name="id"> Id of the iteration we want to change </param>
        /// <param name="newStartTick">set explicitely to 0 if don't want to alter</param>
        /// <param name="newEndTick">set explicitely to 0 if don't want to alter</param>
        public static void changeIteration(long id, long newStartTick, long newEndTick) {
            Iteration i = iterations.First(o => o.id == id);

            if (newStartTick != 0) { //if we want to alter start time
                if (i.startTick > tickCount && newStartTick > tickCount)
                    i.startTick = newStartTick;
                else
                    throw new System.ApplicationException("Attempting change of start time of a running iteration or trying to set start time in the past");
            }

            if (newEndTick != 0) { //if we want to alter end time
                if (i.endTick > tickCount && newEndTick >= tickCount)
                    i.endTick = newEndTick;
                else
                    throw new System.ApplicationException("Attempting to st end time of an iteration in past");
            }

        }

        public static Iteration getIteration(long id) {
            return iterations.First(x => x.id == id);
        }

        public static Iteration getCurrentIteration() {
            return iterations.First(x => x.startTick >= tickCount);
            
        }

        public static void loadIterationInfo(long startTick, long endTick) {
             

        }

        public static Iteration getIterationByName(string name) 
        {
            var x = from i in iterations
                    where i.friendlyName.Equals(name)
                    select i;

            return x.SingleOrDefault();
        }


        public static IEnumerable<Iteration> getIterationsInInterval(long startTick, long endTick)
        {
            var x = from i in iterations
                    where i.startTick <= endTick && i.endTick > startTick 
                    select i;

            return x;
        }

	}//end class Iteration

    

    public class Iteration {

        public long id {get; set;}
        public long startTick {get; internal set;}
        public long endTick { get; internal set; }
        public string friendlyName { get; private set; }
        //public bool active = true;

        public Iteration(long id, PoiT startTick, PoiT endTick, string friendlyName = "") {
            this.id = id;
            this.startTick = startTick;
            this.endTick = endTick;
            this.friendlyName = friendlyName;
        }



        public static PoiT START_OF(Iteration i) {
            return i.startTick;
        }

        public static PoiT END_OF(Iteration i) {
            return i.endTick;
        }
        public static PoiT MIDDLE_OF(Iteration i) {
            return i.startTick + (i.endTick - i.startTick) / 2 ;
        }
    }

    public class ByStartTimes : IComparer<Iteration> {
        public int Compare(Iteration x, Iteration y) {
            return Comparer<long>.Default.Compare(x.startTick, y.startTick);
        }
    }

    //at this point for purely demo purposes we just use the simplest possible implementation, a wrapper around long
    public class PoiT 
    {
       public long tick {get; set;}

        public PoiT(long tick) 
        {
            this.tick = tick;
        }

        // overload operator + 
        public static PoiT operator +(PoiT a, PoiT b)
        {
            return new PoiT(a.tick + b.tick);
        }

        // user-defined conversion from PoiT to long
        public static implicit operator long(PoiT t)
        {
            return t.tick;
        }

        //  User-defined conversion from long to PoiT 
        public static implicit operator PoiT(long t)
        {
            return new PoiT(t);
        }
    }
}
