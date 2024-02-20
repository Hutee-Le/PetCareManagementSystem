using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            var random = new Random();
            Series series = chart1.Series["Series1"];
            series.Points.Clear();

            DateTime firstDayOfYear = new DateTime(DateTime.Now.Year, 1, 1);

            for (int i = 1; i <= 12; i++)
            {
                // Tạo mẫu dữ liệu ngẫu nhiên
                int sampleRevenue = random.Next(10000, 50000); 
                series.Points.AddXY(new DateTime(2024, i, 1), sampleRevenue); 
            }
        }

        private void LblBaoCao_Click(object sender, EventArgs e)
        {
            ChartReceiptForm receiptForm = new ChartReceiptForm();  
            receiptForm.ShowDialog();
        }
    }
}
