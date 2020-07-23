using System;
using System.Net.Http;

namespace TestBypassSSL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            HttpClient httpClient = new HttpClient();
            var result = httpClient.GetAsync("https://mb3admin.com/").Result;
            Console.WriteLine(result.Content.ReadAsStringAsync().Result);
        }
    }
}
