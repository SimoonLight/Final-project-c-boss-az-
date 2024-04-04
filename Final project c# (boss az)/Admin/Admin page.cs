using Final_project_c___boss_az_.Database;
using Final_project_c___boss_az_.Desing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_project_c___boss_az_.Database;

namespace Final_project_c___boss_az_.Admin
{
    internal class Admin_page
    {
        public static string[] admin_page_options = {
        "Show Vacancies",
        "Show Employers",
        "Show Workers",
        "Delete Worker",
        "Delete Vacancie",
        "Delete Employer",
        "Back"
        };

        public static void check_admin()
        {
            Console.Clear();
            string color_rem = All_settings.foreground_Color;
            All_settings.select_desing_color(All_settings.desing_Color);
            Desings_Class.admin_desing();
            All_settings.select_color_foreground(color_rem);
            Console.Write("\t\t\t\n\n\n Enter Username : ");
            string check_admin_username = Console.ReadLine();
            Console.Write("\n Enter Password : ");
            string check_admin_password = Console.ReadLine();
            if (check_admin_username.ToString() == "admin" && check_admin_password.ToString() == "admin")
            {
                admin_page();
            }
            else
            {
                string remember_color = All_settings.foreground_Color;
                All_settings.select_color_foreground("Red");
                Console.Clear();
                Desings_Class.wrong_desing();
                Thread.Sleep(2000);
                All_settings.select_color_foreground(remember_color);
            }

        }

