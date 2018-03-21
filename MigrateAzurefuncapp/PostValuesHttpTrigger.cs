
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Host;
using MigrateFunctionServices;

namespace MigrateAzurefuncapp
{
    public class PostValuesHttpTrigger
    {
        // Make sure this SHOULD always be static.
        public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger Post function processed a request.");

            var service = new ValueServices();

            var result = await service.UpdateValues();

            return req.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}