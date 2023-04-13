using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM;
using System;
using System.Threading;

namespace POM
{
    public class SelectPage : BasePage
    {

        #region SelectPage Locators

        By selectRadioBtn1 = By.Id("radiobutton_1");
        By selectRadioBtn2 = By.Id("radiobutton_2");
        By selectRadioBtn3 = By.Id("radiobutton_3");
        By selectRadioBtn4 = By.Id("radiobutton_4");
        By continueBtn = By.Id("continue");
        By cancelBtn = By.Id("cancel");


        #endregion SelectPage Locators   

        public void SelectHotel()
        {
            //ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Select Hotel");
           
            Click(selectRadioBtn2);
            Thread.Sleep(1000);       
            Click(continueBtn);
            Thread.Sleep(1000);
        }
    }
}
