using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Settings
{
    [Collection("Custom Label Testing")]
    public class CustomLogoTests : BaseTest
    {

        [Fact]
        public async Task PushAdvisorMainLogo()
        {
            var rep = await Client.Portfolio.Representatives.Verbose.GetAsync(1);
            Assert.True(rep.Success);
            Assert.NotNull(rep.Data);

            var repValue = rep.Data;
            var filePath = Path.Combine(Environment.CurrentDirectory, @"TestFiles\", "What_business_to_start_2013_crop.jpg");

            Assert.True(!string.IsNullOrEmpty(filePath));
            var mimeType = MimeMapping.GetMimeMapping(filePath);

            string logo;

            using (System.Drawing.Image image = System.Drawing.Image.FromFile(filePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    logo = $"data:{mimeType};base64,{Convert.ToBase64String(imageBytes)}";
                }
            }

            Assert.NotEmpty(logo);
            var result = Client.Settings.CustomSettings.UploadMainThemeLogo("Representative", repValue.Id ?? 0, logo);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task PushAdvisorMainLogoAsync()
        {
            var rep = await Client.Portfolio.Representatives.Verbose.GetAsync(1);
            Assert.True(rep.Success);
            Assert.NotNull(rep.Data);

            var repValue = rep.Data;
            //var filePath = Path.Combine(Environment.CurrentDirectory, @"TestFiles\", "What_business_to_start_2013_crop.jpg");
            var filePath = Path.Combine(Environment.CurrentDirectory, @"TestFiles\", "startup.jpg");

            Assert.True(!string.IsNullOrEmpty(filePath));
            var mimeType = MimeMapping.GetMimeMapping(filePath);

            string logo;

            using (System.Drawing.Image image = System.Drawing.Image.FromFile(filePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    logo = $"data:{mimeType};base64,{Convert.ToBase64String(imageBytes)}";
                }
            }

            Assert.NotEmpty(logo);
            var result = await Client.Settings.CustomSettings.UploadMainThemeLogoAsync("Representative", repValue.Id ?? 0, logo);

            Assert.True(result.Success);
        }

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

            string logo;

            using (System.Drawing.Image image = System.Drawing.Image.FromFile(filePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    logo = $"data:{mimeType};base64,{Convert.ToBase64String(imageBytes)}";
                }
            }

            Assert.NotEmpty(logo);
            var result = Client.Settings.CustomSettings.UploadMainThemeLogo("BrokerDealer", bdValue.Id?? 0, logo);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task PushBrokerDealerLogoAsync()
        {
            var brokerDealer = await Client.Portfolio.BrokerDealers.Verbose.GetAsync(3);
            Assert.True(brokerDealer.Success);
            Assert.NotNull(brokerDealer.Data);

            var bdValue = brokerDealer.Data;
            var filePath = Path.Combine(Environment.CurrentDirectory, @"TestFiles\", "What_business_to_start_2013_crop.jpg");

            Assert.True(!string.IsNullOrEmpty(filePath));
            var mimeType = MimeMapping.GetMimeMapping(filePath);

            string logo;

            using (System.Drawing.Image image = System.Drawing.Image.FromFile(filePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    logo = $"data:{mimeType};base64,{Convert.ToBase64String(imageBytes)}";
                }
            }

            Assert.NotEmpty(logo);
            var result = await Client.Settings.CustomSettings.UploadMainThemeLogoAsync("BrokerDealer", bdValue.Id ?? 0, logo);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task PushRepLogo()
        {
            var rep = await Client.Portfolio.Representatives.Verbose.GetAsync(1);
            Assert.True(rep.Success);
            Assert.NotNull(rep.Data);

            var repValue = rep.Data;
            var filePath = Path.Combine(Environment.CurrentDirectory, @"TestFiles\", "startup.jpg");

            Assert.True(!string.IsNullOrEmpty(filePath));
            var mimeType = MimeMapping.GetMimeMapping(filePath);

            string logo;

            using (System.Drawing.Image image = System.Drawing.Image.FromFile(filePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    logo = $"data:{mimeType};base64,{Convert.ToBase64String(imageBytes)}";
                }
            }

            Assert.NotEmpty(logo);
            
            var result = await Client.Settings.CustomSettings.UploadAdvisorImage("Representative", repValue.Id ?? 0, logo);

            Assert.True(result.Success);

        }

    }
}
