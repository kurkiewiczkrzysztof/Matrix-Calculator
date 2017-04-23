namespace KalkMacierzy
{
    partial class Dodawanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodawanie));
            this.label1 = new System.Windows.Forms.Label();
            this.textDodW = new System.Windows.Forms.TextBox();
            this.textDodKol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDodZatwierdz = new System.Windows.Forms.Button();
            this.btnDodajDod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Podaj liczbe wierszy i kolumn";
            // 
            // textDodW
            // 
            this.textDodW.Location = new System.Drawing.Point(10, 25);
            this.textDodW.Name = "textDodW";
            this.textDodW.Size = new System.Drawing.Size(25, 20);
            this.textDodW.TabIndex = 5;
            // 
            // textDodKol
            // 
            this.textDodKol.Location = new System.Drawing.Point(60, 25);
            this.textDodKol.Name = "textDodKol";
            this.textDodKol.Size = new System.Drawing.Size(23, 20);
            this.textDodKol.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            // 
            // BtnDodZatwierdz
            // 
            this.BtnDodZatwierdz.Location = new System.Drawing.Point(99, 25);
            this.BtnDodZatwierdz.Name = "BtnDodZatwierdz";
            this.BtnDodZatwierdz.Size = new System.Drawing.Size(75, 23);
            this.BtnDodZatwierdz.TabIndex = 8;
            this.BtnDodZatwierdz.Text = "Zatwierdz";
            this.BtnDodZatwierdz.UseVisualStyleBackColor = true;
            this.BtnDodZatwierdz.Click += new System.EventHandler(this.BtnDodZatwierdz_Click);
            // 
            // btnDodajDod
            // 
            this.btnDodajDod.Enabled = false;
            this.btnDodajDod.Location = new System.Drawing.Point(190, 25);
            this.btnDodajDod.Name = "btnDodajDod";
            this.btnDodajDod.Size = new System.Drawing.Size(75, 23);
            this.btnDodajDod.TabIndex = 9;
            this.btnDodajDod.Text = "Dodaj!";
            this.btnDodajDod.UseVisualStyleBackColor = true;
            this.btnDodajDod.Click += new System.EventHandler(this.btnDodajDod_Click);
            // 
            // Dodawanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 351);
            this.Controls.Add(this.btnDodajDod);
            this.Controls.Add(this.BtnDodZatwierdz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDodKol);
            this.Controls.Add(this.textDodW);
            this.Controls.Add(this.label1);
            this.Name = "Dodawanie";
            this.Text = "Dodawanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDodW;
        private System.Windows.Forms.TextBox textDodKol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDodZatwierdz;
        private System.Windows.Forms.Button btnDodajDod;
    }
}