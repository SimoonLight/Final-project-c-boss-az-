using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_project_c___boss_az_.Desing;
using Final_project_c___boss_az_.Database;

namespace Final_project_c___boss_az_.Backend
{
    public class Control_options
    {
        public static int move_options(string[] options, int options_size, int desing_number)
        {
            int index_of_option = 0;
            while (true)
            {
                Console.Clear();
                if (desing_number == 1)//dizaynin ekrana cixarilmasi ve reng verilmesi
                {
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desings_Class.boss_az_desing();
                    Console.WriteLine("\n\n\n");
                }
                for (int i = 0; i < options_size; i++)//secimler icinde dovr edir ve cesili olan secimin rengini deyisir.
                {
                    if (index_of_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                    {
                        string remember_color = All_settings.foreground_Color;
                        All_settings.select_option(All_settings.selected_option_Color);
                        Console.WriteLine("\t\t\t\t\t\t\t" + options[i]);
                        All_settings.select_color_foreground(remember_color);
                    }
                    else//diger bendlerin ekrana cixarilmasi
                    {
                        All_settings.select_color_foreground(All_settings.foreground_Color);
                        Console.WriteLine("\t\t\t\t\t\t\t" + options[i]);
                    }
                    All_settings.select_color_foreground(All_settings.foreground_Color);
                }
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.DownArrow)//istifadecinin daxil etdiyi deyisenin asaqqi oldugunu yoxlayir
                {
                    if (index_of_option < options_size - 1)
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
                        index_of_option = options_size - 1;
                    }
                }
                else if (input.Key==ConsoleKey.Enter)
                {
                    return index_of_option;
                }
            }//while
        }//move_option funk
    }
}
