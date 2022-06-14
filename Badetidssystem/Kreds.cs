using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystem
{
    public class kreds

    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int NumOfPerson { get; set; }

        public kreds(string id, string name, string address, int numofperson)
        {
            Id = id;
            Name = name;
            Address = address;
            NumOfPerson = numofperson;
        }
             
        //metode
            public override string ToString()
            {
            return $"Id : {Id}, Name : {Name}, Address : {Address} - NumOfPerson : {NumOfPerson},";
            }
        
    }
        
}
