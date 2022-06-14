using System;

namespace Badetidssystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            kreds kred = new kreds("uni", "unity", "maglegårdsvej 2", 4);
            Console.WriteLine(kred);

            BadeTidsPeriode badeTidsPeriode = new BadeTidsPeriode("Morgendukkert ", "Aftensvaler");
            Console.WriteLine(kred);

        }
        
            
    }

}
