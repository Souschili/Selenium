using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Form;

internal class Program
{
    private static readonly int holdTime = 500;
    private readonly static string baseUrl = "https://demoqa.com/text-box";
    static async Task Main(string[] args)
    {
        using var driver = new ChromeDriver();
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));

        // open webpage
        await driver.Navigate().GoToUrlAsync(baseUrl);

        // here we start fill form and waith when eelement rendering
        var userName = wait.Until(x => x.FindElement(By.Id("userName")));
        var userEmail = wait.Until(x => x.FindElement(By.Id("userEmail")));
        var currentAddress = wait.Until(x => x.FindElement(By.Id("currentAddress")));
        var permanentAddress = wait.Until(x => x.FindElement(By.Id("permanentAddress")));
        var send = wait.Until(x => x.FindElement(By.Id("submit")));
        await ManualInputImitator(userName, "Orkhanius the stupid developer");
        await Task.Delay(holdTime);
        await ManualInputImitator(userEmail, "Developers email fuck you ");
        await Task.Delay(holdTime);
        await ManualInputImitator(currentAddress, "My current address ");
        await Task.Delay(holdTime);
        await ManualInputImitator(permanentAddress, "My pertmanent address ");
        await Task.Delay(holdTime);
        send.Submit();

        driver.Quit();// or use Click()
    }

    // method  for manual imitation
    private static async Task ManualInputImitator(IWebElement? elem, string message)
    {
        if (elem is null)
            throw new ArgumentNullException(nameof(elem), "Element cannot be null");
        if (string.IsNullOrWhiteSpace(message))
            throw new ArgumentNullException(nameof(message), "Message cannot be empty");

        foreach (var ch in message)
        {
            elem.SendKeys(ch.ToString());
            await Task.Delay(Random.Shared.Next(40, 150)); 
        }
    }

}




