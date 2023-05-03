using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.calitha.goldparser;

namespace CodeWave
{
    public partial class Compiler : Form
    {
        MyParser p;
        public Compiler()
        {
            InitializeComponent();
            p = new MyParser("CodeWave.cgt",Errors);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Errors.Items.Clear();
            p.Parse(CodeWave.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
