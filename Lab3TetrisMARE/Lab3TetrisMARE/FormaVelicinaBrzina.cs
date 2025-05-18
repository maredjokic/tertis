using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PodaciTetris;

namespace Lab3TetrisMARE
{
    public partial class FormaVelicinaBrzina : Form
    {
        public FormaVelicinaBrzina()
        {
            InitializeComponent();
        }

        private void btnIgraj_Click(object sender, EventArgs e)
        {
            if (tbxIme.Text == "" || tbxPrezime.Text == "")
            {
                MessageBox.Show("Obavezno unesite ime i prezime!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TetrisUC.Visina = (int)numVisina.Value;
                TetrisUC.Sirina = (int)numSirina.Value;
                TetrisUC.Vreme = (int)numBrzina.Value;
                TetrisUC.brojPoena = 0;
                TetrisUC.BrisiFigure();
                TetrisUC.igrac = new Igrac();
                TetrisUC.igrac.Ime = tbxIme.Text;
                TetrisUC.igrac.Prezime = tbxPrezime.Text;
                this.Close();
                this.DialogResult = DialogResult.OK;
                
            }
        }

    }
}
