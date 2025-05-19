using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.IO;
using System.Text.Json;
using System.Linq.Expressions;
namespace cafe_system_managment
{
    public partial class Form1 : Form
    {


        public product2 newItem { get; set; }

        List<product2> productlist = new List<product2>();

        BindingSource bs = new BindingSource();

        StreamWriter sr = new StreamWriter("data.txt", true);
        string searchname2;
        int ordernumber;








        private void SaveData(List<product2> products)
        {
            string json = JsonSerializer.Serialize(products);
            File.WriteAllText("data.json", json);
        }
        private List<product2> LoadData()
        {
            if (File.Exists("data.json"))
            {
                string json = File.ReadAllText("data.json");
                return JsonSerializer.Deserialize<List<product2>>(json);
            }
            return new List<product2>();
        }



        public Form1()
        {
            InitializeComponent();
            newItem = null;


        }


        int fristquantity;
        int secondquantity;
        int addquantity;
        string searchname;
        decimal grandTotal;
        Cusomertype Type;


        private void butadd_Click(object sender, EventArgs e)
        {

            sr.Close();

            

            try
            {
                if (Erorchecker.eror(txtname, txtprice, txtquantity) == true)
                {

                    return;
                }


                if (Erorchecker.erorsamename(dgvfare, txtname, sr) == true) { return; }


                Addd.AddTocombobox(productlist, txtname, txtprice, txtquantity, cbxproduct, bs, txtinvoiceprice);
                Addd.AddToDgvfare(dgvfare, txtname, txtprice, txtquantity, productlist, bs);
                Addd.Addtostreamraider(sr, txtname, txtprice, txtquantity);






                sr.Close();

                



            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

            txtname.Clear();
            txtprice.Clear();
            txtquantity.Clear();
            txtname.Focus();







        }







        private void Form1_Load(object sender, EventArgs e)
        {
            txtdate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtname.Focus();
            txtname.Select();
            txtname.SelectAll();






            sr.Close();
            StreamReader srchker = new StreamReader("data.txt");
            Addd.AddToDgvfarefromstream(srchker, sr, dgvfare, txtname, txtprice, txtquantity);
            srchker.Close();





            productlist = LoadData(); 



            // عرض أسماء المنتجات في ComboBox
            cbxproduct.DataSource = productlist;
            cbxproduct.DisplayMember = "Name";
            cbxproduct.ValueMember = "Price";
            txtinvoiceprice.Clear();
            txtordernumber.Text = "1";
            delete.deletetalltextboxpagemanagment(txtname, txtprice, txtquantity);

        }



        private void butedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Erorchecker.erorrowselected(dgvfare) == true) { return; }
                if (Erorchecker.eror(txtname, txtprice, txtquantity) == true) { return; }
                edit.EditLineInFile("data.txt", searchname, txtname.Text, txtprice.Text, txtquantity.Text, txtname);
                
                edit.Editdgvfare(dgvfare, txtname, txtprice, txtquantity);
                edit.editcombobox(productlist, txtname, txtprice, txtquantity, cbxproduct, bs, txtinvoiceprice, searchname);


                delete.deletetalltextboxpagemanagment(txtname, txtprice, txtquantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }





        private void butdelete_Click(object sender, EventArgs e)
        {



            try
            {
                if (Erorchecker.erorrowselected(dgvfare) == true) { return; }


                delete.DeleteLineFromFile("data.txt", txtname.Text, txtname);
                delete.DeleteFromcombobox(productlist, cbxproduct, bs, txtname.Text, txtname, txtprice, txtquantity, txtinvoiceprice);

                delete.DeleteFromDgvfare(dgvfare);
                txtname.Clear();
                txtprice.Clear();
                txtquantity.Clear();

                delete.deletetalltextboxpagemanagment(txtname, txtprice, txtquantity);










            }




            catch (Exception ex) { MessageBox.Show(ex.Message); }






        }

        private void butre_Click(object sender, EventArgs e)
        {
            restockcs.re(labnewstock, txtnewquantity);




        }

        private void btnstock_Click(object sender, EventArgs e)
        {


            restockcs.restockquantity(txtnewquantity, txtquantity, dgvfare, txtname, txtprice,searchname);

        }

        private void btndeleteallrows_Click(object sender, EventArgs e)
        {
            dgvfare.Rows.Clear();
            txtname.Clear();
            txtprice.Clear();
            txtquantity.Clear();
        }

        private void btndeletealltextbox_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtprice.Clear();
            txtquantity.Clear();
        }



