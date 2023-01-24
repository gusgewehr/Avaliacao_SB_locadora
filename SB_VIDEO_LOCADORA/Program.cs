using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB_VIDEO_LOCADORA
{
    public static class Globals
    {
        public static readonly String cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gusge\Documents\GitHub\SB_VIDEO_LOCADORA\bd_locadora.mdf;Integrated Security=True";
    }
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
