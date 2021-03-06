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
    public class CollabSequence : DP_Line
    {



        public static new bool ValidRoles(DP_ConcreteType newSource, DP_ConcreteType newDest)
        {
            if (newSource == null || CanBeRole1(newSource))
            {
                if (newDest == null || CanBeRole2(newDest))
                    return true;
            }
            if (newDest == null || CanBeRole1(newDest))
            {
                if (newSource == null || CanBeRole2(newSource))
                    return true;
            }
            return false;
        }

        private static bool CanBeRole1(DP_ConcreteType endpoint)
        {
            if (endpoint is CollabStep)
            {
                return true;
            }
            return false;
        }

        private static bool CanBeRole2(DP_ConcreteType endpoint)
        {
            if (endpoint is CollabStep)
            {
                return true;
            }
            return false;
        }

        protected override void SetParams()
        {
            LineProperties.Form = DP_LineForm.Line;
            LineProperties.LineWidth = 2;
            LineProperties.BorderStyle = DashStyle.Solid;
            LineProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            LineProperties.BorderWidth = 0;
            LineProperties.FillStyle = DashStyle.Solid;
            LineProperties.FillColor = Color.FromArgb(255, 0, 0, 0);
            LineProperties.Role1.NameVisible = true;
            LineProperties.Role1.Font = new Font("Segoe UI", (float)9, FontStyle.Regular);
            LineProperties.Role1.Icon = "";
            LineProperties.Role2.NameVisible = true;
            LineProperties.Role2.Font = new Font("Segoe UI", (float)9, FontStyle.Regular);
            LineProperties.Role2.Icon = "..\\..\\Icons\\triangle.gif";

            Name = "NewCollabSequence";
            DisplayName = Name;
            ShowName = false;
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
            PresentationType = DP_PresentationType.Line;
            SimulationType = DP_SimulationType.Flow;
            role1Name = "PreviousCollabStep";
            role2Name = "NextCollabStep";
        }

        public CollabSequence()
        {
        }

        public CollabSequence(DomainProDesigner.DP_ConnectionSpec newRole1, DomainProDesigner.DP_ConnectionSpec newRole2) :
            base(newRole1, newRole2)
        {
            Diagram = new CollabSequenceStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction trigger = new DP_AbstractText.Instruction();
            trigger.Name = "Trigger";
            trigger.String = "return false;\n";
            Text.Instructions.Add(trigger);

            DP_AbstractText.Instruction transfer = new DP_AbstractText.Instruction();
            transfer.Name = "Transfer";
            transfer.String = "";
            Text.Instructions.Add(transfer);

            DP_AbstractText.Instruction resolve = new DP_AbstractText.Instruction();
            resolve.Name = "Resolve";
            resolve.String = "return Context;";
            Text.Instructions.Add(resolve);

        }

        public override void Initialize(DP_AbstractStructure parentDiagram)
        {
            base.Initialize(parentDiagram);
            Diagram.Initialize(this);
        }

        public override DP_ConcreteType Duplicate()
        {
            CollabSequence newType = new CollabSequence();
            newType.Diagram = new CollabSequenceStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is CollabSequence)
            {
              base.Copy(source);
              CollabSequence srcCollabSequence = source as CollabSequence;
            }
        }
    }
}
