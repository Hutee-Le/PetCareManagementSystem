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
using System.Windows.Forms.DataVisualization.Charting;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class AddNewPetForm : Form
    {
        private readonly PetBUS petBUS;
        private readonly SpeciesBUS speciesBUS;
        private readonly BreedBUS breedBUS;
        private int _customerId;
        public AddNewPetForm(int customerId)
        {
            InitializeComponent();
            speciesBUS = new SpeciesBUS();
            petBUS = new PetBUS();
            breedBUS = new BreedBUS();
            _customerId = customerId;
        }

        private void AddNewPetForm_Load(object sender, EventArgs e)
        {
            LoadBreeds();
            LoadSpecies();
        }

        private void LoadBreeds()
        {
            List<Breeds> breeds = breedBUS.GetAll();
            cbxBreed.DataSource = breeds;
            cbxBreed.DisplayMember = "BreedName";
            cbxBreed.ValueMember = "BreedId";
        }

        private void LoadSpecies()
        {
            List<Species> species = speciesBUS.GetAll();
            cbxTypes.DataSource = species;
            cbxTypes.DisplayMember = "SpeciesName";
            cbxTypes.ValueMember = "SpeciesId";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxBreed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTypes.SelectedItem != null)
            {
                Species selectedSpecies = (Species)cbxTypes.SelectedItem;
                int speciesId = selectedSpecies.SpeciesId;
                LoadBreed(speciesId);
            }
        }

        private void LoadBreed(int speciesId)
        {
            List<Breeds> breeds = breedBUS.GetByBreedId(speciesId);
            cbxBreed.DataSource = breeds;
            cbxBreed.DisplayMember = "BreedName";
            cbxBreed.ValueMember = "BreedId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên.");
                txtLastName.Focus();
                return;
            }

            if (cbxBreed.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giống.");
                cbxBreed.Focus();
                return;
            }

            // Kiểm tra xem có loại nào được chọn hay không
            if (cbxTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại.");
                cbxTypes.Focus();
                return;
            }

            if (dtpBirthDay.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Vui lòng chọn Ngày sinh.");
                dtpBirthDay.Focus();
                return;
            }

            int age;
            if (!string.IsNullOrWhiteSpace(txtAge.Text))
            {
                if (!int.TryParse(txtAge.Text, out age))
                {
                    MessageBox.Show("Tuổi phải là một số nguyên dương.");
                    txtAge.Focus();
                    return;
                }
            }
            else
            {
                age = 0; 
            }

            Pets newPet = new Pets
            {
                CustomerId = _customerId,
                Name = txtLastName.Text,
                BreedId = (int)cbxBreed.SelectedValue,
                BirthDate = dtpBirthDay.Value,
                Age = age,
                Gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : null,
            };

            bool success = petBUS.AddNewPet(newPet);
            if (success)
            {
                MessageBox.Show("Thêm thú cưng thành công.");
                this.Close(); // Đóng form sau khi thêm thành công
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm thú cưng.");
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
