using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Settings
{
    [Collection("Custom Label Testing")]
    public class BrokerDealerCustomLogoTests : BaseTest
    {


        [Fact]
        public async Task PushBrokerDealerLogo()
        {
            var brokerDealer = await Client.Portfolio.BrokerDealers.Verbose.GetAsync(3);
            Assert.True(brokerDealer.Success);
            Assert.NotNull(brokerDealer.Data);

            var bdValue = brokerDealer.Data;
            var filePath = Path.Combine(Environment.CurrentDirectory, @"TestFiles\", "What_business_to_start_2013_crop.jpg");

            Assert.True(!string.IsNullOrEmpty(filePath));
            var mimeType = MimeMapping.GetMimeMapping(filePath);
            
            byte[] logo;


            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, (int)fileStream.Length);
                logo = buffer;
            }

            Assert.NotEmpty(logo);
            var result = await Client.Settings.CustomSettings.UploadMainThemeLogo("BrokerDealer", bdValue.Id?? 0, logo);

            Assert.True(result.Success);
        }

    }
}
