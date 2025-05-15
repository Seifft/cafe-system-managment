using cafe_system_managment;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cafe_system_managment
{
    public class find
    {

        public static void selectedrow(DataGridView dgvfare, TextBox txtname, TextBox txtprice, TextBox txtquantity)

        {
            



            {
                if (dgvfare.CurrentRow == null)
                {
                    return;
                }
                string name = dgvfare.CurrentRow.Cells[0].Value.ToString();
                decimal price = decimal.Parse(dgvfare.CurrentRow.Cells[1].Value.ToString());
                int quantity = int.Parse(dgvfare.CurrentRow.Cells[2].Value.ToString());



                product2 newitem = new product2(name, price, quantity);
                txtname.Text = newitem.name;
                txtprice.Text = newitem.price.ToString();
                txtquantity.Text = newitem.quantity.ToString();

                
            }
            txtname.Focus();
            txtname.Select(txtname.Text.Length, 0);


        }


        }
    
}

