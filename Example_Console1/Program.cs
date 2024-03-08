using System;

namespace Example_Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             // Kullanıcıdan sayı girişi almak için
             Console.Write("Enter the first number: ");
             int num1 = Convert.ToInt32(Console.ReadLine());

             Console.Write("Enter the second number: ");
             int num2 = Convert.ToInt32(Console.ReadLine());

             // islem sınıfını oluştur
             islem isl = new islem();

             // İşlemleri gerçekleştir
             isl.addition(num1, num2);
             isl.subtraction(num1, num2);
             isl.multiplication(num1, num2);
             isl.division(num1, num2);

             Console.ReadLine();
            */

            identity id = new identity();
            id.NAME = "Sidar";
            id.LASTNAME = "Çiftçioğlu";
            Console.WriteLine(id.NAME) ;
            Console.WriteLine(id.LASTNAME);
            Console.WriteLine(id.CİTY);
            Console.WriteLine(id.GENDER);
            Console.WriteLine(id.AGE);
            
            Console.ReadLine();  
        }
    }

  
}

