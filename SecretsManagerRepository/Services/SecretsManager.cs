using Amazon;
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using SecretsManagerRepository.Interfaces;
using System;
using System.Threading.Tasks;

namespace SecretsManagerRepository.Services
{
    public class SecretsManager : ISecretsManager
    {
        private GetSecretValueResponse response;

        private AmazonSecretsManagerConfig config => new AmazonSecretsManagerConfig { RegionEndpoint = EndPoint };

        private IAmazonSecretsManager client => new AmazonSecretsManagerClient(AWSKeyId, AWSAccessKey, config);

        /// <summary>
        /// Gets the secret.
        /// </summary>
        /// <param name="secretName">Name of the secret.</param>
        /// <returns>Decrypted <see cref="System.String"/> secret.</returns>
        public string GetSecret(string secretName)
        {
            // Creates a simple request object to the server.
            /// <see cref=" Amazon.SecretsManager.Model.GetSecretValueRequest"/>
            var request = new GetSecretValueRequest
            {
                SecretId = SecretName,
                VersionStage = VersionStage
            };

            try
            {
                // Run an async task to get the secrets value back from the server, while the rest of the app loads.
                response = Task.Run(async () => await client.GetSecretValueAsync(request)).Result;
            }
            catch (ResourceNotFoundException)
            {
                throw;
            }
            catch (InvalidRequestException)
            {
                throw;
            }
            catch (InvalidParameterException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            return response?.SecretString;
        }

        #region Properties

        /// <summary>
        /// Gets or sets the name of the secret.
        /// </summary>
        /// <value>
        /// The name of the secret.
        /// </value>
        public string SecretName { get; set; }

        /// <summary>
        /// Gets or sets the aws key identifier.
        /// </summary>
        /// <value>
        /// The aws key identifier.
        /// </value>
        public string AWSKeyId { get; set; }

        /// <summary>
        /// Gets or sets the aws access key.
        /// </summary>
        /// <value>
        /// The aws access key.
        /// </value>
        public string AWSAccessKey { get; set; }

        /// <summary>
        /// Gets or sets the version stage.
        /// </summary>
        /// <value>
        /// The version stage.
        /// </value>
        public string VersionStage { get; set; }

        /// <summary>
        /// Gets or sets the end point.
        /// </summary>
        /// <value>
        /// The end point.
        /// </value>
        public RegionEndpoint EndPoint { get; set; }

        #endregion
    }
}
