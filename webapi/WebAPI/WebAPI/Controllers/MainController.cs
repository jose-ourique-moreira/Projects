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

        
        public string HelloWorld()
        {

            return "Hello World";
        }


        }
}
