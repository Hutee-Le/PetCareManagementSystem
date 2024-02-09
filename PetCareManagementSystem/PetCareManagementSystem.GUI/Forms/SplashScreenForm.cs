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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            timerSplashScreen.Start();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            progressBarLoading.Value += 10;
            if (progressBarLoading.Value >= progressBarLoading.Maximum)
            {
                timerSplashScreen.Stop();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += LoginForm_FormClosed;
                loginForm.Show();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
