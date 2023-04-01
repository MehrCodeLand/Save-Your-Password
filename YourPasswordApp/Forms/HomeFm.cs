using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourPasswordApp.Core.Repositories;
using YourPasswordApp.Core.Services;

namespace YourPasswordApp.Forms
{
    public partial class HomeFm : Form
    {
        public HomeFm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void HomeFm_Load(object sender, EventArgs e)
        {
        }


        private void createNewPasswordBtn_Click(object sender, EventArgs e)
        {
            CreatePasswordFm createPassword = new CreatePasswordFm(new BrainRepo());
            createPassword.ShowDialog();
            Thread.Sleep(100);
            this.Hide();
        }
        private void yourPasswordsBtn_Click(object sender, EventArgs e)
        {
             ShowPasswordsFm showPasswords = new ShowPasswordsFm( new BrainRepo());
            showPasswords.ShowDialog();
            Thread.Sleep(200);
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            var message = "Bye...";
            MessageBox.Show(message);
            Thread.Sleep(200);
            Application.Exit();
        }
        private void MehrCodeLandBtn_Click(object sender, EventArgs e)
        {
            var url = "https://github.com/MehrCodeLand";
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            Process.Start(psi);
        }
    }
}
