using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using PodaciTetris;
using ExtensionZaSerijalizaciju;

namespace Lab3TetrisMARE
{
    public partial class FormListaIgraca : Form
    {

        public ListaIgraca lista;
        public FormListaIgraca()
        {
            InitializeComponent();
            lista = new ListaIgraca();
        }


        private void btnIskljuci_Click(object sender, EventArgs e)
        {
            timerIgraci.Stop();
            this.Close();
        }

        private void lbxIgraci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormListaIgraca_Load(object sender, EventArgs e)
        {
            lbxIgraci.SelectedIndex = -1;
            lbxIgraci.DisplayMember = "ZaPrikaz";
            if(TetrisUC.igraci.ListaIgraci!=null)
                lbxIgraci.DataSource = TetrisUC.igraci.ListaIgraci.ToList();
            timerIgraci.Start();
        }

        private void timerIgraci_Tick(object sender, EventArgs e)
        {
            lbxIgraci.DataSource = TetrisUC.igraci.ListaIgraci.ToList();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xml files (*.xml)|*.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                TetrisUC.igraci.Serialize(sfd.FileName);
            }
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml files (*.xml)|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TetrisUC.igraci = TetrisUC.igraci.DeSerialize(ofd.FileName);
                lbxIgraci.DataSource = TetrisUC.igraci.ListaIgraci.ToList();
            }
        }
    }
}
