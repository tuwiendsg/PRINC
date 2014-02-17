using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class Collaborator : DP_ComponentType
    {

        private double maxReportImprovementImpactValue = 0.2;

        [DisplayNameAttribute("maxReportImprovementImpact"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.2),
        DescriptionAttribute("keep within 0 to 0.3")]
        public double maxReportImprovementImpact
        {
            get { return maxReportImprovementImpactValue; }
            set { maxReportImprovementImpactValue = value; }
        }

        private int ratingBehaviorValue = 2;

        [DisplayNameAttribute("ratingBehavior"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(2),
        DescriptionAttribute("0 - uniform, 1 - according to severity, 2 - extremum-biased")]
        public int ratingBehavior
        {
            get { return ratingBehaviorValue; }
            set { ratingBehaviorValue = value; }
        }

        private double submitDurationValue = 5.0;

        [DisplayNameAttribute("submitDuration"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(5.0),
        DescriptionAttribute("")]
        public double submitDuration
        {
            get { return submitDurationValue; }
            set { submitDurationValue = value; }
        }

        private double improveDurationValue = 1.0;

        [DisplayNameAttribute("improveDuration"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(1.0),
        DescriptionAttribute("")]
        public double improveDuration
        {
            get { return improveDurationValue; }
            set { improveDurationValue = value; }
        }

        private double rateDurationValue = 0.5;

        [DisplayNameAttribute("rateDuration"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.5),
        DescriptionAttribute("")]
        public double rateDuration
        {
            get { return rateDurationValue; }
            set { rateDurationValue = value; }
        }

        private double duplicateReportDurationValue = 1.0;

        [DisplayNameAttribute("duplicateReportDuration"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(1.0),
        DescriptionAttribute("")]
        public double duplicateReportDuration
        {
            get { return duplicateReportDurationValue; }
            set { duplicateReportDurationValue = value; }
        }

        private double baseCostImproveValue = 100.0;

        [DisplayNameAttribute("baseCostImprove"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(100.0),
        DescriptionAttribute("")]
        public double baseCostImprove
        {
            get { return baseCostImproveValue; }
            set { baseCostImproveValue = value; }
        }

        private double baseCostRateValue = 50.0;

        [DisplayNameAttribute("baseCostRate"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(50.0),
        DescriptionAttribute("")]
        public double baseCostRate
        {
            get { return baseCostRateValue; }
            set { baseCostRateValue = value; }
        }

        private double baseBenefitImproveValue = 80.0;

        [DisplayNameAttribute("baseBenefitImprove"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(80.0),
        DescriptionAttribute("")]
        public double baseBenefitImprove
        {
            get { return baseBenefitImproveValue; }
            set { baseBenefitImproveValue = value; }
        }

        private double baseBenefitRateValue = 50.0;

        [DisplayNameAttribute("baseBenefitRate"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(50.0),
        DescriptionAttribute("")]
        public double baseBenefitRate
        {
            get { return baseBenefitRateValue; }
            set { baseBenefitRateValue = value; }
        }

        private int numberOfReportsToEvaluateValue = 20;

        [DisplayNameAttribute("numberOfReportsToEvaluate"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(20),
        DescriptionAttribute("")]
        public int numberOfReportsToEvaluate
        {
            get { return numberOfReportsToEvaluateValue; }
            set { numberOfReportsToEvaluateValue = value; }
        }

        private int numberOfReportsToEvaluateForDuplicateCheckingValue = 3;

        [DisplayNameAttribute("numberOfReportsToEvaluateForDuplicateChecking"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(3),
        DescriptionAttribute("")]
        public int numberOfReportsToEvaluateForDuplicateChecking
        {
            get { return numberOfReportsToEvaluateForDuplicateCheckingValue; }
            set { numberOfReportsToEvaluateForDuplicateCheckingValue = value; }
        }

        private double tooFarAwayValue = 0.2;

        [DisplayNameAttribute("tooFarAway"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.2),
        DescriptionAttribute("")]
        public double tooFarAway
        {
            get { return tooFarAwayValue; }
            set { tooFarAwayValue = value; }
        }

        private double pointQuotaValue = 500;

        [DisplayNameAttribute("pointQuota"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(500),
        DescriptionAttribute("")]
        public double pointQuota
        {
            get { return pointQuotaValue; }
            set { pointQuotaValue = value; }
        }

        private double probSubmitOrDuplicateValue = 0.3;

        [DisplayNameAttribute("probSubmitOrDuplicate"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.3),
        DescriptionAttribute("")]
        public double probSubmitOrDuplicate
        {
            get { return probSubmitOrDuplicateValue; }
            set { probSubmitOrDuplicateValue = value; }
        }

        private double probImproveOrRateValue = 0.3;

        [DisplayNameAttribute("probImproveOrRate"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.3),
        DescriptionAttribute("")]
        public double probImproveOrRate
        {
            get { return probImproveOrRateValue; }
            set { probImproveOrRateValue = value; }
        }

        private double unitCostOfProcessingValue = 10.0;

        [DisplayNameAttribute("unitCostOfProcessing"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(10.0),
        DescriptionAttribute("")]
        public double unitCostOfProcessing
        {
            get { return unitCostOfProcessingValue; }
            set { unitCostOfProcessingValue = value; }
        }

        private double onSubmitProcessingThresholdValue = 0.6;

        [DisplayNameAttribute("onSubmitProcessingThreshold"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.6),
        DescriptionAttribute("")]
        public double onSubmitProcessingThreshold
        {
            get { return onSubmitProcessingThresholdValue; }
            set { onSubmitProcessingThresholdValue = value; }
        }

        private double  onImproveProcessingThresholdValue = 0.75;

        [DisplayNameAttribute(" onImproveProcessingThreshold"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.75),
        DescriptionAttribute("")]
        public double  onImproveProcessingThreshold
        {
            get { return  onImproveProcessingThresholdValue; }
            set {  onImproveProcessingThresholdValue = value; }
        }

        private double onReportDuplicateProcessingThresholdValue = 0.3;

        [DisplayNameAttribute("onReportDuplicateProcessingThreshold"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.3),
        DescriptionAttribute("")]
        public double onReportDuplicateProcessingThreshold
        {
            get { return onReportDuplicateProcessingThresholdValue; }
            set { onReportDuplicateProcessingThresholdValue = value; }
        }

        private double onRateProcessingThresholdValue = 0.4;

        [DisplayNameAttribute("onRateProcessingThreshold"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.4),
        DescriptionAttribute("")]
        public double onRateProcessingThreshold
        {
            get { return onRateProcessingThresholdValue; }
            set { onRateProcessingThresholdValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
