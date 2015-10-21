using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;
using System.Data.SqlClient;

namespace at.ac.tuwien.dsg.RIFramework.RMod {
	public class Query {

	}

    public class SQLQuery: Query {
        public SqlCommand attributeTimeQuery; //ovo je privremeno ovako, kasnije ce se sigurno promijeniti.
    }

    public class AttributeQuery : Query {

    }

    public class GraphTransQuery : Query {
        public LGSPAction structuralQuery;
    }
}
