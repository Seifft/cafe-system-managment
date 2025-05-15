using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cafe_system_managment
{
    public class Addd
    {
        public static void AddToDgvfare(DataGridView dgvfare, TextBox txtname, TextBox txtprice, TextBox txtquantity, List<product2> productlist, BindingSource bs)
        {


            product2 newItem = new product2(txtname.Text, decimal.Parse(txtprice.Text), int.Parse(txtquantity.Text));
            dgvfare.Rows.Add(newItem.name, newItem.price, newItem.quantity);





        }
        public static void AddToDgvfarefromstream(StreamReader stchker, StreamWriter sr, DataGridView dgvfare, TextBox txtname, TextBox txtprice, TextBox txtquantity)
        {


            StreamReader srchker = new StreamReader("data.txt");




            string line = null;
            bool found = false;

            do
            {
                line = srchker.ReadLine();

                if (line != null)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        decimal price = decimal.Parse(parts[1]);
                        int quantity = int.Parse(parts[2]);
                        product2 newItem = new product2(name, price, quantity);
                        dgvfare.Rows.Add(newItem.name, newItem.price, newItem.quantity);

                    }
                }

            } while (line != null); srchker.Close();
        }


        public static void AddTocombobox(List<product2> productlist, TextBox txtname, TextBox txtprice, TextBox txtquantity, ComboBox cbxproduct, BindingSource bs, TextBox txtinvoiceprice)
        {

            string name = txtname.Text;
            decimal price = Convert.ToDecimal(txtprice.Text);
            int quantity = Convert.ToInt32(txtquantity.Text);
            product2 newItem = new product2(name, price, quantity);
            productlist.Add(newItem);
            bs.DataSource = productlist;
            cbxproduct.DataSource = bs;
            cbxproduct.DisplayMember = "name";
            cbxproduct.ValueMember = "price";
            bs.ResetBindings(false);
            



            txtinvoiceprice.Clear();





        }
        public static void AddToDgvproduct(DataGridView dgvproduct, TextBox txtcbxproduct, TextBox txtinvoiceprice, TextBox txtinvoicequantity)
        {
            

            string name = txtcbxproduct.Text;
            decimal price = Convert.ToDecimal(txtinvoiceprice.Text);
            int quantity = Convert.ToInt32(txtinvoicequantity.Text);
            decimal subtotal = price * quantity;

            datadgvproduct data = new datadgvproduct(name, price, quantity, subtotal);
            dgvproduct.Rows.Add(data.name, data.price, data.quantity, data.subtotal);
            txtinvoicequantity.Clear();


        }

        public static void Addoverallprice(DataGridView dgvproduct, TextBox txtoverall)
        {
            decimal grandTotal = 0;
            foreach (DataGridViewRow row in dgvproduct.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    grandTotal += Convert.ToDecimal(row.Cells[3].Value);
                }
            }
            txtoverall.Text = grandTotal + "EGP";
        }
        public static void Addoverallpricewithdiscount(DataGridView dgvproduct, TextBox txtoverall, TextBox txtdiscount)
        {
            decimal grandTotal = 0;
            foreach (DataGridViewRow row in dgvproduct.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    grandTotal += Convert.ToDecimal(row.Cells[3].Value);
                }
            }
            txtoverall.Text = grandTotal - (grandTotal * (Convert.ToDecimal(txtdiscount.Text) / 100)) + "EGP";

        }


        public static void Addtostreamraider(StreamWriter sr, TextBox txtname, TextBox txtprice, TextBox txtquantity)
        {

            sr = new StreamWriter("data.txt", true);
            string name = txtname.Text;
            decimal price = decimal.Parse(txtprice.Text);
            int quantity = int.Parse(txtquantity.Text);
            product2 newItem = new product2(name, price, quantity);
            sr.WriteLine(newItem.name + ";" + newItem.price + ";" + newItem.quantity);
            sr.Close();



        }
    }
}


