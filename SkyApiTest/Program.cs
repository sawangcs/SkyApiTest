using RestSharp;
using System;
using System.Threading.Tasks;

namespace SkyApiTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                RestClient client = new RestClient(new RestClientOptions("https://phxdev-nginx1.intra.ais:2443/"));
                RestRequest request = new RestRequest("sky-auth/v1/user/authenticate");
                request.AddHeader("Content-Type", "application/json");
                request.AddStringBody("{ \"username\":\"oly_usr\", \"password\":\"ebb1345b837c3039d16e9c0675cc449a\"}", "application/json");
                Console.WriteLine((await client.PostAsync(request)).Content!.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
