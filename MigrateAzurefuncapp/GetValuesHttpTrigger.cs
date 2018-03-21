using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using MigrateFunctionServices;

namespace MigrateAzurefuncapp
{
    public static class GetValuesHttpTrigger
    {
        public static async Task<HttpResponseMessage> Run(HttpRequestMessage req)
        {
            var service = new ValueServices();

            var values = await service.GetValues();

            return req.CreateResponse(HttpStatusCode.OK, values);
        }
    }
}