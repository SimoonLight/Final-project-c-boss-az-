using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_project_c___boss_az_.File_;

namespace Final_project_c___boss_az_.Classes
{
    public class Work
    {
        public string name { get; set; }
        public string description { get; set;}
        public string salary {  get; set; }
        public string about { get; set;}
        public Work()
        {
            this.name=string.Empty;
            this.description=string.Empty;
            this.salary=string.Empty;
            this.about=string.Empty;
        }
        public Work(string _name,string _description,string _salary,string _about)
        {
            this.name=_name;
            this.description=_description;
            this.salary=_salary;
            this.about=_about;
        }
        public void Show_Work()
        {
            Console.WriteLine($" Name : {this.name}");
            Console.WriteLine($" About : {this.name}");
            Console.WriteLine($" Description : {this.name}");
            Console.WriteLine($" Salary : {this.name}");
        }
    }

    public class Worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
        public string email { get; set; }
        public string number { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Work[] works { get; set; }

        public Worker()
        {
            this.name= string.Empty;
            this.surname= string.Empty;
            this.age= string.Empty;
            this.email= string.Empty;
            this.number= string.Empty;
            this.username= string.Empty;
            this.password= string.Empty;
            this.works=new Work[0];
        }

        public Worker(string _name,string _surname,string _age,string _email,string _number,string _username,string _password)
        {
            this.name = _name;
            this.surname =_surname;
            this.age = _age;
            this.email = _email;
            this.number = _number;
            this.username = _username;
            this.password = _password;
            this.works=new Work[0];
        }
        
        public void Add_work_to_worker(Work new_work)
        {
            Work[] new_works=new Work[works.Length+1];
            for (int i = 0; i < works.Length; i++)
            {
                new_works[i] = works[i];
            }
            new_works[works.Length] = new_work;
            this.works = new_works;
            File_.File_class.Write_worker();
        }

        public void delete_work_to_worker(Work new_work)
        {
            Work[] new_works = new Work[works.Length - 1];
            int index = 0;
            for (int i = 0; i < works.Length; i++)
            {
                if (works[i] != new_work)
                {

                new_works[index++] = works[i];
                }
            }
            this.works = new_works;
            File_.File_class.Write_worker();

        }

        public void Show_worker()
        {
            Console.WriteLine($" name : {this.name}");
            Console.WriteLine($" surname : {this.surname}");
            Console.WriteLine($" age : {this.age}");
            Console.WriteLine($" email : {this.email}");
            Console.WriteLine($" number : {this.number}");
            Console.WriteLine($" username : {this.username}");
            Console.WriteLine($" password : {this.password}");
            for (int i = 0; i < works.Length; i++)
            {
                works[i].Show_Work();
            }
        }
    }

    public class Employer
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
        public string email { get; set; }
        public string number { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Work[] works { get; set; }

        public Notfication[] notfications { get; set; }

        public Employer()
        {
            this.name = string.Empty;
            this.surname = string.Empty;
            this.age = string.Empty;
            this.email = string.Empty;
            this.number = string.Empty;
            this.username = string.Empty;
            this.password = string.Empty;
            this.works = new Work[0];
            this.notfications = new Notfication[0];
        }

        public Employer(string _name, string _surname, string _age, string _email, string _number, string _username, string _password)
        {
            this.name = _name;
            this.surname = _surname;
            this.age = _age;
            this.email = _email;
            this.number = _number;
            this.username = _username;
            this.password = _password;
            this.works = new Work[0];
            this.notfications = new Notfication[0];
        }

        public void Add_notfication_to_employer(Notfication notfication)
        {
            Notfication[] new_notfications = new Notfication[notfications.Length + 1];
            for (int i = 0; i < notfications.Length; i++)
            {
                new_notfications[i] = this.notfications[i];
            }
            new_notfications[notfications.Length] = notfication;
            this.notfications = new_notfications;
            File_.File_class.Write_Employer();
        }

        public void Add_work_to_employer(Work new_work)
        {
            Work[] new_works = new Work[works.Length + 1];
            for (int i = 0; i < works.Length; i++)
            {
                new_works[i] = this.works[i];
            }
            new_works[works.Length] = new_work;
            this.works = new_works;
            File_.File_class.Write_Employer();
       
        }

        public void delete_work_to_worker(Work new_work)
        {
            Work[] new_works = new Work[works.Length - 1];
            int index = 0;
            for (int i = 0; i < works.Length; i++)
            {
                if (works[i] != new_work)
                {

                    new_works[index++] = works[i];
                }
            }
            this.works = new_works;
            File_.File_class.Write_Employer();
        }

        public void Show_employer()
        {
            Console.WriteLine($" name : {this.name}");
            Console.WriteLine($" surname : {this.surname}");
            Console.WriteLine($" age : {this.age}");
            Console.WriteLine($" email : {this.email}");
            Console.WriteLine($" number : {this.number}");
            Console.WriteLine($" username : {this.username}");
            Console.WriteLine($" password : {this.password}");
            for (int i = 0; i < works.Length; i++)
            {
                works[i].Show_Work();
            }
        }

    }

    public class Notfication
    {
        public string message { get; set; }
        public Notfication()
        {
            this.message= string.Empty;
        }
        public Notfication(string _message)
        {
            this.message = _message;
        }  
    }


}


