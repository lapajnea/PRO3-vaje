using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaje10
{
    public partial class DodajClana : Form
    {
        public DodajClana()
        {
            InitializeComponent();
        }
        private void Dodaj()
        {
            clan novClan = new clan();
            novClan.Ime = boxIme.Text;
            novClan.Priimek = boxPriimek.Text;
            novClan.Starost = boxStarost.Text;
            novClan.Spol = boxSpol.Text;
            novClan.Dolg = "0";

            model.DodajClana(novClan);
        }
        private void gmbDodajClana_Click(object sender, EventArgs e)
        {
            Dodaj();
            MessageBox.Show("Član je dodan!");
            foreach (TextBox box in this.panel1.Controls)
            {
                box.Text = "";
            }
        }
    }
}

