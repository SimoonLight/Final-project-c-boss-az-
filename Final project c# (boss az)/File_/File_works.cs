using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Final_project_c___boss_az_.Classes;
using Final_project_c___boss_az_.Database;

namespace Final_project_c___boss_az_.File_
{
    public class File_class
    {
        public static void Write_worker()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(Database.Database.AllWorkers, options);

            File.WriteAllText("Workers.json", jsonString);

            Console.WriteLine("Workers have been successfully written to Workers.json.");


        }

        public static void Write_Employer()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(Database.Database.AllEmployers, options);

            File.WriteAllText("Employers.json", jsonString);

            Console.WriteLine("Employers have been successfully written to Employers.json.");


        }

        public static void ReadWorkersFromJson()
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = true
            };

            string jsonString = File.ReadAllText("Workers.json");
            Worker[] workers = JsonSerializer.Deserialize<Worker[]>(jsonString, options);

            // Diziyi doğrudan Database.Database.AllWorkers'e atayın
            Database.Database.convert_workers(workers);

            
        }

        public static void ReadEmployersFromJson()
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = true
            };

            string jsonString = File.ReadAllText("Workers.json");
            Worker[] employers = JsonSerializer.Deserialize<Worker[]>(jsonString, options);

            // Diziyi doğrudan Database.Database.AllWorkers'e atayın
            Database.Database.convert_employers(employers);

          
        }
    }
}
