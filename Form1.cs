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
    public partial class Form1 : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server=mysql04.turhost.com;Port=3306;Database=arifsari;Uid=arifsar;Pwd='arif12345';");
        public Form1()
        {
            InitializeComponent();
            yenile();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           

            Tesisler();
            Guncel_Arizalar();
            personel_cek();
            bakim_cek();
        }

        void Guncel_Arizalar()
        {
           // select * FROM Ariza_Bilgileri where tesis_id = '$tesis_id' and durum='0'

            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT ariza_id,tesis_id,bakimci_id,aciklama,durum,durum   FROM Ariza_Bilgileri where  durum='0'", baglanti);
            komut.ExecuteScalar();
            System.Data.DataTable dt = new System.Data.DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = komut;
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
            dataGridView2.Columns[dataGridView2.Columns.Count - 1].Visible = false;



        }


        void personel_cek()
            
        {


            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * ,kullanici_id from Mobil_kullanicilar", baglanti);
            komut.ExecuteScalar();
            System.Data.DataTable dt = new System.Data.DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = komut;
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            baglanti.Close();
            dataGridView3.Columns[dataGridView3.Columns.Count-1].Visible = false;


        
        }

        void Tesisler()
        {

            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT *,1 from Tesis_Bilgileri", baglanti);
            komut.ExecuteScalar();
            System.Data.DataTable dt = new System.Data.DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = komut;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;


            //"SELECT T_id, T.T_adi, T.T_adresi,T.T_yonetici, T.T_telno,(select Bakimci_adi from Bakimci_Bilgileri WHERE Bakimci_id = T_Bakimci ) AS 'Bakımcı', T.T_id FROM Tesis_Bilgileri AS T       
        }

        void yenile() {
            Tesisler();
            Guncel_Arizalar();
            personel_cek();
            bakim_cek();
            
        }
        void bakim_cek()
        {


            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * from Bakim_Bilgileri", baglanti);
            komut.ExecuteScalar();
            System.Data.DataTable dt = new System.Data.DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = komut;
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            baglanti.Close();
            dataGridView4.Columns[dataGridView4.Columns.Count - 1].Visible = false;



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 frm = new Form2();
           frm.label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           frm.T_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        private void yeniTesisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tesis_Ekle Tform = new Tesis_Ekle();
            Tform.ShowDialog();


        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bakım_Ekle_Guncelle Bform = new Bakım_Ekle_Guncelle();
          //  Bform.Islem_Lbl.Text = "0";
            Bform.ShowDialog();
        }

        private void bakımEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bakım_Ekle_Guncelle Bform = new Bakım_Ekle_Guncelle();
         
            Bform.Show();
        }

        private void elemanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_Eklee PForm = new Personel_Eklee();
            PForm.Show();
        }

       
        private void ariza_olustur_Click(object sender, EventArgs e)
        {
            Ariza_ekle Aform = new Ariza_ekle();
            Aform.ShowDialog();
        }

      

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                String id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                String ad = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show(id+ " "+ ad +"\n Silmek istediğinize emin misiniz?", "Silme İslemei", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try {
                        
                        baglanti.Open();
                        MySqlCommand komut = new MySqlCommand("DELETE FROM `arifsari`.`Tesis_Bilgileri` WHERE `Tesis_Bilgileri`.`T_id` = "+id+";", baglanti);
                        komut.ExecuteScalar();
                        baglanti.Close();
                        Tesisler();
                        Guncel_Arizalar();
                        MessageBox.Show("silme başarılı");
                    }
                    catch (Exception) {
                        MessageBox.Show("silme başarısız");
                    }
                    
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void dataGridView2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                String id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
               String ad = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show(id + "-- " + ad+ "\n Silmek istediğinize emin misiniz?", "Silme İslemei", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        baglanti.Open();
                        MySqlCommand komut = new MySqlCommand("DELETE FROM `arifsari`.`Ariza_Bilgileri` WHERE `Ariza_Bilgileri`.`ariza_id`= " + id + ";", baglanti);
                        komut.ExecuteScalar();
                        baglanti.Close();
                        Tesisler();
                        Guncel_Arizalar();
                        MessageBox.Show("silme başarılı");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("silme başarısız");
                    }


                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }


        private void dataGridView3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                String id = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                String ad = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show(id + "-- " + ad + "\n Silmek istediğinize emin misiniz?", "Silme İslemei", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        baglanti.Open();
                        MySqlCommand komut = new MySqlCommand("DELETE FROM `arifsari`.`Mobil_Kullanicilar` WHERE `Mobil_Kullanicilar`.`kullanici_adi` =" + id + ";", baglanti);
                        komut.ExecuteScalar();
                        baglanti.Close();
                        Tesisler();
                        Guncel_Arizalar();
                        MessageBox.Show("silme başarılı");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("silme başarısız");
                    }


                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }

        }

        private void dataGridView4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                String id = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
                String ad = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show(id + "-- " + ad + "\n Silmek istediğinize emin misiniz?", "Silme İslemei", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        baglanti.Open();
                        MySqlCommand komut = new MySqlCommand("DELETE FROM `arifsari`.`Bakim_Bilgileri` WHERE `Bakim_Bilgileri`.`b_id` = " + id + ";", baglanti);
                        komut.ExecuteScalar();
                        baglanti.Close();
                        Tesisler();
                        Guncel_Arizalar();
                        bakim_cek();
                        personel_cek();
                        MessageBox.Show("silme başarılı");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("silme başarısız");
                    }


                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
            String toplamAd = "";
            int satırSayisi = 0;
            String arananTesisAdi = textBox1.Text;
            //String ad = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            //MessageBox.Show(ad);
            for(int i=0;i<dataGridView1.RowCount;i++){
                satırSayisi++;

                String ad= dataGridView1.Rows[i].Cells[1].Value.ToString();

                if (ad.Equals(arananTesisAdi)) {
                    rowColor.BackColor = Color.Orange;
                    dataGridView1.Rows[i].DefaultCellStyle = rowColor;
                    MessageBox.Show("bulundu");
                }
            }

            
        }

        private void bakımEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bakım_Ekle_Guncelle Bform = new Bakım_Ekle_Guncelle();

            Bform.Show();
        }

        private void bakımEkleToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Bakım_Ekle_Guncelle Bform = new Bakım_Ekle_Guncelle();

            Bform.Show();

        }

        
    }
}
