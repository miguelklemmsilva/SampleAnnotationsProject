using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Amazon.Lambda.Core;

namespace FirstAnnotationsProject;

public class GeneratedProgram
{
    public static async Task Main(string[] args)
    {

        switch (Environment.GetEnvironmentVariable("ANNOTATIONS_HANDLER"))
        {
            case "Default":
                Func<Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyRequest, Amazon.Lambda.Core.ILambdaContext, Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyResponse> default_handler = new FirstAnnotationsProject.Functions_Default_Generated().Default;
                await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder.Create(default_handler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer()).Build().RunAsync();
                break;
            case "Add":
                Func<Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyRequest, Amazon.Lambda.Core.ILambdaContext, Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyResponse> add_handler = new FirstAnnotationsProject.Functions_Add_Generated().Add;
                await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder.Create(add_handler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer()).Build().RunAsync();
                break;
            case "Subtract":
                Func<Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyRequest, Amazon.Lambda.Core.ILambdaContext, Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyResponse> subtract_handler = new FirstAnnotationsProject.Functions_Subtract_Generated().Subtract;
                await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder.Create(subtract_handler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer()).Build().RunAsync();
                break;
            case "Multiply":
                Func<Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyRequest, Amazon.Lambda.Core.ILambdaContext, Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyResponse> multiply_handler = new FirstAnnotationsProject.Functions_Multiply_Generated().Multiply;
                await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder.Create(multiply_handler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer()).Build().RunAsync();
                break;
            case "Divide":
                Func<Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyRequest, Amazon.Lambda.Core.ILambdaContext, Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyResponse> divide_handler = new FirstAnnotationsProject.Functions_Divide_Generated().Divide;
                await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder.Create(divide_handler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer()).Build().RunAsync();
                break;

        }
    }
}