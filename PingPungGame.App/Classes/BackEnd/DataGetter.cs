using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPungGame.App.Classes.BackEnd
{
    public static class DataGetter
    {
        private static string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public static string GetUserName
        {
            get
            {
                return userName;
            }
        }
    }
}
