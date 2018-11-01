using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace Test
{
    public enum BrowserType
    {
        IE,
        Chrome,
        Firefox
    };

    class Scenario1
    {
        IWebDriver driver;
        public Scenario1(BrowserType bType)
        {

            if(bType == BrowserType.Chrome)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--disable-cache");
                driver = new ChromeDriver(options);
            }
            

        }

        
        public void setup(string URL)
        {
            //clear all the cookies
            driver.Manage().Cookies.DeleteAllCookies();

            //goto the url
            driver.Navigate().GoToUrl(URL);
        }


        public List<string> getAllNews()
        {
            List<String> News = new List<string>();

            //get the news one by one
            IList<IWebElement> nElements = driver.FindElements(By.XPath("//article//a/span"));

            //get the text and store it
            foreach(IWebElement element in nElements)
            {
                //Console.WriteLine(element.Text);
                News.Add(element.Text);
            }

            return News;
        }

        public List<string> getAllLiveSports()
        {
            List<String> liveSports = new List<string>();

            //get the live sports one by one
            IList<IWebElement> nElements = driver.FindElements(By.XPath("//div[@class='categoryBadge']/parent::div[@class='categoryListItemWrapper']/span"));

            //get the text and store it
            foreach (IWebElement element in nElements)
            {
                //Console.WriteLine(element.Text);
                liveSports.Add(element.Text);
            }

            return liveSports;
        }

        public void teardown()
        {
            //quit the driver
            driver.Quit();
        }

    }

}
