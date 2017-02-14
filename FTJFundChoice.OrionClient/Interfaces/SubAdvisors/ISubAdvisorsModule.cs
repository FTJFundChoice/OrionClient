using FTJFundChoice.OrionClient.Interfaces.Common;
using FTJFundChoice.OrionClient.Models.Portfolio;

namespace FTJFundChoice.OrionClient.Interfaces.SubAdvisors {

    public interface ISubAdvisorsModule : IQueryModule<SubAdvisor> {
        ISubAdvisorsSimpleModule Simple { get; }
    }
}