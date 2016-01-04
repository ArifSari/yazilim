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
    public partial class Personel_Eklee : Form
    { MySqlConnection baglanti = new MySqlConnection("Server=mysql04.turhost.com;Port=3306;Database=arifsari;Uid=arifsar;Pwd='arif12345';");
       

        public Personel_Eklee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
{

    if (kullanici_adi_text.Text==null|| personel_adi_text.Text == null || parola_text.Text == null || seviye_box.SelectedItem == null)
    {

        MessageBox.Show("bosluklari doldurun");
    }
    else {
        baglanti.Open();
        MySqlCommand komut = new MySqlCommand("INSERT INTO Mobil_kullanicilar (kullanici_adi,parola,seviye,personel_adi) VALUES ('" + kullanici_adi_text.Text + "', '" + parola_text.Text + "', '" + seviye_box.SelectedIndex + "', '" + personel_adi_text.Text + "')", baglanti);
        komut.ExecuteNonQuery();
        MessageBox.Show("Eklendi");
        baglanti.Close();
        
    }
}

            catch (Exception )
            {
                MessageBox.Show("hata oluştu");
            }
        }
    }
}
