using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class CollabPattern : DP_ComponentType
    {

        private uint SeedUValue = 0;

        [DisplayNameAttribute("SeedU"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0),
        DescriptionAttribute("")]
        public uint SeedU
        {
            get { return SeedUValue; }
            set { SeedUValue = value; }
        }

        private uint SeedVValue = 0;

        [DisplayNameAttribute("SeedV"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0),
        DescriptionAttribute("")]
        public uint SeedV
        {
            get { return SeedVValue; }
            set { SeedVValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
