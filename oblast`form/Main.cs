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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void bAddA_Click(object sender, EventArgs e)
        {
            Planshet planshet = new Planshet();
            fPlanshet ft = new fPlanshet(planshet);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tMain.Text +=
                string.Format(" Назва: {0}  \r\n ,Країна виробника: {1} \r\n Вид екрану: {2} \r\n Діагональ екрану: {3} \r\n Кількість ядер:{4} м \r\n Ціна: {5}  \r\n - {6} \r\n - {7} \r\n ",
                planshet.Name, planshet.Countrymanufacture, planshet.Screenview,
                planshet.Screendiagonal, planshet.NumbeofCores, planshet.Price,
                planshet.HasWarranty ? "Є гарантія магазину" : "Немає гарантії",
                planshet.HasInstallmentplan ? "Є розстрочка" : "Немає розстрочки");
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
                "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tMain.Text = string.Empty;
        }
    }
}
