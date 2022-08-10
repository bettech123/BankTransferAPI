using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using static BankTransferAPI.Models.Requests;

namespace BankTransferAPI.Repo
{
    public class BankTransfer : IBankTransfer
    {
        private static readonly HttpClient client;

        static BankTransfer()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("http://154.113.16.142:8882/postingrest/")
            };
        }

        public async Task<GetBvnDetailsRequest> GetBvnDetails(GetBvnDetailsRequest request)
        {
            var url = string.Format("/api/v2/GetBvnDetails/{0}/{1}/{2}", request.Bvn, request.UserName, request.Password);
            var result = new GetBvnDetailsRequest();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<GetBvnDetailsRequest>(stringResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return result;
        }
    }
}
