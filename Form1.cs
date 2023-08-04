using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; 

namespace Motorcycle_Gear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Helmet_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double Cost1 = Convert.ToDouble(helmet_Cost.Text);
            double Cost2 = Convert.ToDouble(jacket_Cost.Text);
            double Cost3 = Convert.ToDouble(gloves_Cost.Text);
            double Cost4 = Convert.ToDouble(pants_Cost.Text);
            double Cost5 = Convert.ToDouble(boots_Cost.Text);
            double final = Cost1 + Cost2 + Cost3 + Cost4 + Cost5;

            f.Text = Convert.ToString(final);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/NTCG25/State-Tax-Calculator");
        }
    }
}

