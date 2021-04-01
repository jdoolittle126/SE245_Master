using DoolittleSE245;
using DoolittleSE245.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoolittleSE245.Core
{


    static class Program
    {

        public static PersonV2DataBaseIO database = new PersonV2DataBaseIO("SEE", "COMMENT", "FOR", "STRING", ":)");
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SearchForm());

        }



    }

}
