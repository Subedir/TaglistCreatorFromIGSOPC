using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaglistCreatorFromIGSOPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();

        }

        private void UploadIGSFile_Click(object sender, EventArgs e)
        {
            openIGSFile.Filter = "IGS file (*.csv)|*.csv|All files (*.*)|*.*";
            System.Windows.Forms.DialogResult result;
            result = openIGSFile.ShowDialog();



        }

        private void UploadOPCFile_Click(object sender, EventArgs e)
        {
            openOPCFile.Filter = "OPC file (*.csv)|*.csv|All files (*.*)|*.*";
            System.Windows.Forms.DialogResult result;
            result = openOPCFile.ShowDialog();
        }
    }
}
