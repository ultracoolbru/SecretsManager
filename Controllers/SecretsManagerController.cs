using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecretsManagerRepository.Interfaces;

namespace SecretsManager.Controllers
{
    /// <summary>
    /// SecretsManagerController class that makes a call to the AWS Secrets Manager API endpoint 
    /// and returns decrypted secret key value.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("[controller]")]
    public class SecretsManagerController : ControllerBase
    {
        private readonly ILogger<SecretsManagerController> _logger;
        private readonly ISecretsManager _secretsManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretsManagerController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="secretsManager">The secrets manager.</param>
        public SecretsManagerController(ILogger<SecretsManagerController> logger, ISecretsManager secretsManager)
        {
            _logger = logger;
            _secretsManager = secretsManager;
        }

        /// <summary>
        /// Gets the amazon secret.
        /// </summary>
        /// <returns>Decrypted <see cref="System.String"/> secret.</returns>
        [HttpGet]
        public string GetAmazonSecret()
        {
            // These can be configured in StartUp and values passed or
            // the values can be read from "appsettings.json" at runtime.
            _secretsManager.AWSAccessKey = "AWSAccessKey";
            _secretsManager.AWSKeyId = "AWSKeyId";
            _secretsManager.EndPoint = Amazon.RegionEndpoint.EUWest1;   // The correct region must be used.
            _secretsManager.SecretName = "secretName";
            _secretsManager.VersionStage = "AWSCURRENT";

            return _secretsManager.GetSecret("secretName");
        }
    }
}
