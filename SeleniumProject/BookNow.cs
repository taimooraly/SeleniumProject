
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM;
using System;
using System.Threading;

namespace POM
{
    public class BookingPage : BasePage
    {
        #region BookHotelPage Locators

        By fnameTxt = By.Id("first_name");
        By lnameTxt = By.Id("last_name");
        By addressTxt = By.Id("address");
        By cCNoTxt = By.Id("cc_num");
        By cCTypeDropDown = By.Id("cc_type");
        By expiryDateDropDown = By.Id("cc_exp_month");
        By expiryYearDropDown = By.Id("cc_exp_year");
        By cVVNoTxt = By.Id("cc_cvv");
        By bookNowBtn = By.Id("book_now");
        By cancelBtn = By.Id("cancel");

        By orderNoTxt = By.Id("order_no");
        #endregion BookHotelPage Locators


        public void BookHotel(string fname, string lname, string address,string cCNo, string cCType , string expiryDate,  string expiryYear , string cVVNo)
        {
           

            Write(fnameTxt,fname);
            Write(lnameTxt, lname);
            Write(addressTxt, address);
            Write(cCNoTxt, cCNo);
            Write(cCTypeDropDown, cCType);
            Write(expiryDateDropDown, expiryDate);
            Write(expiryYearDropDown, expiryYear);
            Write(cVVNoTxt, cVVNo);
            Click(bookNowBtn);
            Thread.Sleep(500);
        }
    }
}