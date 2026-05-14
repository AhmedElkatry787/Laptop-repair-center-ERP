using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ErpSys
{
    public partial class Form1 : Form
    {
        string connStr = @"Server=DESKTOP-FRMO5O1\SQLEXPRESS; Database=dberrp; Integrated Security=True; TrustServerCertificate=True";
        private decimal partCost = 0;

        public Form1()
        {
            InitializeComponent();
            LoadComboBoxData();
            ApplyDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250); 
            tabPage1.BackColor = System.Drawing.Color.FromArgb(245, 247, 250); 
            tabPage2.BackColor = System.Drawing.Color.FromArgb(245, 247, 250); 
            Invoice.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);  
            Reports.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            LoadOrders("");
            LoadReports();
        }

    
        private void ApplyDesign()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Font = new Font("Segoe UI", 10F);
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 32);

            StyleTab1_AddOrder();
            StyleTab2_OrderList();
            StyleTab3_Invoice();
            StyleTab4_Reports();
        }

        private void StyleTab1_AddOrder()
        {
            tabPage1.BackColor = Color.FromArgb(245, 247, 250);
            tabPage1.Text = "  + طلب جديد  ";

            StyleTextBox(ClientName);
            StyleTextBox(Phone);
            StyleTextBox(serial);
            StyleTextBox(notes);
            StyleTextBox(cost);

            StyleComboBox(Devicetype);
            StyleComboBox(proplem);

            dateTimePicker1.Font = new Font("Segoe UI", 10F);

            StyleButtonPrimary(save, "💾   حفظ الطلب");
            StyleButtonDanger(clear, "🗑   مسح");
        }

        private void StyleTab2_OrderList()
        {
            tabPage2.BackColor = Color.FromArgb(245, 247, 250);
            tabPage2.Text = "  ☰ كل الطلبات  ";

            StyleTextBox(txtsearch);
            StyleButtonPrimary(btnsearch, "🔍   بحث");
            StyleButtonSecondary(btnRefresh, "↺   تحديث");
            StyleDataGrid(dataGridView1);
        }

        private void StyleTab3_Invoice()
        {
            Invoice.BackColor = Color.FromArgb(245, 247, 250);
            Invoice.Text = "  ▶ الفواتير  ";

            StyleTextBox(txtInvoiceSearch);
            StyleTextBox(txtLaborCost);

            StyleButtonPrimary(btnLoadInvoice, "🔍   بحث");
            StyleButtonSecondary(btnClearInvoice, "↺   مسح");
            StyleButtonPrimary(btnPrintInvoice, "🖨   طباعة الفاتورة");

            StyleLabelValue(lblClientName);
            StyleLabelValue(lblPhone);
            StyleLabelValue(lblDevice);
            StyleLabelValue(lblProblem);
            StyleLabelValue(lblSerial);
            StyleLabelValue(lblPartCost);
            StyleLabelTotal(lblTotal);
        }

        private void StyleTab4_Reports()
        {
            Reports.BackColor = Color.FromArgb(245, 247, 250);
            Reports.Text = "  ● التقارير  ";

            StyleLabelStat(lblTotalOrders);
            StyleLabelStat(lblDone);
            StyleLabelStat(lblPending);
            StyleLabelStat(lblClients);
            StyleLabelStat(lblRevenue);

            StyleButtonSecondary(btnRefreshReports, "↺   تحديث التقارير");
            StyleDataGrid(dgvReports);
        }

   
        private void StyleTextBox(TextBox txt)
        {
            txt.Font = new Font("Segoe UI", 10F);
            txt.BackColor = Color.FromArgb(247, 249, 252);
            txt.ForeColor = Color.FromArgb(26, 42, 74);
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StyleComboBox(ComboBox cmb)
        {
            cmb.Font = new Font("Segoe UI", 10F);
            cmb.BackColor = Color.FromArgb(247, 249, 252);
            cmb.ForeColor = Color.FromArgb(26, 42, 74);
            cmb.FlatStyle = FlatStyle.Flat;
        }

        private void StyleButtonPrimary(Button btn, string text)
        {
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(26, 95, 168);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 78, 140);
            btn.Height = 38;
            btn.Cursor = Cursors.Hand;
        }

        private void StyleButtonSecondary(Button btn, string text)
        {
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 10F);
            btn.BackColor = Color.FromArgb(240, 244, 250);
            btn.ForeColor = Color.FromArgb(58, 74, 107);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(200, 212, 232);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 232, 247);
            btn.Height = 38;
            btn.Cursor = Cursors.Hand;
        }

        private void StyleButtonDanger(Button btn, string text)
        {
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 10F);
            btn.BackColor = Color.FromArgb(220, 53, 69);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(185, 40, 55);
            btn.Height = 38;
            btn.Cursor = Cursors.Hand;
        }

        private void StyleLabelValue(Label lbl)
        {
            lbl.Font = new Font("Segoe UI", 10F);
            lbl.ForeColor = Color.FromArgb(26, 42, 74);
            lbl.AutoSize = true;
        }

        private void StyleLabelStat(Label lbl)
        {
            lbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(26, 95, 168);
            lbl.AutoSize = true;
        }

        private void StyleLabelTotal(Label lbl)
        {
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(26, 95, 168);
            lbl.AutoSize = true;
        }

        private void StyleDataGrid(DataGridView dgv)
        {
            dgv.Font = new Font("Segoe UI", 10F);
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(221, 228, 240);

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 250);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(107, 122, 153);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.ColumnHeadersHeight = 38;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(42, 53, 80);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(221, 232, 247);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(26, 42, 74);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            dgv.RowTemplate.Height = 36;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 253);

            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RightToLeft = RightToLeft.Yes;
        }

  
        private void LoadComboBoxData()
        {
            Devicetype.Items.AddRange(new string[] { "dell", "lenovo", "msi", "hp", "asus", "mac", "aser" });
            proplem.Items.AddRange(new string[] { "شاشة مكسورة", "بطارية", "هارد ديسك", "مشكلة نظام", "صوت", "شبكة", "أخرى" });
        }

        private void save_Click_11(object sender, EventArgs e)
        {
            decimal finalCost = 0;
            if (!decimal.TryParse(cost.Text, out finalCost))
            {
                MessageBox.Show("يرجى إدخال رقم صحيح في خانة السعر", "تنبيه");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO neworder 
                        (ClientName, ClintNum, Device, proplem, serial, notes, cost, data, Status)
                        VALUES 
                        (@ClientName, @ClintNum, @Device, @proplem, @serial, @notes, @cost, @data, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClientName", ClientName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ClintNum", Phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Device", Devicetype.Text ?? "");
                        cmd.Parameters.AddWithValue("@proplem", proplem.Text ?? "");
                        cmd.Parameters.AddWithValue("@serial", serial.Text.Trim());
                        cmd.Parameters.AddWithValue("@notes", notes.Text.Trim());
                        cmd.Parameters.AddWithValue("@cost", finalCost);
                        cmd.Parameters.AddWithValue("@data", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@Status", "قيد الإصلاح");
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("تم حفظ الطلب بنجاح!");
                LoadOrders("");
                LoadReports();
                clear_Click(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClientName.Clear(); Phone.Clear(); cost.Clear();
            notes.Clear(); serial.Clear();
            Devicetype.SelectedIndex = -1;
            proplem.SelectedIndex = -1;
        }

        private void LoadOrders(string search)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"SELECT 
                        ClientName  AS [اسم العميل],                  
                        Device      AS [الجهاز],
                        proplem     AS [المشكلة],
                        data        AS [التاريخ],
                        Status      AS [الحالة]
                    FROM neworder 
                    WHERE ClientName LIKE @Search 
                    ORDER BY data DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@Search", "%" + search + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string status = row.Cells["الحالة"].Value?.ToString();
                        if (status == "تم التسليم")
                            row.DefaultCellStyle.BackColor = Color.FromArgb(234, 243, 222);
                        else if (status == "قيد الإصلاح")
                            row.DefaultCellStyle.BackColor = Color.FromArgb(250, 238, 218);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnsearch_Clickk(object sender, EventArgs e)
        {
            LoadOrders(txtsearch.Text.Trim());
        }

        private void btnRefresh_Clickk(object sender, EventArgs e)
        {
            txtsearch.Clear();
            LoadOrders("");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string clientName = dataGridView1.Rows[e.RowIndex].Cells["اسم العميل"].Value.ToString();
            string currentStatus = dataGridView1.Rows[e.RowIndex].Cells["الحالة"].Value.ToString();
            string newStatus = currentStatus == "قيد الإصلاح" ? "تم التسليم" : "قيد الإصلاح";

            var confirm = MessageBox.Show(
                "تغيير حالة طلب ( " + clientName + " ) إلى:\n" + newStatus + "؟",
                "تأكيد",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string query = @"UPDATE neworder 
                                         SET Status = @Status 
                                         WHERE ClientName = @ClientName";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue("@ClientName", clientName);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("تم تغيير الحالة بنجاح!", "نجاح",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadOrders("");
                    LoadReports();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ: " + ex.Message, "خطأ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadInvoice_Click(object sender, EventArgs e)
        {
            string clientName = txtInvoiceSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(clientName))
            {
                MessageBox.Show("من فضلك ادخل اسم العميل", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"SELECT TOP 1 
                        ClientName, ClintNum, Device, proplem, serial, cost
                    FROM neworder 
                    WHERE ClientName LIKE @Name 
                    ORDER BY data DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", "%" + clientName + "%");
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblClientName.Text = "العميل:\n" + reader["ClientName"].ToString();
                        lblPhone.Text = "الهاتف:\n" + reader["ClintNum"].ToString();
                        lblDevice.Text = "الجهاز:\n" + reader["Device"].ToString();
                        lblProblem.Text = "المشكلة:\n" + reader["proplem"].ToString();
                        lblSerial.Text = "السيريال:   " + reader["serial"].ToString();
                        partCost = Convert.ToDecimal(reader["cost"]);
                        lblPartCost.Text = "سعر قطعة الغيار:           " + partCost.ToString("N2") + " ج";
                        CalculateTotal();
                    }
                    else
                    {
                        MessageBox.Show("مفيش طلبات لهذا العميل", "تنبيه",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ: " + ex.Message); }
        }

        private void CalculateTotal()
        {
            decimal laborCost = 0;
            decimal.TryParse(txtLaborCost.Text, out laborCost);
            lblTotal.Text = "الإجمالي: " + (partCost + laborCost).ToString("N2") + " جنيه";
        }

        private void txtLaborCost_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            txtInvoiceSearch.Clear();
            txtLaborCost.Clear();
            lblClientName.Text = "العميل: ";
            lblPhone.Text = "الهاتف: ";
            lblDevice.Text = "الجهاز: ";
            lblProblem.Text = "المشكلة: ";
            lblSerial.Text = "السيريال: ";
            lblPartCost.Text = "سعر قطعة الغيار: ";
            lblTotal.Text = "الإجمالي: ";
            partCost = 0;
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (lblClientName.Text == "العميل: ")
            {
                MessageBox.Show("من فضلك ابحث عن عميل أولاً", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal laborCost = 0;
            decimal.TryParse(txtLaborCost.Text, out laborCost);
            decimal total = partCost + laborCost;

            string invoice =
                "=============================\n" +
                "    فاتورة مركز الصيانة      \n" +
                "=============================\n" +
                lblClientName.Text + "\n" +
                lblPhone.Text + "\n" +
                lblDevice.Text + "\n" +
                lblProblem.Text + "\n" +
                lblSerial.Text + "\n" +
                "-----------------------------\n" +
                lblPartCost.Text + "\n" +
                "أجر الإصلاح: " + laborCost.ToString("N2") + " ج\n" +
                "-----------------------------\n" +
                "الإجمالي: " + total.ToString("N2") + " جنيه\n" +
                "=============================";

            MessageBox.Show(invoice, "الفاتورة",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadReports()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM neworder", conn);
                    lblTotalOrders.Text = "إجمالي الطلبات:  " + cmd1.ExecuteScalar().ToString();

                    SqlCommand cmd2 = new SqlCommand(
                        "SELECT COUNT(*) FROM neworder WHERE Status = N'تم التسليم'", conn);
                    lblDone.Text = "تم التسليم:  " + cmd2.ExecuteScalar().ToString();

                    SqlCommand cmd3 = new SqlCommand(
                        "SELECT COUNT(*) FROM neworder WHERE Status = N'قيد الإصلاح'", conn);
                    lblPending.Text = "قيد الإصلاح:  " + cmd3.ExecuteScalar().ToString();

                    SqlCommand cmd4 = new SqlCommand(
                        "SELECT COUNT(DISTINCT ClientName) FROM neworder", conn);
                    lblClients.Text = "عدد العملاء:  " + cmd4.ExecuteScalar().ToString();

                    SqlCommand cmd5 = new SqlCommand(
                        "SELECT ISNULL(SUM(cost), 0) FROM neworder", conn);
                    decimal revenue = Convert.ToDecimal(cmd5.ExecuteScalar());
                    lblRevenue.Text = "إجمالي الإيرادات:  " + revenue.ToString("N2") + " جنيه";

                    string query = @"SELECT 
                        Device       AS [نوع الجهاز],
                        COUNT(*)     AS [عدد الطلبات],
                        SUM(cost)    AS [إجمالي الإيرادات],
                        COUNT(CASE WHEN Status = N'تم التسليم'   THEN 1 END) AS [تم التسليم],
                        COUNT(CASE WHEN Status = N'قيد الإصلاح' THEN 1 END) AS [قيد الإصلاح]
                    FROM neworder
                    GROUP BY Device
                    ORDER BY COUNT(*) DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvReports.DataSource = dt;
                    dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvReports.ReadOnly = true;
                    dgvReports.AllowUserToAddRows = false;
                    dgvReports.RowHeadersVisible = false;
                    dgvReports.Font = new Font("Segoe UI", 10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshReports_Click(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void button2_Click_11(object sender, EventArgs e) { tabControl1.SelectedTab = tabPage2; }
        private void addoeder(object sender, EventArgs e) { tabControl1.SelectedTab = tabPage1; }
        private void btninv(object sender, EventArgs e) { tabControl1.SelectedTab = Invoice; }
        private void showorder(object sender, EventArgs e) { tabControl1.SelectedTab = tabPage2; }
        private void adorder(object sender, EventArgs e) { tabControl1.SelectedTab = tabPage1; }
        private void Invoicesbtn(object sender, EventArgs e) { tabControl1.SelectedTab = Invoice; }
        private void Reports_Click(object sender, EventArgs e) { tabControl1.SelectedTab = Reports; }

  
    }
}