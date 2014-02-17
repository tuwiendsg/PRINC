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
    public class Collaborator : DP_Shape
    {

        private double maxReportImprovementImpactValue = 0.2;

        [DisplayName("maxReportImprovementImpact"),
        Category("Config"),
        DefaultValue(0.2),
        Description("keep within 0 to 0.3")]
        public double maxReportImprovementImpact
        {
            get { return maxReportImprovementImpactValue; }
            set { maxReportImprovementImpactValue = value; }
        }

        private int ratingBehaviorValue = 2;

        [DisplayName("ratingBehavior"),
        Category("Config"),
        DefaultValue(2),
        Description("0 - uniform, 1 - according to severity, 2 - extremum-biased")]
        public int ratingBehavior
        {
            get { return ratingBehaviorValue; }
            set { ratingBehaviorValue = value; }
        }

        private double submitDurationValue = 5.0;

        [DisplayName("submitDuration"),
        Category("Config"),
        DefaultValue(5.0),
        Description("")]
        public double submitDuration
        {
            get { return submitDurationValue; }
            set { submitDurationValue = value; }
        }

        private double improveDurationValue = 1.0;

        [DisplayName("improveDuration"),
        Category("Config"),
        DefaultValue(1.0),
        Description("")]
        public double improveDuration
        {
            get { return improveDurationValue; }
            set { improveDurationValue = value; }
        }

        private double rateDurationValue = 0.5;

        [DisplayName("rateDuration"),
        Category("Config"),
        DefaultValue(0.5),
        Description("")]
        public double rateDuration
        {
            get { return rateDurationValue; }
            set { rateDurationValue = value; }
        }

        private double duplicateReportDurationValue = 1.0;

        [DisplayName("duplicateReportDuration"),
        Category("Config"),
        DefaultValue(1.0),
        Description("")]
        public double duplicateReportDuration
        {
            get { return duplicateReportDurationValue; }
            set { duplicateReportDurationValue = value; }
        }

        private double baseCostImproveValue = 100.0;

        [DisplayName("baseCostImprove"),
        Category("Config"),
        DefaultValue(100.0),
        Description("")]
        public double baseCostImprove
        {
            get { return baseCostImproveValue; }
            set { baseCostImproveValue = value; }
        }

        private double baseCostRateValue = 50.0;

        [DisplayName("baseCostRate"),
        Category("Config"),
        DefaultValue(50.0),
        Description("")]
        public double baseCostRate
        {
            get { return baseCostRateValue; }
            set { baseCostRateValue = value; }
        }

        private double baseBenefitImproveValue = 80.0;

        [DisplayName("baseBenefitImprove"),
        Category("Config"),
        DefaultValue(80.0),
        Description("")]
        public double baseBenefitImprove
        {
            get { return baseBenefitImproveValue; }
            set { baseBenefitImproveValue = value; }
        }

        private double baseBenefitRateValue = 50.0;

        [DisplayName("baseBenefitRate"),
        Category("Config"),
        DefaultValue(50.0),
        Description("")]
        public double baseBenefitRate
        {
            get { return baseBenefitRateValue; }
            set { baseBenefitRateValue = value; }
        }

        private int numberOfReportsToEvaluateValue = 20;

        [DisplayName("numberOfReportsToEvaluate"),
        Category("Config"),
        DefaultValue(20),
        Description("")]
        public int numberOfReportsToEvaluate
        {
            get { return numberOfReportsToEvaluateValue; }
            set { numberOfReportsToEvaluateValue = value; }
        }

        private int numberOfReportsToEvaluateForDuplicateCheckingValue = 3;

        [DisplayName("numberOfReportsToEvaluateForDuplicateChecking"),
        Category("Config"),
        DefaultValue(3),
        Description("")]
        public int numberOfReportsToEvaluateForDuplicateChecking
        {
            get { return numberOfReportsToEvaluateForDuplicateCheckingValue; }
            set { numberOfReportsToEvaluateForDuplicateCheckingValue = value; }
        }

        private double tooFarAwayValue = 0.2;

        [DisplayName("tooFarAway"),
        Category("Config"),
        DefaultValue(0.2),
        Description("")]
        public double tooFarAway
        {
            get { return tooFarAwayValue; }
            set { tooFarAwayValue = value; }
        }

        private double pointQuotaValue = 500;

        [DisplayName("pointQuota"),
        Category("Config"),
        DefaultValue(500),
        Description("")]
        public double pointQuota
        {
            get { return pointQuotaValue; }
            set { pointQuotaValue = value; }
        }

        private double probSubmitOrDuplicateValue = 0.3;

        [DisplayName("probSubmitOrDuplicate"),
        Category("Config"),
        DefaultValue(0.3),
        Description("")]
        public double probSubmitOrDuplicate
        {
            get { return probSubmitOrDuplicateValue; }
            set { probSubmitOrDuplicateValue = value; }
        }

        private double probImproveOrRateValue = 0.3;

        [DisplayName("probImproveOrRate"),
        Category("Config"),
        DefaultValue(0.3),
        Description("")]
        public double probImproveOrRate
        {
            get { return probImproveOrRateValue; }
            set { probImproveOrRateValue = value; }
        }

        private double unitCostOfProcessingValue = 10.0;

        [DisplayName("unitCostOfProcessing"),
        Category("Config"),
        DefaultValue(10.0),
        Description("")]
        public double unitCostOfProcessing
        {
            get { return unitCostOfProcessingValue; }
            set { unitCostOfProcessingValue = value; }
        }

        private double onSubmitProcessingThresholdValue = 0.6;

        [DisplayName("onSubmitProcessingThreshold"),
        Category("Config"),
        DefaultValue(0.6),
        Description("")]
        public double onSubmitProcessingThreshold
        {
            get { return onSubmitProcessingThresholdValue; }
            set { onSubmitProcessingThresholdValue = value; }
        }

        private double  onImproveProcessingThresholdValue = 0.75;

        [DisplayName(" onImproveProcessingThreshold"),
        Category("Config"),
        DefaultValue(0.75),
        Description("")]
        public double  onImproveProcessingThreshold
        {
            get { return  onImproveProcessingThresholdValue; }
            set {  onImproveProcessingThresholdValue = value; }
        }

        private double onReportDuplicateProcessingThresholdValue = 0.3;

        [DisplayName("onReportDuplicateProcessingThreshold"),
        Category("Config"),
        DefaultValue(0.3),
        Description("")]
        public double onReportDuplicateProcessingThreshold
        {
            get { return onReportDuplicateProcessingThresholdValue; }
            set { onReportDuplicateProcessingThresholdValue = value; }
        }

        private double onRateProcessingThresholdValue = 0.4;

        [DisplayName("onRateProcessingThreshold"),
        Category("Config"),
        DefaultValue(0.4),
        Description("")]
        public double onRateProcessingThreshold
        {
            get { return onRateProcessingThresholdValue; }
            set { onRateProcessingThresholdValue = value; }
        }



        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Rectangle;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            ShapeProperties.BorderWidth = 3;
            ShapeProperties.FillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopLeft;
            ShapeProperties.Icon = "";

            Name = "NewCollaborator";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(250, 350);
            NameFont = new Font("Segoe UI", (float)10, FontStyle.Bold);
        }

        public Collaborator()
        {
        }

        public Collaborator(Point startLocation) :
            base(startLocation)
        {
            Diagram = new CollaboratorStructure();
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
            Collaborator newType = new Collaborator();
            newType.Diagram = new CollaboratorStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is Collaborator)
            {
              base.Copy(source);
              Collaborator srcCollaborator = source as Collaborator;
              maxReportImprovementImpact = srcCollaborator.maxReportImprovementImpact;
              ratingBehavior = srcCollaborator.ratingBehavior;
              submitDuration = srcCollaborator.submitDuration;
              improveDuration = srcCollaborator.improveDuration;
              rateDuration = srcCollaborator.rateDuration;
              duplicateReportDuration = srcCollaborator.duplicateReportDuration;
              baseCostImprove = srcCollaborator.baseCostImprove;
              baseCostRate = srcCollaborator.baseCostRate;
              baseBenefitImprove = srcCollaborator.baseBenefitImprove;
              baseBenefitRate = srcCollaborator.baseBenefitRate;
              numberOfReportsToEvaluate = srcCollaborator.numberOfReportsToEvaluate;
              numberOfReportsToEvaluateForDuplicateChecking = srcCollaborator.numberOfReportsToEvaluateForDuplicateChecking;
              tooFarAway = srcCollaborator.tooFarAway;
              pointQuota = srcCollaborator.pointQuota;
              probSubmitOrDuplicate = srcCollaborator.probSubmitOrDuplicate;
              probImproveOrRate = srcCollaborator.probImproveOrRate;
              unitCostOfProcessing = srcCollaborator.unitCostOfProcessing;
              onSubmitProcessingThreshold = srcCollaborator.onSubmitProcessingThreshold;
               onImproveProcessingThreshold = srcCollaborator. onImproveProcessingThreshold;
              onReportDuplicateProcessingThreshold = srcCollaborator.onReportDuplicateProcessingThreshold;
              onRateProcessingThreshold = srcCollaborator.onRateProcessingThreshold;
            }
        }
    }
}
