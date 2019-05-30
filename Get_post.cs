using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Specialized;

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

                // Json get and post
                var response = wb.UploadValues("https://jsonplaceholder.typicode.com/posts", "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);
                Console.WriteLine(responseInString);
            }

            using (var wb = new WebClient())
            {
                var response = wb.DownloadString("https://jsonplaceholder.typicode.com/todos/1");
                Console.WriteLine(response);
            }

        }
    }
}
