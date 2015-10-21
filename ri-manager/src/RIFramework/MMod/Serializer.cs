using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace at.ac.tuwien.dsg.RIFramework.MMod {
	class Serializer {

		public static void serialize(System.IO.Stream stream, MMAction msg, bool toStdOut = false) {

            if (toStdOut) {
                ProtoBuf.Serializer.Serialize<MMAction>(System.Console.OpenStandardOutput(), msg);
            } else {
                ProtoBuf.Serializer.Serialize<MMAction>(stream, msg);
            }
		}

		public static MMAction deserialize(System.IO.Stream source) {
			return ProtoBuf.Serializer.Deserialize<MMAction>(source);
		}

	}
}
