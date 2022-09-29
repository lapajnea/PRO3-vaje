namespace Vaje10
{
    partial class DodajClana
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
            this.lblSpol = new System.Windows.Forms.Label();
            this.lblStarost = new System.Windows.Forms.Label();
            this.lblPriimek = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.boxSpol = new System.Windows.Forms.TextBox();
            this.boxStarost = new System.Windows.Forms.TextBox();
            this.boxPriimek = new System.Windows.Forms.TextBox();
            this.boxIme = new System.Windows.Forms.TextBox();
            this.gmbDodajClana = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSpol
            // 
            this.lblSpol.AutoSize = true;
            this.lblSpol.Location = new System.Drawing.Point(36, 123);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(34, 13);
            this.lblSpol.TabIndex = 10;
            this.lblSpol.Text = "Spol: ";
            // 
            // lblStarost
            // 
            this.lblStarost.AutoSize = true;
            this.lblStarost.Location = new System.Drawing.Point(36, 94);
            this.lblStarost.Name = "lblStarost";
            this.lblStarost.Size = new System.Drawing.Size(43, 13);
            this.lblStarost.TabIndex = 11;
            this.lblStarost.Text = "Starost:";
            // 
            // lblPriimek
            // 
            this.lblPriimek.AutoSize = true;
            this.lblPriimek.Location = new System.Drawing.Point(36, 68);
            this.lblPriimek.Name = "lblPriimek";
            this.lblPriimek.Size = new System.Drawing.Size(44, 13);
            this.lblPriimek.TabIndex = 12;
            this.lblPriimek.Text = "Priimek:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(36, 42);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 13;
            this.lblIme.Text = "Ime:";
            // 
            // boxSpol
            // 
            this.boxSpol.Location = new System.Drawing.Point(3, 29);
            this.boxSpol.Name = "boxSpol";
            this.boxSpol.Size = new System.Drawing.Size(167, 20);
            this.boxSpol.TabIndex = 5;
            // 
            // boxStarost
            // 
            this.boxStarost.Location = new System.Drawing.Point(3, 3);
            this.boxStarost.Name = "boxStarost";
            this.boxStarost.Size = new System.Drawing.Size(167, 20);
            this.boxStarost.TabIndex = 6;
            // 
            // boxPriimek
            // 
            this.boxPriimek.Location = new System.Drawing.Point(3, 55);
            this.boxPriimek.Name = "boxPriimek";
            this.boxPriimek.Size = new System.Drawing.Size(167, 20);
            this.boxPriimek.TabIndex = 7;
            // 
            // boxIme
            // 
            this.boxIme.Location = new System.Drawing.Point(3, 81);
            this.boxIme.Name = "boxIme";
            this.boxIme.Size = new System.Drawing.Size(167, 20);
            this.boxIme.TabIndex = 8;
            // 
            // gmbDodajClana
            // 
            this.gmbDodajClana.Location = new System.Drawing.Point(76, 176);
            this.gmbDodajClana.Name = "gmbDodajClana";
            this.gmbDodajClana.Size = new System.Drawing.Size(153, 53);
            this.gmbDodajClana.TabIndex = 3;
            this.gmbDodajClana.Text = "Dodaj clana";
            this.gmbDodajClana.UseVisualStyleBackColor = true;
            this.gmbDodajClana.Click += new System.EventHandler(this.gmbDodajClana_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boxStarost);
            this.panel1.Controls.Add(this.boxSpol);
            this.panel1.Controls.Add(this.boxPriimek);
            this.panel1.Controls.Add(this.boxIme);
            this.panel1.Location = new System.Drawing.Point(76, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 117);
            this.panel1.TabIndex = 14;
            // 
            // DodajClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 241);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSpol);
            this.Controls.Add(this.lblStarost);
            this.Controls.Add(this.lblPriimek);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.gmbDodajClana);
            this.Name = "DodajClana";
            this.Text = "DodajClana";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSpol;
        private System.Windows.Forms.Label lblStarost;
        private System.Windows.Forms.Label lblPriimek;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox boxSpol;
        private System.Windows.Forms.TextBox boxStarost;
        private System.Windows.Forms.TextBox boxPriimek;
        private System.Windows.Forms.TextBox boxIme;
        private System.Windows.Forms.Button gmbDodajClana;
        private System.Windows.Forms.FlowLayoutPanel panel1;
    }
}