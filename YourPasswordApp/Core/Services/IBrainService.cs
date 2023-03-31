using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourPasswordApp.Models;
using YourPasswordApp.ViewModels;

namespace YourPasswordApp.Core.Services
{
    public interface IBrainService
    {
        int ValidateDataInput(PasswordVm passwordVm);
        int SavePassword(PasswordData password);
    }
}
