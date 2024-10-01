using System;

using System.Windows.Forms;

namespace лаба_8_Forms
{
    public partial class Form2 : Form
    {
        public static string dialogString;

        public Form2()
        {
            InitializeComponent();
            button1.Focus();
        }
        public Form2(string text, string label1, string label2, int lengthText)
        {
            InitializeComponent();
            button1.Focus();
            Text = text;
            this.label1.Text = label1;
            this.label2.Text = label2;
            textBox1.MaxLength = lengthText;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialogString = textBox1.Text.ToLower();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
