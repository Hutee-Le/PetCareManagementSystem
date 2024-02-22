using PetCareManagementSystem.BLL;
using PetCareManagementSystem.DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class ManageRecDetailForm : Form
    {
        public ManageRecDetailForm(ReceiptDetail receiptDetail)
        {
            InitializeComponent();
            this.receiptDetail = receiptDetail;
            receiptdetailBus = new ReceiptDetailBUS();
        }
        private ReceiptDetailBUS receiptdetailBus;
        private ReceiptDetail receiptDetail;
        private void listvRecDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManageRecDetailForm_Load(object sender, EventArgs e)
        {
            //listvRecDetail.View = View.Details;
            //List<Receipt> receipt = receiptBus.getAll();
            //int count = 0;

            //foreach (Receipt rec in receipt)
            //{
            //    ListViewItem item = new ListViewItem(rec.ReceiptId.ToString());

            //    string Employeename = receiptBus.GetEmployeenameByID(rec.EmployeeId);
            //    item.SubItems.Add(Employeename);
            //    item.SubItems.Add(rec.TotalAmount.ToString());
            //    item.SubItems.Add(rec.ReceiptDate.ToString());

            //    listvReceipt.Items.Add(item);
            //    //  txtClass.Text = node.Tag.ToString();

            //    count++;
            //}
        
        }
    }
}
