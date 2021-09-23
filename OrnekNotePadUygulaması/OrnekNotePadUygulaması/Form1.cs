using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrnekNotePadUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void islemAc(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void islemYeni(object sender, EventArgs e)
        {
            this.Text = "Yazı Dosyası-> Kayıtsız";
            richTextBox1.Text = "";

        }

        private void islemFarklıKaydet(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void islemKaydet(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName!="")
            {
                richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void silToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            islemFarklıKaydet(sender, e);
            Application.Exit();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            islemFarklıKaydet(sender, e);
            Application.Exit();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            islemKaydet(sender,e);
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islemKaydet(sender, e);
        }

        private void kaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            islemKaydet(sender, e);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            islemYeni(sender , e);
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islemYeni(sender, e);
        }


        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            islemAc(sender, e);
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islemAc(sender, e);
        }

        private void açToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            islemAc(sender, e);
        }


        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text ="Tarih: " + (DateTime.Now).ToString().Substring(0, 10);
            toolStripStatusLabel2.Text = "Saat: " + (DateTime.Now).ToString().Substring(9,8);
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islemFarklıKaydet(sender, e);
        }
      
    
        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void yardımKonularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void statusStrip1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void açToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.ShowDialog();
        }

        private void kaydetToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void silToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
