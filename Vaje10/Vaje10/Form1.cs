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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(comboBoxDodaj.Text == "Člana")
            {
                DodajClana dodajClana = new DodajClana();
                dodajClana.Show();
            }
            if(comboBoxDodaj.Text == "Knjigo")
            {
                DodajKnjigo dodajKnjigo = new DodajKnjigo();
                dodajKnjigo.Show();
            }
            


        }

        private void Izpis()
        {
            if (comboBoxIzbira.Text == "Knjige")
            {
               
                foreach (knjiga knjiga in model.IzpisKnjig())
                {
                    string niz = $"{knjiga.Naslov}, {knjiga.Avtor}, {knjiga.Zanr}, {knjiga.Leto_izdaje.ToString()}, {knjiga.Zalozba} \n";
                    this.listBox1.Items.Add(niz);
                }
            }
            if (comboBoxIzbira.Text == "Člani")
            {
               
                foreach (clan clanData in model.IzpisClanov())
                {
                    string niz = $"{clanData.Ime}, {clanData.Priimek}, {clanData.Spol}, {clanData.Starost}, {clanData.Dolg}";
                    this.listBox1.Items.Add(niz);
                }
            }
            
        }

        private void gmbPrikaz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Izpis();
           
            
        }
    }
}
