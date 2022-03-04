using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Mod2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void label1_click(object sender, eventargs e)
        //{

        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // ngambil nama terus kirim ke label ketika submit ditekan
            string var;
            var = label1.Text;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //label1.Text = "Hello World!";
            label1.Text = textBox1.Text;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // mendapatkan nama dari textbox

        }

        
    }
}
