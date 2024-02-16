using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        HttpClient client = new HttpClient();
        //end point -;
        //newtonsoft json nuget package
        // need http
        public string GetRon()
        {
            HttpClient client = new HttpClient();
            string ronEndpoint = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            string ronResponse = client.GetStringAsync(ronEndpoint).Result;
            var ronQuote = JArray.Parse(ronResponse)[0].ToString();
            return ronQuote;
        }
        public string GetKanye()
        {
            HttpClient client = new HttpClient();
            string kanyEndpoint = "https://api.kanye.rest/";
            string kanyeResponse = client.GetStringAsync(kanyEndpoint).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse)["quote"].ToString();
            return kanyeQuote;
           
        }
    }
}
