using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourPasswordApp.Core.Services;
using YourPasswordApp.Models;

namespace YourPasswordApp.Forms
{
    public partial class ShowPasswordsFm : Form
    {
        private IBrainService _brain;
        public ShowPasswordsFm( IBrainService brain )
        {
            _brain = brain;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            FillDataGrid();
        }

        private void ResponseToResult(int result)
        {
            var message = "";
            if(result == -123)
            {
                message = "You Should Add Data First!";
                MessageBox.Show(message);

                CreatePasswordFm createPasswordFm = new CreatePasswordFm(_brain);
                createPasswordFm.ShowDialog();
                Thread.Sleep(200);
                this.Close();
            }else if(result == -100)
            {
                message = "Inter Numebr for deleting Data!";
                MessageBox.Show(message);

                ShowPasswordsFm showPasswords = new ShowPasswordsFm(_brain);
                showPasswords.ShowDialog();
                Thread.Sleep(200);
                this.Close();
            }else if( result == -1)
            {
                message = "ID is not Exist";
                MessageBox.Show(message);

                ShowPasswordsFm showPasswords = new ShowPasswordsFm(_brain);
                showPasswords.ShowDialog();
                Thread.Sleep(200);
                this.Close();
            }
        }
        private void FillDataGrid()
        {
            IList<PasswordData> passwords = _brain.GetAllPasswordData();
            if(passwords == null)
            {
                ResponseToResult(-123);
            }
            else
            {
                passwordsDG.DataSource = passwords;  
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            HomeFm homeFm = new HomeFm();
            this.Hide();
            this.Close();
            homeFm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            IList<PasswordData> dataEdit = (IList<PasswordData>)passwordsDG.DataSource;
            int result = _brain.EditPassword(dataEdit);
            if(result == 100)
            {
                ShowPasswordsFm showPasswordsFm = new ShowPasswordsFm(_brain);
                showPasswordsFm.ShowDialog();
                Thread.Sleep(150);
                this.Hide();
                this.Close();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (!DeleteBox.Text.All(char.IsDigit) || DeleteBox.Text == "" || DeleteBox.Text == null)
            {
                ResponseToResult(-100);
            }

            // delete Object
            int myIdPassword = Convert.ToInt32(DeleteBox.Text);
            int result = _brain.DeletePassword(myIdPassword);

            if(result == -1)
            {
                ResponseToResult(-1);
            }


            ShowPasswordsFm showPasswordsFm = new ShowPasswordsFm(_brain);
            showPasswordsFm.ShowDialog();
            Thread.Sleep(100);
            this.Hide();
            this.Close();
        }
    }
}
