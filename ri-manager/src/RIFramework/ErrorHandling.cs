using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace at.ac.tuwien.dsg.RIFramework {

    [Serializable]
    public class RewardingManagerException : Exception {
        public RewardingManagerException(string message) : base(message) {}

    }

    public class ExceptionHandler {

         public static void catchException(RewardingManagerException e) {

             System.Diagnostics.Debug.WriteLine(e.Message);
             Environment.Exit(1);
         }
    }
}
