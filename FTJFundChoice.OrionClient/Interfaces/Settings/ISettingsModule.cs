using FTJFundChoice.OrionClient.Models.Portfolio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Settings
{
    public interface ISettingsModule
    {
        Task<IResult> UploadMainThemeLogo(string entityType, long entityId,string brokerDealerLogo);

        Task<IResult> UploadAdvisorImage(string entityType, long entityId, string logoData);
    }
}
