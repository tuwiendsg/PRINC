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
    public class ConnProperty : DP_Shape
    {


        private string implementationType = "";

        [DisplayName("Implementation Type"),
        Category("Simulation"),
        DefaultValue(""),
        Description("Sets the type of implementation object used to store the data.")]
        public string ImplementationType
        {
            get { return implementationType; }
            set { implementationType = value; }
        }

        private string initialValue = "";

        [DisplayName("Initial Value"),
        Category("Simulation"),
        DefaultValue(""),
        Description("Sets the initial value of the data.")]
        public string InitialValue
        {
            get { return initialValue; }
            set { initialValue = value; }
        }


        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Rectangle;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            ShapeProperties.BorderWidth = 1;
            ShapeProperties.FillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopLeft;
            ShapeProperties.Icon = "";

            Name = "NewConnProperty";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Data;
            Size = new Size(100, 40);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public ConnProperty()
        {
        }

        public ConnProperty(Point startLocation) :
            base(startLocation)
        {
            Diagram = new ConnPropertyStructure();
            Text = new DP_Text();
        }

        public override void Initialize(DP_AbstractStructure parentDiagram)
        {
            base.Initialize(parentDiagram);
            Diagram.Initialize(this);
        }

        public override DP_ConcreteType Duplicate()
        {
            ConnProperty newType = new ConnProperty();
            newType.Diagram = new ConnPropertyStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is ConnProperty)
            {
              base.Copy(source);
              ConnProperty srcConnProperty = source as ConnProperty;
        ImplementationType = srcConnProperty.ImplementationType;
        InitialValue = srcConnProperty.InitialValue;
            }
        }
    }
}
