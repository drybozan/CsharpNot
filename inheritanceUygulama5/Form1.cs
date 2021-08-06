using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Dede dede = new Dede("sjsjsj",5454);
           /* Baba baba = new Baba();
             MessageBox.Show(Baba.yas.ToString());*/
             
            /*Dede dede2 = new Dede();
            Dede.yas = 97;//statik bir değişkene ulaşmak için sadece klass ismiyle ulaşabiliriz.
            MessageBox.Show(Dede.yas.ToString());
            Cocuk cocuk = new Cocuk();
            Cocuk.yas = 888888;  //miras aldığı halde yine klas ismi ile ulaşabilir
            MessageBox.Show(Cocuk.yas.ToString()); //888888
            MessageBox.Show(Dede.yas.ToString());//888888
            MessageBox.Show(Baba.yas.ToString());//888888*/
            // Dede.maas1();  //çıktı:925478 statik değişken statik fonksiyon
            //Dede.maas1();  //hata veriri statik değişken,statik olmayan fonksiyon;statik fonksiyon gerekli
           // Dede.maas1();  //statik olmayan bir değişkeni statik alanda kullanamayız

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
