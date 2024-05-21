using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukaIvanic
{
    public partial class Form1 : Form
    {
        List<Prosjek> ListaOcjena = new List<Prosjek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {

            Prosjek prosjek = new Prosjek(listPredmeti.Text, Convert.ToInt32(txtOcjena));

            ListaOcjena.Add(prosjek);
            txtOcjena.Clear();
            txtOcjena.Focus();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            foreach (Prosjek prosjek in ListaOcjena)
            {
                txtPisanje.AppendText(prosjek.listPredmeti + "\t" + prosjek.Ocjena + "\r\n");
            }
        }
    }
}
