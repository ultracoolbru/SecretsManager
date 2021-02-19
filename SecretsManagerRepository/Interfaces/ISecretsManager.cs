using Amazon;

namespace SecretsManagerRepository.Interfaces
{
    public interface ISecretsManager
    {
        /// <summary>
        /// Gets or sets the name of the secret.
        /// </summary>
        /// <value>
        /// The name of the secret.
        /// </value>
        string SecretName { get; set; }

        /// <summary>
        /// Gets or sets the aws key identifier.
        /// </summary>
        /// <value>
        /// The aws key identifier.
        /// </value>
        string AWSKeyId { get; set; }

        /// <summary>
        /// Gets or sets the aws access key.
        /// </summary>
        /// <value>
        /// The aws access key.
        /// </value>
        string AWSAccessKey { get; set; }

        /// <summary>
        /// Gets or sets the version stage.
        /// </summary>
        /// <value>
        /// The version stage.
        /// </value>
        string VersionStage { get; set; }

        /// <summary>
        /// Gets or sets the end point.
        /// </summary>
        /// <value>
        /// The end point.
        /// </value>
        RegionEndpoint EndPoint { get; set; }

        /// <summary>
        /// Gets the secret.
        /// </summary>
        /// <param name="secretName">Name of the secret.</param>
        /// <returns>Decrypted <see cref="System.String"/> secret.</returns>
        string GetSecret(string secretName);
    }
}
