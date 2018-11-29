using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oblast_form
{
    public partial class fPlanshet : Form
    {
        public Planshet ThePlanshet;

        public fPlanshet(Planshet t)
        {
            ThePlanshet = t;

            InitializeComponent();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fPlanshet_Load(object sender, EventArgs e)
        {
            if (ThePlanshet != null)
            {
                tbName.Text = ThePlanshet.Name;
                tbCountrymanufacture.Text = ThePlanshet.Countrymanufacture;
                tbScreenview.Text = ThePlanshet.Screenview;
                tbScreendiagonal.Text = ThePlanshet.Screendiagonal;
                tbNumbeofcores.Text = ThePlanshet.NumbeofCores;
                tbPrice.Text = ThePlanshet.Price;
                chWarranty.Checked = ThePlanshet.HasWarranty;
                chInstallmentplan.Checked = ThePlanshet.HasInstallmentplan;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            ThePlanshet.Name = tbName.Text.Trim();
            ThePlanshet.Countrymanufacture = tbCountrymanufacture.Text.Trim();
            ThePlanshet.Screenview = tbScreenview.Text.Trim();
            ThePlanshet.Screendiagonal = tbScreendiagonal.Text.Trim();
            ThePlanshet.NumbeofCores = tbNumbeofcores.Text.Trim();
            ThePlanshet.Price = tbPrice.Text.Trim();
            ThePlanshet.HasWarranty = chWarranty.Checked;
            ThePlanshet.HasInstallmentplan = chInstallmentplan.Checked;

            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
