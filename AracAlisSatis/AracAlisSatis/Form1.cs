using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracAlisSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bglsatir = "Server=localhost;Database=aracdatabase;port=3306;persistsecurityinfo=True;SslMode=none;Uid=root;Pwd='1234';";
            MySqlConnection bgl = new MySqlConnection(bglsatir);
            bgl.Open();

            if (bgl.State != ConnectionState.Closed)
            {
               
                string komut = "insert into Tbl_Renk(RenkID,Renk) values('" + txtIlanAdi.Text + "', '" + txtMarka.Text + "')";
                MySqlCommand kmt = new MySqlCommand(komut, bgl);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Baglanti Oldu!");

            }
               

            else
                MessageBox.Show("baglanti kurulamadi.");
            bgl.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
