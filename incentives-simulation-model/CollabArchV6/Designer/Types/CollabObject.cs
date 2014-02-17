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
    public class CollabObject : DP_Shape
    {

        private double BayesThreshold_SubmitValue = 3.0;

        [DisplayName("BayesThreshold_Submit"),
        Category("Config"),
        DefaultValue(3.0),
        Description("")]
        public double BayesThreshold_Submit
        {
            get { return BayesThreshold_SubmitValue; }
            set { BayesThreshold_SubmitValue = value; }
        }

        private double KarmaInfluenceOnBayesThreshold_SubmitValue = 0.3333;

        [DisplayName("KarmaInfluenceOnBayesThreshold_Submit"),
        Category("Config"),
        DefaultValue(0.3333),
        Description("")]
        public double KarmaInfluenceOnBayesThreshold_Submit
        {
            get { return KarmaInfluenceOnBayesThreshold_SubmitValue; }
            set { KarmaInfluenceOnBayesThreshold_SubmitValue = value; }
        }

        private double improvementInfluenceValue = 0.3;

        [DisplayName("improvementInfluence"),
        Category("Config"),
        DefaultValue(0.3),
        Description("")]
        public double improvementInfluence
        {
            get { return improvementInfluenceValue; }
            set { improvementInfluenceValue = value; }
        }

        private double BayesThreshold_RateValue = 7.0;

        [DisplayName("BayesThreshold_Rate"),
        Category("Config"),
        DefaultValue(7.0),
        Description("")]
        public double BayesThreshold_Rate
        {
            get { return BayesThreshold_RateValue; }
            set { BayesThreshold_RateValue = value; }
        }

        private double KarmaInfluenceOnBayesThreshold_RateValue = 0.3333;

        [DisplayName("KarmaInfluenceOnBayesThreshold_Rate"),
        Category("Config"),
        DefaultValue(0.3333),
        Description("")]
        public double KarmaInfluenceOnBayesThreshold_Rate
        {
            get { return KarmaInfluenceOnBayesThreshold_RateValue; }
            set { KarmaInfluenceOnBayesThreshold_RateValue = value; }
        }

        private int  maxNumberOfActionsValue = 10;

        [DisplayName(" maxNumberOfActions"),
        Category("Config"),
        DefaultValue(10),
        Description("")]
        public int  maxNumberOfActions
        {
            get { return  maxNumberOfActionsValue; }
            set {  maxNumberOfActionsValue = value; }
        }

        private int maxNumberOfLowQualityReportsValue = 10;

        [DisplayName("maxNumberOfLowQualityReports"),
        Category("Config"),
        DefaultValue(10),
        Description("")]
        public int maxNumberOfLowQualityReports
        {
            get { return maxNumberOfLowQualityReportsValue; }
            set { maxNumberOfLowQualityReportsValue = value; }
        }

        private int enoughPostActionsOnReportValue = 10;

        [DisplayName("enoughPostActionsOnReport"),
        Category("Config"),
        DefaultValue(10),
        Description("")]
        public int enoughPostActionsOnReport
        {
            get { return enoughPostActionsOnReportValue; }
            set { enoughPostActionsOnReportValue = value; }
        }

        private int situationsToCreatePerPhaseValue = 10;

        [DisplayName("situationsToCreatePerPhase"),
        Category("Config"),
        DefaultValue(10),
        Description("")]
        public int situationsToCreatePerPhase
        {
            get { return situationsToCreatePerPhaseValue; }
            set { situationsToCreatePerPhaseValue = value; }
        }

        private int duplicatesThresholdToProcessValue = 4;

        [DisplayName("duplicatesThresholdToProcess"),
        Category("Config"),
        DefaultValue(4),
        Description("")]
        public int duplicatesThresholdToProcess
        {
            get { return duplicatesThresholdToProcessValue; }
            set { duplicatesThresholdToProcessValue = value; }
        }

        private double phaseDurationValue = 49.0;

        [DisplayName("phaseDuration"),
        Category("Config"),
        DefaultValue(49.0),
        Description("")]
        public double phaseDuration
        {
            get { return phaseDurationValue; }
            set { phaseDurationValue = value; }
        }



        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Rectangle;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 255);
            ShapeProperties.BorderWidth = 2;
            ShapeProperties.FillColor = Color.FromArgb(255, 255, 245, 255);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 5;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopCenter;
            ShapeProperties.Icon = "";

            Name = "NewCollabObject";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(125, 125);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public CollabObject()
        {
        }

        public CollabObject(Point startLocation) :
            base(startLocation)
        {
            Diagram = new CollabObjectStructure();
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
            CollabObject newType = new CollabObject();
            newType.Diagram = new CollabObjectStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is CollabObject)
            {
              base.Copy(source);
              CollabObject srcCollabObject = source as CollabObject;
              BayesThreshold_Submit = srcCollabObject.BayesThreshold_Submit;
              KarmaInfluenceOnBayesThreshold_Submit = srcCollabObject.KarmaInfluenceOnBayesThreshold_Submit;
              improvementInfluence = srcCollabObject.improvementInfluence;
              BayesThreshold_Rate = srcCollabObject.BayesThreshold_Rate;
              KarmaInfluenceOnBayesThreshold_Rate = srcCollabObject.KarmaInfluenceOnBayesThreshold_Rate;
               maxNumberOfActions = srcCollabObject. maxNumberOfActions;
              maxNumberOfLowQualityReports = srcCollabObject.maxNumberOfLowQualityReports;
              enoughPostActionsOnReport = srcCollabObject.enoughPostActionsOnReport;
              situationsToCreatePerPhase = srcCollabObject.situationsToCreatePerPhase;
              duplicatesThresholdToProcess = srcCollabObject.duplicatesThresholdToProcess;
              phaseDuration = srcCollabObject.phaseDuration;
            }
        }
    }
}
