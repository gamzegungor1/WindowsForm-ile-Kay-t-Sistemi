using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsForm9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği verileri alıp veritabanına ekleyeceğiz.


            MessageBox.Show("Kayıt Eklendi");


            // Kayıt yapıldıktan sonra bir sonraki kayıda geçmek için ekrandaki
            // verilerin silinmesini bekleriz 
           

            //1.YOL(Bu yolda her textboxı tek tek sisteme giriyoruz silmesi için)
            /*textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;*/

            // bu yöntem daha uzun işlem gerektiren projelerde tek tek uğraşılmayacağı için 
            //pek tavsiye edilmiyor.

           


        }

        private void lbl_tlfno_Click(object sender, EventArgs e)
        {

        }
    }
}
