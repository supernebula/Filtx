﻿using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Plunder.Setting
{
    class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {

                Console.WriteLine($"Server Listen:{baseAddress}");
                // Create HttpCient and make a request to api/values 
                //HttpClient client = new HttpClient();
                //var response = client.GetAsync(baseAddress + "api/values").Result;
                //Console.WriteLine(response);
                //Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                System.Diagnostics.Process.Start(baseAddress);

                Console.ReadLine();

            }


        }

    }
}
