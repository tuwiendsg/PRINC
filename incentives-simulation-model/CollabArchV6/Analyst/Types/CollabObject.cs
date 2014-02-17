using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class CollabObject : DP_ComponentType
    {

        private double BayesThreshold_SubmitValue = 3.0;

        [DisplayNameAttribute("BayesThreshold_Submit"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(3.0),
        DescriptionAttribute("")]
        public double BayesThreshold_Submit
        {
            get { return BayesThreshold_SubmitValue; }
            set { BayesThreshold_SubmitValue = value; }
        }

        private double KarmaInfluenceOnBayesThreshold_SubmitValue = 0.3333;

        [DisplayNameAttribute("KarmaInfluenceOnBayesThreshold_Submit"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.3333),
        DescriptionAttribute("")]
        public double KarmaInfluenceOnBayesThreshold_Submit
        {
            get { return KarmaInfluenceOnBayesThreshold_SubmitValue; }
            set { KarmaInfluenceOnBayesThreshold_SubmitValue = value; }
        }

        private double improvementInfluenceValue = 0.3;

        [DisplayNameAttribute("improvementInfluence"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.3),
        DescriptionAttribute("")]
        public double improvementInfluence
        {
            get { return improvementInfluenceValue; }
            set { improvementInfluenceValue = value; }
        }

        private double BayesThreshold_RateValue = 7.0;

        [DisplayNameAttribute("BayesThreshold_Rate"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(7.0),
        DescriptionAttribute("")]
        public double BayesThreshold_Rate
        {
            get { return BayesThreshold_RateValue; }
            set { BayesThreshold_RateValue = value; }
        }

        private double KarmaInfluenceOnBayesThreshold_RateValue = 0.3333;

        [DisplayNameAttribute("KarmaInfluenceOnBayesThreshold_Rate"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.3333),
        DescriptionAttribute("")]
        public double KarmaInfluenceOnBayesThreshold_Rate
        {
            get { return KarmaInfluenceOnBayesThreshold_RateValue; }
            set { KarmaInfluenceOnBayesThreshold_RateValue = value; }
        }

        private int  maxNumberOfActionsValue = 10;

        [DisplayNameAttribute(" maxNumberOfActions"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(10),
        DescriptionAttribute("")]
        public int  maxNumberOfActions
        {
            get { return  maxNumberOfActionsValue; }
            set {  maxNumberOfActionsValue = value; }
        }

        private int maxNumberOfLowQualityReportsValue = 10;

        [DisplayNameAttribute("maxNumberOfLowQualityReports"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(10),
        DescriptionAttribute("")]
        public int maxNumberOfLowQualityReports
        {
            get { return maxNumberOfLowQualityReportsValue; }
            set { maxNumberOfLowQualityReportsValue = value; }
        }

        private int enoughPostActionsOnReportValue = 10;

        [DisplayNameAttribute("enoughPostActionsOnReport"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(10),
        DescriptionAttribute("")]
        public int enoughPostActionsOnReport
        {
            get { return enoughPostActionsOnReportValue; }
            set { enoughPostActionsOnReportValue = value; }
        }

        private int situationsToCreatePerPhaseValue = 10;

        [DisplayNameAttribute("situationsToCreatePerPhase"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(10),
        DescriptionAttribute("")]
        public int situationsToCreatePerPhase
        {
            get { return situationsToCreatePerPhaseValue; }
            set { situationsToCreatePerPhaseValue = value; }
        }

        private int duplicatesThresholdToProcessValue = 4;

        [DisplayNameAttribute("duplicatesThresholdToProcess"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(4),
        DescriptionAttribute("")]
        public int duplicatesThresholdToProcess
        {
            get { return duplicatesThresholdToProcessValue; }
            set { duplicatesThresholdToProcessValue = value; }
        }

        private double phaseDurationValue = 49.0;

        [DisplayNameAttribute("phaseDuration"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(49.0),
        DescriptionAttribute("")]
        public double phaseDuration
        {
            get { return phaseDurationValue; }
            set { phaseDurationValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
