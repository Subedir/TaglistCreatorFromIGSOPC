using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaglistCreatorFromIGSOPC
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

            // Initializes the AboutBox with the information in the AssemblyInfo.cs in properties of this program
            this.textBoxDescription.Text = AssemblyTitle.ToString();

        }


        public string AssemblyTitle
        {
            get
            {

                return (Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyDescriptionAttribute))


            }
        }
    }
}
