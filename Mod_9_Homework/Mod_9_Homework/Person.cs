using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    abstract class Person
    {
        public string FirstName, LastName, Birthdate, AddressLine1, AddressLine2, City, StateOrProvince, ZipOrPostal, Country;

        public Person()
        {
            Myconstruct();
        }

        //record how many person class declared
        public static class TrackPerson
        {
            public static int person_num = 0;
        }

        //number of person classes increase
        public virtual void Myconstruct()
        {
            Person.TrackPerson.person_num++;
        }

    }
}
