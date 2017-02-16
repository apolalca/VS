using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UWPWheater.ent;
using System.Runtime.Serialization.Json;
using System.IO;
using UWPWheater.ent.Models;

namespace UWPWheater.dal
{
    public static class Connection
    {
        private const string url = "http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&appid=8a238bfe8b5c36bf39a7835cc9c51dd1&units=imperial";

        public static async Task<RootObject> getWheater(Coord coord)
        {
            var http = new HttpClient();
            var response = await http.GetAsync("http://api.openweathermap.org/data/2.5/weather?lat=32.77&lon=-96.79&appid=8a238bfe8b5c36bf39a7835cc9c51dd1&units=imperial");
            var result = await response.Content.ReadAsStringAsync();
            var serializable =  new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializable.ReadObject(ms);

            return data;
        }
    }
}
