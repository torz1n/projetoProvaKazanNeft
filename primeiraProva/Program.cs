using primeiraProva.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiraProva
{
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
            Application.Run(new frmLogin());
        }
        public static DialogResult Warning(this string text)
        {
            return MessageBox.Show(text, "Kazan  - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
        }
        public static DialogResult Information(this string text)
        {
            return MessageBox.Show(text, "Kazan  - Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
        public static DialogResult Question(this string text)
        {
            return MessageBox.Show(text, "Kazan  - Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
        }
    }

}
