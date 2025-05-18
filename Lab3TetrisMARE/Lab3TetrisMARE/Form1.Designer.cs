namespace Lab3TetrisMARE
{
    partial class Form1
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
            this.tetrisUC1 = new Lab3TetrisMARE.TetrisUC();
            this.SuspendLayout();
            // 
            // tetrisUC1
            // 
            this.tetrisUC1.BackColor = System.Drawing.Color.Thistle;
            this.tetrisUC1.Location = new System.Drawing.Point(2, 1);
            this.tetrisUC1.Name = "tetrisUC1";
            this.tetrisUC1.Size = new System.Drawing.Size(761, 655);
            this.tetrisUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 658);
            this.Controls.Add(this.tetrisUC1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tetris MARE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private TetrisUC tetrisUC1;
    }
}

