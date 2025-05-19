namespace cafe_system_managment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabcontrol = new TabControl();
            tbmenumangment = new TabPage();
            btnfind = new Button();
            btndeletealltextbox = new Button();
            txtnewquantity = new TextBox();
            labnewstock = new Label();
            btnstock = new Button();
            butre = new Button();
            butdelete = new Button();
            butedit = new Button();
            butadd = new Button();
            txtprice = new TextBox();
            txtquantity = new TextBox();
            txtname = new TextBox();
            labquantity = new Label();
            labprice = new Label();
            labname = new Label();
            dgvfare = new DataGridView();
            colname = new DataGridViewTextBoxColumn();
            colprice = new DataGridViewTextBoxColumn();
            colquantity = new DataGridViewTextBoxColumn();
            tpinvoice = new TabPage();
            btndeleteall = new Button();
            btndeletrow = new Button();
            butoverall = new Button();
            cbcustomer = new CheckBox();
            txtdiscount = new TextBox();
            labdiscount = new Label();
            butprint = new Button();
            butinvoiceadd = new Button();
            txtoverall = new TextBox();
            label6 = new Label();
            dgvproduct = new DataGridView();
            colinvoiceproduct = new DataGridViewTextBoxColumn();
            Colinvoiceprice = new DataGridViewTextBoxColumn();
            Colinvoicequantity = new DataGridViewTextBoxColumn();
            colinvoicetotal = new DataGridViewTextBoxColumn();
            txtinvoicequantity = new TextBox();
            txtinvoiceprice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            cbxproduct = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labcustomername = new Label();
            txtcustomername = new TextBox();
            txtdate = new TextBox();
            txtordernumber = new TextBox();
            labdate = new Label();
            labnumorder = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            tabcontrol.SuspendLayout();
            tbmenumangment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvfare).BeginInit();
            tpinvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproduct).BeginInit();
            SuspendLayout();
            // 
            // tabcontrol
            // 
            tabcontrol.Controls.Add(tbmenumangment);
            tabcontrol.Controls.Add(tpinvoice);
            tabcontrol.Location = new Point(2, -1);
            tabcontrol.Name = "tabcontrol";
            tabcontrol.SelectedIndex = 0;
            tabcontrol.Size = new Size(1395, 537);
            tabcontrol.TabIndex = 0;
            tabcontrol.SelectedIndexChanged += tabcontrol_SelectedIndexChanged;
            // 
            // tbmenumangment
            // 
            tbmenumangment.Controls.Add(btnfind);
            tbmenumangment.Controls.Add(btndeletealltextbox);
            tbmenumangment.Controls.Add(txtnewquantity);
            tbmenumangment.Controls.Add(labnewstock);
            tbmenumangment.Controls.Add(btnstock);
            tbmenumangment.Controls.Add(butre);
            tbmenumangment.Controls.Add(butdelete);
            tbmenumangment.Controls.Add(butedit);
            tbmenumangment.Controls.Add(butadd);
            tbmenumangment.Controls.Add(txtprice);
            tbmenumangment.Controls.Add(txtquantity);
            tbmenumangment.Controls.Add(txtname);
            tbmenumangment.Controls.Add(labquantity);
            tbmenumangment.Controls.Add(labprice);
            tbmenumangment.Controls.Add(labname);
            tbmenumangment.Controls.Add(dgvfare);
            tbmenumangment.Location = new Point(4, 29);
            tbmenumangment.Name = "tbmenumangment";
            tbmenumangment.Padding = new Padding(3);
            tbmenumangment.Size = new Size(1387, 504);
            tbmenumangment.TabIndex = 0;
            tbmenumangment.Text = "menu managment";
            tbmenumangment.UseVisualStyleBackColor = true;
            // 
            // btnfind
            // 
            btnfind.Location = new Point(474, 56);
            btnfind.Name = "btnfind";
            btnfind.Size = new Size(113, 39);
            btnfind.TabIndex = 27;
            btnfind.Text = "find";
            btnfind.UseVisualStyleBackColor = true;
            btnfind.Click += btnfind_Click;
            // 
            // btndeletealltextbox
            // 
            btndeletealltextbox.Location = new Point(606, 369);
            btndeletealltextbox.Name = "btndeletealltextbox";
            btndeletealltextbox.Size = new Size(147, 39);
            btndeletealltextbox.TabIndex = 26;
            btndeletealltextbox.Text = "delete all text box";
            btndeletealltextbox.UseVisualStyleBackColor = true;
            btndeletealltextbox.Click += btndeletealltextbox_Click;
            // 
            // txtnewquantity
            // 
            txtnewquantity.Enabled = false;
            txtnewquantity.Location = new Point(561, 118);
            txtnewquantity.Name = "txtnewquantity";
            txtnewquantity.Size = new Size(211, 27);
            txtnewquantity.TabIndex = 24;
            txtnewquantity.Visible = false;
            // 
            // labnewstock
            // 
            labnewstock.AutoSize = true;
            labnewstock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labnewstock.Location = new Point(440, 114);
            labnewstock.Name = "labnewstock";
            labnewstock.Size = new Size(115, 31);
            labnewstock.TabIndex = 23;
            labnewstock.Text = "new stock";
            labnewstock.Visible = false;
            // 
            // btnstock
            // 
            btnstock.Location = new Point(662, 56);
            btnstock.Name = "btnstock";
            btnstock.Size = new Size(113, 39);
            btnstock.TabIndex = 22;
            btnstock.Text = "stock";
            btnstock.UseVisualStyleBackColor = true;
            btnstock.Click += btnstock_Click;
            // 
            // butre
            // 
            butre.Location = new Point(662, 1);
            butre.Name = "butre";
            butre.Size = new Size(113, 39);
            butre.TabIndex = 21;
            butre.Text = "re";
            butre.UseVisualStyleBackColor = true;
            butre.Click += butre_Click;
            // 
            // butdelete
            // 
            butdelete.Location = new Point(304, 163);
            butdelete.Name = "butdelete";
            butdelete.Size = new Size(113, 39);
            butdelete.TabIndex = 20;
            butdelete.Text = "delete";
            butdelete.UseVisualStyleBackColor = true;
            butdelete.Click += butdelete_Click;
            // 
            // butedit
            // 
            butedit.Location = new Point(165, 163);
            butedit.Name = "butedit";
            butedit.Size = new Size(113, 39);
            butedit.TabIndex = 19;
            butedit.Text = "Edit";
            butedit.UseVisualStyleBackColor = true;
            butedit.Click += butedit_Click;
            // 
            // butadd
            // 
            butadd.Location = new Point(17, 163);
            butadd.Name = "butadd";
            butadd.Size = new Size(113, 39);
            butadd.TabIndex = 18;
            butadd.Text = "Add";
            butadd.UseVisualStyleBackColor = true;
            butadd.Click += butadd_Click;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(116, 55);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(301, 27);
            txtprice.TabIndex = 17;
            txtprice.KeyDown += txtprice_KeyDown;
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(116, 114);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(301, 27);
            txtquantity.TabIndex = 16;
            txtquantity.KeyDown += txtquantity_KeyDown;
            // 
            // txtname
            // 
            txtname.Location = new Point(116, 7);
            txtname.Name = "txtname";
            txtname.Size = new Size(301, 27);
            txtname.TabIndex = 15;
            txtname.Enter += txtname_Enter;
            txtname.KeyDown += txtname_KeyDown;
            // 
            // labquantity
            // 
            labquantity.AutoSize = true;
            labquantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labquantity.Location = new Point(21, 108);
            labquantity.Name = "labquantity";
            labquantity.Size = new Size(67, 31);
            labquantity.TabIndex = 14;
            labquantity.Text = "stock";
            // 
            // labprice
            // 
            labprice.AutoSize = true;
            labprice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labprice.Location = new Point(17, 56);
            labprice.Name = "labprice";
            labprice.Size = new Size(65, 31);
            labprice.TabIndex = 13;
            labprice.Text = "price";
            // 
            // labname
            // 
            labname.AutoSize = true;
            labname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labname.Location = new Point(17, 3);
            labname.Name = "labname";
            labname.Size = new Size(71, 31);
            labname.TabIndex = 12;
            labname.Text = "name";
            // 
            // dgvfare
            // 
            dgvfare.AllowUserToAddRows = false;
            dgvfare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfare.Columns.AddRange(new DataGridViewColumn[] { colname, colprice, colquantity });
            dgvfare.Location = new Point(17, 230);
            dgvfare.Name = "dgvfare";
            dgvfare.RowHeadersWidth = 51;
            dgvfare.Size = new Size(424, 177);
            dgvfare.TabIndex = 11;
            dgvfare.SelectionChanged += dgvfare_SelectionChanged_1;
            dgvfare.KeyDown += dgvfare_KeyDown;
            // 
            // colname
            // 
            colname.HeaderText = "name";
            colname.MinimumWidth = 6;
            colname.Name = "colname";
            colname.Width = 125;
            // 
            // colprice
            // 
            colprice.HeaderText = "price";
            colprice.MinimumWidth = 6;
            colprice.Name = "colprice";
            colprice.Width = 125;
            // 
            // colquantity
            // 
            colquantity.HeaderText = "stock";
            colquantity.MinimumWidth = 6;
            colquantity.Name = "colquantity";
            colquantity.Width = 125;
            // 
            // tpinvoice
            // 
            tpinvoice.Controls.Add(btndeleteall);
            tpinvoice.Controls.Add(btndeletrow);
            tpinvoice.Controls.Add(butoverall);
            tpinvoice.Controls.Add(cbcustomer);
            tpinvoice.Controls.Add(txtdiscount);
            tpinvoice.Controls.Add(labdiscount);
            tpinvoice.Controls.Add(butprint);
            tpinvoice.Controls.Add(butinvoiceadd);
            tpinvoice.Controls.Add(txtoverall);
            tpinvoice.Controls.Add(label6);
            tpinvoice.Controls.Add(dgvproduct);
            tpinvoice.Controls.Add(txtinvoicequantity);
            tpinvoice.Controls.Add(txtinvoiceprice);
            tpinvoice.Controls.Add(label5);
            tpinvoice.Controls.Add(label4);
            tpinvoice.Controls.Add(cbxproduct);
            tpinvoice.Controls.Add(label3);
            tpinvoice.Controls.Add(label2);
            tpinvoice.Controls.Add(label1);
            tpinvoice.Controls.Add(labcustomername);
            tpinvoice.Controls.Add(txtcustomername);
            tpinvoice.Controls.Add(txtdate);
            tpinvoice.Controls.Add(txtordernumber);
            tpinvoice.Controls.Add(labdate);
            tpinvoice.Controls.Add(labnumorder);
            tpinvoice.Location = new Point(4, 29);
            tpinvoice.Name = "tpinvoice";
            tpinvoice.Padding = new Padding(3);
            tpinvoice.Size = new Size(1387, 504);
            tpinvoice.TabIndex = 1;
            tpinvoice.Text = "invoice";
            tpinvoice.UseVisualStyleBackColor = true;
            tpinvoice.Click += tpinvoice_Click;
            // 
            // btndeleteall
            // 
            btndeleteall.Location = new Point(825, 300);
            btndeleteall.Name = "btndeleteall";
            btndeleteall.Size = new Size(102, 40);
            btndeleteall.TabIndex = 24;
            btndeleteall.Text = "delete all";
            btndeleteall.UseVisualStyleBackColor = true;
            btndeleteall.Click += btndeleteall_Click_1;
            // 
            // btndeletrow
            // 
            btndeletrow.Location = new Point(1148, 299);
            btndeletrow.Name = "btndeletrow";
            btndeletrow.Size = new Size(102, 40);
            btndeletrow.TabIndex = 23;
            btndeletrow.Text = "delete row";
            btndeletrow.UseVisualStyleBackColor = true;
            btndeletrow.Click += btndeleteall_Click;
            // 
            // butoverall
            // 
            butoverall.Location = new Point(1020, 299);
            butoverall.Name = "butoverall";
            butoverall.Size = new Size(102, 40);
            butoverall.TabIndex = 22;
            butoverall.Text = "overall";
            butoverall.UseVisualStyleBackColor = true;
            butoverall.Click += butoverall_Click;
            // 
            // cbcustomer
            // 
            cbcustomer.AutoSize = true;
            cbcustomer.Location = new Point(1090, 127);
            cbcustomer.Name = "cbcustomer";
            cbcustomer.Size = new Size(151, 24);
            cbcustomer.TabIndex = 21;
            cbcustomer.Text = "premium custome";
            cbcustomer.UseVisualStyleBackColor = true;
            cbcustomer.CheckedChanged += cbcustomer_CheckedChanged;
            // 
            // txtdiscount
            // 
            txtdiscount.Enabled = false;
            txtdiscount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdiscount.Location = new Point(1052, 171);
            txtdiscount.Multiline = true;
            txtdiscount.Name = "txtdiscount";
            txtdiscount.Size = new Size(262, 38);
            txtdiscount.TabIndex = 20;
            txtdiscount.Visible = false;
            // 
            // labdiscount
            // 
            labdiscount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labdiscount.Location = new Point(909, 168);
            labdiscount.Name = "labdiscount";
            labdiscount.Size = new Size(154, 55);
            labdiscount.TabIndex = 19;
            labdiscount.Text = "Discount:";
            labdiscount.Visible = false;
            // 
            // butprint
            // 
            butprint.Location = new Point(1148, 253);
            butprint.Name = "butprint";
            butprint.Size = new Size(102, 40);
            butprint.TabIndex = 18;
            butprint.Text = "Print";
            butprint.UseVisualStyleBackColor = true;
            butprint.Click += butprint_Click;
            // 
            // butinvoiceadd
            // 
            butinvoiceadd.Location = new Point(1020, 253);
            butinvoiceadd.Name = "butinvoiceadd";
            butinvoiceadd.Size = new Size(102, 40);
            butinvoiceadd.TabIndex = 17;
            butinvoiceadd.Text = "Add";
            butinvoiceadd.UseVisualStyleBackColor = true;
            butinvoiceadd.Click += butinvoiceadd_Click;
            // 
            // txtoverall
            // 
            txtoverall.Enabled = false;
            txtoverall.Location = new Point(727, 253);
            txtoverall.Multiline = true;
            txtoverall.Name = "txtoverall";
            txtoverall.Size = new Size(244, 41);
            txtoverall.TabIndex = 16;
            txtoverall.TextChanged += txtoverall_TextChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(603, 252);
            label6.Name = "label6";
            label6.Size = new Size(129, 41);
            label6.TabIndex = 15;
            label6.Text = "Overall:";
            // 
            // dgvproduct
            // 
            dgvproduct.AllowUserToAddRows = false;
            dgvproduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvproduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproduct.Columns.AddRange(new DataGridViewColumn[] { colinvoiceproduct, Colinvoiceprice, Colinvoicequantity, colinvoicetotal });
            dgvproduct.Location = new Point(-4, 345);
            dgvproduct.Name = "dgvproduct";
            dgvproduct.RowHeadersWidth = 51;
            dgvproduct.Size = new Size(1395, 183);
            dgvproduct.TabIndex = 14;
            // 
            // colinvoiceproduct
            // 
            colinvoiceproduct.HeaderText = "product";
            colinvoiceproduct.MinimumWidth = 6;
            colinvoiceproduct.Name = "colinvoiceproduct";
            // 
            // Colinvoiceprice
            // 
            Colinvoiceprice.HeaderText = "price";
            Colinvoiceprice.MinimumWidth = 6;
            Colinvoiceprice.Name = "Colinvoiceprice";
            // 
            // Colinvoicequantity
            // 
            Colinvoicequantity.HeaderText = "quantity";
            Colinvoicequantity.MinimumWidth = 6;
            Colinvoicequantity.Name = "Colinvoicequantity";
            // 
            // colinvoicetotal
            // 
            colinvoicetotal.HeaderText = "Total";
            colinvoicetotal.MinimumWidth = 6;
            colinvoicetotal.Name = "colinvoicetotal";
            // 
            // txtinvoicequantity
            // 
            txtinvoicequantity.Location = new Point(526, 309);
            txtinvoicequantity.Multiline = true;
            txtinvoicequantity.Name = "txtinvoicequantity";
            txtinvoicequantity.Size = new Size(244, 30);
            txtinvoicequantity.TabIndex = 13;
            txtinvoicequantity.KeyDown += txtinvoicequantity_KeyDown;
            // 
            // txtinvoiceprice
            // 
            txtinvoiceprice.Location = new Point(102, 298);
            txtinvoiceprice.Name = "txtinvoiceprice";
            txtinvoiceprice.Size = new Size(244, 27);
            txtinvoiceprice.TabIndex = 12;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(388, 298);
            label5.Name = "label5";
            label5.Size = new Size(151, 41);
            label5.TabIndex = 11;
            label5.Text = "quantity:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 284);
            label4.Name = "label4";
            label4.Size = new Size(96, 41);
            label4.TabIndex = 10;
            label4.Text = "price:";
            // 
            // cbxproduct
            // 
            cbxproduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxproduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxproduct.FormattingEnabled = true;
            cbxproduct.Location = new Point(139, 251);
            cbxproduct.Name = "cbxproduct";
            cbxproduct.Size = new Size(447, 28);
            cbxproduct.TabIndex = 9;
            cbxproduct.SelectedIndexChanged += cbxproduct_SelectedIndexChanged;
            cbxproduct.KeyDown += cbproduct_KeyDown;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 239);
            label3.Name = "label3";
            label3.Size = new Size(179, 41);
            label3.TabIndex = 8;
            label3.Text = "Product:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(558, 0);
            label2.Name = "label2";
            label2.Size = new Size(336, 82);
            label2.TabIndex = 7;
            label2.Text = "Invoice Page";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 212);
            label1.Name = "label1";
            label1.Size = new Size(1375, 24);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labcustomername
            // 
            labcustomername.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labcustomername.Location = new Point(0, 171);
            labcustomername.Name = "labcustomername";
            labcustomername.Size = new Size(251, 41);
            labcustomername.TabIndex = 5;
            labcustomername.Text = "customer name:";
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(270, 186);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(608, 27);
            txtcustomername.TabIndex = 4;
            txtcustomername.KeyDown += txtcastomername_KeyDown;
            // 
            // txtdate
            // 
            txtdate.Enabled = false;
            txtdate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdate.Location = new Point(583, 125);
            txtdate.Multiline = true;
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(262, 27);
            txtdate.TabIndex = 3;
            // 
            // txtordernumber
            // 
            txtordernumber.Location = new Point(214, 125);
            txtordernumber.Name = "txtordernumber";
            txtordernumber.Size = new Size(244, 27);
            txtordernumber.TabIndex = 2;
            // 
            // labdate
            // 
            labdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labdate.Location = new Point(496, 111);
            labdate.Name = "labdate";
            labdate.Size = new Size(105, 55);
            labdate.TabIndex = 1;
            labdate.Text = "Date:";
            // 
            // labnumorder
            // 
            labnumorder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labnumorder.Location = new Point(-4, 111);
            labnumorder.Name = "labnumorder";
            labnumorder.Size = new Size(242, 41);
            labnumorder.TabIndex = 0;
            labnumorder.Text = "order number:";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 548);
            Controls.Add(tabcontrol);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabcontrol.ResumeLayout(false);
            tbmenumangment.ResumeLayout(false);
            tbmenumangment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvfare).EndInit();
            tpinvoice.ResumeLayout(false);
            tpinvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrol;
        private TabPage tbmenumangment;
        private Button butdelete;
        private Button butedit;
        private Button butadd;
        private TextBox txtprice;
        private TextBox txtquantity;
        private TextBox txtname;
        private Label labquantity;
        private Label labprice;
        private Label labname;
        private DataGridView dgvfare;
        private DataGridViewTextBoxColumn colname;
        private DataGridViewTextBoxColumn colprice;
        private DataGridViewTextBoxColumn colquantity;
        private TabPage tpinvoice;
        private Button butre;
        private Button btnstock;
        private Label labnewstock;
        private TextBox txtnewquantity;
        private Button btndeletealltextbox;
        private Label labnumorder;
        private Label labdate;
        private TextBox txtordernumber;
        private TextBox txtdate;
        private Label labcustomername;
        private TextBox txtcustomername;
        private Label label1;
        private Label label2;
        private ComboBox cbxproduct;
        private Label label3;
        private TextBox txtinvoicequantity;
        private TextBox txtinvoiceprice;
        private Label label5;
        private Label label4;
        private DataGridView dgvproduct;
        private DataGridViewTextBoxColumn colinvoiceproduct;
        private DataGridViewTextBoxColumn Colinvoiceprice;
        private DataGridViewTextBoxColumn Colinvoicequantity;
        private DataGridViewTextBoxColumn colinvoicetotal;
        private TextBox txtoverall;
        private Label label6;
        private Button butprint;
        private Button butinvoiceadd;
        private TextBox txtdiscount;
        private Label labdiscount;
        private Button butoverall;
        private CheckBox cbcustomer;
        private Button btndeletrow;
        private Button btndeleteall;
        private Button btnfind;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
