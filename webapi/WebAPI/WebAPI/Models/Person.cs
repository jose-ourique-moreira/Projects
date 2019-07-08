using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Person
    {
        private String firstName;
        private String lastName;
        private int age;

        public string setFirstName(string firstName)
        {
            return this.firstName = firstName;
        }

        public string setLastName(string lastName)
        {
            return this.lastName = lastName;
        }

        public int setAge(int age)
        {
            return this.age = age;
        }


        private string getfirstName()
        {
            return firstName;
        }

        private string getLastName()
        {
            return lastName;
        }

        private int getAge()
        {
            return age;
        }


        public string PersonInfo() {

            return "O meu nome é " + getfirstName() + " " + getLastName() + "e tenho " + getAge() + " Anos.";

        }
    }
}