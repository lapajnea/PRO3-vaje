
namespace Vaje10
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
            this.label1 = new System.Windows.Forms.Label();
            this.gmbDodaj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gmbPrikaz = new System.Windows.Forms.Button();
            this.comboBoxIzbira = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxDodaj = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj";
            // 
            // gmbDodaj
            // 
            this.gmbDodaj.Location = new System.Drawing.Point(34, 109);
            this.gmbDodaj.Name = "gmbDodaj";
            this.gmbDodaj.Size = new System.Drawing.Size(107, 25);
            this.gmbDodaj.TabIndex = 4;
            this.gmbDodaj.Text = "Dodaj";
            this.gmbDodaj.UseVisualStyleBackColor = true;
            this.gmbDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(362, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 264);
            this.listBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(198, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Seznam: ";
            // 
            // gmbPrikaz
            // 
            this.gmbPrikaz.Location = new System.Drawing.Point(191, 109);
            this.gmbPrikaz.Name = "gmbPrikaz";
            this.gmbPrikaz.Size = new System.Drawing.Size(107, 25);
            this.gmbPrikaz.TabIndex = 4;
            this.gmbPrikaz.Text = "Prikaz";
            this.gmbPrikaz.UseVisualStyleBackColor = true;
            this.gmbPrikaz.Click += new System.EventHandler(this.gmbPrikaz_Click);
            // 
            // comboBoxIzbira
            // 
            this.comboBoxIzbira.FormattingEnabled = true;
            this.comboBoxIzbira.Items.AddRange(new object[] {
            "Člani",
            "Knjige"});
            this.comboBoxIzbira.Location = new System.Drawing.Point(201, 69);
            this.comboBoxIzbira.Name = "comboBoxIzbira";
            this.comboBoxIzbira.Size = new System.Drawing.Size(128, 21);
            this.comboBoxIzbira.TabIndex = 7;
            this.comboBoxIzbira.Text = "Prosim izberi tabelo...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Izberi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxDodaj
            // 
            this.comboBoxDodaj.FormattingEnabled = true;
            this.comboBoxDodaj.Items.AddRange(new object[] {
            "Člana",
            "Knjigo"});
            this.comboBoxDodaj.Location = new System.Drawing.Point(34, 69);
            this.comboBoxDodaj.Name = "comboBoxDodaj";
            this.comboBoxDodaj.Size = new System.Drawing.Size(128, 21);
            this.comboBoxDodaj.TabIndex = 7;
            this.comboBoxDodaj.Text = "Prosim izberi ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxDodaj);
            this.Controls.Add(this.comboBoxIzbira);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gmbPrikaz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gmbDodaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gmbDodaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button gmbPrikaz;
        private System.Windows.Forms.ComboBox comboBoxIzbira;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxDodaj;
    }
}

