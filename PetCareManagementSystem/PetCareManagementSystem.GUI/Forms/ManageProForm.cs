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
    public partial class ManageProForm : Form
    {
        public ManageProForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            productBus = new ProductBUS();
        }
        private ProductBUS productBus;
        private void ManageProForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productBus.getAll();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    productBus.DeleteProduct(id);
                }
            
            }
            dataGridView1.DataSource = productBus.getAll();
            if (e.ColumnIndex == 5)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa sản phẩm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Product pro = productBus.getProductByID(id);
                    UpdateProForm updatepro = new UpdateProForm(pro);
                    updatepro.ShowDialog();
                }

            }
            dataGridView1.DataSource = productBus.getAll();
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            AddProForm addpro = new AddProForm();
            addpro.ShowDialog();
        }
    }
}
