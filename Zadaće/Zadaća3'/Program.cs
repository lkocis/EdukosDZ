using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaća3_;

namespace Zadaća3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientCode.RunDemo1();
        }

        public static class ClientCode
        {
            public static void RunDemo1()
            {
                IMailConstructor mailConstructor = new MailConstructor();

                SMTP smtp = new SMTP(mailConstructor);

                smtp.SendNoReplyMail();

                Console.ReadKey();
            }

            public static void RunDemo2()
            {
                LoginPageFactory chromeFactory = new ChromeLoginPageFactory();
                ILoginPage login = chromeFactory.CreatePage();

                login.LoginButton().Click();

                Console.ReadKey();
            }
        }

    }
}
