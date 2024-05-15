using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća3_
{
    //Zadatak 2.
    //Obrasci stvaranja - metoda tvornica
    public class WebElement
    {
        string name;
        public WebElement(string name)
        {
            Console.WriteLine($"Found {name}");
            this.name = name;
        }
        public void Click()
        {
            Console.WriteLine($"Clicked {name}");
        }
    }

    public interface ILoginPage
    {
        WebElement LoginButton();
        WebElement UsernameInput();
        WebElement PasswordInput();
    }

    public class ChromeLoginPage : ILoginPage
    {
        public WebElement LoginButton()
        {
            return new WebElement("LogIn");
        }

        public WebElement UsernameInput()
        {
            return new WebElement("Username: ");
        }
        public WebElement PasswordInput()
        {
            return new WebElement("Password: ");
        }
    }

    public abstract class LoginPageFactory
    {
        public abstract ILoginPage CreatePage();
    }

    public class ChromeLoginPageFactory : LoginPageFactory
    {
        public override ILoginPage CreatePage()
        {
            return new ChromeLoginPage();
        }
    }
}
