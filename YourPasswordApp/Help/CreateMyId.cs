using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourPasswordApp.Help
{
    public class CreateMyId
    {
        public static int CreateId()
        {
            Random rnd = new Random();
            return rnd.Next(100,1000);
        }
    }
}
