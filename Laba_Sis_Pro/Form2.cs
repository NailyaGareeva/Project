using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_Sis_Pro
{
   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           Application.Exit();
        }
           private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.saveAs();
            Close();
        }
       

            public void UploadFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Бинарные файлы|*.bin";
                ofd.Filter = "Текстовые файлы|*.JSON ";
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                   
                }
            }

        }
    }

}
