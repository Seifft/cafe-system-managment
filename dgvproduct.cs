using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_system_managment
{

    public class dgvproduct : product2
    {
        
       
        public decimal total { get; private set; }

        public dgvproduct(string product, decimal price, int quantity, decimal total) : base(product, price, quantity)
        {
            
            this.total = total;
        }
       
    }
}
