using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SystemsInsight.Core
{
    public static class JsonUtilities
    {
        public static JsonSerializerOptions GetJsonDefaults()
        {
            var options = new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
               //IgnoreReadOnlyProperties = true,
                WriteIndented = true,
            };

            return options;

        }
        public static string ConvertToJsonString(this object o)
        {
            var options = GetJsonDefaults();

            var s = JsonSerializer.Serialize(o, options);

            return s;
        }

        public static T ConvertFromJsonString<T>(this string s)
        {
            var options = GetJsonDefaults();

            var o = JsonSerializer.Deserialize(s, typeof(T), options);

            return (T)o;
        }

        public static void WriteJsonFile(this object o, string path)
        {
            var s = o.ConvertToJsonString();

            File.WriteAllText(path, s);
        }

        public static T ReadJsonFile<T>(string path)
        {
            var s = File.ReadAllText(path);

            var o = ConvertFromJsonString<T>(s);

            return o;
        }
    }
}
