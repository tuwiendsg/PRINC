using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace at.ac.tuwien.infosys.dsg.RIFramework.RMod {
    class RModManager {

        public static int getNewUID() {
            //in reality, everything should be ulong, but for easier reading in the development phase, we set now everything to int.
            byte[] buffer = Guid.NewGuid().ToByteArray();

            return Math.Abs((int) BitConverter.ToInt64(buffer, 0) % Int32.MaxValue);
        }

    }
}
