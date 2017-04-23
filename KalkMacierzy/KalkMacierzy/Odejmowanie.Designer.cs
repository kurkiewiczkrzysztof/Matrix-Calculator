namespace KalkMacierzy
{
    partial class Odejmowanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odejmowanie));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textODJKol = new System.Windows.Forms.TextBox();
            this.textODJW = new System.Windows.Forms.TextBox();
            this.BtnOdjZatwierdz = new System.Windows.Forms.Button();
            this.btnOdejmijDod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj liczbe wierszy i kolumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "X";
            // 
            // textODJKol
            // 
            this.textODJKol.Location = new System.Drawing.Point(66, 29);
            this.textODJKol.Name = "textODJKol";
            this.textODJKol.Size = new System.Drawing.Size(23, 20);
            this.textODJKol.TabIndex = 9;
            // 
            // textODJW
            // 
            this.textODJW.Location = new System.Drawing.Point(16, 29);
            this.textODJW.Name = "textODJW";
            this.textODJW.Size = new System.Drawing.Size(25, 20);
            this.textODJW.TabIndex = 8;
            // 
            // BtnOdjZatwierdz
            // 
            this.BtnOdjZatwierdz.Location = new System.Drawing.Point(107, 32);
            this.BtnOdjZatwierdz.Name = "BtnOdjZatwierdz";
            this.BtnOdjZatwierdz.Size = new System.Drawing.Size(75, 23);
            this.BtnOdjZatwierdz.TabIndex = 11;
            this.BtnOdjZatwierdz.Text = "Zatwierdz";
            this.BtnOdjZatwierdz.UseVisualStyleBackColor = true;
            this.BtnOdjZatwierdz.Click += new System.EventHandler(this.BtnOdjZatwierdz_Click);
            // 
            // btnOdejmijDod
            // 
            this.btnOdejmijDod.Enabled = false;
            this.btnOdejmijDod.Location = new System.Drawing.Point(203, 32);
            this.btnOdejmijDod.Name = "btnOdejmijDod";
            this.btnOdejmijDod.Size = new System.Drawing.Size(75, 23);
            this.btnOdejmijDod.TabIndex = 12;
            this.btnOdejmijDod.Text = "Odejmij!";
            this.btnOdejmijDod.UseVisualStyleBackColor = true;
            this.btnOdejmijDod.Click += new System.EventHandler(this.btnOdejmijDod_Click);
            // 
            // Odejmowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 351);
            this.Controls.Add(this.btnOdejmijDod);
            this.Controls.Add(this.BtnOdjZatwierdz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textODJKol);
            this.Controls.Add(this.textODJW);
            this.Controls.Add(this.label1);
            this.Name = "Odejmowanie";
            this.Text = "Odejmowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textODJKol;
        private System.Windows.Forms.TextBox textODJW;
        private System.Windows.Forms.Button BtnOdjZatwierdz;
        private System.Windows.Forms.Button btnOdejmijDod;
    }
}