using Final_project_c___boss_az_.Database;
using Final_project_c___boss_az_.Desing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_project_c___boss_az_.Classes;
using Final_project_c___boss_az_.Database;
using Final_project_c___boss_az_.File_;
using Final_project_c___boss_az_.Checks;

namespace Final_project_c___boss_az_.User
{
    internal class User
    {

        public static void Sign_in()//girmek
        {
            Console.Clear();
            string remember_color_ = All_settings.foreground_Color;
            All_settings.select_desing_color(All_settings.desing_Color);
            Desings_Class.sign_in_desing();
            All_settings.select_color_foreground(remember_color_);

            int number = chouse_workerOREmployer();
            if (number == 0 || number == 1)
            {

                Console.Write("\n\n\n\t\t\t Enter username : ");
                string user_username = Console.ReadLine();
                Console.Write("\n\n\n\t\t\t Enter password : ");
                string user_password = Console.ReadLine();

                if (number == 0)
                {
                    //worker
                    for (int i = 0; i < Database.Database.AllWorkers.Length; i++)
                    {
                        if (Database.Database.AllWorkers[i].username == user_username && Database.Database.AllWorkers[i].password == user_password)
                        {
                            worker_page(Database.Database.AllWorkers[i]);
                        }
                    }
                }
                else if (number == 1)
                {
                    //employer
                    for (int i = 0; i < Database.Database.AllEmployers.Length; i++)
                    {
                        if (Database.Database.AllEmployers[i].username == user_username && Database.Database.AllEmployers[i].password == user_password)
                        {
                            Employer_page(Database.Database.AllEmployers[i]);
                        }
                    }
                }
                else
                {
                    //back
                }

            }
        }

        public static bool check_email;

        public static void Sign_up()//kayt olmaq
        {
            //ad,soyad,yas,email,nomre,nickname,password

            int number = chouse_workerOREmployer();
            if (number == 0 || number == 1)
            {
                again_choice_employer:
                Console.Clear();
                string remember_color_ = All_settings.foreground_Color;
                All_settings.select_desing_color(All_settings.desing_Color);
                Desings_Class.sign_up_desing();
                All_settings.select_color_foreground(remember_color_);

                Console.Write("\n\n\n\t\t\t Enter your name : ");
                string user_name = Console.ReadLine();
                bool check_name=Checks.Check_class.check_name(user_name);
                if (check_name == false)
                {
                    goto again_choice_employer;
                }

                Console.Write("\t\t\t Enter your surname : ");
                string user_surname = Console.ReadLine();
                bool check_surname=Checks.Check_class.check_name(user_surname);
                if (check_surname == false)
                {
                    goto again_choice_employer;
                }

                Console.Write("\t\t\t Enter your age : ");
                string user_age = Console.ReadLine();
                bool check_age=Checks.Check_class.check_age(user_age);
                if (check_age == false)
                {
                    goto again_choice_employer;
                }

                Console.Write("\t\t\t Enter your email : ");
                string user_email = Console.ReadLine();
                check_email=Checks.Check_class.check_email(user_email);
                Checks.Check_class.SendEmail(user_email);
                if (check_email == false)
                {
                    goto again_choice_employer;
                }

                Console.Write("\t\t\t Enter your nomre : ");
                string user_nomre = Console.ReadLine();
                bool check_nomre=Checks.Check_class.check_number(user_nomre);
                if (check_nomre == false)
                {
                    goto again_choice_employer;
                }

                Console.Write("\t\t\t Enter your nickname : ");
                string user_nickname = Console.ReadLine();
                bool check_username=Checks.Check_class.check_name(user_nickname);
                if (check_username == false)
                {
                    goto again_choice_employer;
                }

                Console.Write("\t\t\t Enter your password : ");
                string user_password = Console.ReadLine();
                bool check_password=Checks.Check_class.check_name(user_password);
                if (check_password == false)
                {
                    goto again_choice_employer;
                }



                if (number == 0)
                {
                    Worker worker = new Worker(user_name, user_surname, user_age, user_email, user_nomre, user_nickname, user_password);
                    Database.Database.AddWorkerToDatabase(worker);
                    File_.File_class.Write_worker();
                }
                else if (number == 1)
                {
                    Employer employer = new Employer(user_name, user_surname, user_age, user_email, user_nomre, user_nickname, user_password);
                    Database.Database.AddEmployerToDatabase(employer);
                    File_.File_class.Write_Employer();
                }

            }
            else
            {
                //back
            }
        }

