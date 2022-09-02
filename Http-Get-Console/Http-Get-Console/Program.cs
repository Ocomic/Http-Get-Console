// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class program
    {
        public static string userInput = "dbXRates";
        public static async Task Main(string[] args)
        {

            dynamic response = await program.makeRequest("https://data-asg.goldprice.org/"+userInput+"/USD");
            Console.WriteLine(response);

        }

        public static async Task<dynamic> makeRequest(string url)
        {
            using var client = new HttpClient();

            var result = await client.GetStringAsync(url);
            dynamic json = JsonConvert.DeserializeObject<dynamic>(result);
            return json;

        }

    }

}
