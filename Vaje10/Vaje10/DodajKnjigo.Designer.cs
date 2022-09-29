namespace Vaje10
{
    partial class DodajKnjigo
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
            this.gmbDodajKnjigo = new System.Windows.Forms.Button();
            this.boxNaslov = new System.Windows.Forms.TextBox();
            this.boxAvtor = new System.Windows.Forms.TextBox();
            this.boxZanr = new System.Windows.Forms.TextBox();
            this.boxLetoIzdaje = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblAvtor = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblLetoIzdaje = new System.Windows.Forms.Label();
            this.boxZalozba = new System.Windows.Forms.TextBox();
            this.lblZalozba = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmbDodajKnjigo
            // 
            this.gmbDodajKnjigo.Location = new System.Drawing.Point(79, 212);
            this.gmbDodajKnjigo.Name = "gmbDodajKnjigo";
            this.gmbDodajKnjigo.Size = new System.Drawing.Size(153, 53);
            this.gmbDodajKnjigo.TabIndex = 0;
            this.gmbDodajKnjigo.Text = "Dodaj knjigo";
            this.gmbDodajKnjigo.UseVisualStyleBackColor = true;
            this.gmbDodajKnjigo.Click += new System.EventHandler(this.gmbDodajKnjigo_Click);
            // 
            // boxNaslov
            // 
            this.boxNaslov.Location = new System.Drawing.Point(5, 24);
            this.boxNaslov.Name = "boxNaslov";
            this.boxNaslov.Size = new System.Drawing.Size(167, 20);
            this.boxNaslov.TabIndex = 1;
            // 
            // boxAvtor
            // 
            this.boxAvtor.Location = new System.Drawing.Point(5, 53);
            this.boxAvtor.Name = "boxAvtor";
            this.boxAvtor.Size = new System.Drawing.Size(167, 20);
            this.boxAvtor.TabIndex = 1;
            // 
            // boxZanr
            // 
            this.boxZanr.Location = new System.Drawing.Point(5, 79);
            this.boxZanr.Name = "boxZanr";
            this.boxZanr.Size = new System.Drawing.Size(167, 20);
            this.boxZanr.TabIndex = 1;
            // 
            // boxLetoIzdaje
            // 
            this.boxLetoIzdaje.Location = new System.Drawing.Point(5, 105);
            this.boxLetoIzdaje.Name = "boxLetoIzdaje";
            this.boxLetoIzdaje.Size = new System.Drawing.Size(167, 20);
            this.boxLetoIzdaje.TabIndex = 1;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(29, 32);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(43, 13);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "Naslov:";
            // 
            // lblAvtor
            // 
            this.lblAvtor.AutoSize = true;
            this.lblAvtor.Location = new System.Drawing.Point(29, 58);
            this.lblAvtor.Name = "lblAvtor";
            this.lblAvtor.Size = new System.Drawing.Size(35, 13);
            this.lblAvtor.TabIndex = 2;
            this.lblAvtor.Text = "Avtor:";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Location = new System.Drawing.Point(29, 84);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(32, 13);
            this.lblZanr.TabIndex = 2;
            this.lblZanr.Text = "Žanr:";
            // 
            // lblLetoIzdaje
            // 
            this.lblLetoIzdaje.AutoSize = true;
            this.lblLetoIzdaje.Location = new System.Drawing.Point(11, 110);
            this.lblLetoIzdaje.Name = "lblLetoIzdaje";
            this.lblLetoIzdaje.Size = new System.Drawing.Size(62, 13);
            this.lblLetoIzdaje.TabIndex = 2;
            this.lblLetoIzdaje.Text = "Leto Izdaje:";
            // 
            // boxZalozba
            // 
            this.boxZalozba.Location = new System.Drawing.Point(5, 131);
            this.boxZalozba.Name = "boxZalozba";
            this.boxZalozba.Size = new System.Drawing.Size(167, 20);
            this.boxZalozba.TabIndex = 1;
            // 
            // lblZalozba
            // 
            this.lblZalozba.AutoSize = true;
            this.lblZalozba.Location = new System.Drawing.Point(10, 139);
            this.lblZalozba.Name = "lblZalozba";
            this.lblZalozba.Size = new System.Drawing.Size(51, 13);
            this.lblZalozba.TabIndex = 2;
            this.lblZalozba.Text = "Založba: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boxZalozba);
            this.panel1.Controls.Add(this.boxLetoIzdaje);
            this.panel1.Controls.Add(this.boxZanr);
            this.panel1.Controls.Add(this.boxAvtor);
            this.panel1.Controls.Add(this.boxNaslov);
            this.panel1.Location = new System.Drawing.Point(74, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 174);
            this.panel1.TabIndex = 3;
            // 
            // DodajKnjigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblZalozba);
            this.Controls.Add(this.lblLetoIzdaje);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.lblAvtor);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.gmbDodajKnjigo);
            this.Name = "DodajKnjigo";
            this.Text = "DodajKnjigo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gmbDodajKnjigo;
        private System.Windows.Forms.TextBox boxNaslov;
        private System.Windows.Forms.TextBox boxAvtor;
        private System.Windows.Forms.TextBox boxZanr;
        private System.Windows.Forms.TextBox boxLetoIzdaje;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblAvtor;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblLetoIzdaje;
        private System.Windows.Forms.TextBox boxZalozba;
        private System.Windows.Forms.Label lblZalozba;
        private System.Windows.Forms.Panel panel1;
    }
}