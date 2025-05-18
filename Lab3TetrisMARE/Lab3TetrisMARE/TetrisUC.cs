using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PodaciTetris;

namespace Lab3TetrisMARE
{
    public partial class TetrisUC : UserControl
    {

        #region Podacici

        public static Figura figura1;
        public static Figura figura2;

        public static ListaIgraca igraci;

        public static Kvadrat[][] SledecaFigura;

        public static Igrac igrac;

        public int timer1Vreme;
        public static int Visina
        {
            get; set;
        }
        public static int Sirina
        {
            get; set;
        }
        public static int Vreme
        {
            get; set;
        }
        public static int brojPoena;
        public static bool aktivnaIgra=false;
        public bool indikatorPauze = false;

        #endregion

        public TetrisUC()
        {
            //btnPauza.Enabled = false;
            igraci = new ListaIgraca();
            InitializeComponent();
            // this.Parent.KeyDown += new KeyEventHandler(TetrisUC_KeyDown);
            btnPauza.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            var frmVelicinaBrzina = new FormaVelicinaBrzina();

            frmVelicinaBrzina.StartPosition = FormStartPosition.CenterScreen;
            DialogResult d = frmVelicinaBrzina.ShowDialog();
            if (d == DialogResult.OK)
            {
                figura1 = null;
                figura2 = null;
                CrtajPolje(Visina, Sirina);
            }


        }

        private void CrtajPolje(int visina, int sirina)
        {
            indikatorPauze = false;
            btnPauza.Text = "Pauza";
            for (int i = 7; i < Controls.Count; i++)
            {
                Control c = Controls[i] as Control;
                Controls.RemoveAt(i--);
                c.Dispose();
            }

            Size siz = new Size(25, 25);

            SledecaFigura = new Kvadrat[5][];
            for (int i = 0; i < 5; i++)
                SledecaFigura[i] = new Kvadrat[5];


            for (int i = 0, y = 50, x = 50; i < 5; i++)
            {
                x = 50;
                y = y + siz.Width;
                for (int j = 0; j < 5; j++, x = x + siz.Width)
                {
                    Label l = new Label();
                    l.Name = "";
                    l.BackColor = Color.White;
                    l.Size = siz;
                    l.MinimumSize = siz;
                    l.MaximumSize = siz;
                    l.BorderStyle = BorderStyle.FixedSingle;
                    SledecaFigura[i][j] = new Kvadrat(i, j, l);
                    l.Location = new Point(x, y);
                    //base.Size = new Size(500, 500);
                    this.Controls.Add(l);
                }
            }


            TetrisPodaci.Instanca.MatricaTetris = new Kvadrat[visina][];
            TetrisPodaci.Instanca.Redovi = visina;
            TetrisPodaci.Instanca.Kolone = sirina;
            for (int i = 0; i < visina; i++)
            {
                TetrisPodaci.Instanca.MatricaTetris[i] = new Kvadrat[sirina];
            }



            for (int i = 0, y = 50, x = 200; i < visina; i++)
            {
                x = 200;
                y = y + siz.Width;
                for (int j = 0; j < sirina; j++, x = x + siz.Width)
                {
                    Label l = new Label();
                    l.Name = "prazna";
                    l.BackColor = Color.White;
                    l.Size = siz;
                    l.MinimumSize = siz;
                    l.MaximumSize = siz;
                    l.BorderStyle = BorderStyle.FixedSingle;
                    TetrisPodaci.Instanca.MatricaTetris[i][j] = new Kvadrat(i, j, l);
                    l.Location = new Point(x, y);
                    //base.Size = new Size(500, 500);
                    this.Controls.Add(l);
                }
            }


            btnPauza.Enabled = true;

            timer1Vreme = 0;

            timer1.Start();
            PrikazNoveFigure();

            UbaciNovuFiguru();
            aktivnaIgra = true;

            

            tajmerDodajObjekat.Interval = Vreme;
            tajmerDodajObjekat.Start();
            //PrikazNoveFigure();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1Vreme++;
            lblBrojPoena.Text = brojPoena.ToString();
            lblVreme.Text = timer1Vreme.ToString();
        }

