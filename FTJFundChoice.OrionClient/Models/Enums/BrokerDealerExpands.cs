namespace FTJFundChoice.OrionClient.Models.Enums
{
	public enum BrokerDealerExpands
	{
		None = 0,
		Portfolio = 1,
		AdditionalContacts = 2,
		AdvPayee = 4,
		Notes = 8,
		Documents = 16,
		UserDefinedFields = 32,
		ReportImage = 64,
		All = 127
	}
}
