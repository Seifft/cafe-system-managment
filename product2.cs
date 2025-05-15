using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_system_managment
{
    public class product2 
    {

        public int quantity { get; private set; }
        public string name { get; private set; }
        public decimal price { get; private set; }

        



        public product2(string Name, decimal Price, int Quantity) 
        {
            name = Name;
            price = Price;
            quantity = Quantity;
        }

        public override string ToString()
        {
            return name;
        }
       /* public override string ToString()
        {
            return $"{name};{price};{quantity}";
        }*/

    }
}
