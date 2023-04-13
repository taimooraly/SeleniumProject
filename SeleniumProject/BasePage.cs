using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace POM
{
    public class BasePage : ExtentReport 
    {
        public static IWebDriver driver;


        public static void Initialization(String browser)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        public static void SeliniumClose()
        {
            driver.Close();
        }

        public void OpenUrl(string url)
        {
            driver.Url = url;

        }
        public void Write(By by, string text)
        {
            try
            {
                driver.FindElement(by).SendKeys(text);
                TakeScreenshot(Status.Pass, "Enter ");
            }

            catch (Exception ex)
            {
                TakeScreenshot(Status.Fail, "Enter Failed" + ex);
            }
           
        }
        public void Click(By by)
        {
            try
            {
              driver.FindElement(by).Click();
              TakeScreenshot(Status.Pass, "Click ");
            }
            catch (Exception ex)
            {
                TakeScreenshot(Status.Fail, "Click Failed " + ex);
            }


        }
        public static void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }

    }
}