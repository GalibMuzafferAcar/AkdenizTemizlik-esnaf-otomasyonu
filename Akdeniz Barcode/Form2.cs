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
using System.Data.Sql;

namespace Akdeniz_Barcode
{
    public partial class Form2 : Form
    {
        SqlCommand cmd;
      
        SqlDataAdapter da;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection(Properties.Settings.Default.dbo_akdeniztemizlikConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {

            string urunekle = "insert into Urun (barkod,isim,fiyat,grup,stok) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"')";

            bagla.Open();
            SqlDataAdapter urun = new SqlDataAdapter("select * from urun where barkod ='" + textBox1.Text + "' ", bagla);
            DataTable tablo = new DataTable();
            urun.Fill(tablo);
            if (tablo.Rows.Count > 0)
            { bagla.Close();
                MessageBox.Show("bu barkod zaten kayıtlı");
            }

            else
            {
                SqlCommand ekle = new SqlCommand(urunekle, bagla);
                SqlDataReader MyReader;
                try
                {
                    
                    MyReader = ekle.ExecuteReader();
                    MessageBox.Show("Ürün Eklendi");
                    while (MyReader.Read()) { }

                    bagla.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
