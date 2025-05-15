using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_system_managment
{
    public class datadgvproduct : product2
    {
        public decimal subtotal { get; private set; }
        public datadgvproduct(string Name, decimal Price, int Quantity,decimal Subtotal) : base(Name, Price, Quantity)
        {
            subtotal = Subtotal;
        }

    }
}
