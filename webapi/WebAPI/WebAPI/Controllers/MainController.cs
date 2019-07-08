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
        public void OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even number!");
            }
            else
            {
                Console.WriteLine("Odd Number!");
            }

        }

    
        public int[] OrderList(int[] list)
        {
            Array.Sort(list);

            return list;
        }



  


    }
}
