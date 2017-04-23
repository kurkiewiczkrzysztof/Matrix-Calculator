namespace KalkMacierzy
{
    partial class Mnozenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mnozenie));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textMNKol = new System.Windows.Forms.TextBox();
            this.textMNW = new System.Windows.Forms.TextBox();
            this.btnZatwierdzODJ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textMNW2 = new System.Windows.Forms.TextBox();
            this.textMNKol2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMNDod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj liczbe wierszy i kolumn pierwszej macierzy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "X";
            // 
            // textMNKol
            // 
            this.textMNKol.Location = new System.Drawing.Point(65, 25);
            this.textMNKol.Name = "textMNKol";
            this.textMNKol.Size = new System.Drawing.Size(23, 20);
            this.textMNKol.TabIndex = 9;
            // 
            // textMNW
            // 
            this.textMNW.Location = new System.Drawing.Point(15, 25);
            this.textMNW.Name = "textMNW";
            this.textMNW.Size = new System.Drawing.Size(25, 20);
            this.textMNW.TabIndex = 8;
            // 
            // btnZatwierdzODJ
            // 
            this.btnZatwierdzODJ.Location = new System.Drawing.Point(186, 81);
            this.btnZatwierdzODJ.Name = "btnZatwierdzODJ";
            this.btnZatwierdzODJ.Size = new System.Drawing.Size(75, 23);
            this.btnZatwierdzODJ.TabIndex = 11;
            this.btnZatwierdzODJ.Text = "Zatwierdz";
            this.btnZatwierdzODJ.UseVisualStyleBackColor = true;
            this.btnZatwierdzODJ.Click += new System.EventHandler(this.btnZatwierdzODJ_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Podaj liczbe wierszy i kolumn drugiej macierzy";
            // 
            // textMNW2
            // 
            this.textMNW2.Enabled = false;
            this.textMNW2.Location = new System.Drawing.Point(15, 64);
            this.textMNW2.Name = "textMNW2";
            this.textMNW2.Size = new System.Drawing.Size(25, 20);
            this.textMNW2.TabIndex = 8;
            // 
            // textMNKol2
            // 
            this.textMNKol2.Location = new System.Drawing.Point(65, 64);
            this.textMNKol2.Name = "textMNKol2";
            this.textMNKol2.Size = new System.Drawing.Size(23, 20);
            this.textMNKol2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // btnMNDod
            // 
            this.btnMNDod.Enabled = false;
            this.btnMNDod.Location = new System.Drawing.Point(276, 81);
            this.btnMNDod.Name = "btnMNDod";
            this.btnMNDod.Size = new System.Drawing.Size(75, 23);
            this.btnMNDod.TabIndex = 12;
            this.btnMNDod.Text = "Mnozenie";
            this.btnMNDod.UseVisualStyleBackColor = true;
            this.btnMNDod.Click += new System.EventHandler(this.btnMNDod_Click);
            // 
            // Mnozenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 351);
            this.Controls.Add(this.btnMNDod);
            this.Controls.Add(this.btnZatwierdzODJ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMNKol2);
            this.Controls.Add(this.textMNKol);
            this.Controls.Add(this.textMNW2);
            this.Controls.Add(this.textMNW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Mnozenie";
            this.Text = "Mnozenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMNKol;
        private System.Windows.Forms.TextBox textMNW;
        private System.Windows.Forms.Button btnZatwierdzODJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMNW2;
        private System.Windows.Forms.TextBox textMNKol2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMNDod;
    }
}