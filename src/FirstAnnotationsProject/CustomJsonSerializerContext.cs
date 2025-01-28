using System.Text.Json.Serialization;
using Amazon.Lambda.APIGatewayEvents;

namespace FirstAnnotationsProject;

[JsonSerializable(typeof(APIGatewayHttpApiV2ProxyRequest))]
[JsonSerializable(typeof(APIGatewayHttpApiV2ProxyResponse))]
public partial class CustomJsonSerializerContext : JsonSerializerContext
{
}