        private void PrikazNoveFigure()
        {
            int rr;
            Random r = new Random();
            rr = (int)r.Next(0, 5);
            figura2 = new Figura(rr);

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    SledecaFigura[i][j].Labela.BackColor = Color.White;

            if (figura2.kockice.Length == 1)
            {
                SledecaFigura[figura2.kockice[0].RedKvadrata + 2][figura2.kockice[0].KolonaKvadrata + 2].Labela.BackColor = figura2.col;
            }
            else
            {
                for (int i = 0; i < figura2.kockice.Length; i++)
                {
                    SledecaFigura[figura2.kockice[i].RedKvadrata + 1][figura2.kockice[i].KolonaKvadrata + 1].Labela.BackColor = figura2.col;
                }
            }

        }

        public void DodajIgraca()
        {
            if(igrac!=null)
            {
                if (igraci == null)
                    igraci = new ListaIgraca();

                igrac.Datum = DateTime.Now;
                igrac.BrojPoena = brojPoena;
                igrac.Vreme = timer1Vreme;

                igraci.DodajIgraca(igrac);

                igraci.Sortiraj(igraci.ListaIgraci);

            }
        }

        private void UbaciNovuFiguru()
        {
            
            figura1 = figura2;
            
            int sredina = TetrisPodaci.Instanca.Kolone / 2;
            
            if (figura1.kockice.Length == 1)
            {

                if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][sredina + figura1.kockice[0].KolonaKvadrata].Labela.BackColor != Color.White)
                {
                    figura1 = null;
                    figura2 = null;

                    timer1.Stop();
                    tajmerDodajObjekat.Stop();
                    aktivnaIgra = false;
                    btnPauza.Enabled = false;
                    DodajIgraca();
                    MessageBox.Show("Kraj igre. Vas broj poena je " + lblBrojPoena.Text + ".", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    return;
                }
                TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][sredina + figura1.kockice[0].KolonaKvadrata].Labela.BackColor = figura1.col;

