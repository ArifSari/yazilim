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
    public partial class Tesis_Ekle : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=mysql04.turhost.com;Port=3306;Database=arifsari;Uid=arifsar;Pwd='arif12345';");
       
        string secilifirma;


        public Tesis_Ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("INSERT INTO Tesis_Bilgileri (T_adi,T_yonetici, T_adresi, T_telno, T_bakimci) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + maskedTextBox1.Text + "','" + secilifirma + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Eklendi");
            baglanti.Close();
        }

        private void Tesis_Ekle_Load(object sender, EventArgs e)
        {
            firma_cek();

        }

        void firma_cek()
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT kullanici_id,personel_adi FROM Mobil_kullanicilar", baglanti);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
                comboBox1.Items.Add(dr[1]);

            }
            baglanti.Close();
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilifirma = comboBox2.Items[comboBox1.SelectedIndex].ToString();
        }
    }
}
