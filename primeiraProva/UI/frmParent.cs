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

            foreach (Control objectHere in this.Controls)
            {
                if (objectHere is ComboBox)
                {
                    ComboBox comboBoxes = (ComboBox)objectHere;
                    comboBoxes.SelectedIndex = -1;
                }
            }
            
        }

       public  Session2Entities ctx = new Session2Entities();
           
        private void frmParent_Load(object sender, EventArgs e)
        {

        }
    }
}
