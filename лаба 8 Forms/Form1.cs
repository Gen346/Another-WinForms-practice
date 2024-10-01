using System;

using System.Drawing;

using System.Windows.Forms;

namespace лаба_8_Forms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        struct MemoryOfRadioButton
        {
            public int a;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int flag;
        Color c = SystemColors.WindowText;
        String f = "Microsoft Sans Serif";
        Color backC = SystemColors.InactiveBorder;
        float s = 10;
        FontStyle fontStyle = FontStyle.Regular;
        MemoryOfRadioButton[] memory = new MemoryOfRadioButton[5];
        #region CheckBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fontColorMenuItem.Enabled = fontColorMenuItem.Enabled ? false : true;
            if (!FontColor_checkBox1.Checked)
            {
                fontColorMenuItem.Checked = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                SetRadioButtonStatus(4);
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            fontMenuItem.Enabled = fontMenuItem.Enabled ? false : true;
            if (!Font_checkBox2.Checked)
            {
                fontMenuItem.Checked = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                SetRadioButtonStatus(4);
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            backgroundColorMenuItem.Enabled = backgroundColorMenuItem.Enabled ? false : true;
            if (!BGColor_checkBox3.Checked)
            {
                backgroundColorMenuItem.Checked = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                SetRadioButtonStatus(4);
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            fontSizeMenuItem.Enabled = fontSizeMenuItem.Enabled ? false : true;
            if (!Size_checkBox4.Checked)
            {
                fontSizeMenuItem.Checked = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                SetRadioButtonStatus(4);
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            underliningMenuItem.Enabled = underliningMenuItem.Enabled ? false : true;
            if (!UL_checkBox5.Checked)
            {
                underliningMenuItem.Checked = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                SetRadioButtonStatus(4);
            }
        }
        #endregion

        #region Text design menu 
        private void fontColorMenuItem_Click(object sender, EventArgs e)
        {
            fontMenuItem.Checked = false;
            backgroundColorMenuItem.Checked = false;
            fontSizeMenuItem.Checked = false;
            underliningMenuItem.Checked = false;
            fontColorMenuItem.Checked = true;
            BasedSettingsRadioBottom(radioButton1);
            BasedSettingsRadioBottom(radioButton2);
            BasedSettingsRadioBottom(radioButton3);
            radioButton1.Text = "Read";
            radioButton2.Text = "Green";
            radioButton3.Text = "Blue";
            radioButton1.ForeColor = Color.Red;
            radioButton2.ForeColor = Color.Green;
            radioButton3.ForeColor = Color.Blue;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            flag = 1;
            SetRadioButtonStatus(memory[flag - 1].a);
        }

        private void fontMenuItem_Click(object sender, EventArgs e)
        {
            fontColorMenuItem.Checked = false;
            backgroundColorMenuItem.Checked = false;
            fontSizeMenuItem.Checked = false;
            underliningMenuItem.Checked = false;
            fontMenuItem.Checked = true;
            BasedSettingsRadioBottom(radioButton1);
            BasedSettingsRadioBottom(radioButton2);
            BasedSettingsRadioBottom(radioButton3);
            radioButton1.Text = "Microsoft Sans Serif";
            radioButton2.Text = "Impact";
            radioButton3.Text = "Courier New";
            radioButton1.Font = new Font("Microsoft Sans Serif", 10);
            radioButton2.Font = new Font("Impact", 10);
            radioButton3.Font = new Font("Courier New", 10);
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            flag = 2;
            SetRadioButtonStatus(memory[flag - 1].a);
        }

        private void backgroundColorMenuItem_Click(object sender, EventArgs e)
        {
            fontColorMenuItem.Checked = false;
            fontMenuItem.Checked = false;
            fontSizeMenuItem.Checked = false;
            underliningMenuItem.Checked = false;
            backgroundColorMenuItem.Checked = true;
            BasedSettingsRadioBottom(radioButton1);
            BasedSettingsRadioBottom(radioButton2);
            BasedSettingsRadioBottom(radioButton3);
            radioButton1.Text = "Green";
            radioButton2.Text = "Orange";
            radioButton3.Text = "Violet";
            radioButton1.BackColor = Color.Green;
            radioButton2.BackColor = Color.Orange;
            radioButton3.BackColor = Color.Violet;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            flag = 3;
            SetRadioButtonStatus(memory[flag - 1].a);
        }

        private void fontSizeMenuItem_Click(object sender, EventArgs e)
        {
            fontColorMenuItem.Checked = false;
            fontMenuItem.Checked = false;
            backgroundColorMenuItem.Checked = false;
            underliningMenuItem.Checked = false;
            fontSizeMenuItem.Checked = true;
            BasedSettingsRadioBottom(radioButton1);
            BasedSettingsRadioBottom(radioButton2);
            BasedSettingsRadioBottom(radioButton3);
            radioButton1.Text = "Font size - 8";
            radioButton2.Text = "Font size - 10";
            radioButton3.Text = "Font size - 12";
            radioButton1.Font = new Font("Microsoft Sans Serif", 8);
            radioButton2.Font = new Font("Microsoft Sans Serif", 10);
            radioButton3.Font = new Font("Microsoft Sans Serif", 12);
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            flag = 4;
            SetRadioButtonStatus(memory[flag - 1].a);
        }

        private void underliningMenuItem_Click(object sender, EventArgs e)
        {
            fontColorMenuItem.Checked = false;
            fontMenuItem.Checked = false;
            backgroundColorMenuItem.Checked = false;
            fontSizeMenuItem.Checked = false;
            underliningMenuItem.Checked = true;

            radioButton1.Visible = false;
            radioButton3.Visible = false;
            BasedSettingsRadioBottom(radioButton2);
            radioButton2.Text = "Underline text";
            radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            radioButton2.Visible = true;
            flag = 5;
            SetRadioButtonStatus(memory[flag - 1].a);
        }
        #endregion

        #region Radio Button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1: c = Color.Red; break;
                case 2: f = Convert.ToString(radioButton1.Font.Name); break;
                case 3: backC = radioButton1.BackColor; break;
                case 4: s = Convert.ToInt32(radioButton1.Font.Size); break;
                default: break;
            }
            memory[flag - 1].a = 1;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1: c = radioButton2.ForeColor; break;
                case 2: f = Convert.ToString(radioButton2.Font.Name); break;
                case 3: backC = radioButton2.BackColor; break;
                case 4: s = Convert.ToInt32(radioButton2.Font.Size); break;
                case 5: fontStyle = FontStyle.Underline; break;
                default: break;
            }
            memory[flag - 1].a = 2;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1: c = radioButton3.ForeColor; break;
                case 2: f = Convert.ToString(radioButton3.Font.Name); break;
                case 3: backC = radioButton3.BackColor; break;
                case 4: s = Convert.ToInt32(radioButton3.Font.Size); break;
                default: break;
            }
            memory[flag - 1].a = 3;
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            SetSettingsToTextBox1();
        }
        private void SetSettingsToTextBox1()
        {
            if (flag != 0)
            {
                textBox1.ForeColor = c;
                textBox1.Font = new Font(f, textBox1.Font.Size);
                textBox1.BackColor = backC;
                textBox1.Font = new Font(Convert.ToString(textBox1.Font.Name), s);
                textBox1.Font = new System.Drawing.Font(Convert.ToString(textBox1.Font.Name), textBox1.Font.Size, fontStyle);
            }
        }
        private void SetRadioButtonStatus(int a)
        {
            switch (a)
            {
                case 1: radioButton1.Checked = true; break;
                case 2: radioButton2.Checked = true; break;
                case 3: radioButton3.Checked = true; break;
                default:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
            }
        }
        private void BasedSettingsRadioBottom(RadioButton a)
        {
            a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            a.BackColor = SystemColors.ScrollBar;
            a.ForeColor = SystemColors.ControlText;
        }
        private void ттToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Text editing menu
        private void wordsBackwardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = "";
            for (int i = textBox1.Text.Length - 1; i >= 0; i--)
            {
                if (textBox1.Text[i] != '\r')
                {
                    if (textBox1.Text[i] == '\n') { a += '\r'; a += textBox1.Text[i]; }
                    else a += textBox1.Text[i];
                }
            }

            textBox2.Text = a;
        }

        private void betweenDavidAndGoliathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] a = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int indxMin = 0;
            int indxMax = 0;
            int difference = a.Length;
            int start = 0; //Start word index
            int end = 0; //End word index
            for (int i = 0; i < a.Length; i++)
            {
                if (Leng(a[i]) > Leng(a[indxMax])) indxMax = i;
                if (Leng(a[i]) < Leng(a[indxMin]) && Leng(a[i]) != 0) indxMin = i;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (Leng(a[i]) == Leng(a[indxMax])) //перебираем все самые длинные слова
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (Leng(a[j]) == Leng(a[indxMin])) //перебираем все самые длинные слова
                        {
                            if (Math.Abs(i - j) < difference) //перебираем все возможные длины между короткими и длинными словами
                            {
                                difference = Math.Abs(i - j);
                                start = Math.Min(i, j);
                                end = start == i ? j : i;
                            }
                        }
                    }
                }
            }

            textBox2.Text = "";
            for (int i = 0; i < a.Length; i++)
            {
                if ((i <= start || i >= end) || Leng(a[i]) == 0)
                {
                    textBox2.Text += a[i] + " ";
                }
            }
        }
        private int Leng(string s)
        {
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '\n' && s[i] != '\r') num += 1;
            }
            return num;
        }
        //private void deleteCharToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form2 f2 = new Form2();
        //    f2.ShowDialog();
        //    if (f2.DialogResult == DialogResult.OK)
        //    {
        //        if (string.IsNullOrWhiteSpace(Form2.dialogString)) { f2.Close(); return; }
        //        char chr = Convert.ToChar(Form2.dialogString);
        //        textBox2.Text = "";
        //        foreach (char c in textBox1.Text) if (char.ToLower(c) != chr) textBox2.Text += c;
        //    }
        //}
        private void deleteCharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(Form2.dialogString)) { f2.Close(); return; }
                char chr = Convert.ToChar(Form2.dialogString);
                string newText = "";
                foreach (char c in textBox1.Text)
                {
                    if (char.ToLower(c) != chr)
                    {
                        newText += c;
                    }
                }
                textBox2.Text = newText;
            }
        }

        //private void deleteCharToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form2 f2 = new Form2();
        //    f2.ShowDialog();
        //    if (f2.DialogResult == DialogResult.OK)
        //    {
        //        if (string.IsNullOrWhiteSpace(Form2.dialogString)) { f2.Close(); return; }
        //        char chr = Convert.ToChar(Form2.dialogString);
        //        string newText = "";
        //        foreach (char c in textBox1.Text)
        //        {
        //            if (char.ToLower(c) != chr)
        //            {
        //                newText += c;
        //            }
        //        }
        //        textBox1.Text = newText;
        //    }
        //}



        private void changeCharToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2("Change char", "Enter the char", "Which you want to be changed", 1);
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(Form2.dialogString)) { f2.Close(); return; }
                char chr = Convert.ToChar(Form2.dialogString);
                Form2 nf2 = new Form2("Enter string", "Enter the char or string", "Which one you want to replace", textBox1.Text.Length);
                nf2.ShowDialog();
                if (nf2.DialogResult == DialogResult.OK)
                {
                    string str = Form2.dialogString;
                    textBox2.Text = "";
                    foreach (char c in textBox1.Text)
                    {
                        if (char.ToLower(c) != chr) textBox2.Text += c;
                        else textBox2.Text += str;
                    }

                }
            }

        }
        #endregion

        private void defaulteParametrsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            for (int i = 0; i < 5; i++)
            {
                memory[i].a = 0;
            }
            FontColor_checkBox1.Checked = false;
            Font_checkBox2.Checked = false;
            BGColor_checkBox3.Checked = false;
            Size_checkBox4.Checked = false;
            UL_checkBox5.Checked = false;
            c = SystemColors.WindowText;
            f = "Microsoft Sans Serif";
            backC = SystemColors.InactiveBorder;
            s = 10;
            fontStyle = FontStyle.Regular;

            SetSettingsToTextBox1();
        }

        private void windowResultResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
