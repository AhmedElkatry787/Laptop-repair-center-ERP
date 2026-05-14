using System;
using System.Data;
using System.Data.SqlClient;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOrders("");
            LoadReports();
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
                            row.DefaultCellStyle.BackColor =
                                System.Drawing.Color.FromArgb(234, 243, 222);
                        else if (status == "قيد الإصلاح")
                            row.DefaultCellStyle.BackColor =
                                System.Drawing.Color.FromArgb(250, 238, 218);
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
                        lblClientName.Text = "العميل: \n" + reader["ClientName"].ToString();
                        lblPhone.Text = "الهاتف: \n" + reader["ClintNum"].ToString();
                        lblDevice.Text = "الجهاز:\n " + reader["Device"].ToString();
                        lblProblem.Text = "المشكلة:\n " + reader["proplem"].ToString();
                        lblSerial.Text = "السيريال:\n " + reader["serial"].ToString();
                        partCost = Convert.ToDecimal(reader["cost"]);
                        lblPartCost.Text = "سعر قطعة الغيار: " + partCost.ToString("N2") + " ج";
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
                    dgvReports.Font = new System.Drawing.Font("Segoe UI", 10);
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