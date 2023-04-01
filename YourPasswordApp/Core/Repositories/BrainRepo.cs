using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourPasswordApp.Core.Services;
using YourPasswordApp.Models;
using YourPasswordApp.ViewModels;

namespace YourPasswordApp.Core.Repositories
{
    public class BrainRepo : IBrainService
    {
        private readonly string _path = @"C:\PasswordData\yourPassword.json";
        public BrainRepo()
        {
            CheckDataCenter();
        }


        #region Show Password Form

        public IList<PasswordData> GetAllPasswordData()
        {
            var allData = File.ReadAllText(_path);
            if(allData == null)
            {
                return null;
            }

            IList<PasswordData> allPasswords = JsonConvert.DeserializeObject<IList<PasswordData>>(allData);
            return allPasswords;
        }

        public int DeletePassword(int myId)
        {
            // is Valid ID
            int result = IsValidId(myId);
            if(result == -1 ) return -1;



            IList<PasswordData> passwords = GetAllPasswordData();
            passwords.Remove(passwords.SingleOrDefault(u => u.MyPasswordId == myId));

            // save data
            SavePasswords(passwords);

            return 100; 
        }
        private int IsValidId( int id )
        {
            IList<PasswordData> passwords = GetAllPasswordData();
            PasswordData pass = passwords.SingleOrDefault(u => u.MyPasswordId == id);
            if(pass == null)
            {
                return -1;
            }

            return 1;
        }

        public int EditPassword(IList<PasswordData> passwords)
        {
            var dataStr = JsonConvert.SerializeObject(passwords);
            File.WriteAllText(_path, dataStr);

            return 100;
        }

        #endregion

        #region Save Password
        private IList<PasswordData> GetAllData()
        {
            IList<PasswordData> data = new List<PasswordData>();
            var allPasswordData = File.ReadAllText(_path);
            data = JsonConvert.DeserializeObject<IList<PasswordData>>(allPasswordData);
            return data;
        }
        private void SavePasswords(IList<PasswordData> passwords)
        {
            var dataStr = JsonConvert.SerializeObject(passwords);
            File.WriteAllText(_path, dataStr);
        }
        public int SavePassword(PasswordData password)
        {
            IList<PasswordData> data = GetAllData();
            if(data != null)
            {
                data.Add(password);
                string passwordStr = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(_path, passwordStr);
                return 600;
            }
            else
            {
                IList<PasswordData> mydata = new List<PasswordData>();
                mydata.Add(password);
                string passwordStr = JsonConvert.SerializeObject(mydata, Formatting.Indented);
                File.WriteAllText(_path, passwordStr);
                return 600;
            }
        }

        #endregion

        #region Create File

        /*
        101 -> We create File
        202 -> File Is Exist
         */
        private void CheckDataCenter()
        {
            var result = CreateFile();
        }

        private int CreateFile()
        {
            // create File
            if (!File.Exists(_path))
            {
                Directory.CreateDirectory(@"C:\PasswordData");
                var myFile = File.Create(_path);
                myFile.Close();

                return 101;
            }
            return 202;
        }


        #endregion


        /*
         -100 -> title is null
         -200 -> title lenght
         -250 -> title type
         -300 -> description is big
         -400 -> pasword null
         500 -> Done
         */
        public int ValidateDataInput(PasswordVm passwordVm)
        {
            if ( passwordVm.Title == null || passwordVm.Title == "") { return -100; }
            else if(passwordVm.Title.Length < 2 || passwordVm.Title.Length > 15 ) { return -200; }
            else if (passwordVm.Title[0].GetType() == typeof(int)) { return -250; }

            if(passwordVm.Description.Length > 100) { return -300; }

            if (passwordVm.PasswordStr == null || passwordVm.PasswordStr == "") { return -400; }

            return 500;
        }


    }
}
