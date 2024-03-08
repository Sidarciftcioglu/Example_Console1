using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console1
{
     class islem
    {
        /*
         public int sum(int n1,int n2)
        {
            int n3= n1 + n2;
            Console.WriteLine("Answer: " +n3);
            return n3;
        }

        public int cube(int n1)
        {
            int n2= n1 *n1*n1;
            Console.WriteLine("Answer: "+n2);
            return n2;
        }
        */

        public int addition(int n1,int n2)
        {
            int n3 = n1 + n2;
            Console.WriteLine("addition :" + n3);
            return n3;
        }
        public int subtraction(int n1, int n2)
        {
            int n3 = n1 - n2;
            Console.WriteLine("subtraction :" + n3);
            return n3;
        }
        public int multiplication(int n1, int n2)
        {
            int n3 = n1 * n2;
            Console.WriteLine("multiplication :" + n3);
            return n3;
        }
        public int division(int n1, int n2)
        {
            int n3 = n1 / n2;
            Console.WriteLine("division :" + n3);
            return n3;
        }
    }
}
