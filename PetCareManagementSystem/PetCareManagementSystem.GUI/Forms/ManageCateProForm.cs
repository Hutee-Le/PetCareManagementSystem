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
    public partial class ManageCateProForm : Form
    {
        public ManageCateProForm()
        {
            InitializeComponent();
            cateproBus = new CateProBUS();
            productBus = new ProductBUS();
        }
        private CateProBUS cateproBus;
        private ProductBUS productBus;
    

        private void treeViewCate_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            //txtClass.Text = node.Tag.ToString();
            //selectedNode = node;
            List<Product> prolist1 = productBus.GetProByCateId((int)node.Tag);
            lsvProduct.View = View.Details;
            lsvProduct.Items.Clear();
            int count = 0;

            foreach (Product pro1 in prolist1)
            {
                ListViewItem item = new ListViewItem(pro1.ProductId.ToString());
                //item.ImageIndex = count;
                //item.ImageKey = "iconKey";


                item.SubItems.Add(pro1.ProductName.ToString());
                item.SubItems.Add(pro1.Description.ToString());
                item.SubItems.Add(pro1.UnitPrice.ToString());
                item.SubItems.Add(pro1.QuantityInStock.ToString());
                lsvProduct.Items.Add(item);
                //  txtClass.Text = node.Tag.ToString();

                count++;
            }
        }

        private void ManageCateProForm_Load(object sender, EventArgs e)
        {

            List<CategoryProduct> catelist = cateproBus.getAll();
            foreach (CategoryProduct c in catelist)
            {
                TreeNode tn = new TreeNode(c.CateProName);
                tn.Name = c.CateProName;
                tn.Tag = c.CateProId;
                List<Product> productlist = productBus.GetProByCateId(c.CateProId);
                foreach (Product product in productlist)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Name = product.ProductName;
                    childNode.Tag = product.ProductId;
                    tn.Nodes.Add(childNode);
                }
                treeViewCate.Nodes.Add(tn);
            }
            // treeView1.SelectedNode = treeView1.Nodes[0];
            // treeView1.ExpandAll();


            List<Product> prolist = productBus.getAll();
            lsvProduct.View = View.Details;
            int count = 0;

            foreach (Product pro in prolist)
            {
                ListViewItem item = new ListViewItem(pro.ProductId.ToString());
                //item.ImageIndex = count;
                //item.ImageKey = "iconKey";
                item.SubItems.Add(pro.ProductName.ToString());
                item.SubItems.Add(pro.Description.ToString());
                item.SubItems.Add(pro.UnitPrice.ToString());
                item.SubItems.Add(pro.QuantityInStock.ToString());
                lsvProduct.Items.Add(item);
                count++;
            }
        }

        private void lsvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