        public static string[] choice_WorkerOREmployer_list =
        {
            "Worker",
            "Employer",
            "Back"
        };

        public static int chouse_workerOREmployer()
        {
            Console.Clear();
            string remember_color_ = All_settings.foreground_Color;
            All_settings.select_desing_color(All_settings.desing_Color);
            Desings_Class.sign_up_desing();
            All_settings.select_color_foreground(remember_color_);

            int index_of_option = 0;
            while (true)
            {
                Console.Clear();
                All_settings.select_desing_color(All_settings.desing_Color);
                Desings_Class.admin_desing();
                All_settings.select_color_foreground(All_settings.foreground_Color);

                for (int i = 0; i < choice_WorkerOREmployer_list.Length; i++)//secimler icinde dovr edir ve cesili olan secimin rengini deyisir.
                {
                    if (index_of_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                    {
                        string remember_color = All_settings.foreground_Color;
                        All_settings.select_option(All_settings.selected_option_Color);
                        Console.WriteLine("\t\t\t\t\t\t\t" + choice_WorkerOREmployer_list[i]);
                        All_settings.select_color_foreground(remember_color);
                    }
                    else//diger bendlerin ekrana cixarilmasi
                    {
                        All_settings.select_color_foreground(All_settings.foreground_Color);
                        Console.WriteLine("\t\t\t\t\t\t\t" + choice_WorkerOREmployer_list[i]);
                    }
                    All_settings.select_color_foreground(All_settings.foreground_Color);
                }
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.DownArrow)//istifadecinin daxil etdiyi deyisenin asaqqi oldugunu yoxlayir
                {
                    if (index_of_option < choice_WorkerOREmployer_list.Length - 1)
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
                        index_of_option = choice_WorkerOREmployer_list.Length - 1;
                    }
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }//while

            if (index_of_option == 0)
            {
                return 0;
            }
            else if (index_of_option == 1)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }

        public static string[] employer_page_options = {
        "Show Vacancies",
        "Delete Vacancie",
        "Add Vacancies",
        "Show notfications",
        "Back"
        };

        public static void Employer_page(Employer employer)
        {
            Console.Clear();
            string remember_color_ = All_settings.foreground_Color;
            All_settings.select_desing_color(All_settings.desing_Color);
            Desing.Desings_Class.employer_desing();
            All_settings.select_color_foreground(remember_color_);

            while (true)
            {

                int index_of_option = 0;
                while (true)
                {
                    Console.Clear();
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desings_Class.admin_desing();
                    All_settings.select_color_foreground(All_settings.foreground_Color);

                    for (int i = 0; i < employer_page_options.Length; i++)//secimler icinde dovr edir ve cesili olan secimin rengini deyisir.
                    {
                        if (index_of_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                        {
                            string remember_color = All_settings.foreground_Color;
                            All_settings.select_option(All_settings.selected_option_Color);
                            Console.WriteLine("\t\t\t\t\t\t\t" + employer_page_options[i]);
                            All_settings.select_color_foreground(remember_color);
                        }
                        else//diger bendlerin ekrana cixarilmasi
                        {
                            All_settings.select_color_foreground(All_settings.foreground_Color);
                            Console.WriteLine("\t\t\t\t\t\t\t" + employer_page_options[i]);
                        }
                        All_settings.select_color_foreground(All_settings.foreground_Color);
                    }
                    ConsoleKeyInfo input;
                    input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.DownArrow)//istifadecinin daxil etdiyi deyisenin asaqqi oldugunu yoxlayir
                    {
                        if (index_of_option < employer_page_options.Length - 1)
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
                            index_of_option = employer_page_options.Length - 1;
                        }
                    }
                    else if (input.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }//while

                if (index_of_option == 0)
                {
                    //show
                    Console.Clear();
                    string remember_color_2 = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desing.Desings_Class.employer_desing();
                    All_settings.select_color_foreground(remember_color_2);
                    for (int i = 0; i < employer.works.Length; i++)
                    {
                        employer.works[i].Show_Work();
                    }

                    Console.Write(" Click any button for contunuye : ");
                    string click_for_contunie = Console.ReadLine();

                }
                else if (index_of_option == 1)
                {
                    //delete vacation
                    Console.Clear();
                    string remember_color_2 = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desing.Desings_Class.employer_desing();
                    All_settings.select_color_foreground(remember_color_2);
                    for (int i = 0; i < employer.works.Length; i++)
                    {
                        employer.works[i].Show_Work();
                    }

                    Console.Write(" Enter vacation name : ");
                    string vacation_name = Console.ReadLine();

                    for (int i = 0; i < employer.works.Length; i++)
                    {
                        if (employer.works[i].name == vacation_name)
                        {
                            employer.delete_work_to_worker(employer.works[i]);
                        }
                    }

                }
                else if (index_of_option == 2)
                {
                    // add_vacation
                    Console.Clear();
                    string remember_color_2 = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desing.Desings_Class.employer_desing();
                    All_settings.select_color_foreground(remember_color_2);

                    //name dexcription salary about
                    Console.Write("\t\t\t\n\n\n Enter Vacation name : ");
                    string work_name=Console.ReadLine();
                    Console.Write("\t\t\t\n\n\n Enter Vacation description : ");
                    string work_description=Console.ReadLine();
                    Console.Write("\t\t\t\n\n\n Enter Vacation salary : ");
                    string work_salary=Console.ReadLine();
                    Console.Write("\t\t\t\n\n\n Enter Vacation about : ");
                    string work_about=Console.ReadLine();

                    Work new_work = new Work(work_name,work_description,work_salary,work_about);
                    employer.Add_work_to_employer(new_work);
                }
                else if (index_of_option == 3)
                {
                    //show notfications
                    Console.Clear();
                    string remember_color_2 = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desing.Desings_Class.employer_desing();

                    for (int i = 0; i < employer.notfications.Length; i++)
                    {
                        Console.WriteLine(employer.notfications[i].message);
                        Console.WriteLine(" ------------------------------------------ ");
                    }
                    Console.Write(" Click any button for contunuye : ");
                    string click_for_contunie = Console.ReadLine();
                }
                else
                {
                    break;
                }

            }
        }


