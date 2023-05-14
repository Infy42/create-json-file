using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace create_json_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsingClass();

            Console.Read();
        }

        static void UsingClass()
        {
            DateTime dateTime = DateTime.Now;
            DateTime dateTimeTwo = dateTime.AddDays(20);

            JSON json = new JSON()
            {
                id = 1,
                name = "Rapheal Colluci",
                email = "rafa@gmail.com",
                birth_date = dateTime.ToString(),
                salary = 105000,
                position = "C# Software Developer",
                hired_date = dateTimeTwo.ToString(),
            };

            string serializedJson = JsonSerializer.Serialize(json);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\createdJson.json";

            File.WriteAllText(path, serializedJson);
        }

        static void UsingAnonymous()
        {
            DateTime dateTime = DateTime.Now;
            DateTime dateTimeTwo = dateTime.AddDays(20);

            var json = new
            {
                id = 1,
                name = "Rapheal Colluci",
                email = "rafa@gmail.com",
                birth_date = dateTime.ToString(),
                salary = 105000,
                position = "C# Software Developer",
                hired_date = dateTimeTwo.ToString(),
            };

            string serializedJson = JsonSerializer.Serialize(json);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\createdJson.json";

            File.WriteAllText(path, serializedJson);
        }
    }
}
