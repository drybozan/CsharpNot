using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance_miras_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DemoView demoView = new DemoView();
            DemoView demoView = new DemoView(false);
            MessageBox.Show(demoView.yas.ToString());
            //yas sorularında en son çalışan kurucu metoddaki yaş geçerlidir.Miras alan classta yas tanımlı değil ise miras aldığı classın yaşı geçerlidir

        }
    }
}
