// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    //program for getting json file from url source
    class program
    {
        //insert string in url of makeRequest
        public static string userInput = "dbXRates";
        
        //get Json response from http url  
        public static async Task Main(string[] args)
        {

            dynamic response = await program.makeRequest("https://data-asg.goldprice.org/"+userInput+"/USD");
            Console.WriteLine(response);

        }

        //use url source to get json and await until task is finished
        public static async Task<dynamic> makeRequest(string url)
        {
            using var client = new HttpClient();

            var result = await client.GetStringAsync(url);
            dynamic json = JsonConvert.DeserializeObject<dynamic>(result);
            return json;

        }

    }

}
