
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeBrowser();
        driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");
        IWebElement element = driver.FindElement(By.Name("myName"));
        if(element.Displayed)
        {
            System.Console.WriteLine("Yes!Find it");
        }
        else
        {
            System.Console.WriteLine("Sorry!Couln't find the element");
        }
        driver.Quit();


    }
}

