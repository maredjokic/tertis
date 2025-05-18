using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3TetrisMARE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar=='a'|| e.KeyChar == 'A')
            //{
            //    TetrisUC.MrdajLevo();
            //}
            //else if (e.KeyChar == 'd' || e.KeyChar == 'D')
            //{
            //    TetrisUC.MrdajDesno();
            //}
            //else if (e.KeyChar == 's' || e.KeyChar == 'S')
            //{
            //    TetrisUC.MrdajNaDole();
            //}
            //else if(e.KeyChar =='w' || e.KeyChar == 'W')
            //{
            //    TetrisUC.Rotiraj();
            //}

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'a' || e.KeyValue == 'A')
            {
                TetrisUC.MrdajLevo();
            }
            else if (e.KeyValue == 'd' || e.KeyValue == 'D')
            {
                TetrisUC.MrdajDesno();
            }
            else if (e.KeyValue == 's' || e.KeyValue == 'S')
            {
                TetrisUC.MrdajNaDole();
            }
            else if (e.KeyValue == 'w' || e.KeyValue == 'W')
            {
                TetrisUC.Rotiraj();
            }
        
        }



    }
}
