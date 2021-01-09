using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Payments : UserControl
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lblPri_Click(object sender, EventArgs e)
        {
            if (comSection.Text.ToLower() == "Ear Section.".ToLower())
            {
                lblPri.Text = "30$";
            }
            else if (comSection.Text.ToLower() == "Eye Section.".ToLower())
            {
                lblPri.Text = "50$";
            }
            else if (comSection.Text.ToLower() == "Nose Section.".ToLower())
            {
                lblPri.Text = "40$";
            }
            else if (comSection.Text.ToLower() == "Mouth & Thraot Section.".ToLower())
            {
                lblPri.Text = "50$";
            }
            else if (comSection.Text.ToLower() == "General Surgery Section.".ToLower())
            {
                lblPri.Text = "2000$";
            }
            else if (comSection.Text.ToLower() == "Orthopaedic Section Section.".ToLower())
            {
                lblPri.Text = "1000$";
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (comSection.Text.ToLower() == "Ear Section.".ToLower())
            {
                lblPri.Text = "30$";
            }
            else if (comSection.Text.ToLower() == "Eye Section.".ToLower())
            {
                lblPri.Text = "50$";
            }
            else if (comSection.Text.ToLower() == "Nose Section.".ToLower())
            {
                lblPri.Text = "40$";
            }
            else if (comSection.Text.ToLower() == "Mouth & Thraot Section.".ToLower())
            {
                lblPri.Text = "50$";
            }
            else if (comSection.Text.ToLower() == "General Surgery Section.".ToLower())
            {
                lblPri.Text = "2000$";
            }
            else if (comSection.Text.ToLower() == "Orthopaedic Section.".ToLower())
            {
                lblPri.Text = "1000$";
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            lblPri.Text = "";
        }
    }
}

