using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.Debugger;
using System.Net.PeerToPeer;
using System.Threading;

namespace POM
{
    public class SearchPage : BasePage 
    {
        By locationDropDown = By.Id("location");
        By hotelDropDown = By.Id("hotels");
        By roomTypeDropDown = By.Id("room_type");
        By noOfRoomDropDown = By.Id("room_nos");
        By checkInDateTxt = By.Id("datepick_in");
        By checkOutDateTxt = By.Id("datepick_out");
        By adultPerRoomDropDown = By.Id("adult_room");
        By childrenPerRoomDropDown = By.Id("child_room");
        By searchBtn = By.Id("Submit");
        By resetBtn = By.Id("Reset");

        public void Search( string location, string hotelDD, string roomTypeDD, string noOfRoomDD, string checkin, string checkout, string adults, string childrens)
        {
            
        
            Write(locationDropDown, location);
            Write(hotelDropDown, hotelDD);
            Write(roomTypeDropDown, roomTypeDD);
            Write(noOfRoomDropDown, noOfRoomDD);
            Write(checkInDateTxt, checkin);
            Write(checkOutDateTxt, checkout);
            Write(adultPerRoomDropDown, adults);
            Write(childrenPerRoomDropDown, childrens);
            Click(searchBtn);
            Thread.Sleep(1000);
    }

        




    }
}