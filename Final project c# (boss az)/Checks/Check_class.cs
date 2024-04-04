using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Final_project_c___boss_az_.User;

namespace Final_project_c___boss_az_.Checks
{
    internal class Check_class
    {

        public static bool check_name(string name)
        {
            if (name.Length >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool check_age(string age)
        {
            if (age.Length <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool check_email(string email)
        {
            if (email.Length > 10)
            {

                if (email[email.Length - 1] == 'm' && email[email.Length - 2] == 'o' && email[email.Length - 3] == 'c'
                    && email[email.Length - 4] == '.' && email[email.Length - 5] == 'l' && email[email.Length - 6] == 'i'
                    && email[email.Length - 7] == 'a' && email[email.Length - 8] == 'm' && email[email.Length - 9] == 'g'
                    && email[email.Length - 10] == '@')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool check_number(string number)
        {
            if (number.Length == 10)
            {

                if ((number[0] == '0' && number[1] == '5' && number[2] == '0') || (number[0] == '0' && number[1] == '5' && number[2] == '1') ||
                    (number[0] == '0' && number[1] == '7' && number[2] == '0') || (number[0] == '0' && number[1] == '7' && number[2] == '7') ||
                    (number[0] == '0' && number[1] == '5' && number[2] == '5') || (number[0] == '0' && number[1] == '9' && number[2] == '9'))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void SendEmail(string to)
        {
            while (true)
            {
                //Console.Clear();
                var client = new SmtpClient("smtp.gmail.com", 587);

                client.EnableSsl = true;

                client.Credentials = new NetworkCredential(
                    "denemeeeer10@gmail.com", "bwcg sopr cxht nlrn");
                Random rand = new Random();
                int verificationCode = rand.Next(10000, 99999);

                string htmlMessage = $@"
            <!DOCTYPE html>
            <html lang=""en"">
            <head>
                <meta charset=""UTF-8"">
                <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                <title>Email Message</title>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        margin: 0;
                        padding: 0;
                    }}
                    .container {{
                        width: 80%;
                        margin: 20px auto;
                        background-color: #fff;
                        padding: 20px;
                        border-radius: 8px;
                        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
                    }}
                    h1 {{
                        color: #333;
                        text-align: center;
                    }}
                    p {{
                        color: #666;
                        line-height: 1.6;
                    }}
                    .code {{
                        font-weight: bold;
                        color: #007bff;
                        font-size: 24px;
                    }}
                </style>
            </head>
            <body>
                <div class=""container"">
                    <h1>Sizin Testiq Kodunuz</h1>
                    <p>
                        Sizin testiq lenme kodunuz aşağıdaki gibidir:
                    </p>
                    <p class=""code"">{verificationCode}</p>
                </div>
            </body>
            </html>
            ";

                var message = new MailMessage()
                {
                    Subject = "BOSS.AZ Tesdiq Kodu",
                    Body = htmlMessage,
                    IsBodyHtml = true
                };
                if (check_email(to))
                {

                    message.From = new MailAddress("denemeeeer10@gmail.com", "Boss.az");
                    message.To.Add(new MailAddress(to));

                    client.Send(message);

                    Console.WriteLine("Size testiq kodu gönderdik.");
                    Console.Write("Testiq kodunu girin: ");
                    int code = int.Parse(Console.ReadLine());

                    if (code == verificationCode)
                    {
                        Console.WriteLine("Testiq kodu doğru.");
                        break;
                    }
                    else
                    {
                        User.User.check_email = false;
                        break;
                    }
                }
                else
                {
                    User.User.check_email = false;
                    break;
                }
            }
        }

    }
}
