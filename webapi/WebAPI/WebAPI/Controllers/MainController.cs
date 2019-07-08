using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class MainController : ApiController
    {

        int[] unsortedList = { 0, 10, 16, 21, 33, 50, 45, 23, 80 };

         public HttpWebResponse OrderList()
        {
            Array.Sort(unsortedList);

            HttpWebResponse response = new HttpWebResponse();

            response.Content = new StringContent(unsortedList.ToString);

        }

        public HttpWebResponse OddsOrEvens(int number)
        {
            HttpWebResponse response = new HttpWebResponse();

            if(number%2 == 0)
            {
                response.Content = new StringContent("The number is Even!");
            }
            else
            {
                response.Content = new StringContent("The number is Odd!");
            }


        }



    
       



  


    }
}
