using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourPasswordApp.Models
{
    public class PasswordData
    {
        public int MyPasswordId { get; set; }
        public string Title { get; set; }
        public string PasswordStr { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
