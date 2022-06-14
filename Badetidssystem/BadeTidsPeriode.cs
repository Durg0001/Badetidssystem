using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystem
{
    class BadeTidsPeriode
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }

        public BadeTidsPeriode(string name1, string name2)
        {
           
            Name1 = name1;
            Name2 = name2;            
        }
        
        public enum DayOfWeek
        {
            sunday= 0,
            Monday = 1,
            Tuesday = 2, 
            Wednesday= 3, 
            Thursday= 4, 
            Friday= 5, 
            Saturday= 6
        }
        
        //metode

        public override string ToString()
        {
            return $"Name1: {Name1}, Name2: {Name2}";
        }
    }
}
