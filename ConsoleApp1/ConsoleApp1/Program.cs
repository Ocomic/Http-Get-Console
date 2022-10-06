// See https://aka.ms/new-console-template for more information

// step1. Package Manager install: Install-Package Newtonsoft.Json -Version 12.0.3


using System;
using System.Data;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
    //program for getting json file from url source

   /* class program
    {
        //insert string in url of makeRequest
        public static string userInput = "db";

       //get Json response from http url  
        public static async Task Main(string[] args)
        {
            try
            {
                dynamic response = await program.makeRequest("https://my-json-server.typicode.com/Ocomic/Http-Get-Console/" + userInput);
                Console.WriteLine(response);


                


            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            


            //change (response) to (response.objectname) to enter a json object from
            //json "objectname" has to be changed to the name of the object in the file

        }

        //use url source to get json and await until task is finished
        public static async Task<dynamic> makeRequest(string url)
        {

            using var client = new HttpClient();

            try
            {
                var result = await client.GetStringAsync(url);
                dynamic json = JsonConvert.DeserializeObject<dynamic>(result);
                return json;            

            }

            finally
            {
                client.Dispose();
            }


        }

        





    }
    */
       
   class program
   {

       public static async Task Main(string[] args)
       {
           string userInput = "db";
           string url = "https://my-json-server.typicode.com/Ocomic/Http-Get-Console/" +userInput;

           HttpClient client = new HttpClient();

           try
           {
               var result = await client.GetAsync(url);
               string jsonResponse = await result.Content.ReadAsStringAsync();

               Console.WriteLine(jsonResponse);

                var test = JObject.Parse(jsonResponse);
                JArray items = (JArray)test["attachments"];
                int length = items.Count;

                Console.WriteLine(length);


                // count attachments -1 because attachment 1 is not needed, because it is just the text of the message
                int X = length;
                int[] nums2 = Enumerable.Range(1, X -1).ToArray();




                foreach (int i in nums2)
                {
                    string si = "Test" + i;
                    Console.WriteLine(si);
                }
                Console.ReadLine();






            }

           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }

           finally
           {
               client.Dispose();
           }







       }
    }

    
    
}




