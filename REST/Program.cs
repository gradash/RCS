
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using Newtonsoft.Json;

namespace REST
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "https://my-json-server.typicode.com/gradash/RCS/cars";

            WebClient client = new WebClient();

            String response = client.DownloadString(url);

            


            List<Car> rec = JsonConvert.DeserializeObject<List<Car>>(response);

           
            
                foreach (Car c in rec)
                {
                    Console.WriteLine(c.mark +" "+ c.model +" "+ c.color);
                }
            



        }
    }
}