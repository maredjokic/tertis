namespace Lab3TetrisMARE
{
    partial class FormListaIgraca
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbxIgraci = new System.Windows.Forms.ListBox();
            this.btnIskljuci = new System.Windows.Forms.Button();
            this.timerIgraci = new System.Windows.Forms.Timer(this.components);
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxIgraci
            // 
            this.lbxIgraci.FormattingEnabled = true;
            this.lbxIgraci.HorizontalScrollbar = true;
            this.lbxIgraci.Location = new System.Drawing.Point(12, 12);
            this.lbxIgraci.MultiColumn = true;
            this.lbxIgraci.Name = "lbxIgraci";
            this.lbxIgraci.ScrollAlwaysVisible = true;
            this.lbxIgraci.Size = new System.Drawing.Size(316, 303);
            this.lbxIgraci.TabIndex = 0;
            this.lbxIgraci.SelectedIndexChanged += new System.EventHandler(this.lbxIgraci_SelectedIndexChanged);
            // 
            // btnIskljuci
            // 
            this.btnIskljuci.Location = new System.Drawing.Point(12, 352);
            this.btnIskljuci.Name = "btnIskljuci";
            this.btnIskljuci.Size = new System.Drawing.Size(100, 41);
            this.btnIskljuci.TabIndex = 1;
            this.btnIskljuci.Text = "Iskljuci";
            this.btnIskljuci.UseVisualStyleBackColor = true;
            this.btnIskljuci.Click += new System.EventHandler(this.btnIskljuci_Click);
            // 
            // timerIgraci
            // 
            this.timerIgraci.Interval = 1500;
            this.timerIgraci.Tick += new System.EventHandler(this.timerIgraci_Tick);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(204, 386);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(124, 36);
            this.btnUcitaj.TabIndex = 2;
            this.btnUcitaj.Text = "Ucitaj iz XML";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(204, 331);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(124, 36);
            this.btnUpisi.TabIndex = 3;
            this.btnUpisi.Text = "Upisi u XML";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // FormListaIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(340, 446);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnIskljuci);
            this.Controls.Add(this.lbxIgraci);
            this.Name = "FormListaIgraca";
            this.ShowIcon = false;
            this.Text = "FormListaIgraca";
            this.Load += new System.EventHandler(this.FormListaIgraca_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxIgraci;
        private System.Windows.Forms.Button btnIskljuci;
        private System.Windows.Forms.Timer timerIgraci;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnUpisi;
    }
}