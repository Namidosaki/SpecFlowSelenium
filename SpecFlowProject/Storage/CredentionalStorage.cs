using GoogleLoginTest.Models;
using Microsoft.Extensions.Configuration;

namespace GoogleLoginTest.Storage
{
    public class CredentionalStorage
    {
        public ValidInvalid Credentions;
        
        public CredentionalStorage()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            Credentions = config.GetRequiredSection("Credentionals").Get<ValidInvalid>();
        }

    }
}
