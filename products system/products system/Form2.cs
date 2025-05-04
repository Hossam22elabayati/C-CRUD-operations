using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace products_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim(' ') =="osama"  && textBox2.Text=="123")
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
                
            }
            else if (textBox1.Text.Trim(' ')=="" || textBox2.Text=="")
            {
                MessageBox.Show("enter password or user name ", "not sucess ", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
