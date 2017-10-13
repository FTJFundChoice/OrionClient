using FTJFundChoice.OrionClient.Interfaces.Plans;

namespace FTJFundChoice.OrionClient.Compositions.Plans
{
	public class PlansModule : IPlansModule
	{
		private OrionApiClient client = null;
		private IPlansVerboseModule verbose = null;

		public PlansModule(OrionApiClient client)
		{
			this.client = client;
			verbose = new PlansVerboseModule(client);
		}

		public IPlansVerboseModule Verbose
		{
			get
			{
				return verbose;
			}
		}
	}
}