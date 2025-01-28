using System.Text.Json.Serialization;
using Amazon.Lambda.Annotations;
using Amazon.Lambda.APIGatewayEvents;

namespace FirstAnnotationsProject;

[JsonSerializable(typeof(APIGatewayHttpApiV2ProxyRequest))]
[JsonSerializable(typeof(APIGatewayHttpApiV2ProxyResponse))]
[assembly: LambdaGlobalProperties(GenerateMain = true)]
public partial class CustomJsonSerializerContext : JsonSerializerContext
{
}