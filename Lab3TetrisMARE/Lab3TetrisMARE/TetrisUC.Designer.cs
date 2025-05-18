namespace Lab3TetrisMARE
{
    partial class TetrisUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnZapocni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojPoena = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tajmerDodajObjekat = new System.Windows.Forms.Timer(this.components);
            this.btnPauza = new System.Windows.Forms.Button();
            this.brnIgraci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZapocni
            // 
            this.btnZapocni.Location = new System.Drawing.Point(19, 14);
            this.btnZapocni.Name = "btnZapocni";
            this.btnZapocni.Size = new System.Drawing.Size(109, 36);
            this.btnZapocni.TabIndex = 0;
            this.btnZapocni.Text = "Zapocni novu igru";
            this.btnZapocni.UseVisualStyleBackColor = true;
            this.btnZapocni.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.3F);
            this.label1.Location = new System.Drawing.Point(410, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj poena:";
            // 
            // lblBrojPoena
            // 
            this.lblBrojPoena.AutoSize = true;
            this.lblBrojPoena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.3F);
            this.lblBrojPoena.Location = new System.Drawing.Point(538, 25);
            this.lblBrojPoena.Name = "lblBrojPoena";
            this.lblBrojPoena.Size = new System.Drawing.Size(24, 25);
            this.lblBrojPoena.TabIndex = 2;
            this.lblBrojPoena.Text = "0";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.3F);
            this.lblVreme.Location = new System.Drawing.Point(357, 25);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(24, 25);
            this.lblVreme.TabIndex = 4;
            this.lblVreme.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.3F);
            this.label4.Location = new System.Drawing.Point(271, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vreme:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tajmerDodajObjekat
            // 
            this.tajmerDodajObjekat.Interval = 1000;
            this.tajmerDodajObjekat.Tick += new System.EventHandler(this.tajmerDodajObjekat_Tick);
            // 
            // btnPauza
            // 
            this.btnPauza.Location = new System.Drawing.Point(143, 14);
            this.btnPauza.Name = "btnPauza";
            this.btnPauza.Size = new System.Drawing.Size(109, 36);
            this.btnPauza.TabIndex = 5;
            this.btnPauza.Text = "Pauza";
            this.btnPauza.UseVisualStyleBackColor = true;
            this.btnPauza.Click += new System.EventHandler(this.btnPauza_Click);
            // 
            // brnIgraci
            // 
            this.brnIgraci.Location = new System.Drawing.Point(589, 14);
            this.brnIgraci.Name = "brnIgraci";
            this.brnIgraci.Size = new System.Drawing.Size(122, 36);
            this.brnIgraci.TabIndex = 6;
            this.brnIgraci.Text = "Igraci";
            this.brnIgraci.UseVisualStyleBackColor = true;
            this.brnIgraci.Click += new System.EventHandler(this.brnIgraci_Click);
            // 
            // TetrisUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Controls.Add(this.brnIgraci);
            this.Controls.Add(this.btnPauza);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBrojPoena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZapocni);
            this.Name = "TetrisUC";
            this.Size = new System.Drawing.Size(761, 690);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZapocni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojPoena;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tajmerDodajObjekat;
        private System.Windows.Forms.Button btnPauza;
        private System.Windows.Forms.Button brnIgraci;
    }
}
