using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Akdeniz_Barcode
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection(Properties.Settings.Default.dbo_akdeniztemizlikConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            string isimch = "update urun set isim='" + textBox2.Text + "'where id ='" + textBox1.Text + "' ";
            bagla.Open();
            SqlCommand ch = new SqlCommand(isimch, bagla);
            SqlDataReader MyReader;
            try
            {

                MyReader = ch.ExecuteReader();
                MessageBox.Show("Ürün İsmi Güncellendi");
                while (MyReader.Read()) { }

                bagla.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            bagla.Open();
            SqlDataAdapter urun = new SqlDataAdapter("select * from urun", bagla);
            DataTable tablo = new DataTable();
            urun.Fill(tablo);
            string[] row = new string[] { "'" + tablo.Rows[0][1].ToString() + "'", "" + tablo.Rows[0][2].ToString() + "", "" + tablo.Rows[0][3].ToString() + "", "" + tablo.Rows[0][4].ToString() + "", "" + tablo.Rows[0][5].ToString() + "" };
            dataGridView1.DataSource = tablo;
            bagla.Close();


        }
        private void Form3_Load(object sender, EventArgs e)
        {
            bagla.Open();
            SqlDataAdapter urun = new SqlDataAdapter("select * from urun" , bagla);
            DataTable tablo = new DataTable();
            urun.Fill(tablo);
            string[] row = new string[] { "'" + tablo.Rows[0][1].ToString() + "'", "" + tablo.Rows[0][2].ToString() + "", "" + tablo.Rows[0][3].ToString() + "", "" + tablo.Rows[0][4].ToString() + "", "" + tablo.Rows[0][5].ToString() + "" };
            dataGridView1.DataSource=tablo;
            bagla.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fiyatch = "update urun set fiyat='" + textBox3.Text + "'where id ='" + textBox1.Text + "' ";
            bagla.Open();
            SqlCommand ch = new SqlCommand(fiyatch, bagla);
            SqlDataReader MyReader;
            try
            {

                MyReader = ch.ExecuteReader();
                MessageBox.Show("Ürün Fiyatı Güncellendi");
                while (MyReader.Read()) { }

                bagla.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            bagla.Open();
            SqlDataAdapter urun = new SqlDataAdapter("select * from urun", bagla);
            DataTable tablo = new DataTable();
            urun.Fill(tablo);
            string[] row = new string[] { "'" + tablo.Rows[0][1].ToString() + "'", "" + tablo.Rows[0][2].ToString() + "", "" + tablo.Rows[0][3].ToString() + "", "" + tablo.Rows[0][4].ToString() + "", "" + tablo.Rows[0][5].ToString() + "" };
            dataGridView1.DataSource = tablo;
            bagla.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string grupch = "update urun set grup='" + textBox4.Text + "'where id ='" + textBox1.Text + "' ";
            bagla.Open();
            SqlCommand ch = new SqlCommand(grupch, bagla);
            SqlDataReader MyReader;
            try
            {

                MyReader = ch.ExecuteReader();
                MessageBox.Show("Ürün Grubu Güncellendi");
                while (MyReader.Read()) { }

                bagla.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            bagla.Open();
            SqlDataAdapter urun = new SqlDataAdapter("select * from urun", bagla);
            DataTable tablo = new DataTable();
            urun.Fill(tablo);
            string[] row = new string[] { "'" + tablo.Rows[0][1].ToString() + "'", "" + tablo.Rows[0][2].ToString() + "", "" + tablo.Rows[0][3].ToString() + "", "" + tablo.Rows[0][4].ToString() + "", "" + tablo.Rows[0][5].ToString() + "" };
            dataGridView1.DataSource = tablo;
            bagla.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string stokch = "update urun set stok='" + textBox5.Text + "'where id ='" + textBox1.Text + "' ";
            bagla.Open();
            SqlCommand ch = new SqlCommand(stokch, bagla);
            SqlDataReader MyReader;
            try
            {

                MyReader = ch.ExecuteReader();
                MessageBox.Show("Ürün Stok Güncellendi");
                while (MyReader.Read()) { }

                bagla.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            bagla.Open();
            SqlDataAdapter urun = new SqlDataAdapter("select * from urun", bagla);
            DataTable tablo = new DataTable();
            urun.Fill(tablo);
            string[] row = new string[] { "'" + tablo.Rows[0][1].ToString() + "'", "" + tablo.Rows[0][2].ToString() + "", "" + tablo.Rows[0][3].ToString() + "", "" + tablo.Rows[0][4].ToString() + "", "" + tablo.Rows[0][5].ToString() + "" };
            dataGridView1.DataSource = tablo;
            bagla.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sil = "delete urun where id ='" + textBox1.Text + "' ";
            bagla.Open();
            SqlCommand ch = new SqlCommand(sil, bagla);
            SqlDataReader MyReader;
            try
            {

                MyReader = ch.ExecuteReader();
                MessageBox.Show("Ürün Silindi");
                while (MyReader.Read()) { }

                bagla.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            bagla.Open();
            SqlDataAdapter urun = new SqlDataAdapter("select * from urun", bagla);
            DataTable tablo = new DataTable();
            urun.Fill(tablo);
            string[] row = new string[] { "'" + tablo.Rows[0][1].ToString() + "'", "" + tablo.Rows[0][2].ToString() + "", "" + tablo.Rows[0][3].ToString() + "", "" + tablo.Rows[0][4].ToString() + "", "" + tablo.Rows[0][5].ToString() + "" };
            dataGridView1.DataSource = tablo;
            bagla.Close();
        }
    }
}
