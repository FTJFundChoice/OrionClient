using Newtonsoft.Json;
using System;
namespace FTJFundChoice.OrionClient.Models.Portfolio
{
	public class Account
	{
		[JsonProperty("isActive")]
		public bool IsActive { get; set; }
		[JsonProperty("custodian")]
		public string Custodian { get; set; }
		[JsonProperty("fundFamily")]
		public string FundFamily { get; set; }
		[JsonProperty("createdDate")]
		public DateTime CreatedDate { get; set; }
		[JsonProperty("isManaged")]
		public bool IsManaged { get; set; }
		[JsonProperty("isSweepAccount")]
		public bool IsSweepAccount { get; set; }
		[JsonProperty("isSleeveAccount")]
		public bool IsSleeveAccount { get; set; }
		[JsonProperty("brokerDealer")]
		public string BrokerDealer { get; set; }
		[JsonProperty("fundFamilyId")]
		public int FundFamilyId { get; set; }
		[JsonProperty("registrationId")]
		public long RegistrationId { get; set; }
		[JsonProperty("clientId")]
		public long ClientId { get; set; }
		[JsonProperty("custodianId")]
		public long CustodianId { get; set; }
		[JsonProperty("shareClass")]
		public string ShareClass { get; set; }
		[JsonProperty("shareClassId")]
		public int ShareClassId { get; set; }
		[JsonProperty("isTradingBlocked")]
		public bool IsTradingBlocked { get; set; }
		[JsonProperty("createdBy")]
		public string CreatedBy { get; set; }
		[JsonProperty("editedBy")]
		public string EditedBy { get; set; }
		[JsonProperty("editedDate")]
		public DateTime EditedDate { get; set; }
		[JsonProperty("accountStatusId")]
		public int AccountStatusId { get; set; }
		[JsonProperty("accountStatusDescription")]
		public string AccountStatusDescription { get; set; }
		[JsonProperty("feeScheduleId")]
		public int FeeScheduleId { get; set; }
		[JsonProperty("feeSchedule")]
		public string FeeSchedule { get; set; }
		[JsonProperty("masterPayoutScheduleId")]
		public int MasterPayoutScheduleId { get; set; }
		[JsonProperty("masterPayoutSchedule")]
		public string MasterPayoutSchedule { get; set; }
		[JsonProperty("representative")]
		public string Representative { get; set; }
		[JsonProperty("representativeNumber")]
		public string RepresentativeNumber { get; set; }
		[JsonProperty("household")]
		public string Household { get; set; }
		[JsonProperty("billPayMethod")]
		public string BillPayMethod { get; set; }
		[JsonProperty("acceptsLists")]
		public bool AcceptsList { get; set; }
		[JsonProperty("includeInAggregate")]
		public bool IncludeInAggregate { get; set; }
		[JsonProperty("isDiscretionary")]
		public bool IsDiscretionary { get; set; }
		[JsonProperty("isQualified")]
		public bool IsQualified { get; set; }
		[JsonProperty("isWrapManaged")]
		public bool IsWrapManaged { get; set; }
		[JsonProperty("lastName")]
		public string LastName { get; set; }
		[JsonProperty("id")]
		public long Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("number")]
		public string Number { get; set; }
		[JsonProperty("accountType")]
		public string AccountType { get; set; }
	}
}
