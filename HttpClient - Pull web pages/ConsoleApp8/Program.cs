using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the defined method to do the function
            loadData();
            Console.ReadLine();
            
        }

        static async void loadData()
        {
            string page = "http://www.short-funny.com";
            using (HttpClient Matt = new HttpClient())
            using (HttpResponseMessage response = await Matt.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data !=null)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}
