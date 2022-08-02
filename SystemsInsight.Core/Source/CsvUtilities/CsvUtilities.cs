using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsInsight.Core
{
    public static class CsvUtilities
    {
        public static void WriteCsvFile<T>(this IEnumerable<T> data, string fileName)
        {
            using var writer = new StreamWriter(fileName);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                  AllowComments = true,
                  IgnoreBlankLines = true,
            };

            using var csv = new CsvWriter(writer, config);

            csv.WriteRecords<T>(data);
        }

        public static List<T> ReadCsvFile<T>(string fileName)
        {
            using var reader = new StreamReader(fileName);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                AllowComments = true,
                IgnoreBlankLines = true,
            };

            using var csv = new CsvReader(reader, config);

            var data = csv.GetRecords<T>().ToList();

            return data;
        }
    }
}
