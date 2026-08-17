using primeiraProva.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace primeiraProva.UI
{
    public partial class frmRequest : frmParent
    {
        private Asset selectedAsset;

        public frmRequest(string valorNumberOfEMs, string valorLastClosed, string valorAssetName, string valorAssetSN)
        {
            InitializeComponent();
            //string assetSNnLabel = valorAssetSN;
            //label4.Text = assetSNnLabel;

            //string assetNameLabel = valorAssetName;
            //label7.Text = assetNameLabel;

            //string lastClosedLabel = valorLastClosed;

        }

        public frmRequest(Asset selectedAsset)
        {
            InitializeComponent();
            this.selectedAsset = selectedAsset;
            label8.Text = selectedAsset.AssetSN;
            label7.Text = selectedAsset.AssetName;
            label9.Text = selectedAsset.DepartmentLocation.Department.Name;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtAssetSN_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