        private void tpinvoice_Click(object sender, EventArgs e)
        {

            txtcustomername.Focus();
            txtcustomername.Select();
            txtcustomername.SelectAll();


        }







        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrol.SelectedIndex >= 0)
            {



                if (tabcontrol.SelectedIndex == 0)
                {
                    txtname.Focus();

                }
                else
                {
                    txtcustomername.Focus();

                }
            }
        }

        private void txtcastomername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxproduct.Focus();
            }

        }

        private void cbproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtinvoicequantity.Focus();
            }

            txtinvoiceprice.Text = cbxproduct.SelectedValue.ToString();
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtprice.Focus();
            }
            if (e.KeyData == (Keys.Alt | Keys.E))
            {
                butedit.PerformClick();
                txtname.Focus();
            }

        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtquantity.Focus();
            }
            if (e.KeyData == (Keys.Alt | Keys.E))
            {
                butedit.PerformClick();
                txtname.Focus();
            }
        }

        private void txtquantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butadd.PerformClick();
                txtname.Focus();
            }
            if (e.KeyData == (Keys.Alt | Keys.E))
            {
                butedit.PerformClick();
                txtname.Focus();
            }
        }

        private void dgvfare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                butdelete.PerformClick();
                txtname.Focus();
            }

        }

        private void txtinvoicequantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butinvoiceadd.PerformClick();
                txtcustomername.Focus();
            }
        }

        private void cbxproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxproduct.Text != "")
                {
                    txtinvoiceprice.Text = cbxproduct.SelectedValue.ToString();
                }
                
                if (cbxproduct.SelectedItem is product2 selectedProduct)
                {
                    txtname.Text = selectedProduct.name;
                    txtprice.Text = selectedProduct.price.ToString();
                    txtquantity.Text = selectedProduct.quantity.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            searchname = txtname.Text;
            searchname2 = txtname.Text;
        }

        private void butinvoiceadd_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Erorchecker.InvoicEror(txtinvoiceprice, txtinvoicequantity, txtcustomername, txtordernumber, cbxproduct, txtoverall) == true)
                {

                    txtinvoicequantity.Clear();

                    return;
                }
                string name = cbxproduct.Text; 
                decimal price = Convert.ToDecimal(txtinvoiceprice.Text);
                int quantity = Convert.ToInt32(txtinvoicequantity.Text);
                decimal subtotal = price * quantity;

                
                dgvproduct.Rows.Add(name, price, quantity, subtotal);
                txtinvoicequantity.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void butoverall_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbcustomer.Checked == true)
                {

                    Type = Cusomertype.premium;
                }
                else
                {
                    Type = Cusomertype.normal;
                }
                if (Type == Cusomertype.premium)
                {
                    if (txtdiscount.Text == "")
                    {
                        MessageBox.Show("please enter discount");
                        return;
                    }
                    else
                    {
                        Addd.Addoverallpricewithdiscount(dgvproduct, txtoverall, txtdiscount);
                    }

                }
                else { Addd.Addoverallprice(dgvproduct, txtoverall); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

    

            
        }

        private void btndeleteall_Click(object sender, EventArgs e)
        {
            delete.deletedgvprocutrow(dgvproduct);
        }

        private void btndeleteall_Click_1(object sender, EventArgs e)
        {
            delete.deleteallpageinvoice(txtinvoiceprice, txtinvoicequantity, dgvproduct, txtoverall, txtdiscount,txtcustomername);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData(productlist);
        }

        private void dgvfare_SelectionChanged_1(object sender, EventArgs e)
        {
            try { find.selectedrow(dgvfare, txtname, txtprice, txtquantity); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void btnfind_Click(object sender, EventArgs e)
        {
           
            try
            {
                searchname = txtname.Text;
                bool found = false;
                if (txtname.Text == "")
                {
                    MessageBox.Show("please enter name");
                    return;
                }
                foreach (DataGridViewRow row in dgvfare.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(searchname, StringComparison.OrdinalIgnoreCase))
                    {
                        dgvfare.ClearSelection(); 
                        row.Selected = true;      
                        dgvfare.CurrentCell = row.Cells[0];
                        find.selectedrow(dgvfare, txtname, txtprice, txtquantity);
                        found = true;                                     

                        break; 
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("item not found"); return;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void butprint_Click(object sender, EventArgs e)
        {
            
            if (txtoverall.Text == "")
            {
                MessageBox.Show("the overall section is empty");
                return;
            }
            ordernumber++;
            txtordernumber.Text = ordernumber.ToString();
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

            dgvproduct.DataSource = null; 
           
            delete.deleteallpageinvoice(txtinvoiceprice, txtinvoicequantity, dgvproduct, txtoverall,txtdiscount, txtcustomername);
            txtcustomername.Focus();
            


        }



        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 40;
            Font f = new Font("Arial", 18, FontStyle.Bold);

            string strNo = "Order Number : " + txtordernumber.Text;
            string strDate = "Date : " + txtdate.Text;
            string strName = "Customer Name : " + txtcustomername.Text;

            SizeF fontSizeNo = e.Graphics.MeasureString(strNo, f);
            SizeF fontSizeDate = e.Graphics.MeasureString(strDate, f);
            SizeF fontSizeName = e.Graphics.MeasureString(strName, f);

            e.Graphics.DrawString(strNo, f, Brushes.Red, (e.PageBounds.Width - fontSizeNo.Width) / 2, margin);
            e.Graphics.DrawString(strDate, f, Brushes.Black, margin, margin + fontSizeNo.Height);
            e.Graphics.DrawString(strName, f, Brushes.Black, margin, margin + fontSizeNo.Height + fontSizeDate.Height);

            float preHeights = margin + fontSizeNo.Height + fontSizeDate.Height + fontSizeName.Height + 20;

            e.Graphics.DrawRectangle(Pens.Black, margin, preHeights, e.PageBounds.Width - margin * 2, e.PageBounds.Height - margin * 2 - preHeights);

            float colHeight = 60;
            float colOneWidth = 300;
            float colTwoWidth = 125 + colOneWidth;
            float colThreeWidth = 125 + colTwoWidth;
            float colFourWidth = 125 + colThreeWidth;

            e.Graphics.DrawLine(Pens.Black, margin, preHeights + colHeight, e.PageBounds.Width - margin, preHeights + colHeight);

            e.Graphics.DrawString("Product", f, Brushes.Black, margin + 10, preHeights + 15);
            e.Graphics.DrawLine(Pens.Black, margin + colOneWidth, preHeights, margin + colOneWidth, e.PageBounds.Height - margin * 2);

            e.Graphics.DrawString("Price", f, Brushes.Black, margin + colOneWidth + 10, preHeights + 15);
            e.Graphics.DrawLine(Pens.Black, margin + colTwoWidth, preHeights, margin + colTwoWidth, e.PageBounds.Height - margin * 2);

            e.Graphics.DrawString("Quantity", f, Brushes.Black, margin + colTwoWidth + 10, preHeights + 15);
            e.Graphics.DrawLine(Pens.Black, margin + colThreeWidth, preHeights, margin + colThreeWidth, e.PageBounds.Height - margin * 2);

            e.Graphics.DrawString("Overall", f, Brushes.Red, margin + colThreeWidth + 10, preHeights + 15);

            
            float rowsHeight = 60;

            for (int x = 0; x < dgvproduct.Rows.Count; x += 1)
            {
                e.Graphics.DrawString(dgvproduct.Rows[x].Cells[0].Value.ToString(), f, Brushes.Black, margin + 15, preHeights + rowsHeight);
                e.Graphics.DrawString(dgvproduct.Rows[x].Cells[1].Value.ToString(), f, Brushes.Black, margin + colOneWidth + 15, preHeights + rowsHeight);
                e.Graphics.DrawString(dgvproduct.Rows[x].Cells[2].Value.ToString(), f, Brushes.Black, margin + colTwoWidth + 15, preHeights + rowsHeight);
                e.Graphics.DrawString(dgvproduct.Rows[x].Cells[3].Value.ToString(), f, Brushes.Black, margin + colThreeWidth + 15, preHeights + rowsHeight);

                e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight + colHeight, e.PageBounds.Width - margin, preHeights + rowsHeight + colHeight);

                rowsHeight += 60;
            }


            e.Graphics.DrawString("Total", f, Brushes.Red, margin + colTwoWidth + 15, preHeights + rowsHeight + 15);
            e.Graphics.DrawString(txtoverall.Text, f, Brushes.Red, margin + colThreeWidth + 15, preHeights + rowsHeight + 15);
            e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight + colHeight, e.PageBounds.Width - margin, preHeights + rowsHeight + colHeight);

        }

        private void txtoverall_TextChanged(object sender, EventArgs e)
        {
            string price = (txtoverall.Text);
        }

        private void cbcustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbcustomer.Checked == true)
            {
                txtdiscount.Enabled = true;
                txtdiscount.Visible = true;
                labdiscount.Visible = true;
            }
            else
            {
                txtdiscount.Enabled = false;
                txtdiscount.Visible = false;
                labdiscount.Visible = false;
            }
        }
    }
}

            
