using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cafe_system_managment
{
    public class restockcs
    {
        public static void re(Label labnewstock, TextBox txtnewquantity)
        {

            if (labnewstock.Visible == false)
            {

                labnewstock.Visible = true;
                txtnewquantity.Visible = true;
                txtnewquantity.Enabled = true;

            }

            else
            {

                labnewstock.Visible = false;
                txtnewquantity.Visible = false;
                txtnewquantity.Enabled = false;


            }
            
        }
        public static void restockquantity(TextBox txtnewquantity, TextBox txtquantity,DataGridView dgvfare, TextBox txtname, TextBox txtprice,string searchname)
        {
            int fristquantity = int.Parse(txtquantity.Text);
            int secondquantity = int.Parse(txtnewquantity.Text);
            int addquantity = fristquantity + secondquantity;
            
            
            txtquantity.Clear();
            txtnewquantity.Clear();

            txtquantity.Text = addquantity.ToString();
             edit.EditLineInFile("data.txt", searchname, txtname.Text, txtprice.Text, txtquantity.Text,txtname);

            dgvfare.CurrentRow.Cells[2].Value = txtquantity.Text;
            delete.deletetalltextboxpagemanagment(txtname, txtprice, txtquantity);
        }
    }
}