        public static void admin_page()
        {
            while (true)
            {
            int index_of_option = 0;
            while (true)
            {
                Console.Clear();
                All_settings.select_desing_color(All_settings.desing_Color);
                Desings_Class.admin_desing();
                All_settings.select_color_foreground(All_settings.foreground_Color);

                for (int i = 0; i < admin_page_options.Length; i++)//secimler icinde dovr edir ve cesili olan secimin rengini deyisir.
                {
                    if (index_of_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                    {
                        string remember_color = All_settings.foreground_Color;
                        All_settings.select_option(All_settings.selected_option_Color);
                        Console.WriteLine("\t\t\t\t\t\t\t" + admin_page_options[i]);
                        All_settings.select_color_foreground(remember_color);
                    }
                    else//diger bendlerin ekrana cixarilmasi
                    {
                        All_settings.select_color_foreground(All_settings.foreground_Color);
                        Console.WriteLine("\t\t\t\t\t\t\t" + admin_page_options[i]);
                    }
                    All_settings.select_color_foreground(All_settings.foreground_Color);
                }
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.DownArrow)//istifadecinin daxil etdiyi deyisenin asaqqi oldugunu yoxlayir
                {
                    if (index_of_option < admin_page_options.Length - 1)
                    {
                        index_of_option++;
                    }
                    else
                    {
                        index_of_option = 0;
                    }
                }
                else if (input.Key == ConsoleKey.UpArrow)//istifadecinin daxil etdiyi deyisenin yuxari oldugunu yoxlayir
                {
                    if (index_of_option > 0)
                    {
                        index_of_option--;
                    }
                    else
                    {
                        index_of_option = admin_page_options.Length - 1;
                    }
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }//while



            if (index_of_option == 0)
            {
                    Console.Clear();
                    string color_rem = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desings_Class.admin_desing();
                    All_settings.select_color_foreground(color_rem);
                    for (int i = 0; i < Database.Database.AllEmployers.Length; i++)
                {
                    for (int k = 0; k < Database.Database.AllEmployers[i].works.Length; k++)
                    {
                        Console.WriteLine(Database.Database.AllEmployers[i].works[k]);
                        Console.WriteLine(" ----------------------------------------------------- ");
                    }
                    Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++++ ");
                }
                Console.Write(" Click any button for go back : ");
                string for_back = Console.ReadLine();
            }
            else if (index_of_option == 1)
            {
                Console.Clear();
                string color_rem = All_settings.foreground_Color;
                All_settings.select_desing_color(All_settings.desing_Color);
                Desings_Class.admin_desing();
                All_settings.select_color_foreground(color_rem);
                for (int i = 0; i < Database.Database.AllEmployers.Length; i++)
                {
                    Database.Database.AllEmployers[i].Show_employer();
                    Console.WriteLine(" ----------------------------------------------------- ");
                }
                Console.Write(" Click any button for go back : ");
                string for_back = Console.ReadLine();
            }
            else if (index_of_option == 2)
            {
                //   "Show Workers",
                Console.Clear();
                string color_rem = All_settings.foreground_Color;
                All_settings.select_desing_color(All_settings.desing_Color);
                Desings_Class.admin_desing();
                All_settings.select_color_foreground(color_rem);
                for (int i = 0; i < Database.Database.AllWorkers.Length; i++)
                {
                    Database.Database.AllWorkers[i].Show_worker();
                    Console.WriteLine(" ----------------------------------------------------- ");
                }
                Console.Write(" Click any button for go back : ");
                string for_back = Console.ReadLine();
            }
            else if (index_of_option == 3)
            {
                //   "Delete Worker"
                Console.Clear();
                string color_rem = All_settings.foreground_Color;
                All_settings.select_desing_color(All_settings.desing_Color);
                Desings_Class.admin_desing();
                All_settings.select_color_foreground(color_rem);
                for (int i = 0; i < Database.Database.AllWorkers.Length; i++)
                {
                    Database.Database.AllWorkers[i].Show_worker();
                    Console.WriteLine(" ----------------------------------------------------- ");
                }
                Console.Write(" enter nickname : ");
                string check_nickname = Console.ReadLine();
                bool check = false;
                for (int i = 0; i < Database.Database.AllWorkers.Length; i++)
                {
                    if (Database.Database.AllWorkers[i].username == check_nickname)
                    {
                        check = true;
                    }
                    if (check == true)
                    {
                        Database.Database.DeleteWorkerToDatabase(Database.Database.AllWorkers[i]);

                    }
                }
            }
            else if (index_of_option == 4)
            {
                //"Delete Vacancie",
                Console.Clear();
                string color_rem = All_settings.foreground_Color;
                All_settings.select_desing_color(All_settings.desing_Color);
                Desings_Class.admin_desing();
                All_settings.select_color_foreground(color_rem);

                for (int i = 0; i < Database.Database.AllEmployers.Length; i++)
                {
                    for (int k = 0; k < Database.Database.AllEmployers[i].works.Length; k++)
                    {
                        Database.Database.AllEmployers[i].works[k].Show_Work();
                        Console.WriteLine(" ----------------------------------------------------- ");
                    }
                    Database.Database.AllEmployers[i].Show_employer();
                    Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++++ ");
                }
                Console.Write(" enter name : ");
                string check_nickname = Console.ReadLine();
                bool check = false;
                for (int i = 0; i < Database.Database.AllEmployers.Length; i++)
                {
                    for (int k = 0; k < Database.Database.AllEmployers[i].works.Length; k++)
                    {
                        if (Database.Database.AllEmployers[i].works[k].name == check_nickname)
                        {
                            check = true;
                        }
                        if (check == true)
                        {
                            Database.Database.AllEmployers[i].delete_work_to_worker(Database.Database.AllEmployers[i].works[k]);

                        }
                    }
                }
            }
            else if (index_of_option == 5)
            {
                //"Delete employer",
                Console.Clear();
                string color_rem = All_settings.foreground_Color;
                All_settings.select_desing_color(All_settings.desing_Color);
                Desings_Class.admin_desing();
                All_settings.select_color_foreground(color_rem);
                for (int i = 0; i < Database.Database.AllEmployers.Length; i++)
                {
                    Database.Database.AllEmployers[i].Show_employer();
                    Console.WriteLine(" ----------------------------------------------------- ");
                }
                Console.Write(" enter nickname : ");
                string check_nickname = Console.ReadLine();
                bool check = false;
                for (int i = 0; i < Database.Database.AllEmployers.Length; i++)
                {
                    if (Database.Database.AllEmployers[i].username == check_nickname)
                    {
                        check = true;
                    }
                    if (check == true)
                    {
                        Database.Database.DeleteEmployerToDatabase(Database.Database.AllEmployers[i]);

                    }
                }
            }
            else if (index_of_option == 7)
            {
                //back
                    break;
            }
            else
            {
                    break;
            }

            }
        }
    }
}
