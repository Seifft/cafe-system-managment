using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_system_managment
{
    internal class edit
    {
        public static void Editdgvfare(DataGridView dgvfare, TextBox txtname, TextBox txtprice, TextBox txtquantity)
        {
            
            string name = txtname.Text;

            decimal price = decimal.Parse(txtprice.Text);

            int quantity = int.Parse(txtquantity.Text);


            product2 newItem = new product2(name, price, quantity);
            dgvfare.CurrentRow.Cells[0].Value = newItem.name;
            dgvfare.CurrentRow.Cells[1].Value = newItem.price;
            dgvfare.CurrentRow.Cells[2].Value = newItem.quantity;

        }
        public static void editcombobox(List<product2> productlist, TextBox txtname, TextBox txtprice, TextBox txtquantity, ComboBox cbxproduct, BindingSource bs, TextBox txtinvoiceprice, string searchname)
        {
            

            product2 newItem = new product2(txtname.Text, decimal.Parse(txtprice.Text), int.Parse(txtquantity.Text));
            var foundItem = productlist.FirstOrDefault(item => item.name == searchname);

            if (foundItem != null)
            {
                cbxproduct.SelectedItem = foundItem;
            }
            else { MessageBox.Show("item not found"); return; }

            int selectedIndex = cbxproduct.SelectedIndex;
            if (selectedIndex >= 0)
            {

                productlist[selectedIndex] = newItem;

                bs.DataSource = productlist;
                cbxproduct.DataSource = bs;
                cbxproduct.DisplayMember = "name";
                cbxproduct.ValueMember = "price";
                bs.ResetBindings(false);


                
                txtinvoiceprice.Clear();
            }
        }
        public static void EditLineInFile(string filename, string searchname, string newName, string newPrice, string newQuantity, TextBox txtname)
        {
            txtname.Focus();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                if (parts.Length >= 3 && parts[0] == searchname)
                {
                    
                    parts[0] = newName;
                    parts[1] = newPrice;
                    parts[2] = newQuantity;
                    lines[i] = string.Join(";", parts);
                    break;
                }
            }
            File.WriteAllLines(filename, lines);
        }
        

    }
}

