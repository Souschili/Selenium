using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium;

class Program
{
    static async Task Main()
    {
        #region Basic
        // using var driver=new ChromeDriver();
        // await driver.Navigate().GoToUrlAsync("https://demoqa.com/text-box");
        // Thread.Sleep(2000);

        // var userName=driver.FindElement(By.Id("userName"));
        // var userEmail = driver.FindElement(By.Id("userEmail"));
        // var userAddress = driver.FindElement(By.Id("currentAddress"));
        // var permanentAddress = driver.FindElement(By.Id("permanentAddress"));
        // userName.Click();
        // userName.SendKeys("Orkhan");
        // Thread.Sleep(1000);
        // userEmail.Click();
        // userEmail.SendKeys("demo@example.az");
        // Thread.Sleep(1000);
        // userAddress.Click();
        // userAddress.SendKeys("R.Rustamov 43 ap/ 82");
        // Thread.Sleep(1000);
        //// permanentAddress.Click();
        // permanentAddress.SendKeys("Azerbaijan Baku city");
        // Thread.Sleep(3000);
        // driver.Quit();
        #endregion

        #region Waith
        var driver=new ChromeDriver();
        var waith=new WebDriverWait(driver,TimeSpan.FromSeconds(5));
        await driver.Navigate().GoToUrlAsync("https://demoqa.com/text-box");
        await Task.Delay(1000);
        driver.Quit();
        #endregion
    }
}


