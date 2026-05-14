namespace ErpSys
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button16 = new Button();
            Invoices = new Button();
            button4 = new Button();
            btnShowOrders = new Button();
            button1 = new Button();
            clear = new Button();
            Devicetype = new ComboBox();
            proplem = new ComboBox();
            Phone = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            notes = new TextBox();
            cost = new TextBox();
            label7 = new Label();
            data = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            serial = new TextBox();
            label2 = new Label();
            ClientName = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            button15 = new Button();
            button8 = new Button();
            label9 = new Label();
            button2 = new Button();
            button3 = new Button();
            txtsearch = new TextBox();
            label8 = new Label();
            btnRefresh = new Button();
            btnsearch = new Button();
            dataGridView1 = new DataGridView();
            Invoice = new TabPage();
            button14 = new Button();
            button9 = new Button();
            lblTotal = new Label();
            lblPartCost = new Label();
            lblProblem = new Label();
            btnPrintInvoice = new Button();
            btnClearInvoice = new Button();
            btnLoadInvoice = new Button();
            txtInvoiceSearch = new TextBox();
            txtLaborCost = new TextBox();
            lblDevice = new Label();
            lblClientName = new Label();
            lblPhone = new Label();
            lblSerial = new Label();
            label11 = new Label();
            label10 = new Label();
            button5 = new Button();
            button6 = new Button();
            Reports = new TabPage();
            button13 = new Button();
            button7 = new Button();
            button11 = new Button();
            button12 = new Button();
            lblRevenue = new Label();
            lblClients = new Label();
            btnRefreshReports = new Button();
            dgvReports = new DataGridView();
            lblPending = new Label();
            lblDone = new Label();
            lblTotalOrders = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Invoice.SuspendLayout();
            Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(Invoice);
            tabControl1.Controls.Add(Reports);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(725, 628);
            tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button16);
            tabPage1.Controls.Add(Invoices);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(btnShowOrders);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(clear);
            tabPage1.Controls.Add(Devicetype);
            tabPage1.Controls.Add(proplem);
            tabPage1.Controls.Add(Phone);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(notes);
            tabPage1.Controls.Add(cost);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(data);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(serial);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(ClientName);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(717, 595);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "addorder";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button16.BackColor = Color.RoyalBlue;
            button16.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button16.ForeColor = Color.White;
            button16.Location = new Point(10, 210);
            button16.Name = "button16";
            button16.Size = new Size(150, 40);
            button16.TabIndex = 65;
            button16.Text = "التقارير";
            button16.UseVisualStyleBackColor = false;
            button16.Click += Reports_Click;
            // 
            // Invoices
            // 
            Invoices.AutoSize = true;
            Invoices.BackColor = Color.RoyalBlue;
            Invoices.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Invoices.ForeColor = Color.White;
            Invoices.Location = new Point(10, 150);
            Invoices.Margin = new Padding(6);
            Invoices.Name = "Invoices";
            Invoices.Size = new Size(150, 40);
            Invoices.TabIndex = 42;
            Invoices.Text = "الفواتير";
            Invoices.UseVisualStyleBackColor = false;
            Invoices.Click += Invoicesbtn;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(524, 393);
            button4.Name = "button4";
            button4.Size = new Size(126, 35);
            button4.TabIndex = 40;
            button4.Text = "save";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += save_Click_11;
            // 
            // btnShowOrders
            // 
            btnShowOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShowOrders.BackColor = Color.RoyalBlue;
            btnShowOrders.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnShowOrders.ForeColor = Color.White;
            btnShowOrders.Location = new Point(10, 90);
            btnShowOrders.Margin = new Padding(4);
            btnShowOrders.Name = "btnShowOrders";
            btnShowOrders.Size = new Size(150, 40);
            btnShowOrders.TabIndex = 39;
            btnShowOrders.Text = "عرض الطلبات ";
            btnShowOrders.UseVisualStyleBackColor = false;
            btnShowOrders.Click += showorder;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 30);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 38;
            button1.Text = "اضافه طلب";
            button1.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            clear.BackColor = Color.RoyalBlue;
            clear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            clear.ForeColor = Color.White;
            clear.Location = new Point(376, 393);
            clear.Name = "clear";
            clear.Size = new Size(126, 35);
            clear.TabIndex = 20;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // Devicetype
            // 
            Devicetype.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            Devicetype.FormattingEnabled = true;
            Devicetype.Location = new Point(197, 145);
            Devicetype.Name = "Devicetype";
            Devicetype.Size = new Size(211, 31);
            Devicetype.TabIndex = 22;
            // 
            // proplem
            // 
            proplem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            proplem.FormattingEnabled = true;
            proplem.Location = new Point(426, 145);
            proplem.Name = "proplem";
            proplem.Size = new Size(250, 31);
            proplem.TabIndex = 23;
            // 
            // Phone
            // 
            Phone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            Phone.Location = new Point(426, 72);
            Phone.MaxLength = 12;
            Phone.Name = "Phone";
            Phone.Size = new Size(250, 30);
            Phone.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(426, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 30);
            dateTimePicker1.TabIndex = 25;
            // 
            // notes
            // 
            notes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            notes.Location = new Point(194, 336);
            notes.Name = "notes";
            notes.Size = new Size(482, 30);
            notes.TabIndex = 26;
            // 
            // cost
            // 
            cost.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cost.Location = new Point(195, 207);
            cost.Name = "cost";
            cost.Size = new Size(210, 30);
            cost.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(426, 108);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 28;
            label7.Text = "نوع المشكله";
            // 
            // data
            // 
            data.AutoSize = true;
            data.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            data.ForeColor = Color.RoyalBlue;
            data.Location = new Point(426, 184);
            data.Name = "data";
            data.Size = new Size(54, 23);
            data.TabIndex = 29;
            data.Text = "التاريخ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(195, 311);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 30;
            label5.Text = "ملاحظات";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(426, 38);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 31;
            label6.Text = "رقم الهاتف";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(194, 184);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 32;
            label3.Text = "سعر الاصلاح";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(194, 240);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 33;
            label4.Text = "سيريال الجهاز";
            // 
            // serial
            // 
            serial.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            serial.Location = new Point(194, 271);
            serial.Name = "serial";
            serial.Size = new Size(482, 30);
            serial.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(194, 108);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 35;
            label2.Text = "نوع الجهاز";
            // 
            // ClientName
            // 
            ClientName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            ClientName.Location = new Point(194, 69);
            ClientName.Name = "ClientName";
            ClientName.Size = new Size(214, 30);
            ClientName.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(194, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 37;
            label1.Text = "اسم العميل";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button15);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(txtsearch);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(btnRefresh);
            tabPage2.Controls.Add(btnsearch);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(717, 595);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "orderlist";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button15.BackColor = Color.RoyalBlue;
            button15.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button15.ForeColor = Color.White;
            button15.Location = new Point(10, 210);
            button15.Name = "button15";
            button15.Size = new Size(150, 40);
            button15.TabIndex = 64;
            button15.Text = "التقارير";
            button15.UseVisualStyleBackColor = false;
            button15.Click += Reports_Click;
            // 
            // button8
            // 
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.BackColor = Color.RoyalBlue;
            button8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(10, 150);
            button8.Name = "button8";
            button8.Size = new Size(150, 40);
            button8.TabIndex = 43;
            button8.Text = "الفواتير";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btninv;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(548, 8);
            label9.Name = "label9";
            label9.Size = new Size(135, 20);
            label9.TabIndex = 42;
            label9.Text = "بحث ب اسم العميل ";
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 90);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 41;
            button2.Text = "عرض الطلبات ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_11;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.RoyalBlue;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(10, 30);
            button3.Name = "button3";
            button3.Size = new Size(150, 40);
            button3.TabIndex = 40;
            button3.Text = "اضافه طلب";
            button3.UseVisualStyleBackColor = false;
            button3.Click += addoeder;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(508, 31);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(174, 27);
            txtsearch.TabIndex = 9;
            txtsearch.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(219, 30);
            label8.Name = "label8";
            label8.Size = new Size(120, 25);
            label8.TabIndex = 8;
            label8.Text = "سجل الطلبات ";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.RoyalBlue;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(375, 534);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(147, 43);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Clickk;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.RoyalBlue;
            btnsearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnsearch.ForeColor = Color.White;
            btnsearch.Location = new Point(536, 534);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(160, 43);
            btnsearch.TabIndex = 6;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Clickk;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(216, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(480, 448);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Invoice
            // 
            Invoice.Controls.Add(button14);
            Invoice.Controls.Add(button9);
            Invoice.Controls.Add(lblTotal);
            Invoice.Controls.Add(lblPartCost);
            Invoice.Controls.Add(lblProblem);
            Invoice.Controls.Add(btnPrintInvoice);
            Invoice.Controls.Add(btnClearInvoice);
            Invoice.Controls.Add(btnLoadInvoice);
            Invoice.Controls.Add(txtInvoiceSearch);
            Invoice.Controls.Add(txtLaborCost);
            Invoice.Controls.Add(lblDevice);
            Invoice.Controls.Add(lblClientName);
            Invoice.Controls.Add(lblPhone);
            Invoice.Controls.Add(lblSerial);
            Invoice.Controls.Add(label11);
            Invoice.Controls.Add(label10);
            Invoice.Controls.Add(button5);
            Invoice.Controls.Add(button6);
            Invoice.Location = new Point(4, 29);
            Invoice.Name = "Invoice";
            Invoice.Padding = new Padding(3);
            Invoice.Size = new Size(717, 595);
            Invoice.TabIndex = 2;
            Invoice.Text = "Invoice";
            Invoice.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button14.BackColor = Color.RoyalBlue;
            button14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button14.ForeColor = Color.White;
            button14.Location = new Point(10, 210);
            button14.Name = "button14";
            button14.Size = new Size(150, 40);
            button14.TabIndex = 63;
            button14.Text = "التقارير";
            button14.UseVisualStyleBackColor = false;
            button14.Click += Reports_Click;
            // 
            // button9
            // 
            button9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button9.BackColor = Color.RoyalBlue;
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(10, 150);
            button9.Name = "button9";
            button9.Size = new Size(150, 40);
            button9.TabIndex = 58;
            button9.Text = "الفواتير";
            button9.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.WhiteSmoke;
            lblTotal.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.RoyalBlue;
            lblTotal.Location = new Point(399, 361);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(303, 35);
            lblTotal.TabIndex = 57;
            lblTotal.Text = "الاجمالي";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPartCost
            // 
            lblPartCost.BackColor = Color.WhiteSmoke;
            lblPartCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPartCost.ForeColor = Color.RoyalBlue;
            lblPartCost.Location = new Point(399, 254);
            lblPartCost.Name = "lblPartCost";
            lblPartCost.Size = new Size(303, 35);
            lblPartCost.TabIndex = 56;
            lblPartCost.Text = "سعر قطعه الغيار";
            lblPartCost.TextAlign = ContentAlignment.TopRight;
            // 
            // lblProblem
            // 
            lblProblem.BackColor = Color.WhiteSmoke;
            lblProblem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblProblem.ForeColor = Color.RoyalBlue;
            lblProblem.Location = new Point(214, 144);
            lblProblem.Name = "lblProblem";
            lblProblem.Size = new Size(238, 44);
            lblProblem.TabIndex = 55;
            lblProblem.Text = "المشكله ";
            lblProblem.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BackColor = Color.RoyalBlue;
            btnPrintInvoice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.Location = new Point(208, 428);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(139, 39);
            btnPrintInvoice.TabIndex = 54;
            btnPrintInvoice.Text = "طباعه الفاتوره";
            btnPrintInvoice.UseVisualStyleBackColor = false;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // btnClearInvoice
            // 
            btnClearInvoice.BackColor = Color.RoyalBlue;
            btnClearInvoice.ForeColor = Color.White;
            btnClearInvoice.Location = new Point(617, 41);
            btnClearInvoice.Name = "btnClearInvoice";
            btnClearInvoice.Size = new Size(85, 37);
            btnClearInvoice.TabIndex = 53;
            btnClearInvoice.Text = "مسح";
            btnClearInvoice.UseVisualStyleBackColor = false;
            btnClearInvoice.Click += btnClearInvoice_Click;
            // 
            // btnLoadInvoice
            // 
            btnLoadInvoice.BackColor = Color.RoyalBlue;
            btnLoadInvoice.ForeColor = Color.White;
            btnLoadInvoice.Location = new Point(481, 41);
            btnLoadInvoice.Name = "btnLoadInvoice";
            btnLoadInvoice.Size = new Size(121, 37);
            btnLoadInvoice.TabIndex = 52;
            btnLoadInvoice.Text = "عرض الفاتوره";
            btnLoadInvoice.UseVisualStyleBackColor = false;
            btnLoadInvoice.Click += btnLoadInvoice_Click;
            // 
            // txtInvoiceSearch
            // 
            txtInvoiceSearch.Location = new Point(214, 46);
            txtInvoiceSearch.Name = "txtInvoiceSearch";
            txtInvoiceSearch.Size = new Size(261, 27);
            txtInvoiceSearch.TabIndex = 51;
            txtInvoiceSearch.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLaborCost
            // 
            txtLaborCost.BackColor = Color.WhiteSmoke;
            txtLaborCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtLaborCost.ForeColor = Color.RoyalBlue;
            txtLaborCost.Location = new Point(399, 306);
            txtLaborCost.Multiline = true;
            txtLaborCost.Name = "txtLaborCost";
            txtLaborCost.Size = new Size(182, 40);
            txtLaborCost.TabIndex = 50;
            txtLaborCost.Click += txtLaborCost_TextChanged;
            txtLaborCost.TextChanged += txtLaborCost_TextChanged;
            // 
            // lblDevice
            // 
            lblDevice.BackColor = Color.WhiteSmoke;
            lblDevice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDevice.ForeColor = Color.RoyalBlue;
            lblDevice.ImageAlign = ContentAlignment.TopCenter;
            lblDevice.Location = new Point(538, 86);
            lblDevice.Name = "lblDevice";
            lblDevice.Size = new Size(164, 44);
            lblDevice.TabIndex = 49;
            lblDevice.Text = "نوع الجهاز";
            lblDevice.TextAlign = ContentAlignment.TopRight;
            // 
            // lblClientName
            // 
            lblClientName.BackColor = Color.WhiteSmoke;
            lblClientName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblClientName.ForeColor = Color.RoyalBlue;
            lblClientName.ImageAlign = ContentAlignment.TopCenter;
            lblClientName.Location = new Point(214, 86);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(185, 44);
            lblClientName.TabIndex = 48;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.WhiteSmoke;
            lblPhone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPhone.ForeColor = Color.RoyalBlue;
            lblPhone.ImageAlign = ContentAlignment.TopCenter;
            lblPhone.Location = new Point(399, 86);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(145, 44);
            lblPhone.TabIndex = 47;
            // 
            // lblSerial
            // 
            lblSerial.BackColor = Color.WhiteSmoke;
            lblSerial.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSerial.ForeColor = Color.RoyalBlue;
            lblSerial.Location = new Point(452, 144);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(250, 44);
            lblSerial.TabIndex = 46;
            lblSerial.Text = "سيريال";
            lblSerial.TextAlign = ContentAlignment.TopRight;
            // 
            // label11
            // 
            label11.BackColor = Color.WhiteSmoke;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.ForeColor = Color.RoyalBlue;
            label11.Location = new Point(579, 309);
            label11.Name = "label11";
            label11.Size = new Size(128, 40);
            label11.TabIndex = 45;
            label11.Text = "تكلفه التغير";
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.RoyalBlue;
            label10.Location = new Point(522, 198);
            label10.Name = "label10";
            label10.Size = new Size(185, 35);
            label10.TabIndex = 44;
            label10.Text = "تفاصيل الفاتوره";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.RoyalBlue;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(10, 90);
            button5.Name = "button5";
            button5.Size = new Size(150, 40);
            button5.TabIndex = 43;
            button5.Text = "عرض الطلبات ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += showorder;
            // 
            // button6
            // 
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.BackColor = Color.RoyalBlue;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(10, 30);
            button6.Name = "button6";
            button6.Size = new Size(150, 40);
            button6.TabIndex = 42;
            button6.Text = "اضافه طلب";
            button6.UseVisualStyleBackColor = false;
            button6.Click += adorder;
            // 
            // Reports
            // 
            Reports.Controls.Add(button13);
            Reports.Controls.Add(button7);
            Reports.Controls.Add(button11);
            Reports.Controls.Add(button12);
            Reports.Controls.Add(lblRevenue);
            Reports.Controls.Add(lblClients);
            Reports.Controls.Add(btnRefreshReports);
            Reports.Controls.Add(dgvReports);
            Reports.Controls.Add(lblPending);
            Reports.Controls.Add(lblDone);
            Reports.Controls.Add(lblTotalOrders);
            Reports.Location = new Point(4, 29);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3);
            Reports.Size = new Size(717, 595);
            Reports.TabIndex = 3;
            Reports.Text = "Reports";
            Reports.UseVisualStyleBackColor = true;
            Reports.Click += Reports_Click;
            // 
            // button13
            // 
            button13.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button13.BackColor = Color.RoyalBlue;
            button13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button13.ForeColor = Color.White;
            button13.Location = new Point(10, 210);
            button13.Name = "button13";
            button13.Size = new Size(150, 40);
            button13.TabIndex = 62;
            button13.Text = "التقارير";
            button13.UseVisualStyleBackColor = false;
            button13.Click += Reports_Click;
            // 
            // button7
            // 
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.BackColor = Color.RoyalBlue;
            button7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(10, 150);
            button7.Name = "button7";
            button7.Size = new Size(150, 40);
            button7.TabIndex = 61;
            button7.Text = "الفواتير";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btninv;
            // 
            // button11
            // 
            button11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button11.BackColor = Color.RoyalBlue;
            button11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button11.ForeColor = Color.White;
            button11.Location = new Point(10, 90);
            button11.Name = "button11";
            button11.Size = new Size(150, 40);
            button11.TabIndex = 60;
            button11.Text = "عرض الطلبات ";
            button11.UseVisualStyleBackColor = false;
            button11.Click += showorder;
            // 
            // button12
            // 
            button12.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button12.BackColor = Color.RoyalBlue;
            button12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button12.ForeColor = Color.White;
            button12.Location = new Point(10, 30);
            button12.Name = "button12";
            button12.Size = new Size(150, 40);
            button12.TabIndex = 59;
            button12.Text = "اضافه طلب";
            button12.UseVisualStyleBackColor = false;
            button12.Click += addoeder;
            // 
            // lblRevenue
            // 
            lblRevenue.BackColor = Color.DodgerBlue;
            lblRevenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRevenue.ForeColor = Color.White;
            lblRevenue.ImageAlign = ContentAlignment.TopCenter;
            lblRevenue.Location = new Point(226, 77);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(285, 40);
            lblRevenue.TabIndex = 7;
            lblRevenue.Text = "اجمالي الاردادات";
            // 
            // lblClients
            // 
            lblClients.BackColor = Color.DodgerBlue;
            lblClients.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblClients.ForeColor = Color.White;
            lblClients.ImageAlign = ContentAlignment.TopCenter;
            lblClients.Location = new Point(511, 77);
            lblClients.Name = "lblClients";
            lblClients.Size = new Size(200, 40);
            lblClients.TabIndex = 6;
            lblClients.Text = "عدد العملاء";
            lblClients.TextAlign = ContentAlignment.TopRight;
            // 
            // btnRefreshReports
            // 
            btnRefreshReports.BackColor = Color.RoyalBlue;
            btnRefreshReports.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRefreshReports.ForeColor = Color.White;
            btnRefreshReports.Location = new Point(226, 444);
            btnRefreshReports.Name = "btnRefreshReports";
            btnRefreshReports.Size = new Size(105, 33);
            btnRefreshReports.TabIndex = 4;
            btnRefreshReports.Text = "refresh";
            btnRefreshReports.UseVisualStyleBackColor = false;
            btnRefreshReports.Click += btnRefreshReports_Click;
            // 
            // dgvReports
            // 
            dgvReports.BackgroundColor = Color.White;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(226, 120);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(485, 308);
            dgvReports.TabIndex = 3;
            // 
            // lblPending
            // 
            lblPending.BackColor = Color.DodgerBlue;
            lblPending.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPending.ForeColor = Color.White;
            lblPending.Location = new Point(561, 37);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(150, 40);
            lblPending.TabIndex = 2;
            lblPending.Text = "قيد الاصلاح ";
            lblPending.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDone
            // 
            lblDone.BackColor = Color.DodgerBlue;
            lblDone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDone.ForeColor = Color.White;
            lblDone.Location = new Point(411, 37);
            lblDone.Name = "lblDone";
            lblDone.Size = new Size(150, 40);
            lblDone.TabIndex = 1;
            lblDone.Text = "تم التسليم ";
            lblDone.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.BackColor = Color.DodgerBlue;
            lblTotalOrders.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalOrders.ForeColor = Color.White;
            lblTotalOrders.Location = new Point(226, 37);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(186, 40);
            lblTotalOrders.TabIndex = 0;
            lblTotalOrders.Text = "اجمالي الطلبات ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 619);
            Controls.Add(tabControl1);
            Name = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Invoice.ResumeLayout(false);
            Invoice.PerformLayout();
            Reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnShowOrders;
        private Button button1;
        private Button clear;
        private Button save_Click;
        private ComboBox Devicetype;
        private ComboBox proplem;
        private TextBox Phone;
        private DateTimePicker dateTimePicker1;
        private TextBox notes;
        private TextBox cost;
        private Label label7;
        private Label data;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private TextBox serial;
        private Label label2;
        private TextBox ClientName;
        private Label label1;
        private TabPage tabPage2;
        private Button button2;
        private Button button3;
        private TextBox txtsearch;
        private Label label8;
        private Button btnRefresh;
        private Button btnsearch;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label9;
        private TabPage Invoice;
        private Button button5;
        private Button button6;
        private Label lblProblem;
        private Button btnPrintInvoice;
        private Button btnClearInvoice;
        private Button btnLoadInvoice;
        private TextBox txtInvoiceSearch;
        private TextBox txtLaborCost;
        private Label lblDevice;
        private Label lblClientName;
        private Label lblPhone;
        private Label lblSerial;
        private Label label11;
        private Label label10;
        private Label lblPartCost;
        private Label lblTotal;
        private Button Invoices;
        private Button button8;
        private Button button9;
        private TabPage Reports;
        private Label lblPending;
        private Label lblDone;
        private Label lblTotalOrders;
        private Button btnRefreshReports;
        private DataGridView dgvReports;
        private Label lblRevenue;
        private Label lblClients;
        private Button button7;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button16;
        private Button button15;
    }
}