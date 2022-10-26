using System;
using CsvReader;
using System.IO;
using System.Globalization;
using System.Linq;

namespace SM
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader(Desktop\MCUMovies.csv.rtf)
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var movies = csvReader.GetRecords<dynamic>().ToList();
                }
            }
        }
    }
}