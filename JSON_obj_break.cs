using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Specialized;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace Examples.System.Net
{

    public class WebRequestPostExample
    {
        public static void Main()
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["username"] = "myUser";
                data["password"] = "myPassword";

                var response = wb.UploadValues("https://jsonplaceholder.typicode.com/posts", "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);
                //Console.WriteLine(responseInString);
            }

            using (var wb = new WebClient())
            {
                var response = wb.DownloadString("https://jsonplaceholder.typicode.com/todos/1");
                Dictionary<string, object> list = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.ToString());

                string[] keys = list.Keys.ToArray();

                Console.WriteLine("Origanal data ");
                Console.WriteLine("===========================");
                Console.WriteLine("");
                Console.WriteLine(response);
                Console.WriteLine("===========================");
                Console.WriteLine("Breaking data ");
                Console.WriteLine("");
                // or you  can use for loop
                Console.WriteLine("1 ) " + list[keys[0]].ToString());
                Console.WriteLine("2 ) " + list[keys[1]].ToString());
                Console.WriteLine("3 ) " + list[keys[2]].ToString());
                Console.WriteLine("4 ) " + list[keys[3]].ToString());



                Console.WriteLine();

                //Console.WriteLine(response);
            }

        }
    }
}
