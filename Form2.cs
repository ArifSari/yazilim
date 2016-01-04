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
    public partial class Form2 : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=mysql04.turhost.com;Port=3306;Database=arifsari;Uid=arifsar;Pwd='arif12345';");
       
        String tesis_id;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            tesis_id = T_id.Text;
            eski_arizalar();
            yapilan_bakimlar();
        }

        void eski_arizalar()
        {
            

            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * ,1 FROM Ariza_Bilgileri where tesis_id = '"+tesis_id+"' and durum ='1'", baglanti);
            komut.ExecuteScalar();
            System.Data.DataTable dt = new System.Data.DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = komut;
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            baglanti.Close();
            dataGridView4.Columns[dataGridView4.Columns.Count - 1].Visible = false;



        }

        void yapilan_bakimlar(){


            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT *,1  FROM Log_Bilgileri where tesis_id = '" + tesis_id + "'  ", baglanti);
            komut.ExecuteScalar();
            System.Data.DataTable dt = new System.Data.DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = komut;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            eski_arizalar();
            yapilan_bakimlar();
        }
                 
    }
}
