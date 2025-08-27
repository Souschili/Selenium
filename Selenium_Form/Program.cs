using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Form
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var baseUrl = "https://demoqa.com/text-box";
            var driver = new ChromeDriver();
            var wait = new WebDriverWait(driver,TimeSpan.FromSeconds(8));

            // open webpage
            await driver.Navigate().GoToUrlAsync(baseUrl);

            // here we start fill form and waith when eelement rendering
            var userName = wait.Until(x => x.FindElement(By.Id("userName")));
            userName.SendKeys("Орхан красавчик");
            
            driver.Close();
        }
    }
}
