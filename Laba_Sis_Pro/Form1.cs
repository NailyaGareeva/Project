using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_Sis_Pro
{
    public partial class Form1 : Form
    {
        private string filename;
        private bool showdialog = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!showdialog)
            {
                Close();
            }
            else
            {
                Form2 m2 = new Form2();
                m2.ShowDialog();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       public void saveAs()
        {
            if (showdialog || filename.Length == 0)
            {
                SaveFileDialog SFD = new SaveFileDialog();
                SFD.FileName = richTextBox1.Text;
                SFD.FileName = "MyFile";
                SFD.Filter = "Binary (*.bin)|*.bin|JSON (*.JSON)|*.JSON";
                try
                {
                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        filename = SFD.FileName;
                        showdialog = false;
                    }
                    else
                        return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            Save(filename);
            }
           
        }

        private void Save(string filename)
        {
            try
            {
                StreamWriter SW = new StreamWriter(filename);
                SW.Write(richTextBox1.Text.ToString());
                SW.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save("C:\\Users\\DNS\\Desktop\\Сиспро");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            openFileDialog1.Filter = "file (*.bin; *.JSON)|*.bin; *.JSON";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            richTextBox1.Text = openFileDialog1.FileName;
                            richTextBox1.Text = File.ReadAllText(richTextBox1.Text);// Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }


            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!showdialog)
            {
                richTextBox1.Clear();
            }
            else
            {
                Form2 m2 = new Form2();
                m2.ShowDialog();
                richTextBox1.Clear();
            }
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText(TextDataFormat.Text).ToString();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}