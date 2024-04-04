using Final_project_c___boss_az_.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Final_project_c___boss_az_.Admin;
using Final_project_c___boss_az_.User;


namespace Final_project_c___boss_az_.Desing
{
    public class Desings_Class
    {
        //1
        public static void boss_az_desing()
        {
            Console.WriteLine($@"
                                 ░▒▓███████▓▒░ ░▒▓██████▓▒░ ░▒▓███████▓▒░▒▓███████▓▒░       ░▒▓██████▓▒░░▒▓████████▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░     ░▒▓█▓▒░             ░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░     ░▒▓█▓▒░             ░▒▓█▓▒░░▒▓█▓▒░    ░▒▓██▓▒░  
                                 ░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓██████▓▒░       ░▒▓████████▓▒░  ░▒▓██▓▒░    
                                 ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░     ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░░▒▓██▓▒░      
                                 ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░     ░▒▓█▓▒░▒▓██▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
                                 ░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓███████▓▒░▒▓███████▓▒░░▒▓██▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ 
            ");
        }

        //2
        public static void admin_desing()
        {
            Console.WriteLine(@$" 
                                  ░▒▓██████▓▒░░▒▓███████▓▒░░▒▓██████████████▓▒░░▒▓█▓▒░▒▓███████▓▒░  
                                 ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
            ");
        }

        //3
        public static void worker_desing()
        {
            Console.WriteLine(@$" 
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓███████▓▒░  
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓███████▓▒░░▒▓██████▓▒░ ░▒▓███████▓▒░  
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ 
                                  ░▒▓█████████████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░                                                              
            ");
        }

        //4
        public static void employer_desing()
        {
            Console.WriteLine(@$" 
                                 ░▒▓████████▓▒░▒▓██████████████▓▒░░▒▓███████▓▒░░▒▓█▓▒░      ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓███████▓▒░  
                                 ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓██████▓▒░ ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓██████▓▒░ ░▒▓███████▓▒░  
                                 ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░   ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░   ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓████████▓▒░▒▓██████▓▒░   ░▒▓█▓▒░   ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░                                                       
            ");
        }

        //5
        public static void sign_in_desing()
        {
            Console.WriteLine(@$" 
                                 ░▒▓███████▓▒░▒▓█▓▒░░▒▓██████▓▒░░▒▓███████▓▒░       ░▒▓█▓▒░▒▓███████▓▒░  
                                ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓██████▓▒░░▒▓█▓▒░▒▓█▓▒▒▓███▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                       ░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                       ░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                ░▒▓███████▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                                                                                                             
            ");
        }

        //6
        public static void sign_up_desing()
        {
            Console.WriteLine(@$" 
                                 ░▒▓███████▓▒░▒▓█▓▒░░▒▓██████▓▒░░▒▓███████▓▒░       ░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░  
                                ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓██████▓▒░░▒▓█▓▒░▒▓█▓▒▒▓███▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░  
                                       ░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
                                       ░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
                                ░▒▓███████▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░       ░▒▓██████▓▒░░▒▓█▓▒░                                                                                                                                 
            ");
        }

        //7
        public static void about_desing()
        {
            Console.WriteLine(@$" 
                                 ░▒▓██████▓▒░░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ 
                                ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     
                                ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     
                                ░▒▓████████▓▒░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     
                                ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     
                                ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     
                                ░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░ ░▒▓██████▓▒░   ░▒▓█▓▒░                                                                                                                                                                             
            ");
        }

        //8
        public static void exit_desing()
        {
            Console.WriteLine(@$" 
                                 ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░▒▓████████▓▒░ 
                                 ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░  ░▒▓█▓▒░     
                                 ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░  ░▒▓█▓▒░     
                                 ░▒▓██████▓▒░  ░▒▓██████▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     
                                 ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░  ░▒▓█▓▒░     
                                 ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░  ░▒▓█▓▒░     
                                 ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░  ░▒▓█▓▒░                                                                                                                                                                            
            ");
        }

        //9
        public static void start_desing()
        {
            Console.WriteLine(@$" 
                                 ░▒▓███████▓▒░▒▓████████▓▒░▒▓██████▓▒░░▒▓███████▓▒░▒▓████████▓▒░ 
                                ░▒▓█▓▒░         ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░     
                                ░▒▓█▓▒░         ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░     
                                 ░▒▓██████▓▒░   ░▒▓█▓▒░  ░▒▓████████▓▒░▒▓███████▓▒░  ░▒▓█▓▒░     
                                       ░▒▓█▓▒░  ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░     
                                       ░▒▓█▓▒░  ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░     
                                ░▒▓███████▓▒░   ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░                                                                                                                                                                             
            ");
        }

        //10
        public static void settings_desing()
        {
            Console.WriteLine(@$" 
                                  ░▒▓███████▓▒░▒▓████████▓▒░▒▓████████▓▒░▒▓████████▓▒░▒▓█▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░ ░▒▓███████▓▒░ 
                                 ░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░      ░▒▓█▓▒░   ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
                                 ░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░      ░▒▓█▓▒░   ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░        
                                  ░▒▓██████▓▒░░▒▓██████▓▒░    ░▒▓█▓▒░      ░▒▓█▓▒░   ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒▒▓███▓▒░░▒▓██████▓▒░  
                                        ░▒▓█▓▒░▒▓█▓▒░         ░▒▓█▓▒░      ░▒▓█▓▒░   ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░ 
                                        ░▒▓█▓▒░▒▓█▓▒░         ░▒▓█▓▒░      ░▒▓█▓▒░   ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░ 
                                 ░▒▓███████▓▒░░▒▓████████▓▒░  ░▒▓█▓▒░      ░▒▓█▓▒░   ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓███████▓▒░                                                                                                                                                                             
            ");
        }

        //11
        public static void wrong_desing()
        {
            Console.WriteLine(@$" 
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓███████▓▒░ ░▒▓██████▓▒░  
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒▒▓███▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                 ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
                                  ░▒▓█████████████▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░  
                                                                                                                                                                                                                                                
            ");
        }


    }

    public class Options_Class
    {
        public static string[] first_menu_options = new string[]
        {
            "Start",
            "About",
            "Settings",
            "Exit"
        };
        public static int first_menu_options_count = 4;


    }

    public class About_class
    {
        public static string about = @$"Layihə haqqında:

Boss.Az - əmək bazarının bütün iştirakçılarının faydalana biləcəyi, dəqiq və sürətli iş və ya işçi axtarışı üçün nəzərdə tutulmuş onlayn platformadır. Layihə istifadəçilərə geniş iş elanı və CV bazasından rahat istifadə imkanı yaradır.

Layihə fəaliyyətinə 2008-ci ildə başlayıb və hal-hazırda Azərbaycanın əmək bazarında aparıcı onlayn resuslarından biridir.

Boss.Az - işədüzəltmə şirkəti deyil. Layihənin məqsədi işə götürən ilə potensial işçi arasında vasitəçisiz və operativ əlaqə imkanı yaratmaqdır.

Elanların yerləşdirilməsi:

Boss.Az - istifadəçilərə sayta iş elanı və CV yerləşdirmək imkanı yaradır. Hər istifadəçi ay ərzində ödənişsiz olaraq bir iş elanı və bir CV yerləşdirə bilər.

Bizimlə əlaqə:

Biz layihənin inkişafı və təkmilləşdirilməsi üçün əlimizdən gələni edirik və sizin bu haqda olan fikirlərinizi və təkliflərinizi dinləməyə hazırıq. Bizimlə əlaqə yaratmaq üçün boss@boss.az e-mail ünvanına yaza və ya (012) 505-08-10 telefon nömrəsinə zəng edə bilərsiniz.";

        public static void Show_about()
        {
            Console.Clear();
            string remember_color = All_settings.foreground_Color;
            All_settings.select_desing_color(All_settings.desing_Color);
            Desings_Class.about_desing();
            All_settings.select_color_foreground(remember_color);
            foreach (var item in about)
            {
                Console.Write(item);
                Thread.Sleep(20);
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    Console.Clear();
                    string remember_color2 = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desings_Class.about_desing();
                    All_settings.select_color_foreground(remember_color2);
                    Console.WriteLine(about);
                    break;
                }
            }
        }
    }

    public class Settings_class
    {
        public static string[] colors = new string[]
        {
            "Black",
            "White",
            "Red",
            "Gray",
            "Yellow",
            "Green",
            "Blue"
        };
        public static string[] settings_options = new string[]
        {
            "Foreground color",
            "Background color",
            "Selected color",
            "Desing color",
            "Back"
        };
        public static void Show_Settings()
        {
            int selected_option = 0;
            while (true)
            {
                Console.Clear();

                string remember_color2 = All_settings.foreground_Color;
                All_settings.select_desing_color(All_settings.desing_Color);
                Desings_Class.settings_desing();
                All_settings.select_color_foreground(remember_color2);


                for (int i = 0; i < settings_options.Length; i++)
                {

                    if (selected_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                    {
                        string remember_color = All_settings.foreground_Color;
                        All_settings.select_option(All_settings.selected_option_Color);
                        Console.WriteLine("\t\t\t\t\t\t\t" + settings_options[i]);
                        All_settings.select_color_foreground(remember_color);
                    }
                    else//diger bendlerin ekrana cixarilmasi
                    {
                        All_settings.select_color_foreground(All_settings.foreground_Color);
                        Console.WriteLine("\t\t\t\t\t\t\t" + settings_options[i]);
                    }
                    All_settings.select_color_foreground(All_settings.foreground_Color);

                }

                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.DownArrow)//istifadecinin daxil etdiyi deyisenin asaqqi oldugunu yoxlayir
                {
                    if (selected_option < settings_options.Length - 1)
                    {
                        selected_option++;
                    }
                    else
                    {
                        selected_option = 0;
                    }
                }
                else if (input.Key == ConsoleKey.UpArrow)//istifadecinin daxil etdiyi deyisenin yuxari oldugunu yoxlayir
                {
                    if (selected_option > 0)
                    {
                        selected_option--;
                    }
                    else
                    {
                        selected_option = settings_options.Length - 1;
                    }
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }

            //settings options

            if (selected_option == 0)//foreground
            {
                while (true)
                {
                    Console.Clear();
                    string remember_color = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desings_Class.settings_desing();
                    All_settings.select_color_foreground(remember_color);
                    All_settings.select_color_foreground(All_settings.foreground_Color);
                    for (int i = 0; i < settings_options.Length; i++)
                    {
                        if (selected_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                        {
                            string remember_color2 = All_settings.foreground_Color;
                            All_settings.select_option(All_settings.selected_option_Color);
                            All_settings.select_color_foreground(remember_color2);
                            Console.Write("\t\t\t\t\t\t\t" + settings_options[i] + "   |  <  ");
                            Console.Write(All_settings.foreground_Color + "  >\n");

                        }
                        else//diger bendlerin ekrana cixarilmasi
                        {
                            string remember_color2 = All_settings.foreground_Color;
                            All_settings.select_color_foreground(All_settings.foreground_Color);
                            Console.WriteLine("\t\t\t\t\t\t\t" + settings_options[i]);
                            All_settings.select_color_foreground(remember_color2);
                        }
                        All_settings.select_color_foreground(All_settings.foreground_Color);
                    }

                    ConsoleKeyInfo input2;
                    input2 = Console.ReadKey(true);
                    if (input2.Key == ConsoleKey.LeftArrow)//sola
                    {
                        if (All_settings.foreground_Color_number < colors.Length - 1)
                        {
                            All_settings.foreground_Color_number++;
                            All_settings.select_color_foreground(colors[All_settings.foreground_Color_number]);
                        }
                        else
                        {
                            All_settings.foreground_Color_number = 0;
                            All_settings.select_color_foreground(colors[All_settings.foreground_Color_number]);
                        }
                        All_settings.select_color_foreground(colors[All_settings.foreground_Color_number]);
                    }
                    else if (input2.Key == ConsoleKey.RightArrow)//saga
                    {
                        if (All_settings.foreground_Color_number > 0)
                        {
                            All_settings.foreground_Color_number--;
                            All_settings.select_color_foreground(colors[All_settings.foreground_Color_number]);
                        }
                        else
                        {
                            All_settings.foreground_Color_number = colors.Length - 1;
                            All_settings.select_color_foreground(colors[All_settings.foreground_Color_number]);
                        }
                        All_settings.select_color_foreground(colors[All_settings.foreground_Color_number]);
                    }
                    else if (input2.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            else if (selected_option == 1)//background
            {
                while (true)
                {
                    Console.Clear();
                    string remember_color = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desings_Class.settings_desing();
                    All_settings.select_color_foreground(remember_color);
                    All_settings.select_color_background(All_settings.background_Color);
                    for (int i = 0; i < settings_options.Length; i++)
                    {
                        if (selected_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                        {
                            string remember_color2 = All_settings.foreground_Color;
                            All_settings.select_option(All_settings.selected_option_Color);
                            Console.Write("\t\t\t\t\t\t\t" + settings_options[i] + "   |  <  ");
                            Console.Write(All_settings.background_Color + "  >\n");
                            All_settings.select_color_foreground(remember_color2);

                        }
                        else//diger bendlerin ekrana cixarilmasi
                        {
                            string remember_color2 = All_settings.foreground_Color;
                            All_settings.select_color_background(All_settings.background_Color);
                            Console.WriteLine("\t\t\t\t\t\t\t" + settings_options[i]);
                            All_settings.select_color_foreground(remember_color2);
                        }
                        All_settings.select_color_background(All_settings.background_Color);
                    }

                    ConsoleKeyInfo input2;
                    input2 = Console.ReadKey(true);
                    if (input2.Key == ConsoleKey.LeftArrow)//sola
                    {
                        if (All_settings.background_Color_number > 0)
                        {
                            All_settings.background_Color_number--;
                        }
                        else
                        {
                            All_settings.background_Color_number = colors.Length - 1;
                        }
                        All_settings.select_color_background(colors[All_settings.background_Color_number]);
                    }
                    else if (input2.Key == ConsoleKey.RightArrow)//saga
                    {
                        if (All_settings.background_Color_number < colors.Length - 1)
                        {
                            All_settings.background_Color_number++;
                        }
                        else
                        {
                            All_settings.background_Color_number = 0;
                        }
                        All_settings.select_color_background(colors[All_settings.background_Color_number]);
                    }
                    else if (input2.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            else if (selected_option == 2)//selected
            {
                while (true)
                {
                    Console.Clear();
                    string remember_color = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desings_Class.settings_desing();
                    All_settings.select_color_foreground(remember_color);
                    All_settings.select_color_foreground(All_settings.foreground_Color);
                    for (int i = 0; i < settings_options.Length; i++)
                    {
                        if (selected_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                        {
                            string remember_color2 = All_settings.foreground_Color;
                            All_settings.select_option(All_settings.selected_option_Color);
                            Console.Write("\t\t\t\t\t\t\t" + settings_options[i] + "   |  <  ");
                            Console.Write(All_settings.selected_option_Color + "  >\n");
                            All_settings.select_color_foreground(remember_color2);

                        }
                        else//diger bendlerin ekrana cixarilmasi
                        {
                            string remember_color2 = All_settings.foreground_Color;
                            All_settings.select_option(All_settings.selected_option_Color);
                            All_settings.select_color_foreground(remember_color2);
                            Console.WriteLine("\t\t\t\t\t\t\t" + settings_options[i]);
                        }
                        All_settings.select_color_foreground(All_settings.foreground_Color);
                    }

                    ConsoleKeyInfo input2;
                    input2 = Console.ReadKey(true);
                    if (input2.Key == ConsoleKey.LeftArrow)//sola
                    {
                        if (All_settings.selected_option_Color_number < colors.Length - 1)
                        {
                            All_settings.selected_option_Color_number++;
                            All_settings.select_option(colors[All_settings.selected_option_Color_number]);
                        }
                        else
                        {
                            All_settings.selected_option_Color_number = 0;
                            All_settings.select_option(colors[All_settings.selected_option_Color_number]);
                        }
                        All_settings.select_color_foreground(colors[All_settings.foreground_Color_number]);
                    }
                    else if (input2.Key == ConsoleKey.RightArrow)//saga
                    {
                        if (All_settings.selected_option_Color_number > 0)
                        {
                            All_settings.selected_option_Color_number--;
                            All_settings.select_option(colors[All_settings.selected_option_Color_number]);
                        }
                        else
                        {
                            All_settings.selected_option_Color_number = colors.Length - 1;
                            All_settings.select_option(colors[All_settings.selected_option_Color_number]);
                        }
                        All_settings.select_color_foreground(colors[All_settings.foreground_Color_number]);
                    }
                    else if (input2.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            else if (selected_option == 3) //desing color
            {
                while (true)
                {
                    Console.Clear();
                    string remember_color = All_settings.foreground_Color;
                    All_settings.select_desing_color(All_settings.desing_Color);
                    Desings_Class.settings_desing();
                    All_settings.select_color_foreground(remember_color);
                    All_settings.select_color_foreground(All_settings.foreground_Color);
                    for (int i = 0; i < settings_options.Length; i++)
                    {
                        if (selected_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                        {
                            string remember_color2 = All_settings.foreground_Color;
                            All_settings.select_desing_color(All_settings.desing_Color);
                            All_settings.select_color_foreground(remember_color2);
                            Console.Write("\t\t\t\t\t\t\t" + settings_options[i] + "   |  <  ");
                            Console.Write(All_settings.desing_Color + "  >\n");

                        }
                        else//diger bendlerin ekrana cixarilmasi
                        {
                            string remember_color2 = All_settings.foreground_Color;
                            All_settings.select_desing_color(All_settings.desing_Color);
                            All_settings.select_color_foreground(remember_color2);
                            Console.WriteLine("\t\t\t\t\t\t\t" + settings_options[i]);
                        }
                        All_settings.select_color_foreground(All_settings.foreground_Color);
                    }

                    ConsoleKeyInfo input2;
                    input2 = Console.ReadKey(true);
                    if (input2.Key == ConsoleKey.LeftArrow)//sola
                    {
                        if (All_settings.desing_Color_number < colors.Length - 1)
                        {
                            All_settings.desing_Color_number++;
                            All_settings.select_desing_color(colors[All_settings.desing_Color_number]);
                        }
                        else
                        {
                            All_settings.desing_Color_number = 0;
                            All_settings.select_desing_color(colors[All_settings.desing_Color_number]);
                        }
                        All_settings.select_color_foreground(colors[All_settings.foreground_Color_number]);
                    }
                    else if (input2.Key == ConsoleKey.RightArrow)//saga
                    {
                        if (All_settings.desing_Color_number > 0)
                        {
                            All_settings.desing_Color_number--;
                            All_settings.select_desing_color(colors[All_settings.desing_Color_number]);
                        }
                        else
                        {
                            All_settings.desing_Color_number = colors.Length - 1;
                            All_settings.select_desing_color(colors[All_settings.desing_Color_number]);
                        }
                        All_settings.select_color_foreground(colors[All_settings.foreground_Color_number]);
                    }
                    else if (input2.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            else
            {
                //back
            }


        }
    }

    public class Start_class
    {
        public static string[] start_page_options = {
        "Admin",
        "Sign In",
        "Sign Up",
        "Back"
        };

        public static void Start_page()
        {
            while (true)
            {
            int index_of_option = 0;
            while (true)
            {
                Console.Clear();
                All_settings.select_desing_color(All_settings.desing_Color);
                Desings_Class.start_desing();
                All_settings.select_color_foreground(All_settings.foreground_Color);

                for (int i = 0; i < start_page_options.Length; i++)//secimler icinde dovr edir ve cesili olan secimin rengini deyisir.
                {
                    if (index_of_option == i)//secilmis bendin ekrana cixarilmasi ve reng verilmesi
                    {
                        string remember_color = All_settings.foreground_Color;
                        All_settings.select_option(All_settings.selected_option_Color);
                        Console.WriteLine("\t\t\t\t\t\t\t" + start_page_options[i]);
                        All_settings.select_color_foreground(remember_color);
                    }
                    else//diger bendlerin ekrana cixarilmasi
                    {
                        All_settings.select_color_foreground(All_settings.foreground_Color);
                        Console.WriteLine("\t\t\t\t\t\t\t" + start_page_options[i]);
                    }
                    All_settings.select_color_foreground(All_settings.foreground_Color);
                }
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.DownArrow)//istifadecinin daxil etdiyi deyisenin asaqqi oldugunu yoxlayir
                {
                    if (index_of_option < start_page_options.Length - 1)
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
                        index_of_option = start_page_options.Length - 1;
                    }
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }//while

                if (index_of_option == 0)
                {
                    Admin_page.check_admin();
                    
                }
                else if (index_of_option == 1)
                {
                    User.User.Sign_in();
                }
                else if (index_of_option == 2)
                {
                    User.User.Sign_up();
                }
                else if (index_of_option == 3)
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
