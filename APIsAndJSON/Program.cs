using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    
    public class Program
    {
        static void Main(string[] args)
        {

            #region first
            //var response = new RonVSKanyeAPI();
            //for(int i = 0; i <5; i++)
            //{
            //    var ronQuote = response.GetRon();
            //    Console.WriteLine(ronQuote);
            //    Console.WriteLine();
            //    var kanyeQuote = response.GetKanye();
            //   Console.WriteLine(kanyeQuote);

            //}
            #endregion
            #region Weather

            OpenWeatherMapAPI.Weather();
            #endregion
        }
    }
}
