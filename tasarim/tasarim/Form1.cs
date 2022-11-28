using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

//Anti virüs uygulamasından "dosya antivürüsü" ve uygulama denetimi" ni kapatman gerekiyor bu bağlantıyı yaptıktan sonra yoksa uygulaman çalışmaz

namespace tasarim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=LAPTOP-63TIC6E6\\SQLEXPRESS;Database=GorselProgramlama;User Id=tasarim;Password=123; connection timeout=30;";
            SqlConnection conn= new SqlConnection();
            conn.ConnectionString= ConnectionString;
            conn.Open();
            MessageBox.Show("Bağlantı Açıldı.");
            conn.Close();


        }
    }
}
