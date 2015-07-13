using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    abstract class Person
    {
        public string FirstName, LastName, Birthdate, AddressLine1, AddressLine2, City, StateOrProvince, ZipOrPostal, Country;

        public Person()
        {
            Myconstruct();
        }

        public static class TrackPerson
        {
            public static int person_num = 0;
        }

        public virtual void Myconstruct()
        {
            Person.TrackPerson.person_num++;
        }

    }
}
