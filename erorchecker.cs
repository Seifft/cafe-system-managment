using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
namespace cafe_system_managment
{
    public static class Erorchecker
    {
        public static bool eror(TextBox txtname, TextBox txtprice, TextBox txtquantity)
        {

            if (txtname.Text == null || txtname.Text.Length == 0)
            {

                MessageBox.Show("Eror: Name Text is Empty");
                txtname.Clear();
                txtname.Focus();
                return true;



            }

            if (txtprice.Text == null || txtprice.Text.Length == 0)
            {
                MessageBox.Show("Eror: Price Text is empty");
                txtprice.Clear();
                txtprice.Focus();
                return true;
            }
            if (txtquantity.Text == null || txtquantity.Text.Length == 0)
            {

                MessageBox.Show("Eror: quantity Text is Empty");
                txtquantity.Clear();
                txtquantity.Focus();
                return true;
            }
            string name = txtname.Text;

            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Eror: Name Text Contains Numbers");
                txtquantity.Clear();
                txtprice.Clear();
                txtname.Clear();
                txtname.Focus();
                return true;
            }
            decimal price = decimal.Parse(txtprice.Text);




            if (price < 0) 
            { 
                txtprice.Clear();
                txtprice.Focus();
                MessageBox.Show("Eror: Price Text Contains Negative Number");
                
                return true; 
            }

            int quantity = int.Parse(txtquantity.Text);


            


            if (quantity < 0) 
            {
                txtquantity.Clear();
                txtquantity.Focus();

                MessageBox.Show("Eror: Stock Text Contains Negative Number"); return true; 
            }
            else { return false; }
        }



        public static bool erorrowselected(DataGridView dgvfare)
        {
            if (dgvfare.SelectedRows.Count == 0)
            {
                MessageBox.Show("Eror: You Donot Select A Row (please select one) ");

                return true;
            }
            else { return false; }







        }
        public static bool erorsamename(DataGridView dgvfare, TextBox txtname, StreamWriter sr)
        {

            StreamReader srchker = new StreamReader("data.txt");
            string srker = srchker.ReadToEnd();
            srchker.Close();
            if (srker.Contains(txtname.Text + ";"))
            {
                MessageBox.Show("item already exist");
                txtname.Focus();
                txtname.Select();
                txtname.SelectAll();
                srchker.Close();
                return true;



            }
            else { return false; }





        }

        public static bool InvoicEror(TextBox txtinvoiceprice, TextBox txtinvoicequantity, TextBox txtcastomername, TextBox txtordernumber, ComboBox cbxproduct, TextBox txtoverall)
        {

            
             if (!int.TryParse(txtinvoicequantity.Text, out int quantity))
             {
                 MessageBox.Show("Invalid quantity");
                txtinvoicequantity.Clear();
                return true;
                
             }
           


            if (!int.TryParse(txtinvoiceprice.Text, out int price))
            {
                MessageBox.Show("Invalid price");
                txtinvoiceprice.Clear();
                return true;
            }
            if (!int.TryParse(txtordernumber.Text, out int orderNum))
            {
                MessageBox.Show("Invalid Oreder");
                txtordernumber.Clear();
                return true;

            }

            if (txtinvoiceprice.Text == "")
            {
                MessageBox.Show("the price section is invalid");
                txtinvoiceprice.Clear();
                return true;
            }
            if (price < 0)
            {
                MessageBox.Show("The price Should be positive");
                txtinvoiceprice.Clear();
                return true;
            }

            if(txtinvoicequantity.Text == "")
            {
                MessageBox.Show("the quantity section is invalid");
                txtinvoicequantity.Clear();
                return true;
            }
            if (quantity < 0)
            {
                MessageBox.Show("The quantity should be positive");
                txtinvoicequantity.Clear();
                return true;
            }

            if (txtcastomername.Text == "")
            {
                MessageBox.Show("the customer name section is empty");
                txtcastomername.Clear();
                return true;
            }
            if (txtordernumber.Text == "" || orderNum <= 0)
            {
                MessageBox.Show("the order number section is invalid");
                txtordernumber.Clear();
                return true;
            }
            if (cbxproduct.Text == "")
            {
                MessageBox.Show("the product section is empty");

                return true;
            }
            else
            {
                return false;
            }


        }
       
       







    }
}



    

