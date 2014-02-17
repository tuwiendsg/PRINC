using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Xml.Serialization;
using DomainPro.Core.Types;
using DomainPro.Designer;
using DomainPro.Designer.Types;
using DomainPro.Designer.Controls;

namespace Designer.Types
{
    public class CollabPattern : DP_Shape
    {

        private uint SeedUValue = 0;

        [DisplayName("SeedU"),
        Category("Config"),
        DefaultValue(0),
        Description("")]
        public uint SeedU
        {
            get { return SeedUValue; }
            set { SeedUValue = value; }
        }

        private uint SeedVValue = 0;

        [DisplayName("SeedV"),
        Category("Config"),
        DefaultValue(0),
        Description("")]
        public uint SeedV
        {
            get { return SeedVValue; }
            set { SeedVValue = value; }
        }



        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Rectangle;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            ShapeProperties.BorderWidth = 1;
            ShapeProperties.FillColor = Color.FromArgb(255, 250, 255, 255);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopLeft;
            ShapeProperties.Icon = "";

            Name = "NewCollabPattern";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(100, 100);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public CollabPattern()
        {
        }

        public CollabPattern(Point startLocation) :
            base(startLocation)
        {
            Diagram = new CollabPatternStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction startup = new DP_AbstractText.Instruction();
            startup.Name = "Startup";
            startup.String = "";
            Text.Instructions.Add(startup);

        }

        public override void Initialize(DP_AbstractStructure parentDiagram)
        {
            base.Initialize(parentDiagram);
            Diagram.Initialize(this);
        }

        public override DP_ConcreteType Duplicate()
        {
            CollabPattern newType = new CollabPattern();
            newType.Diagram = new CollabPatternStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is CollabPattern)
            {
              base.Copy(source);
              CollabPattern srcCollabPattern = source as CollabPattern;
              SeedU = srcCollabPattern.SeedU;
              SeedV = srcCollabPattern.SeedV;
            }
        }
    }
}
