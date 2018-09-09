using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Basic_Mail
{
    class Settings
    {
        private static string ConString;
        public static int User_ID;
        private static void Connection_intialization() {
            StreamReader sr = new StreamReader("CnStr1002.txt");
            ConString = sr.ReadLine();
        }

        public static string Con_String() {
            Connection_intialization();
            return ConString;
        }
    }
}
