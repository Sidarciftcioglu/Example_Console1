using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console1
{
     class identity
    {
        string name;
        string lastName;
        string city;
        int age;
        char gender;

        public string NAME
        {
            get { return name; }
            set { name = value.ToLower(); }
        }
        public string LASTNAME
        {
            get { return lastName; }
            set { lastName = value.ToUpper(); }
        }
        public string CİTY
        {
            get { return city; }
            set { city = value.ToUpper(); }
        }
        public char GENDER
        {
            get { return gender; }
            set { gender = value; }
        }
        public int AGE
        {
            get { return age; }
            set { age = Math.Abs( value); }
        }

        public identity()
        {
            name = "  ";
            lastName = " ";
            age = 20;
            gender = 'W';
            city = "Mardin";
        }
    }
   
}
