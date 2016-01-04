using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asansor_Ariza_Bakim
{
    public partial class Ariza_ekle : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server=mysql04.turhost.com;Port=3306;Database=arifsari;Uid=arifsar;Pwd='arif12345';");
        

        public Ariza_ekle()
        {
            InitializeComponent();
        }

        private void Ariza_ekle_Load(object sender, EventArgs e)
        {
            tesis_cek();
            personel_cek();
        }


        void tesis_cek()
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT T_id,T_adi FROM Tesis_Bilgileri", baglanti);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string tesis_tanitim = "";
                tesis_tanitim = dr[0].ToString()+" "+dr[1];
                tesis_sec.Items.Add(tesis_tanitim);
              

            }
            baglanti.Close();
            tesis_sec.SelectedIndex = 0;
          

        }

        void personel_cek()
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT kullanici_id,personel_adi FROM Mobil_kullanicilar", baglanti);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string bakimci_tanitim = "";
                bakimci_tanitim = dr[0].ToString() + " " + dr[1];
                personel_listesi.Items.Add(bakimci_tanitim);


            }
            baglanti.Close();
            personel_listesi.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String []personel_id = personel_listesi.Text.Split(' ');
                String[] tesis_id = tesis_sec.Text.Split(' ');
                baglanti.Open();
                 MySqlCommand komut = new MySqlCommand("INSERT INTO Ariza_Bilgileri (bakimci_id,tesis_id, aciklama) VALUES ('" + personel_id[0] + "', '" + tesis_id[0] + "', '" + aciklama_kutu.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Eklendi" );
                baglanti.Close();
            }
            catch (Exception) {

                MessageBox.Show("ariza ekleme başarısız.");
            }
           
        }
    }
}
