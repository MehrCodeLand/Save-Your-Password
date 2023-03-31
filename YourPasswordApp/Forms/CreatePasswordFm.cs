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
using YourPasswordApp.Help;
using YourPasswordApp.Models;
using YourPasswordApp.ViewModels;

namespace YourPasswordApp.Forms
{
    public partial class CreatePasswordFm : Form
    {
        private IBrainService _brain;
        public CreatePasswordFm( IBrainService brain )
        {
            _brain = brain;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void CreatePasswordFm_Load(object sender, EventArgs e)
        {

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            PasswordVm passwordVm = new PasswordVm()
            {
                Title = TitletBox.Text,
                PasswordStr = passwordtBox.Text,
                Description = descriptionBox.Text,
            };

            int result = _brain.ValidateDataInput(passwordVm);
            // show result
            if (result != 500)
            {
                var message = "";
                if (result == -100)
                {
                    message = "check title again!";
                    MessageBox.Show(message);

                    CreatePasswordFm passwordFm = new CreatePasswordFm(_brain);
                    passwordFm.ShowDialog();
                    Thread.Sleep(100);
                    this.Close();
                }
                else if (result == -250)
                {
                    message = "TITLE Cant start with [number]!";
                    MessageBox.Show(message);

                    CreatePasswordFm passwordFm = new CreatePasswordFm(_brain);
                    passwordFm.ShowDialog();
                    Thread.Sleep(100);
                    this.Close();
                }
                else if (result == -400)
                {
                    message = "Password is null!";
                    MessageBox.Show(message);

                    CreatePasswordFm passwordFm = new CreatePasswordFm(_brain);
                    passwordFm.ShowDialog();
                    Thread.Sleep(100);
                    this.Close();
                }
                else if (result == -300)
                {
                    message = "check Description again! [Large file]";
                    MessageBox.Show(message);

                    CreatePasswordFm passwordFm = new CreatePasswordFm(_brain);
                    passwordFm.ShowDialog();
                    Thread.Sleep(100);
                    this.Close();
                }
            }

            // time to save data 
            PasswordData passwordData = new PasswordData()
            {
                MyPasswordId = CreateMyId.CreateId(),
                PasswordStr = passwordVm.PasswordStr,
                Description = passwordVm.Description,
                Title = passwordVm.Title,
            };
            result = _brain.SavePassword(passwordData);

            CreatePasswordFm createPasswordFm = new CreatePasswordFm(_brain);
            createPasswordFm.ShowDialog();
            Thread.Sleep(150);
            this.Close();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            HomeFm homeFm = new HomeFm();
            homeFm.ShowDialog();
            Thread.Sleep(200);
            this.Close();
        }
    }
}
