namespace Asansor_Ariza_Bakim
{
    partial class Ariza_ekle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tesis_sec = new System.Windows.Forms.ComboBox();
            this.personel_listesi = new System.Windows.Forms.ComboBox();
            this.aciklama_kutu = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tesis_sec);
            this.groupBox1.Controls.Add(this.personel_listesi);
            this.groupBox1.Controls.Add(this.aciklama_kutu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "arıza bilgileri";
            // 
            // tesis_sec
            // 
            this.tesis_sec.FormattingEnabled = true;
            this.tesis_sec.Location = new System.Drawing.Point(92, 39);
            this.tesis_sec.Name = "tesis_sec";
            this.tesis_sec.Size = new System.Drawing.Size(315, 21);
            this.tesis_sec.TabIndex = 5;
            // 
            // personel_listesi
            // 
            this.personel_listesi.FormattingEnabled = true;
            this.personel_listesi.Location = new System.Drawing.Point(92, 79);
            this.personel_listesi.Name = "personel_listesi";
            this.personel_listesi.Size = new System.Drawing.Size(315, 21);
            this.personel_listesi.TabIndex = 4;
            // 
            // aciklama_kutu
            // 
            this.aciklama_kutu.Location = new System.Drawing.Point(92, 123);
            this.aciklama_kutu.Name = "aciklama_kutu";
            this.aciklama_kutu.Size = new System.Drawing.Size(315, 41);
            this.aciklama_kutu.TabIndex = 3;
            this.aciklama_kutu.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arızalı Tesis";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 72);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Türkçe Karakter Kullanmayınız";
            // 
            // Ariza_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 244);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ariza_ekle";
            this.Text = "Arıza  Oluştur";
            this.Load += new System.EventHandler(this.Ariza_ekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox aciklama_kutu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tesis_sec;
        private System.Windows.Forms.ComboBox personel_listesi;
        private System.Windows.Forms.Label label4;

    }
}