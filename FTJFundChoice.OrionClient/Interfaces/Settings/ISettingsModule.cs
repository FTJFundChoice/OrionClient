using FTJFundChoice.OrionClient.Models.Portfolio;
using FTJFundChoice.OrionClient.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Settings
{
    public interface ISettingsModule
    {
        Task<IResult<Logo>> UploadMainThemeLogo(string entityType, long entityId,string brokerDealerLogo);

        Task<IResult<Logo>> UploadAdvisorImage(string entityType, long entityId, string logoData);
    }
}
