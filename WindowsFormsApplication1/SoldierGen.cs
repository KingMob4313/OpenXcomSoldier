using LinqToExcel;
using SoldierGen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoldierGen
{
    public partial class SoldierGen : Form
    {
        private string _fileName;
        private SoldierBundle bundle = new SoldierBundle();
        private readonly Processor _processor;

        public SoldierGen()
        {
            InitializeComponent();
            _processor = new Processor(this);
        }

        public Processor Processor
        {
            get { return _processor; }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void SelectXLSX_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                _fileName = ofd.InitialDirectory + ofd.FileName;
            }
            textBox1.Text = _fileName.ToString();
            //DataTable dt = new DataTable();

            var newSoldier = Processor.LoadXLS(_fileName, bundle, inTransitCheckBox.Checked, hoursArrivalTextBox.Text);
            textBox2.Text = newSoldier.soldierCount.ToString();
            textBox3.Text = newSoldier.soldierText.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void inTransitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            hoursArrivalTextBox.Enabled = inTransitCheckBox.Checked;
            hoursArrivalTextBox.ReadOnly = !inTransitCheckBox.Checked;
        }

        private void setArrivalTimeButton_Click(object sender, EventArgs e)
        {
        }
    }
}