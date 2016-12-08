using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace WordpressAuto
{
    public class Class1
    {
        public void go()
        {
            //System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "@C:\\Projects\\WordpressAuto\\WordpressAuto\\bin\\geckodriver.exe");
            //IWebDriver driver = new FirefoxDriver();
            //driver.Navigate().GoToUrl("http://google.com");

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\\Projects\\WordpressAuto\\WordpressAuto\\bin", "geckodriver.exe");
            service.Port = 64444;
            service.FirefoxBinaryPath = @"C:\\Program Files\Mozilla Firefox\\firefox.exe";
            var driver = new FirefoxDriver(service);
            var baseURL = "http://localhost:49539";
            var verificationErrors = new StringBuilder();
            driver.Navigate().GoToUrl("http://www.google.com");
        }
    }
}
