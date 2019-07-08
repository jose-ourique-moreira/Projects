using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class TestController : ApiController
    {
        private string even = "Number is Even";
        private string odd = "Number is Odd";

        [HttpGet]
        public Action OddOrEven(int number)
        {
           
            if(number % 2 == 0)
            {

                return even;
            }
            else
            {
                return odd;
            }


        }
        
        
    }
}
