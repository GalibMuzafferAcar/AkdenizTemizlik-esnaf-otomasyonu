using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.Barcode;
using System.Data.SqlClient;

namespace Akdeniz_Barcode
{
    public partial class Barcode_Scanner : Form
    {
        public Barcode_Scanner()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection(Properties.Settings.Default.dbo_akdeniztemizlikConnectionString);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            bagla.Open();
            SqlDataAdapter urun = new SqlDataAdapter("select * from urun where barkod ='" + textBox1.Text + "' ", bagla);
            DataTable tablo = new DataTable();
            urun.Fill(tablo);
            if (tablo.Rows.Count > 0)
            {
                textBox2.Text = tablo.Rows[0][2].ToString();
                textBox3.Text = tablo.Rows[0][3].ToString();
                textBox4.Text = tablo.Rows[0][4].ToString();
                bagla.Close();

            }
            else
            {
                bagla.Close();
                MessageBox.Show("böyle bir ürün bulunmamaktadır");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Barcode_Scanner_Load(object sender, EventArgs e)
        {

        }

        private void Barcode_Scanner_Shown(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           

                double sayi1, sayi2, sonuc;
                bagla.Open();
                SqlDataAdapter urun = new SqlDataAdapter("select * from urun where barkod ='" + textBox6.Text + "' ", bagla);
                DataTable tablo = new DataTable();
                urun.Fill(tablo);
                if (tablo.Rows.Count > 0)
                {

                    string[] row = new string[] { "'" + tablo.Rows[0][2].ToString() + "'", "" + tablo.Rows[0][4].ToString() + "", "" + tablo.Rows[0][3].ToString() + "", "" + textBox5.Text + "" };
                    dataGridView1.Rows.Add(row);
                    sayi1 = Convert.ToDouble(tablo.Rows[0][3]) * Convert.ToDouble(textBox5.Text);
                    sayi2 = Convert.ToDouble(textBox8.Text);
                    sonuc = sayi1 + sayi2;
                    textBox8.Text = sonuc.ToString();
                    textBox7.Text = sonuc.ToString() + " ₺ ";
                    bagla.Close();
                    textBox6.Text = "";

                }
                else
                {
                    bagla.Close();
                }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                double sayi1, sayi2, sonuc;
                string ssayi1, ssayi2;
                if (dataGridView1.Rows.Count > 1)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {

                        ssayi1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        ssayi2 = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                        sayi1 = Convert.ToDouble(ssayi1) * Convert.ToDouble(ssayi2);
                        sayi2 = Convert.ToDouble(textBox8.Text);
                        sonuc = sayi2 - sayi1;
                        textBox8.Text = sonuc.ToString();
                        textBox7.Text = sonuc.ToString() + " ₺ ";
                        dataGridView1.Rows.RemoveAt(row.Index);

                    }
                }

            }
            catch
            {
                MessageBox.Show("Hata! Bu bölge zaten boş.");
            }
            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
    }
