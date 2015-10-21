using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using at.ac.tuwien.dsg.RIFramework.RMod;

namespace at.ac.tuwien.dsg.RIFramework.MMod {
	//Mapping model
	
	[ProtoBuf.ProtoContract]
	public class MMAction {
		[ProtoBuf.ProtoMember(1)]
		public long id;

		[ProtoBuf.ProtoMember(2)]
		public double value;

		[ProtoBuf.ProtoMember(3)]
		public int type;

		[ProtoBuf.ProtoMember(4)]
		public double difficulty;

		[ProtoBuf.ProtoMember(5)]
		public double weight;

		[ProtoBuf.ProtoMember(6)]
		public long timestamp;

		[ProtoBuf.ProtoMember(7)]
		public MMArtifact artifact;

		[ProtoBuf.ProtoMember(8)]
		public List<MMWorker> workers; //it may suffice to just have an array of MMWorker IDs

		[ProtoBuf.ProtoMember(9)]
		public List<MMTeam> teams;
	}

	[ProtoBuf.ProtoContract]
	public class MMArtifact {

		[ProtoBuf.ProtoMember(1)]
		public long id;

		[ProtoBuf.ProtoMember(2)]
		public double importance;

		[ProtoBuf.ProtoMember(3)]
		public int type;
		//public List<MMAction> actions; //we may not need this. Consider removing.
	}

	[ProtoBuf.ProtoContract]
	public class MMWorker {

		[ProtoBuf.ProtoMember(1)]
		public long id;

		[ProtoBuf.ProtoMember(2)]
		public double rank;

		[ProtoBuf.ProtoMember(3)]
		public double performance;

		[ProtoBuf.ProtoMember(4)]
		public double effort;

		[ProtoBuf.ProtoMember(5)]
		public double experience;

		[ProtoBuf.ProtoMember(6)]
		public double expertise;

        [ProtoBuf.ProtoMember(7)]
        public double score;

        [ProtoBuf.ProtoMember(8)]
        public double points;

        [ProtoBuf.ProtoMember(9)]
        public double amount;

        [ProtoBuf.ProtoMember(10)]
        public double wage;

        [ProtoBuf.ProtoMember(11)]
        public double rate;

        [ProtoBuf.ProtoMember(12)]
        public double bonus;

        [ProtoBuf.ProtoMember(13)]
        public double payout;

		//public List<MMAction> actions; //we may not need this. Consider removing.
		//public List<MMTeam> teams; //we may not need this. Consider removing.
	}

	[ProtoBuf.ProtoContract]
	public class MMTeam {

		[ProtoBuf.ProtoMember(1)]
		public long id;

		[ProtoBuf.ProtoMember(2)]
		public List<MMWorker> workers;
	}

	public class MMGlobalData {

	}

	public class MMIterationData {

	}


    #region RotatingPresidency_Specific

    public enum MMActionType_RotatingPresidency
    {
        ENABLE_INCENTIVE = 1,
        DISABLE_INCENTIVE = 2
    }

    static class RotatingPresidency_Metrics
    {

        public static double calculateEffort(at.ac.tuwien.dsg.RIFramework.RMod.Worker w)
        {
            return (new Random().Next(1,100) / 100); //todo: change to return always predictable values for the simuation
        }


    }

    static class RotatingPresidency_Messages
    {
        public static void SendSuggestNewManager(at.ac.tuwien.dsg.RIFramework.RMod.Worker w)
        {
            MMAction msg = new MMAction();
            msg.timestamp = Timeline.now();
            List<MMWorker> workers = new List<MMWorker>();
            workers.Add(new MMWorker { id = w.WorkerID});
            msg.workers = workers;
            Serializer.serialize(null, msg, true);
        }
    }
    #endregion RotatingPresidency_Specific

}// end namespace MMod
