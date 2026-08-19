using primeiraProva.Models;
using System;
using System.Windows.Forms;

namespace primeiraProva.UI
{
    public partial class frmParent : System.Windows.Forms.Form
    {
        public frmParent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            
            
        }

       public  Session2Entities ctx = new Session2Entities();
           
        private void frmParent_Load(object sender, EventArgs e)
        {
            Metodo(panel1 as Control);
        }

        private void Metodo(Control control)
        {
            foreach (Control objectHere in control.Controls)
            {
                if (objectHere is ComboBox comboBoxes)
                {
                    comboBoxes.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                if (objectHere.HasChildren)
                {
                    Metodo(objectHere);
                }
            }
        }
    }
}
