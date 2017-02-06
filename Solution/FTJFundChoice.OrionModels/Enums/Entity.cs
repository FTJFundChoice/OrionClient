using System.Runtime.Serialization;

namespace FTJFundChoice.OrionModels.Enums {

    /// <summary>
    /// WIP - Gradually identifying the EnumMember value.
    /// </summary>
    public enum Entity {

        [EnumMember(Value = "Undefined")]
        Undefined = 0,

        // Not in Orion documentation
        [EnumMember(Value = "Advisor")]
        Advisor = -1,

        Payee = 1,

        [EnumMember(Value = "Broker/Dealer")]
        BrokerDealer = 2,

        [EnumMember(Value = "Wholesaler")]
        Wholesaler = 3,

        [EnumMember(Value = "Representative")]
        Representative = 4,

        [EnumMember(Value = "Household")]
        Household = 5,

        Registration = 6,
        Account = 7,
        Asset = 8,
        Product = 9,
        Transaction = 10,
        Distribution = 11,
        FundFamily = 12,
        Personal = 13,
        PayoutSchedule = 14,
        FeeSchedule = 15,
        Platform = 16,
        RIA = 17,
        Custodian = 18,
        Journal = 19,
        SWP = 20,
        Other = 21,
        NASD = 22,
        CashFunding = 23,
        Bill = 24,
        BillInstance = 25,
        BillMasterPayout = 26,
        Model = 27,
        NewAccountClient = 28,
        NewAccountReg = 29,
        DownloadExclusion = 30,
        Price = 31,
        UserDefinedFields = 32,
        NewAcctUserDef = 33,
        ManagersMessage = 34,
        IndexEntry = 35,
        PerformanceFee = 36,
        PerformancePayout = 37,
        NewAccountAsset = 38,
        Owner = 39,

        [EnumMember(Value = "Administrator")]
        Administrator = 50,

        OutsideClient = 51,

        [EnumMember(Value = "Sub-advisor")]
        SubAdvisor = 52,

        ModelRange = 53,
        FaxCover = 54,
        Fax = 55,
        OneTimeDistribution = 56,
        WebLogin = 57,
        Plan401k = 58,
        BillAccountItem = 59,

        [EnumMember(Value = "Third-Party Administrator")]
        ThirdPartyAdministrator = 60,

        CrmContact = 61,
        Participant = 62,

        [EnumMember(Value = "Plan Sponsor")]
        PlanSponsor = 63,

        CRMEmailList = 64,

        [EnumMember(Value = "Third Party")]
        ThirdParty = 65,

        WorkflowItem = 66,
        WorkflowAction = 67,

        [EnumMember(Value = "Service Account")]
        ServiceAccount = 68,

        EntityOption = 69,
        HouseholdMember = 70,
        DownloadSymbol = 71,
        IndexBlend = 72,
        NABenefit = 73,
        AggregateModel = 74,
        CompositeRange = 75,

        [EnumMember(Value = "Rep Account Manager")]
        RepAccountManager = 76,

        ScriptsScrubs = 77,
        ServiceAccountBrokerDealer = 78,
        BusinessLine = 79,
        Blob = 80,
        AssetClass = 81,
        ServieAccountLite = 82,
        NewAccountUserDefDtl = 83,
        Branch = 84,
        AssetLevelStrategy = 85,
        Report = 86,
        DataQueries = 87,
        PriceUnUsed = 88,
        ModelItem = 89,
        AssetCategory = 90,
        RiskCategory = 91,
        PlatformRange = 92,
        Dividend = 93,
        RegistrationType = 94,
        CustodianCommon = 95,
        RepState = 96,
        QpeDashboard = 97,
        ReportBatch = 98,
        ModelGroup = 99,
        ShareClass = 100,
        DownloadFile = 101,
        User = 102,
        DynamicGrouping = 103,
        ProductType = 104,
        ProductSubType = 105,
        InvestmentObjective = 106,
        PortfolioGroup = 107,
        OrionRealizedLot = 108,
        OrionUnrealizedLot = 109,
        CustodianRealizedLot = 110,
        CustodianUnrealizedLot = 111
    }
}