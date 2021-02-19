## What is AWS Secrets Manager

AWS Secrets Manager provides protection of sensitive data such as API keys, database connection strings and other secrets. 
The use of AWS Secrets eliminates the need to hardcode sensitive information in plain text.

It also provides rotation of secets to better protect and meet compliance requirements.

## Benefits

### Rotate secrets safely

AWS Secrets Manager help meet security and compliance requirements by enabling the rotation of secrets safely without the need for
code deployments.

Using LAMBDA functions can also extend secrets manager rotation to other types, such as APIkeys and auth tokens.

### Manage accesss

Using fine-grained AWS Identity and Access Management (IAM) policies, access to secrets can be restricted.

A good example would be to allow developers to access secrets only when they are used in a development environment.

### Secure and audit centrally

With AWS Secrets Manager, keys can be encrypted using encryption keys using AWS Key Management Service, which also integrates into AWS logging 
monitoring for centralised auditing.

## Getting Started

### Prerequisites

- An AWS console account is required. If you do not have one, then create one [here](https://portal.aws.amazon.com/billing/signup#/start).
- All relevant networking configuration has been setup so that the Secret Manager API can be accessed externally.

To get started using AWS Secrets Manager, simply visit the [Secrets Manager](https://aws.amazon.com/secrets-manager/) portal and click on the Get started with AWS Secrets Manager.

AWS Secrets Manager offers a host of additional features in its [API](https://docs.aws.amazon.com/secretsmanager/latest/apireference/Welcome.html). However, the example only covers retrieving (read only) information.

Although there are a number of additional features offered by AWS Secrets, it is recommended that secret keys are stored and managed by an administrator.

### Application Settings

The sample API has been configured to accept a number of parameters which are all obtained from the AWS Secret Manager console.

- AWSAccess - key used in conjunction with AWSKeyId to access the API.
- AWSKeyId - key used in conjunction with AWSAccess to access the API.
- EndPoint - API endpoint will be a region, for example Amazon.RegionEndpoint.EUWest1.
- SecretName - this is the name given to the secret key you would like to retrieve a decrypted string value from.
- VersionStage - optional.

These paramaters can be used in the appsettings.json file and passed during start-up or runtime. The application example would pass these values using ConfigurationBuilder at runtime.

Once all paramters have been saved, run the API and test the API using the Swagger UI.## What is AWS Secrets Manager

AWS Secrets Manager provides protection of sensitive data such as API keys, database connection strings and other secrets. 
The use of AWS Secrets eliminates the need to hardcode sensitive information in plain text.

It also provides rotation of secets to better protect and meet compliance requirements.

## Benefits

### Rotate secrets safely

AWS Secrets Manager help meet security and compliance requirements by enabling the rotation of secrets safely without the need for
code deployments.

Using LAMBDA functions can also extend secrets manager rotation to other types, such as APIkeys and auth tokens.

### Manage accesss

Using fine-grained AWS Identity and Access Management (IAM) policies, access to secrets can be restricted.

A good example would be to allow developers to access secrets only when they are used in a development environment.

### Secure and audit centrally

With AWS Secrets Manager, keys can be encrypted using encryption keys using AWS Key Management Service, which also integrates into AWS logging 
monitoring for centralised auditing.

## Getting Started

### Prerequisites

- An AWS console account is required. If you do not have one, then create one [here](https://portal.aws.amazon.com/billing/signup#/start).
- All relevant networking configuration has been setup so that the Secret Manager API can be accessed externally.

To get started using AWS Secrets Manager, simply visit the [Secrets Manager](https://aws.amazon.com/secrets-manager/) portal and click on the Get started with AWS Secrets Manager.

AWS Secrets Manager offers a host of additional features in its [API](https://docs.aws.amazon.com/secretsmanager/latest/apireference/Welcome.html). However, the example only covers retrieving (read only) information.

Although there are a number of additional features offered by AWS Secrets, it is recommended that secret keys are stored and managed by an administrator.

### Application Settings

The sample API has been configured to accept a number of parameters which are all obtained from the AWS Secret Manager console.

- AWSAccess - key used in conjunction with AWSKeyId to access the API.
- AWSKeyId - key used in conjunction with AWSAccess to access the API.
- EndPoint - API endpoint will be a region, for example Amazon.RegionEndpoint.EUWest1.
- SecretName - this is the name given to the secret key you would like to retrieve a decrypted string value from.
- VersionStage - optional.

These paramaters can be used in the appsettings.json file and passed during start-up or runtime. The application example would pass these values using ConfigurationBuilder at runtime.

Once all paramters have been saved, run the API and test the API using the Swagger UI.

[![Buy me a Coffee](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/ultracoolbru)
[![Become a Patron](https://img.shields.io/badge/Patreon-F96854?style=for-the-badge&logo=patreon&logoColor=white)](https://www.patreon.com/ultracoolbru)

[![Facebook](https://img.shields.io/badge/Facebook-1877F2?style=for-the-badge&logo=facebook&logoColor=white)](https://www.faceboook.com/ultracoolplayground)
[![Instagram](https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white)](https://www.instagram.com/ultracoolbru)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/ultracoolbru)
[![Github](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/ultracoolbru)



