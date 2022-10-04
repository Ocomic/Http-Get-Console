// See https://aka.ms/new-console-template for more information

// step1. Package Manager install: Install-Package Newtonsoft.Json -Version 12.0.3


using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

            dynamic response = await program.makeRequest("https://my-json-server.typicode.com/Ocomic/Http-Get-Console/db");
            Console.WriteLine(response); 
            //change (response) to (response.objectname) to enter a json object from
            //json "objectname" has to be changed to the name of the object in the file

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
