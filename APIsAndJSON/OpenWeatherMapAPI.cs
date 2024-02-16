using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void Weather()
        {
            HttpClient client = new HttpClient();
            Console.WriteLine("enter city");           
            var myCity = Console.ReadLine();
            var myApiKey = "b576e859f26c54dfe653d89d5e857d72";

            var wEndpoint = $"https://api.openweathermap.org/data/2.5/weather?q={myCity}&appid={myApiKey}&units=imperial";
            var report = client.GetStringAsync(wEndpoint).Result;
            JObject wObject = JObject.Parse(report);
            Console.WriteLine(wObject["main"]["temp"]);
            

        }
    }
}
