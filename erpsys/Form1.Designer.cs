namespace ErpSys
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            btnShowOrders = new Button();
            Invoices = new Button();
            button16 = new Button();
            label1 = new Label();
            ClientName = new TextBox();
            label6 = new Label();
            Phone = new TextBox();
            label2 = new Label();
            Devicetype = new ComboBox();
            label7 = new Label();
            proplem = new ComboBox();
            label3 = new Label();
            cost = new TextBox();
            data = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            serial = new TextBox();
            label5 = new Label();
            notes = new TextBox();
            save = new Button();
            clear = new Button();
            tabPage2 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button8 = new Button();
            button15 = new Button();
            label9 = new Label();
            txtsearch = new TextBox();
            btnsearch = new Button();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            Invoice = new TabPage();
            button6 = new Button();
            button5 = new Button();
            button9 = new Button();
            button14 = new Button();
            txtInvoiceSearch = new TextBox();
            btnLoadInvoice = new Button();
            btnClearInvoice = new Button();
            lblClientName = new Label();
            lblPhone = new Label();
            lblDevice = new Label();
            lblProblem = new Label();
            lblSerial = new Label();
            label11 = new Label();
            lblPartCost = new Label();
            txtLaborCost = new TextBox();
            lblTotal = new Label();
            btnPrintInvoice = new Button();
            Reports = new TabPage();
            button12 = new Button();
            button11 = new Button();
            button7 = new Button();
            button13 = new Button();
            lblTotalOrders = new Label();
            lblDone = new Label();
            lblPending = new Label();
            lblClients = new Label();
            lblRevenue = new Label();
            button10 = new Button();
            btnRefreshReports = new Button();
            dgvReports = new DataGridView();
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
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(760, 650);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(245, 247, 250);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btnShowOrders);
            tabPage1.Controls.Add(Invoices);
            tabPage1.Controls.Add(button16);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(ClientName);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(Phone);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(Devicetype);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(proplem);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cost);
            tabPage1.Controls.Add(data);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(serial);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(notes);
            tabPage1.Controls.Add(save);
            tabPage1.Controls.Add(clear);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(752, 617);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "  + طلب جديد  ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(221, 232, 247);
            button1.FlatAppearance.BorderColor = Color.FromArgb(26, 95, 168);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(26, 95, 168);
            button1.Location = new Point(12, 30);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(155, 40);
            button1.TabIndex = 1;
            button1.Text = "➕  طلب جديد";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnShowOrders
            // 
            btnShowOrders.BackColor = Color.FromArgb(240, 244, 250);
            btnShowOrders.FlatAppearance.BorderSize = 0;
            btnShowOrders.FlatStyle = FlatStyle.Flat;
            btnShowOrders.Font = new Font("Segoe UI", 10F);
            btnShowOrders.ForeColor = Color.FromArgb(58, 74, 107);
            btnShowOrders.Location = new Point(12, 80);
            btnShowOrders.Name = "btnShowOrders";
            btnShowOrders.RightToLeft = RightToLeft.Yes;
            btnShowOrders.Size = new Size(155, 40);
            btnShowOrders.TabIndex = 2;
            btnShowOrders.Text = "☰  كل الطلبات";
            btnShowOrders.UseVisualStyleBackColor = false;
            btnShowOrders.Click += showorder;
            // 
            // Invoices
            // 
            Invoices.BackColor = Color.FromArgb(240, 244, 250);
            Invoices.FlatAppearance.BorderSize = 0;
            Invoices.FlatStyle = FlatStyle.Flat;
            Invoices.Font = new Font("Segoe UI", 10F);
            Invoices.ForeColor = Color.FromArgb(58, 74, 107);
            Invoices.Location = new Point(12, 130);
            Invoices.Name = "Invoices";
            Invoices.RightToLeft = RightToLeft.Yes;
            Invoices.Size = new Size(155, 40);
            Invoices.TabIndex = 3;
            Invoices.Text = "▶  الفواتير";
            Invoices.UseVisualStyleBackColor = false;
            Invoices.Click += Invoicesbtn;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(240, 244, 250);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 10F);
            button16.ForeColor = Color.FromArgb(58, 74, 107);
            button16.Location = new Point(12, 180);
            button16.Name = "button16";
            button16.RightToLeft = RightToLeft.Yes;
            button16.Size = new Size(155, 40);
            button16.TabIndex = 4;
            button16.Text = "●  التقارير";
            button16.UseVisualStyleBackColor = false;
            button16.Click += Reports_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(107, 122, 153);
            label1.Location = new Point(652, 40);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 5;
            label1.Text = "اسم العميل";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ClientName
            // 
            ClientName.Location = new Point(442, 40);
            ClientName.Name = "ClientName";
            ClientName.Size = new Size(205, 27);
            ClientName.TabIndex = 10;
            ClientName.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(107, 122, 153);
            label6.Location = new Point(330, 40);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 11;
            label6.Text = "رقم الهاتف";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Phone
            // 
            Phone.Location = new Point(195, 40);
            Phone.MaxLength = 12;
            Phone.Name = "Phone";
            Phone.Size = new Size(130, 27);
            Phone.TabIndex = 11;
            Phone.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(107, 122, 153);
            label2.Location = new Point(652, 90);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 12;
            label2.Text = "نوع الجهاز";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Devicetype
            // 
            Devicetype.FormattingEnabled = true;
            Devicetype.Location = new Point(442, 90);
            Devicetype.Name = "Devicetype";
            Devicetype.Size = new Size(205, 28);
            Devicetype.TabIndex = 12;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(107, 122, 153);
            label7.Location = new Point(330, 90);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 13;
            label7.Text = "نوع المشكلة";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // proplem
            // 
            proplem.FormattingEnabled = true;
            proplem.Location = new Point(195, 90);
            proplem.Name = "proplem";
            proplem.Size = new Size(130, 28);
            proplem.TabIndex = 13;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(107, 122, 153);
            label3.Location = new Point(652, 140);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 14;
            label3.Text = "سعر الإصلاح";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cost
            // 
            cost.Location = new Point(442, 140);
            cost.Name = "cost";
            cost.Size = new Size(205, 27);
            cost.TabIndex = 14;
            cost.TextAlign = HorizontalAlignment.Right;
            // 
            // data
            // 
            data.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            data.ForeColor = Color.FromArgb(107, 122, 153);
            data.Location = new Point(330, 140);
            data.Name = "data";
            data.Size = new Size(90, 20);
            data.TabIndex = 15;
            data.Text = "التاريخ";
            data.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(195, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(107, 122, 153);
            label4.Location = new Point(652, 190);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 16;
            label4.Text = "سيريال الجهاز";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // serial
            // 
            serial.Location = new Point(195, 190);
            serial.Name = "serial";
            serial.Size = new Size(452, 27);
            serial.TabIndex = 16;
            serial.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(107, 122, 153);
            label5.Location = new Point(652, 240);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 17;
            label5.Text = "ملاحظات";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // notes
            // 
            notes.Location = new Point(195, 240);
            notes.Name = "notes";
            notes.Size = new Size(452, 27);
            notes.TabIndex = 17;
            notes.TextAlign = HorizontalAlignment.Right;
            // 
            // save
            // 
            save.BackColor = Color.RoyalBlue;
            save.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.ForeColor = SystemColors.ButtonFace;
            save.Location = new Point(572, 300);
            save.Name = "save";
            save.Size = new Size(140, 38);
            save.TabIndex = 18;
            save.Text = "💾   حفظ الطلب";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click_11;
            // 
            // clear
            // 
            clear.BackColor = Color.RoyalBlue;
            clear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = SystemColors.ButtonHighlight;
            clear.Location = new Point(417, 300);
            clear.Name = "clear";
            clear.Size = new Size(140, 38);
            clear.TabIndex = 19;
            clear.Text = "🗑   مسح";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(245, 247, 250);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button15);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtsearch);
            tabPage2.Controls.Add(btnsearch);
            tabPage2.Controls.Add(btnRefresh);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(752, 617);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "  ☰ الطلبات  ";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(240, 244, 250);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.FromArgb(58, 74, 107);
            button3.Location = new Point(12, 30);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(155, 40);
            button3.TabIndex = 1;
            button3.Text = "➕  طلب جديد";
            button3.UseVisualStyleBackColor = false;
            button3.Click += addoeder;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(221, 232, 247);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(26, 95, 168);
            button2.Location = new Point(12, 80);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(155, 40);
            button2.TabIndex = 2;
            button2.Text = "☰  كل الطلبات";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_11;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(240, 244, 250);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10F);
            button8.ForeColor = Color.FromArgb(58, 74, 107);
            button8.Location = new Point(12, 130);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.Yes;
            button8.Size = new Size(155, 40);
            button8.TabIndex = 3;
            button8.Text = "▶  الفواتير";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btninv;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(240, 244, 250);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 10F);
            button15.ForeColor = Color.FromArgb(58, 74, 107);
            button15.Location = new Point(12, 180);
            button15.Name = "button15";
            button15.RightToLeft = RightToLeft.Yes;
            button15.Size = new Size(155, 40);
            button15.TabIndex = 4;
            button15.Text = "●  التقارير";
            button15.UseVisualStyleBackColor = false;
            button15.Click += Reports_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(107, 122, 153);
            label9.Location = new Point(560, 55);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 6;
            label9.Text = "بحث باسم العميل";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(310, 53);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(240, 27);
            txtsearch.TabIndex = 5;
            txtsearch.TextAlign = HorizontalAlignment.Right;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(195, 53);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(110, 27);
            btnsearch.TabIndex = 6;
            btnsearch.Text = "🔍   بحث";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Clickk;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.RoyalBlue;
            btnRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(195, 560);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 49);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "↺   تحديث";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Clickk;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(195, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(540, 455);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Invoice
            // 
            Invoice.BackColor = Color.FromArgb(245, 247, 250);
            Invoice.Controls.Add(button6);
            Invoice.Controls.Add(button5);
            Invoice.Controls.Add(button9);
            Invoice.Controls.Add(button14);
            Invoice.Controls.Add(txtInvoiceSearch);
            Invoice.Controls.Add(btnLoadInvoice);
            Invoice.Controls.Add(btnClearInvoice);
            Invoice.Controls.Add(lblClientName);
            Invoice.Controls.Add(lblPhone);
            Invoice.Controls.Add(lblDevice);
            Invoice.Controls.Add(lblProblem);
            Invoice.Controls.Add(lblSerial);
            Invoice.Controls.Add(label11);
            Invoice.Controls.Add(lblPartCost);
            Invoice.Controls.Add(txtLaborCost);
            Invoice.Controls.Add(lblTotal);
            Invoice.Controls.Add(btnPrintInvoice);
            Invoice.Location = new Point(4, 29);
            Invoice.Name = "Invoice";
            Invoice.Size = new Size(752, 617);
            Invoice.TabIndex = 2;
            Invoice.Text = "  ▶ الفواتير  ";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(240, 244, 250);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10F);
            button6.ForeColor = Color.FromArgb(58, 74, 107);
            button6.Location = new Point(12, 30);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.Yes;
            button6.Size = new Size(155, 40);
            button6.TabIndex = 1;
            button6.Text = "➕  طلب جديد";
            button6.UseVisualStyleBackColor = false;
            button6.Click += adorder;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(240, 244, 250);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F);
            button5.ForeColor = Color.FromArgb(58, 74, 107);
            button5.Location = new Point(12, 80);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.Yes;
            button5.Size = new Size(155, 40);
            button5.TabIndex = 2;
            button5.Text = "☰  كل الطلبات";
            button5.UseVisualStyleBackColor = false;
            button5.Click += showorder;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(221, 232, 247);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button9.ForeColor = Color.FromArgb(26, 95, 168);
            button9.Location = new Point(12, 130);
            button9.Name = "button9";
            button9.RightToLeft = RightToLeft.Yes;
            button9.Size = new Size(155, 40);
            button9.TabIndex = 3;
            button9.Text = "▶  الفواتير";
            button9.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(240, 244, 250);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 10F);
            button14.ForeColor = Color.FromArgb(58, 74, 107);
            button14.Location = new Point(12, 180);
            button14.Name = "button14";
            button14.RightToLeft = RightToLeft.Yes;
            button14.Size = new Size(155, 40);
            button14.TabIndex = 4;
            button14.Text = "●  التقارير";
            button14.UseVisualStyleBackColor = false;
            button14.Click += Reports_Click;
            // 
            // txtInvoiceSearch
            // 
            txtInvoiceSearch.Location = new Point(310, 50);
            txtInvoiceSearch.Name = "txtInvoiceSearch";
            txtInvoiceSearch.Size = new Size(240, 27);
            txtInvoiceSearch.TabIndex = 5;
            txtInvoiceSearch.TextAlign = HorizontalAlignment.Right;
            // 
            // btnLoadInvoice
            // 
            btnLoadInvoice.Location = new Point(195, 50);
            btnLoadInvoice.Name = "btnLoadInvoice";
            btnLoadInvoice.Size = new Size(110, 27);
            btnLoadInvoice.TabIndex = 6;
            btnLoadInvoice.Text = "🔍   بحث";
            btnLoadInvoice.UseVisualStyleBackColor = false;
            btnLoadInvoice.Click += btnLoadInvoice_Click;
            // 
            // btnClearInvoice
            // 
            btnClearInvoice.Location = new Point(560, 50);
            btnClearInvoice.Name = "btnClearInvoice";
            btnClearInvoice.Size = new Size(80, 27);
            btnClearInvoice.TabIndex = 7;
            btnClearInvoice.Text = "↺   مسح";
            btnClearInvoice.UseVisualStyleBackColor = false;
            btnClearInvoice.Click += btnClearInvoice_Click;
            // 
            // lblClientName
            // 
            lblClientName.BackColor = Color.WhiteSmoke;
            lblClientName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblClientName.ForeColor = SystemColors.ControlDarkDark;
            lblClientName.ImageAlign = ContentAlignment.TopLeft;
            lblClientName.Location = new Point(430, 89);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(210, 40);
            lblClientName.TabIndex = 8;
            lblClientName.Text = "العميل: ";
            lblClientName.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.WhiteSmoke;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhone.ForeColor = SystemColors.ControlDarkDark;
            lblPhone.ImageAlign = ContentAlignment.MiddleRight;
            lblPhone.Location = new Point(195, 100);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(210, 40);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "الهاتف: ";
            lblPhone.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDevice
            // 
            lblDevice.BackColor = Color.WhiteSmoke;
            lblDevice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDevice.ForeColor = SystemColors.ControlDarkDark;
            lblDevice.Location = new Point(430, 150);
            lblDevice.Name = "lblDevice";
            lblDevice.Size = new Size(210, 45);
            lblDevice.TabIndex = 10;
            lblDevice.Text = "الجهاز: ";
            lblDevice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblProblem
            // 
            lblProblem.BackColor = Color.WhiteSmoke;
            lblProblem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProblem.ForeColor = SystemColors.ControlDarkDark;
            lblProblem.ImageAlign = ContentAlignment.MiddleRight;
            lblProblem.Location = new Point(195, 150);
            lblProblem.Name = "lblProblem";
            lblProblem.Size = new Size(210, 45);
            lblProblem.TabIndex = 11;
            lblProblem.Text = "المشكلة: ";
            lblProblem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSerial
            // 
            lblSerial.BackColor = Color.WhiteSmoke;
            lblSerial.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSerial.ForeColor = SystemColors.ControlDarkDark;
            lblSerial.Location = new Point(292, 210);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(273, 30);
            lblSerial.TabIndex = 12;
            lblSerial.Text = "السيريال: ";
            lblSerial.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(107, 122, 153);
            label11.Location = new Point(366, 305);
            label11.Name = "label11";
            label11.Size = new Size(130, 25);
            label11.TabIndex = 13;
            label11.Text = "تكلفة التغيير";
            label11.TextAlign = ContentAlignment.MiddleRight;
            label11.UseWaitCursor = true;
            // 
            // lblPartCost
            // 
            lblPartCost.BackColor = Color.WhiteSmoke;
            lblPartCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPartCost.ForeColor = SystemColors.ControlDarkDark;
            lblPartCost.Location = new Point(215, 260);
            lblPartCost.Name = "lblPartCost";
            lblPartCost.Size = new Size(210, 25);
            lblPartCost.TabIndex = 14;
            lblPartCost.Text = "سعر قطعة الغيار: ";
            lblPartCost.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLaborCost
            // 
            txtLaborCost.Location = new Point(195, 303);
            txtLaborCost.Name = "txtLaborCost";
            txtLaborCost.Size = new Size(150, 27);
            txtLaborCost.TabIndex = 8;
            txtLaborCost.TextAlign = HorizontalAlignment.Right;
            txtLaborCost.TextChanged += txtLaborCost_TextChanged;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(26, 95, 168);
            lblTotal.Location = new Point(195, 355);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(445, 30);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "الإجمالي: ";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BackColor = Color.RoyalBlue;
            btnPrintInvoice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.Location = new Point(195, 405);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(180, 38);
            btnPrintInvoice.TabIndex = 9;
            btnPrintInvoice.Text = "🖨   طباعة الفاتورة";
            btnPrintInvoice.UseVisualStyleBackColor = false;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // Reports
            // 
            Reports.BackColor = Color.FromArgb(245, 247, 250);
            Reports.Controls.Add(button12);
            Reports.Controls.Add(button11);
            Reports.Controls.Add(button7);
            Reports.Controls.Add(button13);
            Reports.Controls.Add(lblTotalOrders);
            Reports.Controls.Add(lblDone);
            Reports.Controls.Add(lblPending);
            Reports.Controls.Add(lblClients);
            Reports.Controls.Add(lblRevenue);
            Reports.Controls.Add(button10);
            Reports.Controls.Add(btnRefreshReports);
            Reports.Controls.Add(dgvReports);
            Reports.Location = new Point(4, 29);
            Reports.Name = "Reports";
            Reports.Size = new Size(752, 617);
            Reports.TabIndex = 3;
            Reports.Text = "  ● التقارير  ";
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(240, 244, 250);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 10F);
            button12.ForeColor = Color.FromArgb(58, 74, 107);
            button12.Location = new Point(12, 30);
            button12.Name = "button12";
            button12.RightToLeft = RightToLeft.Yes;
            button12.Size = new Size(155, 40);
            button12.TabIndex = 1;
            button12.Text = "➕  طلب جديد";
            button12.UseVisualStyleBackColor = false;
            button12.Click += addoeder;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(240, 244, 250);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 10F);
            button11.ForeColor = Color.FromArgb(58, 74, 107);
            button11.Location = new Point(12, 80);
            button11.Name = "button11";
            button11.RightToLeft = RightToLeft.Yes;
            button11.Size = new Size(155, 40);
            button11.TabIndex = 2;
            button11.Text = "☰  كل الطلبات";
            button11.UseVisualStyleBackColor = false;
            button11.Click += showorder;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(240, 244, 250);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 10F);
            button7.ForeColor = Color.FromArgb(58, 74, 107);
            button7.Location = new Point(12, 130);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.Yes;
            button7.Size = new Size(155, 40);
            button7.TabIndex = 3;
            button7.Text = "▶  الفواتير";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btninv;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(221, 232, 247);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button13.ForeColor = Color.FromArgb(26, 95, 168);
            button13.Location = new Point(12, 180);
            button13.Name = "button13";
            button13.RightToLeft = RightToLeft.Yes;
            button13.Size = new Size(155, 40);
            button13.TabIndex = 4;
            button13.Text = "●  التقارير";
            button13.UseVisualStyleBackColor = false;
            button13.Click += Reports_Click;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.BackColor = Color.FromArgb(230, 241, 251);
            lblTotalOrders.BorderStyle = BorderStyle.FixedSingle;
            lblTotalOrders.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalOrders.ForeColor = Color.FromArgb(26, 95, 168);
            lblTotalOrders.Location = new Point(195, 30);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(160, 50);
            lblTotalOrders.TabIndex = 5;
            lblTotalOrders.Text = "إجمالي الطلبات";
            lblTotalOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDone
            // 
            lblDone.BackColor = Color.FromArgb(234, 243, 222);
            lblDone.BorderStyle = BorderStyle.FixedSingle;
            lblDone.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDone.ForeColor = Color.FromArgb(59, 109, 17);
            lblDone.Location = new Point(365, 30);
            lblDone.Name = "lblDone";
            lblDone.Size = new Size(160, 50);
            lblDone.TabIndex = 6;
            lblDone.Text = "تم التسليم";
            lblDone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPending
            // 
            lblPending.BackColor = Color.FromArgb(250, 238, 218);
            lblPending.BorderStyle = BorderStyle.FixedSingle;
            lblPending.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPending.ForeColor = Color.FromArgb(133, 79, 11);
            lblPending.Location = new Point(530, 30);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(105, 50);
            lblPending.TabIndex = 7;
            lblPending.Text = "قيد الإصلاح";
            lblPending.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClients
            // 
            lblClients.BackColor = Color.FromArgb(240, 244, 250);
            lblClients.BorderStyle = BorderStyle.FixedSingle;
            lblClients.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblClients.ForeColor = Color.FromArgb(26, 42, 74);
            lblClients.Location = new Point(195, 90);
            lblClients.Name = "lblClients";
            lblClients.Size = new Size(240, 50);
            lblClients.TabIndex = 8;
            lblClients.Text = "عدد العملاء";
            lblClients.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRevenue
            // 
            lblRevenue.BackColor = Color.FromArgb(230, 241, 251);
            lblRevenue.BorderStyle = BorderStyle.FixedSingle;
            lblRevenue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRevenue.ForeColor = Color.FromArgb(26, 95, 168);
            lblRevenue.Location = new Point(437, 90);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(195, 50);
            lblRevenue.TabIndex = 9;
            lblRevenue.Text = "إجمالي الإيرادات";
            lblRevenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            button10.Location = new Point(0, 0);
            button10.Name = "button10";
            button10.Size = new Size(0, 0);
            button10.TabIndex = 10;
            button10.Visible = false;
            // 
            // btnRefreshReports
            // 
            btnRefreshReports.BackColor = Color.RoyalBlue;
            btnRefreshReports.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshReports.ForeColor = SystemColors.ButtonHighlight;
            btnRefreshReports.Location = new Point(195, 518);
            btnRefreshReports.Name = "btnRefreshReports";
            btnRefreshReports.Size = new Size(160, 45);
            btnRefreshReports.TabIndex = 6;
            btnRefreshReports.Text = "↺   تحديث التقارير";
            btnRefreshReports.UseVisualStyleBackColor = false;
            btnRefreshReports.Click += btnRefreshReports_Click;
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(195, 155);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(445, 350);
            dgvReports.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 650);
            Controls.Add(tabControl1);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "`";
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
        private TabPage tabPage2;
        private TabPage Invoice;
        private TabPage Reports;

        // Tab 1
        private Button button1;
        private Button btnShowOrders;
        private Button Invoices;
        private Button button16;
        private Label label1;
        private TextBox ClientName;
        private Label label6;
        private TextBox Phone;
        private Label label2;
        private ComboBox Devicetype;
        private Label label7;
        private ComboBox proplem;
        private Label label3;
        private TextBox cost;
        private Label data;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox serial;
        private Label label5;
        private TextBox notes;
        private Button save;
        private Button clear;

        // Tab 2
        private Button button3;
        private Button button2;
        private Button button8;
        private Button button15;
        private Label label9;
        private TextBox txtsearch;
        private Button btnsearch;
        private Button btnRefresh;
        private DataGridView dataGridView1;

        // Tab 3
        private Button button6;
        private Button button5;
        private Button button9;
        private Button button14;
        private TextBox txtInvoiceSearch;
        private Button btnLoadInvoice;
        private Button btnClearInvoice;
        private Label lblClientName;
        private Label lblPhone;
        private Label lblDevice;
        private Label lblProblem;
        private Label lblSerial;
        private Label label11;
        private Label lblPartCost;
        private TextBox txtLaborCost;
        private Label lblTotal;
        private Button btnPrintInvoice;

        // Tab 4
        private Button button12;
        private Button button11;
        private Button button7;
        private Button button13;
        private Label lblTotalOrders;
        private Label lblDone;
        private Label lblPending;
        private Label lblClients;
        private Label lblRevenue;
        private Button button10;
        private Button btnRefreshReports;
        private DataGridView dgvReports;
    }
}