using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematiksel_işem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bu kod batığın zaman label yada text vb. gibi kaybolur görünmez hale gelir
            label3.Visible= false;
            textBox2.Visible= false;
            label1.Text = "kare";
            label2.Visible = true;
            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox2.Visible = true;
            label1.Text = "dikdörtgen";
            label2.Visible = false;
            textBox1.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
        }
    }
}
