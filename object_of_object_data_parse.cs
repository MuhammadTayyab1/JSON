using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Specialized;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Examples.System.Net
{

    public class WebRequestPostExample
    {
        public static void Main()
        {
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString("https://api.myjson.com/bins/a4vru");

                Console.WriteLine(response);

                Dictionary<string, car> test = JsonConvert.DeserializeObject<Dictionary<string, car>>(response);

                string[] nam = new string[test.Keys.ToArray().Length];
                string[] id = new string[test.Keys.ToArray().Length];
                string[] sta = new string[test.Keys.ToArray().Length];


                string[] keys = test.Keys.ToArray();

                int index = 0;
                foreach (var item in keys)
                {
                    car temp = test[item];

                    //Console.WriteLine(temp.Name);
                    nam[index] = temp.Name;

                    //Console.WriteLine(temp.Id);
                    id[index] = temp.Id;

                    //Console.WriteLine(temp.Status);
                    sta[index] = temp.Status;

                    index++;

                    //Console.WriteLine("=============");
                }


                // checking arrays data
                Console.WriteLine("data in arrays ");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("Name    :  " + nam[i]);
                    Console.WriteLine("Id      :  " + id[i]);
                    Console.WriteLine("Status  :  " + sta[i]);
                }

            }

        }

        public class car
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public string Status { get; set; }

        }
    }
}