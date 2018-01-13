using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CST356Lab1WebApplication.Models
{
    public class Person
    {
        string personName;
        string personGender;

        Person(string personName, string personGender)
        {
            this.personName = personName;
            this.personGender = personGender;
        }
    }
}