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
    public class MessageIcon : Icon
    {



        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Icon;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = false;
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 255);
            ShapeProperties.BorderWidth = 2;
            ShapeProperties.FillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.GradientFill = false;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 2;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopLeft;
            ShapeProperties.Icon = "..\\..\\Icons\\message.gif";

            Name = "NewMessageIcon";
            DisplayName = Name;
            ShowName = false;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(48, 48);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public MessageIcon()
        {
        }

        public MessageIcon(Point startLocation) :
            base(startLocation)
        {
            Diagram = new MessageIconStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction startup = new DP_AbstractText.Instruction();
            startup.Name = "Startup";
            startup.String = "";
            Text.Instructions.Add(startup);

        }

        public override void Initialize(DP_AbstractStructure parentDiagram)
        {
            base.Initialize(parentDiagram);
        }

        public override DP_ConcreteType Duplicate()
        {
            MessageIcon newType = new MessageIcon();
            newType.Diagram = new MessageIconStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is MessageIcon)
            {
              base.Copy(source);
              MessageIcon srcMessageIcon = source as MessageIcon;
            }
        }
    }
}
