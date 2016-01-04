using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Asansor_Ariza_Bakim
{
    public partial class Bakım_Ekle_Guncelle : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=mysql04.turhost.com;Port=3306;Database=arifsari;Uid=arifsar;Pwd='arif12345';");


        public Bakım_Ekle_Guncelle()
        {
            InitializeComponent();
        }

        private void Bakım_Ekle_Guncelle_Load(object sender, EventArgs e)
        {
            
         
          
        }

      

       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Length != 0)
                {
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("INSERT INTO Bakim_Bilgileri (b_adi) VALUES ('" + textBox2.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Bakim Eklendi");
                    baglanti.Close();
                }
                else
                { MessageBox.Show("Bakim İsmi Boş Geçilemez"); }
            }
            catch (Exception) {
                MessageBox.Show("Bakım Eklenemedi");
            }
        }

     

       

    }
}
