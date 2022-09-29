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
    public partial class DodajKnjigo : Form
    {
        public DodajKnjigo()
        {
            InitializeComponent();
        }

        private void Dodaj()
        {
            knjiga novaKnjiga = new knjiga();
            novaKnjiga.Naslov = boxNaslov.Text;
            novaKnjiga.Avtor = boxAvtor.Text;
            novaKnjiga.Zanr = boxZanr.Text;
            novaKnjiga.Leto_izdaje = boxLetoIzdaje.Text;
            novaKnjiga.Zalozba = boxZalozba.Text;

            model.DodajKnjigo(novaKnjiga);
        }
        private void gmbDodajKnjigo_Click(object sender, EventArgs e)
        {

            Dodaj();
            MessageBox.Show("Knjiga je dodana!");
             foreach(TextBox box in this.panel1.Controls)
            {
                box.Text = "";
            }

        }
    }
}
