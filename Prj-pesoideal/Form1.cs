using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_pesoideal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();    
            txtheight.Clear();
            cmbgender.Text = "";
            txtweight.Clear();
            txtname.Focus();
        }

        private void btnidealweight_Click(object sender, EventArgs e)
        {
            try
            {
                Double h = 0, ideal_weight = 0;

                h = double.Parse(txtheight.Text);
                if (cmbgender.Text == "Female")
                {
                    ideal_weight = (62.7 * h) - 44.7;
                    MessageBox.Show(txtname.Text + " Your ideal weight is: "
                         + ideal_weight.ToString() + "Kgs", "Ideal Weight",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbgender.Text == "Male")
                {
                    ideal_weight = (72.7 * h) - 58;
                    MessageBox.Show(txtname.Text + " Your ideal weight is: "
                        + ideal_weight.ToString() + "Kgs", "Ideal Weight",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Choose your gender!", "Ideal Weight",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Please check if all the information required was added", "Ideal Weight",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h = 0, w = 0, bmi = 0;
            h = double.Parse(txtheight.Text);
            w = double.Parse(txtweight.Text);
            bmi = w / (h * h);
            MessageBox.Show(txtname.Text + " Your BMI is: " +
                bmi.ToString(), "Ideal Weight", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