        public static string[] worker_page_options = {
        "Show Vacancies",
        "Back"
        };

        public static void worker_page(Worker worker)
        {
            Console.Clear();
            string remember_color_ = All_settings.foreground_Color;
            All_settings.select_desing_color(All_settings.desing_Color);
            Desing.Desings_Class.employer_desing();
            All_settings.select_color_foreground(remember_color_);

            while (true)
            {

                int index_of_option = 0;
                while (true)
                {
                    Console.Clear();
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desings_Class.admin_desing();
                    All_settings.select_color_foreground(All_settings.foreground_Color);

                    for (int i = 0; i < worker_page_options.Length; i++)//secimler icinde dovr edir ve cesili olan secimin rengini deyisir.
                    {
                        if (index_of_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                        {
                            string remember_color = All_settings.foreground_Color;
                            All_settings.select_option(All_settings.selected_option_Color);
                            Console.WriteLine("\t\t\t\t\t\t\t" + worker_page_options[i]);
                            All_settings.select_color_foreground(remember_color);
                        }
                        else//diger bendlerin ekrana cixarilmasi
                        {
                            All_settings.select_color_foreground(All_settings.foreground_Color);
                            Console.WriteLine("\t\t\t\t\t\t\t" + worker_page_options[i]);
                        }
                        All_settings.select_color_foreground(All_settings.foreground_Color);
                    }
                    ConsoleKeyInfo input;
                    input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.DownArrow)//istifadecinin daxil etdiyi deyisenin asaqqi oldugunu yoxlayir
                    {
                        if (index_of_option < worker_page_options.Length - 1)
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
                            index_of_option = worker_page_options.Length - 1;
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
                    string remember_color_2 = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desing.Desings_Class.employer_desing();
                    All_settings.select_color_foreground(remember_color_2);
                    for (int i = 0; i < Database.Database.AllEmployers.Length; i++)
                    {
                        for (int k = 0; k < Database.Database.AllEmployers[i].works.Length; k++)
                        {
                            Database.Database.AllEmployers[i].works[k].Show_Work();
                            Console.WriteLine(" --------------------------------------------- ");

                        }
                    }

                    Console.Write(" Enter vacancie name : ");
                    string work_name_enter = Console.ReadLine();

                    for (int i = 0; i < Database.Database.AllEmployers.Length; i++)
                    {
                        for (int k = 0; k < Database.Database.AllEmployers[i].works.Length; k++)
                        {
                            if (Database.Database.AllEmployers[i].works[k].name == work_name_enter)
                            {
                                Notfication notfication = new Notfication($"{worker.name} added your vacancie ");
                                Database.Database.AllEmployers[i].Add_notfication_to_employer(notfication);
                            }

                        }
                    }

                }
                else
                {
                    break;
                }

            }
        }

    }
}
