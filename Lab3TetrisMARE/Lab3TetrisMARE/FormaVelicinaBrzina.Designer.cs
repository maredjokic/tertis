namespace Lab3TetrisMARE
{
    partial class FormaVelicinaBrzina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numVisina = new System.Windows.Forms.NumericUpDown();
            this.numSirina = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBrzina = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIgraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numVisina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSirina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrzina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velicina polja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // numVisina
            // 
            this.numVisina.Location = new System.Drawing.Point(101, 99);
            this.numVisina.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numVisina.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numVisina.Name = "numVisina";
            this.numVisina.Size = new System.Drawing.Size(56, 20);
            this.numVisina.TabIndex = 4;
            this.numVisina.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numSirina
            // 
            this.numSirina.Location = new System.Drawing.Point(183, 99);
            this.numSirina.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSirina.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSirina.Name = "numSirina";
            this.numSirina.Size = new System.Drawing.Size(57, 20);
            this.numSirina.TabIndex = 5;
            this.numSirina.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brzina kretanja";
            // 
            // numBrzina
            // 
            this.numBrzina.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numBrzina.Location = new System.Drawing.Point(101, 134);
            this.numBrzina.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numBrzina.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numBrzina.Name = "numBrzina";
            this.numBrzina.Size = new System.Drawing.Size(113, 20);
            this.numBrzina.TabIndex = 7;
            this.numBrzina.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ms";
            // 
            // btnIgraj
            // 
            this.btnIgraj.Location = new System.Drawing.Point(101, 173);
            this.btnIgraj.Name = "btnIgraj";
            this.btnIgraj.Size = new System.Drawing.Size(64, 23);
            this.btnIgraj.TabIndex = 9;
            this.btnIgraj.Text = "Igraj";
            this.btnIgraj.UseVisualStyleBackColor = true;
            this.btnIgraj.Click += new System.EventHandler(this.btnIgraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prezime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ime:";
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(102, 27);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(138, 20);
            this.tbxIme.TabIndex = 12;
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(102, 62);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(138, 20);
            this.tbxPrezime.TabIndex = 13;
            // 
            // FormaVelicinaBrzina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(267, 213);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIgraj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numBrzina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSirina);
            this.Controls.Add(this.numVisina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaVelicinaBrzina";
            this.ShowIcon = false;
            this.Text = "FormaVelicinaBrzina";
            ((System.ComponentModel.ISupportInitialize)(this.numVisina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSirina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrzina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numVisina;
        private System.Windows.Forms.NumericUpDown numSirina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBrzina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIgraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.TextBox tbxPrezime;
    }
}