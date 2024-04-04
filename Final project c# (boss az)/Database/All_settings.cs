using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Final_project_c___boss_az_.Classes;
using Final_project_c___boss_az_.File_;

namespace Final_project_c___boss_az_.Database
{
    public class All_settings
    {
        public static string foreground_Color = "Green";
        public static int foreground_Color_number = 5;
        public static string background_Color = "Black";
        public static int background_Color_number = 0;
        public static string selected_option_Color = "Red";
        public static int selected_option_Color_number = 2;
        public static string desing_Color = "Yellow";
        public static int desing_Color_number = 4;
        public static void select_color_foreground(string color)
        {
            if (color == "Black")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                foreground_Color = "Black";
            }
            else if(color == "White")
            {
                Console.ForegroundColor= ConsoleColor.White;
                foreground_Color = "White";
            }
            else if (color == "Red")
            {
                Console.ForegroundColor= ConsoleColor.Red;
                foreground_Color = "Red";
            }
            else if (color == "Gray")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                foreground_Color = "Gray";
            }
            else if (color == "Yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreground_Color = "Yellow";
            }
            else if (color == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                foreground_Color = "Green";
            }
            else if (color == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                foreground_Color = "Blue";
            }
        }
        public static void select_color_background(string color)
        {
            if (color == "Black")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                background_Color = "Black";
            }
            else if (color == "White")
            {
                Console.BackgroundColor = ConsoleColor.White;
                background_Color = "White";
            }
            else if (color == "Red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                background_Color = "Red";
            }
            else if (color == "Gray")
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                background_Color = "Gray";
            }
            else if (color == "Yellow")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                background_Color = "Yellow";
            }
            else if (color == "Green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                background_Color = "Green";
            }
            else if (color == "Blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                background_Color = "Blue";
            }
        }
        public static void select_option(string color)
        {
            if (color == "Black")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                selected_option_Color = "Black";
            }
            else if (color == "White")
            {
                Console.ForegroundColor = ConsoleColor.White;
                selected_option_Color = "White";
            }
            else if (color == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                selected_option_Color = "Red";
            }
            else if (color == "Gray")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                selected_option_Color = "Gray";
            }
            else if (color == "Yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                selected_option_Color = "Yellow";
            }
            else if (color == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                selected_option_Color = "Green";
            }
            else if (color == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                selected_option_Color = "Blue";
            }
        }
        public static void select_desing_color(string color)
        {
            if (color == "Black")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                desing_Color = "Black";
            }
            else if (color == "White")
            {
                Console.ForegroundColor = ConsoleColor.White;
                desing_Color = "White";
            }
            else if (color == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                desing_Color = "Red";
            }
            else if (color == "Gray")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                desing_Color = "Gray";
            }
            else if (color == "Yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                desing_Color = "Yellow";
            }
            else if (color == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                desing_Color = "Green";
            }
            else if (color == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                desing_Color = "Blue";
            }
        }

    }

    public class Database
    {
        private static Worker[] _allWorkers = new Worker[0];
        private static Employer[] _allEmployers = new Employer[0];

        public static Worker[] AllWorkers
        {
            get { return _allWorkers; }
        }

        public static Employer[] AllEmployers
        {
            get { return _allEmployers; }
        }

        public static void convert_workers(Worker[] new_workers)
        {
            Array.Resize(ref _allWorkers, new_workers.Length + 1);
            _allWorkers = new_workers;
        } 

        public static void convert_employers(Worker[] new_workers)
        {
            Array.Resize(ref _allWorkers, new_workers.Length + 1);
            _allWorkers = new_workers;
        } 

        public static void AddWorkerToDatabase(Worker worker)
        {
            Array.Resize(ref _allWorkers, _allWorkers.Length + 1);
            _allWorkers[_allWorkers.Length - 1] = worker;
        } 

        public static void AddEmployerToDatabase(Employer employer)
        {
            Array.Resize(ref _allEmployers, _allEmployers.Length + 1);
            _allEmployers[_allEmployers.Length - 1] = employer;
        }

        public static void DeleteWorkerToDatabase(Worker worker)
        {
            int index = 0;
            for (int i = 0; i < _allWorkers.Length; i++)
            {
                if (_allWorkers[i] != worker)
                {
                    _allWorkers[index++] = _allWorkers[i];
                }
            }
            Array.Resize(ref _allWorkers, _allWorkers.Length - 1);
            File_.File_class.Write_worker();
        }
        
        public static void DeleteEmployerToDatabase(Employer employer)
        {
            int index = 0;
            for (int i = 0; i < _allEmployers.Length; i++)
            {
                if (_allEmployers[i] != employer)
                {
                    _allEmployers[index++] = _allEmployers[i];
                }
            }
            Array.Resize(ref _allEmployers, _allEmployers.Length - 1);
            File_.File_class.Write_Employer();

        }

    }
}