              figura1.kockice[0].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][sredina + figura1.kockice[0].KolonaKvadrata].Labela;
                TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][sredina + figura1.kockice[0].KolonaKvadrata].JeFigura = true;
                figura1.kockice[0].Labela.Name = "figura";
                figura1.kockice[0].RedKvadrata = figura1.kockice[0].RedKvadrata;
                figura1.kockice[0].KolonaKvadrata = sredina + figura1.kockice[0].KolonaKvadrata;
                PrikazNoveFigure();

            }
            else
            {
                if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][sredina + figura1.kockice[0].KolonaKvadrata].Labela.BackColor != Color.White
                    || TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata][sredina + figura1.kockice[1].KolonaKvadrata].Labela.BackColor != Color.White
                    || TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata][sredina + figura1.kockice[0].KolonaKvadrata].Labela.BackColor != Color.White
                    || TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][sredina + figura1.kockice[1].KolonaKvadrata].Labela.BackColor != Color.White
                    ||TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][sredina + figura1.kockice[0].KolonaKvadrata-1].Labela.BackColor != Color.White
                    || TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata+1][sredina + figura1.kockice[0].KolonaKvadrata-1].Labela.BackColor != Color.White)
                {
                   figura1 = null;
                    figura2 = null;

                    timer1.Stop();
                    tajmerDodajObjekat.Stop();
                    aktivnaIgra = false;
                    btnPauza.Enabled = false;
                    DodajIgraca();
                    MessageBox.Show("Kraj igre. Vas broj poena je " + lblBrojPoena.Text + ".", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                for (int i = 0; i < figura1.kockice.Length; i++)
                {
                    TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][sredina - 1 + figura1.kockice[i].KolonaKvadrata].Labela.BackColor = figura1.col;

                    figura1.kockice[i].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][sredina - 1 + figura1.kockice[i].KolonaKvadrata].Labela;
                    TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][sredina - 1 + figura1.kockice[i].KolonaKvadrata].JeFigura = true;
                    figura1.kockice[i].Labela.Name = "figura";
                    figura1.kockice[i].RedKvadrata = figura1.kockice[i].RedKvadrata;
                    figura1.kockice[i].KolonaKvadrata = sredina - 1 + figura1.kockice[i].KolonaKvadrata;
                    PrikazNoveFigure();
                }
            }
            

        }

        private void tajmerDodajObjekat_Tick(object sender, EventArgs e)// IZMENI IME U POMERAJ OBJEKAT
        {
            if (aktivnaIgra == true)
            {
                for (int i = Visina - 1; i > 0; i--)
                {
                    int brojac = 0;
                    for (int j = Sirina - 1; j > -1; j--)
                    {

                        if (TetrisPodaci.Instanca.MatricaTetris[i][j].Labela.BackColor != Color.White && TetrisPodaci.Instanca.MatricaTetris[i][j].JeFigura == false)
                        {
                            brojac++;
                        }
                        //if (Figura.PostojiLi(TetrisPodaci.Instanca.MatricaTetris[i][j], figura1.kockice))
                        //{
                        //    brojac--;
                        //}
                    }
                    if (brojac == Sirina)/// ako jeste skida red
                    {
                        for (int q = 0; q < figura1.kockice.Length; q++)
                        {
                                figura1.kockice[q].Labela.BackColor = Color.White;
                                TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[q].RedKvadrata][figura1.kockice[q].KolonaKvadrata].JeFigura = false;
                            
                        }
                        for (int p = i; p > 0; p--)
                        {
                            for (int c = 0; c < Sirina; c++)
                            {

                                if (!Figura.PostojiLi(TetrisPodaci.Instanca.MatricaTetris[p][c], figura1.kockice) || !Figura.PostojiLi(TetrisPodaci.Instanca.MatricaTetris[p - 1][c], figura1.kockice))
                                {
                                    TetrisPodaci.Instanca.MatricaTetris[p][c].Labela.Name = "prazno";
                                    TetrisPodaci.Instanca.MatricaTetris[p][c].Labela.BackColor = TetrisPodaci.Instanca.MatricaTetris[p - 1][c].Labela.BackColor;

                                }
                            }

                        }

                        for (int c = 0; c < Sirina; c++)
                        {
                            //TetrisPodaci.Instanca.MatricaTetris[0][c].Labela = new Label();
                            TetrisPodaci.Instanca.MatricaTetris[0][c].Labela.BackColor = Color.White;// spusta i figuru
                            //ne aktivira se onda funkcija za pomeranje, jer ce skidanje reda spustiti figuru na dole
                        }
                        for (int q = 0; q < figura1.kockice.Length; q++)
                        {

                            figura1.kockice[q].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[q].RedKvadrata][figura1.kockice[q].KolonaKvadrata].Labela;
                            figura1.kockice[q].Labela.BackColor = figura1.col;
                            figura1.kockice[q].JeFigura = true;

                        }
                        brojPoena++;
                        return;
                    }
                }

                if (figura1 != null)
                {



                    for (int i = 0; i < figura1.kockice.Length; i++)
                    {
                        if (figura1.kockice[i].RedKvadrata == Visina - 1)
                        {
                            for (int j = 0; j < figura1.kockice.Length; j++)
                            {
                                TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[j].RedKvadrata][figura1.kockice[j].KolonaKvadrata].JeFigura = false;
                            }
                            UbaciNovuFiguru();
                            PrikazNoveFigure();
                            return;
                        }
                    }

                    for (int i = 0; i < figura1.kockice.Length; i++)
                    {

                        if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata + 1][figura1.kockice[i].KolonaKvadrata].Labela.BackColor != Color.White)
                        {
                            if (!Figura.PostojiLi(TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata + 1][figura1.kockice[i].KolonaKvadrata], figura1.kockice))
                            {
                                for (int j = 0; j < figura1.kockice.Length; j++)
                                {
                                    TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[j].RedKvadrata][figura1.kockice[j].KolonaKvadrata].JeFigura = false;
                                }
                                UbaciNovuFiguru();
                                PrikazNoveFigure();
                                return;
                            }
                        }
                    }

                    for (int i = 0; i < figura1.kockice.Length; i++)
                    {
                        if (figura1.kockice[i].RedKvadrata < Visina && aktivnaIgra == true)
                        {
                            figura1.kockice[i].Labela.BackColor = Color.White;
                            TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata].JeFigura = false;
                        }
                    }
                    for (int i = 0; i < figura1.kockice.Length; i++)
                    {

                        if (figura1.kockice[i].RedKvadrata < Visina)
                        {
                            
                            TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata + 1][figura1.kockice[i].KolonaKvadrata].Labela.BackColor = figura1.col;
                            figura1.kockice[i].Labela.Name = "boja";
                            figura1.kockice[i].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata + 1][figura1.kockice[i].KolonaKvadrata].Labela;
                            figura1.kockice[i].Labela.Name = "figura";
                            figura1.kockice[i].RedKvadrata = figura1.kockice[i].RedKvadrata + 1;
                            TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata].JeFigura = true;
                        }
                    }
                }
            }

        }

        public static void MrdajLevo()
        {
            if (aktivnaIgra == true)
            {
                for (int i = 0; i < figura1.kockice.Length; i++)
                {
                    if (figura1.kockice[i].RedKvadrata == Visina - 1 || figura1.kockice[i].KolonaKvadrata == 0)
                    {

                        return;
                    }
                }

                for (int i = 0; i < figura1.kockice.Length; i++)
                {
                    if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata - 1].Labela.BackColor != Color.White)
                    {
                        if (!Figura.PostojiLi(TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata - 1], figura1.kockice))
                        {
                            //UbaciNovuFiguru();
                            //PrikazNoveFigure();
                            return;
                        }
                    }
                }


                for (int i = 0; i < figura1.kockice.Length; i++)
                {
                    if (figura1.kockice[i].RedKvadrata < Visina && figura1.kockice[i].KolonaKvadrata != 0)
                    {
                        figura1.kockice[i].Labela.BackColor = Color.White;
                        TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata].JeFigura = false;
                    }
                }
                for (int i = 0; i < figura1.kockice.Length; i++)
                {

                    if (figura1.kockice[i].RedKvadrata < Visina && figura1.kockice[i].KolonaKvadrata != 0)
                    {

                        TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata - 1].Labela.BackColor = figura1.col;
                        figura1.kockice[i].Labela.Name = "boja";
                        figura1.kockice[i].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata - 1].Labela;
                        // figura1.kockice[i].Labela.Name = "boja";

                        figura1.kockice[i].Labela.Name = "figura";
                        figura1.kockice[i].KolonaKvadrata = figura1.kockice[i].KolonaKvadrata - 1;
                        TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata].JeFigura = true;

                    }
                    else
                    {
                        return;
                    }
                }
            }

        }

        public static void MrdajDesno()
        {
            if (aktivnaIgra == true)
            {
                for (int i = 0; i < figura1.kockice.Length; i++)
                {
                    if (figura1.kockice[i].RedKvadrata == Visina - 1 || figura1.kockice[i].KolonaKvadrata == TetrisPodaci.Instanca.Kolone - 1)
                    {

                        return;
                    }
                }


                for (int i = 0; i < figura1.kockice.Length; i++)
                {
                    if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata + 1].Labela.BackColor != Color.White)
                    {
                        if (!Figura.PostojiLi(TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata + 1], figura1.kockice))
                        {
                            //UbaciNovuFiguru();
                            //PrikazNoveFigure();
                            return;
                        }
                    }
                }

                for (int i = 0; i < figura1.kockice.Length; i++)
                {
                    if (figura1.kockice[i].RedKvadrata < Visina && figura1.kockice[i].KolonaKvadrata != TetrisPodaci.Instanca.Kolone - 1)
                    {
                        figura1.kockice[i].Labela.BackColor = Color.White;
                        TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata].JeFigura = false;
                    }
                }
                for (int i = 0; i < figura1.kockice.Length; i++)
                {

                    if (figura1.kockice[i].RedKvadrata < Visina && figura1.kockice[i].KolonaKvadrata != TetrisPodaci.Instanca.Kolone - 1)
                    {

                        TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata + 1].Labela.BackColor = figura1.col;
                        figura1.kockice[i].Labela.Name = "boja";
                        figura1.kockice[i].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata + 1].Labela;
                        figura1.kockice[i].Labela.Name = "figura";
                        figura1.kockice[i].KolonaKvadrata = figura1.kockice[i].KolonaKvadrata + 1;
                        TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata].JeFigura = true;

                    }
                    else
                    {
                        return;
                    }
                }
            }

        }

        public static void BrisiFigure()
        {
            figura1 = null;
            figura2 = null;
            
        }

        public static void MrdajNaDole()
        {
            if (figura1 != null && aktivnaIgra == true)
            {



                for (int i = 0; i < figura1.kockice.Length; i++)
                {
                    if (figura1.kockice[i].RedKvadrata == Visina - 1)
                    {

                        return;
                    }
                }

                for (int i = 0; i < figura1.kockice.Length; i++)
                {
                    if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata + 1][figura1.kockice[i].KolonaKvadrata].Labela.BackColor != Color.White)
                    {
                        if (!Figura.PostojiLi(TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata + 1][figura1.kockice[i].KolonaKvadrata], figura1.kockice))
                        {

                            return;
                        }
                    }
                }

                for (int i = 0; i < figura1.kockice.Length; i++)
                {
                    if (figura1.kockice[i].RedKvadrata < Visina)
                    {
                        figura1.kockice[i].Labela.BackColor = Color.White;
                        TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata].JeFigura = false;
                    }
                }
                for (int i = 0; i < figura1.kockice.Length; i++)
                {

                    if (figura1.kockice[i].RedKvadrata < Visina)
                    {

                        TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata + 1][figura1.kockice[i].KolonaKvadrata].Labela.BackColor = figura1.col;
                        figura1.kockice[i].Labela.Name = "boja";
                        figura1.kockice[i].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata + 1][figura1.kockice[i].KolonaKvadrata].Labela;
                        figura1.kockice[i].Labela.Name = "figura";
                        figura1.kockice[i].RedKvadrata = figura1.kockice[i].RedKvadrata + 1;
                        TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata].JeFigura = true;
                    }
                }


            }

        }

       public static void Rotiraj()
        {
            


            if (figura1 != null && aktivnaIgra == true)
            {
                for(int i=0;i<figura1.kockice.Length;i++)
                      TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata].JeFigura = false;


                if (figura1.col == Color.Blue)
                {
                    if (figura1.kockice[1].KolonaKvadrata > 0 && figura1.kockice[1].KolonaKvadrata < Sirina - 1 && figura1.kockice[1].RedKvadrata < Visina - 1)
                    {
                        if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata][figura1.kockice[1].KolonaKvadrata + 1].Labela.BackColor == Color.White
                        && TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata][figura1.kockice[1].KolonaKvadrata - 1].Labela.BackColor == Color.White)
                        {
                            figura1.kockice[0].Labela.BackColor = Color.White;
                            figura1.kockice[2].Labela.BackColor = Color.White;

                            //TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][figura1.kockice[0].KolonaKvadrata].JeFigura = false;
                           // TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[2].RedKvadrata][figura1.kockice[2].KolonaKvadrata].JeFigura = false;

                            figura1.kockice[0].KolonaKvadrata--;
                            figura1.kockice[0].RedKvadrata++;

                            figura1.kockice[2].KolonaKvadrata++;
                            figura1.kockice[2].RedKvadrata--;

                            //TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][figura1.kockice[0].KolonaKvadrata].JeFigura = true;
                            //TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[2].RedKvadrata][figura1.kockice[2].KolonaKvadrata].JeFigura = true;

                            figura1.kockice[0].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][figura1.kockice[0].KolonaKvadrata].Labela;
                            figura1.kockice[2].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[2].RedKvadrata][figura1.kockice[2].KolonaKvadrata].Labela;
                            figura1.kockice[0].Labela.BackColor = figura1.col;
                            figura1.kockice[2].Labela.BackColor = figura1.col;
                        }
                        else if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata-1][figura1.kockice[1].KolonaKvadrata ].Labela.BackColor == Color.White
                        && TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata+1][figura1.kockice[1].KolonaKvadrata ].Labela.BackColor == Color.White)
                        {

                            figura1.kockice[0].Labela.BackColor = Color.White;
                            figura1.kockice[2].Labela.BackColor = Color.White;
                           // TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][figura1.kockice[0].KolonaKvadrata].JeFigura = false;
                           // TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[2].RedKvadrata][figura1.kockice[2].KolonaKvadrata].JeFigura = false;

                            figura1.kockice[0].KolonaKvadrata++;
                            figura1.kockice[0].RedKvadrata--;

                            figura1.kockice[2].KolonaKvadrata--;
                            figura1.kockice[2].RedKvadrata++;

                            //TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][figura1.kockice[0].KolonaKvadrata].JeFigura = true;
                           // TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[2].RedKvadrata][figura1.kockice[2].KolonaKvadrata].JeFigura = true;

                            figura1.kockice[0].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][figura1.kockice[0].KolonaKvadrata].Labela;
                            figura1.kockice[2].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[2].RedKvadrata][figura1.kockice[2].KolonaKvadrata].Labela;
                            figura1.kockice[0].Labela.BackColor = figura1.col;
                            figura1.kockice[2].Labela.BackColor = figura1.col;
                        }
                    }
                }

                if (figura1.kockice.Length == 4)
                {
                    if (figura1.kockice[2].KolonaKvadrata > 0 && figura1.kockice[2].KolonaKvadrata < Sirina - 1 && figura1.kockice[2].RedKvadrata < Visina - 1)
                    {
                        if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[2].RedKvadrata + 1][figura1.kockice[2].KolonaKvadrata].Labela.BackColor == Color.White)
                        {
                            
                            figura1.kockice[3].Labela.BackColor = Color.White;
                            //TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[3].RedKvadrata][figura1.kockice[3].KolonaKvadrata].JeFigura = false;
                            figura1.kockice[3].KolonaKvadrata--;
                            figura1.kockice[3].RedKvadrata++;
                            figura1.kockice[3].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[3].RedKvadrata][figura1.kockice[3].KolonaKvadrata].Labela;
                            figura1.kockice[3].Labela.BackColor = figura1.col;
                           // TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[3].RedKvadrata][figura1.kockice[3].KolonaKvadrata].JeFigura = true;
                        }
                        else if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[2].RedKvadrata][figura1.kockice[2].KolonaKvadrata + 1].Labela.BackColor == Color.White)
                        {
     
                            figura1.kockice[0].Labela.BackColor = Color.White;
                            //TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][figura1.kockice[0].KolonaKvadrata].JeFigura = false;
                            figura1.kockice[0].KolonaKvadrata++;
                            figura1.kockice[0].RedKvadrata++;
                            figura1.kockice[0].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][figura1.kockice[0].KolonaKvadrata].Labela;
                            figura1.kockice[0].Labela.BackColor = figura1.col;
                            //TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][figura1.kockice[0].KolonaKvadrata].JeFigura =true;
                        }
                        else if (TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[2].RedKvadrata - 1][figura1.kockice[2].KolonaKvadrata].Labela.BackColor == Color.White)
                        {
                            
                            figura1.kockice[1].Labela.BackColor = Color.White;
                           // TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata][figura1.kockice[1].KolonaKvadrata].JeFigura = false;
                            figura1.kockice[1].KolonaKvadrata++;
                            figura1.kockice[1].RedKvadrata--;
                            figura1.kockice[1].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata][figura1.kockice[1].KolonaKvadrata].Labela;
                            figura1.kockice[1].Labela.BackColor = figura1.col;
                           // TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata][figura1.kockice[1].KolonaKvadrata].JeFigura = true;

                        }
                        else if(TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[2].RedKvadrata][figura1.kockice[2].KolonaKvadrata-1].Labela.BackColor == Color.White)
                        {
                            figura1.kockice[1].Labela.BackColor = Color.White;
                            figura1.kockice[1].KolonaKvadrata--;
                            figura1.kockice[1].RedKvadrata++;
                            figura1.kockice[1].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata][figura1.kockice[1].KolonaKvadrata].Labela;
                            figura1.kockice[1].Labela.BackColor = figura1.col;
                           // TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[1].RedKvadrata][figura1.kockice[1].KolonaKvadrata].JeFigura = true;

                            figura1.kockice[0].Labela.BackColor = Color.White;
                            figura1.kockice[0].KolonaKvadrata--;
                            figura1.kockice[0].RedKvadrata--;
                            figura1.kockice[0].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[0].RedKvadrata][figura1.kockice[0].KolonaKvadrata].Labela;
                            figura1.kockice[0].Labela.BackColor = figura1.col;

                            //TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[3].RedKvadrata][figura1.kockice[3].KolonaKvadrata].JeFigura = false;
                            figura1.kockice[3].Labela.BackColor = Color.White;
                            figura1.kockice[3].KolonaKvadrata++;
                            figura1.kockice[3].RedKvadrata--;
                            figura1.kockice[3].Labela = TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[3].RedKvadrata][figura1.kockice[3].KolonaKvadrata].Labela;
                            figura1.kockice[3].Labela.BackColor = figura1.col;



                        }
                    }
                }
                for (int i = 0; i < figura1.kockice.Length; i++)
                    TetrisPodaci.Instanca.MatricaTetris[figura1.kockice[i].RedKvadrata][figura1.kockice[i].KolonaKvadrata].JeFigura =true;

            }
                
        }

        private void btnPauza_Click(object sender, EventArgs e)
        {
            if(indikatorPauze == false)
            {
                btnPauza.Text = "Nastavi igru";
                timer1.Stop();
                tajmerDodajObjekat.Stop();
                indikatorPauze = true;
                aktivnaIgra = false;
            }
            else if (indikatorPauze == true)
            {
                btnPauza.Text = "Pauza";
                timer1.Start();
                tajmerDodajObjekat.Start();
                indikatorPauze = false;
                aktivnaIgra = true;
            }
        }

        private void brnIgraci_Click(object sender, EventArgs e)
        {
            var frmlistaIgraca = new FormListaIgraca();

            frmlistaIgraca.StartPosition = FormStartPosition.CenterScreen;
            frmlistaIgraca.Show();
        }
    }
}
  

        
    

