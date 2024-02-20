using PetCareManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class ChartReceiptForm : Form
    {
        public ChartReceiptForm()
        {
            InitializeComponent();
            productBus = new ProductBUS();
            receiptBUS = new ReceiptBUS();
            cateProBUS = new CateProBUS();

        }
        private ProductBUS productBus;
        private ReceiptBUS receiptBUS;
        private CateProBUS cateProBUS;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChartReceiptForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            int countPro = productBus.countPro();
            label2.Text = countPro.ToString();
            string countSumReceipt = receiptBUS.countSumReceipt();
            label3.Text = countSumReceipt.ToString();
            TypeCatechart.DataSource = cateProBUS.getCateName();

            TypeCatechart.Series[0].XValueMember = "CateProName"; // Tên loại sản phẩm
            TypeCatechart.Series[0].YValueMembers = "CateProID"; // Số lượng sản phẩm
            TypeCatechart.Series[0].IsValueShownAsLabel = true; // Hiển thị giá trị nhãn

            // Chỉ định loại biểu đồ là Doughnut
            TypeCatechart.Series[0].ChartType = SeriesChartType.Doughnut;

            // Cập nhật dữ liệu vào biểu đồ
            TypeCatechart.DataBind();
            NumberReceiptchart.DataSource = receiptBUS.getAll();
            NumberReceiptchart.Series[0].XValueMember = "ReceiptDate";
            NumberReceiptchart.Series[0].YValueMembers = "TotalAmount";

            NumberReceiptchart.DataBind();
        }
        private void Load7days()
        {
            var refreshData = receiptBUS.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                NumberReceiptchart.DataSource = receiptBUS.GetReceiptAnalisys();
                NumberReceiptchart.Series[0].XValueMember = "ReceiptDate";
                NumberReceiptchart.Series[0].YValueMembers = "TotalAmount";

                NumberReceiptchart.DataBind();
            }
        }
        private void LoadToday()
        {
            var refreshData = receiptBUS.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                NumberReceiptchart.DataSource = receiptBUS.GetReceiptToday();
                NumberReceiptchart.Series[0].XValueMember = "ReceiptDate";
                NumberReceiptchart.Series[0].YValueMembers = "TotalAmount";

                NumberReceiptchart.DataBind();
            }
        }

        private void LoadThismonth()
        {
            var refreshData = receiptBUS.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                NumberReceiptchart.DataSource = receiptBUS.GetReceiptbymonth();
                NumberReceiptchart.Series[0].XValueMember = "ReceiptDate";
                NumberReceiptchart.Series[0].YValueMembers = "TotalAmount";

                NumberReceiptchart.DataBind();
            }
        }

        private void btn1month_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadThismonth();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadToday();
        }

        private void btn7days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            Load7days();

        }
    }
}
