namespace лаба_8_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underliningMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditiongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsBackwardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_l_sh_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.defaulteParametrsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.windowResultResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ттToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Confirm_button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.UL_checkBox5 = new System.Windows.Forms.CheckBox();
            this.Size_checkBox4 = new System.Windows.Forms.CheckBox();
            this.BGColor_checkBox3 = new System.Windows.Forms.CheckBox();
            this.Font_checkBox2 = new System.Windows.Forms.CheckBox();
            this.FontColor_checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox1.Location = new System.Drawing.Point(107, 108);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(576, 327);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1574, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textDesignToolStripMenuItem,
            this.textEditiongToolStripMenuItem,
            this.toolStripSeparator1,
            this.defaulteParametrsToolStripMenuItem,
            this.toolStripSeparator2,
            this.windowResultResetToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 38);
            this.toolStripMenuItem1.Text = "Edit";
            // 
            // textDesignToolStripMenuItem
            // 
            this.textDesignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontColorMenuItem,
            this.fontMenuItem,
            this.backgroundColorMenuItem,
            this.fontSizeMenuItem,
            this.underliningMenuItem});
            this.textDesignToolStripMenuItem.Name = "textDesignToolStripMenuItem";
            this.textDesignToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
            this.textDesignToolStripMenuItem.Text = "Text design";
            // 
            // fontColorMenuItem
            // 
            this.fontColorMenuItem.Enabled = false;
            this.fontColorMenuItem.Name = "fontColorMenuItem";
            this.fontColorMenuItem.Size = new System.Drawing.Size(334, 44);
            this.fontColorMenuItem.Text = "Font color";
            this.fontColorMenuItem.Click += new System.EventHandler(this.fontColorMenuItem_Click);
            // 
            // fontMenuItem
            // 
            this.fontMenuItem.Enabled = false;
            this.fontMenuItem.Name = "fontMenuItem";
            this.fontMenuItem.Size = new System.Drawing.Size(334, 44);
            this.fontMenuItem.Text = "Font";
            this.fontMenuItem.Click += new System.EventHandler(this.fontMenuItem_Click);
            // 
            // backgroundColorMenuItem
            // 
            this.backgroundColorMenuItem.Enabled = false;
            this.backgroundColorMenuItem.Name = "backgroundColorMenuItem";
            this.backgroundColorMenuItem.Size = new System.Drawing.Size(334, 44);
            this.backgroundColorMenuItem.Text = "Background color";
            this.backgroundColorMenuItem.Click += new System.EventHandler(this.backgroundColorMenuItem_Click);
            // 
            // fontSizeMenuItem
            // 
            this.fontSizeMenuItem.Enabled = false;
            this.fontSizeMenuItem.Name = "fontSizeMenuItem";
            this.fontSizeMenuItem.Size = new System.Drawing.Size(334, 44);
            this.fontSizeMenuItem.Text = "Font size";
            this.fontSizeMenuItem.Click += new System.EventHandler(this.fontSizeMenuItem_Click);
            // 
            // underliningMenuItem
            // 
            this.underliningMenuItem.Enabled = false;
            this.underliningMenuItem.Name = "underliningMenuItem";
            this.underliningMenuItem.Size = new System.Drawing.Size(334, 44);
            this.underliningMenuItem.Text = "Underlining";
            this.underliningMenuItem.Click += new System.EventHandler(this.underliningMenuItem_Click);
            // 
            // textEditiongToolStripMenuItem
            // 
            this.textEditiongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordsBackwardsToolStripMenuItem,
            this.Delete_l_sh_ToolStripMenuItem,
            this.deleteCharToolStripMenuItem,
            this.changeCharToolStripMenuItem});
            this.textEditiongToolStripMenuItem.Name = "textEditiongToolStripMenuItem";
            this.textEditiongToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
            this.textEditiongToolStripMenuItem.Text = "Text editing";
            this.textEditiongToolStripMenuItem.ToolTipText = "Remove the words located between the closest longest and shortest words and outpu" +
    "t the text\r\n\r\n";
            // 
            // wordsBackwardsToolStripMenuItem
            // 
            this.wordsBackwardsToolStripMenuItem.Name = "wordsBackwardsToolStripMenuItem";
            this.wordsBackwardsToolStripMenuItem.Size = new System.Drawing.Size(541, 44);
            this.wordsBackwardsToolStripMenuItem.Text = "Words backwards";
            this.wordsBackwardsToolStripMenuItem.ToolTipText = "All words in the text are inverted";
            this.wordsBackwardsToolStripMenuItem.Click += new System.EventHandler(this.wordsBackwardsToolStripMenuItem_Click);
            // 
            // Delete_l_sh_ToolStripMenuItem
            // 
            this.Delete_l_sh_ToolStripMenuItem.Name = "Delete_l_sh_ToolStripMenuItem";
            this.Delete_l_sh_ToolStripMenuItem.Size = new System.Drawing.Size(541, 44);
            this.Delete_l_sh_ToolStripMenuItem.Text = "Delete between longest and shortest";
            this.Delete_l_sh_ToolStripMenuItem.ToolTipText = "Delete the words located between the closest ones\r\nlongest and shortest words and" +
    " output the text\r\n\r\n";
            this.Delete_l_sh_ToolStripMenuItem.Click += new System.EventHandler(this.betweenDavidAndGoliathToolStripMenuItem_Click);
            // 
            // deleteCharToolStripMenuItem
            // 
            this.deleteCharToolStripMenuItem.Name = "deleteCharToolStripMenuItem";
            this.deleteCharToolStripMenuItem.Size = new System.Drawing.Size(541, 44);
            this.deleteCharToolStripMenuItem.Text = "Delete char";
            this.deleteCharToolStripMenuItem.Click += new System.EventHandler(this.deleteCharToolStripMenuItem_Click);
            // 
            // changeCharToolStripMenuItem
            // 
            this.changeCharToolStripMenuItem.Name = "changeCharToolStripMenuItem";
            this.changeCharToolStripMenuItem.Size = new System.Drawing.Size(541, 44);
            this.changeCharToolStripMenuItem.Text = "Change char";
            this.changeCharToolStripMenuItem.Click += new System.EventHandler(this.changeCharToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(448, 6);
            // 
            // defaulteParametrsToolStripMenuItem
            // 
            this.defaulteParametrsToolStripMenuItem.Name = "defaulteParametrsToolStripMenuItem";
            this.defaulteParametrsToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
            this.defaulteParametrsToolStripMenuItem.Text = "Defaulte design options";
            this.defaulteParametrsToolStripMenuItem.Click += new System.EventHandler(this.defaulteParametrsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(448, 6);
            // 
            // windowResultResetToolStripMenuItem
            // 
            this.windowResultResetToolStripMenuItem.Name = "windowResultResetToolStripMenuItem";
            this.windowResultResetToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
            this.windowResultResetToolStripMenuItem.Text = "Reset editing window results";
            this.windowResultResetToolStripMenuItem.Click += new System.EventHandler(this.windowResultResetToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoToolTip = true;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ттToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(71, 38);
            this.toolStripMenuItem2.Text = "Exit";
            // 
            // ттToolStripMenuItem
            // 
            this.ттToolStripMenuItem.Name = "ттToolStripMenuItem";
            this.ттToolStripMenuItem.Size = new System.Drawing.Size(252, 44);
            this.ттToolStripMenuItem.Text = "Close app";
            this.ттToolStripMenuItem.Click += new System.EventHandler(this.ттToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox2.Location = new System.Drawing.Point(872, 108);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(576, 327);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(257, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text design result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(1038, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text editing result";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.Confirm_button1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.UL_checkBox5);
            this.groupBox1.Controls.Add(this.Size_checkBox4);
            this.groupBox1.Controls.Add(this.BGColor_checkBox3);
            this.groupBox1.Controls.Add(this.Font_checkBox2);
            this.groupBox1.Controls.Add(this.FontColor_checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(412, 469);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(746, 354);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text design";
            // 
            // Confirm_button1
            // 
            this.Confirm_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Confirm_button1.Location = new System.Drawing.Point(246, 298);
            this.Confirm_button1.Margin = new System.Windows.Forms.Padding(6);
            this.Confirm_button1.Name = "Confirm_button1";
            this.Confirm_button1.Size = new System.Drawing.Size(242, 44);
            this.Confirm_button1.TabIndex = 10;
            this.Confirm_button1.Text = "Confirm";
            this.Confirm_button1.UseVisualStyleBackColor = true;
            this.Confirm_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioButton3.Location = new System.Drawing.Point(460, 200);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(274, 42);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioButton2.Location = new System.Drawing.Point(460, 146);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(274, 42);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioButton1.Location = new System.Drawing.Point(460, 92);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(274, 42);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // UL_checkBox5
            // 
            this.UL_checkBox5.AutoSize = true;
            this.UL_checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.UL_checkBox5.Location = new System.Drawing.Point(14, 237);
            this.UL_checkBox5.Margin = new System.Windows.Forms.Padding(6);
            this.UL_checkBox5.Name = "UL_checkBox5";
            this.UL_checkBox5.Size = new System.Drawing.Size(183, 35);
            this.UL_checkBox5.TabIndex = 4;
            this.UL_checkBox5.Text = "Underlining";
            this.UL_checkBox5.UseVisualStyleBackColor = true;
            this.UL_checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // Size_checkBox4
            // 
            this.Size_checkBox4.AutoSize = true;
            this.Size_checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Size_checkBox4.Location = new System.Drawing.Point(14, 192);
            this.Size_checkBox4.Margin = new System.Windows.Forms.Padding(6);
            this.Size_checkBox4.Name = "Size_checkBox4";
            this.Size_checkBox4.Size = new System.Drawing.Size(99, 35);
            this.Size_checkBox4.TabIndex = 3;
            this.Size_checkBox4.Text = "Size";
            this.Size_checkBox4.UseVisualStyleBackColor = true;
            this.Size_checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // BGColor_checkBox3
            // 
            this.BGColor_checkBox3.AutoSize = true;
            this.BGColor_checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BGColor_checkBox3.Location = new System.Drawing.Point(14, 148);
            this.BGColor_checkBox3.Margin = new System.Windows.Forms.Padding(6);
            this.BGColor_checkBox3.Name = "BGColor_checkBox3";
            this.BGColor_checkBox3.Size = new System.Drawing.Size(257, 35);
            this.BGColor_checkBox3.TabIndex = 2;
            this.BGColor_checkBox3.Text = "Background color";
            this.BGColor_checkBox3.UseVisualStyleBackColor = true;
            this.BGColor_checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Font_checkBox2
            // 
            this.Font_checkBox2.AutoSize = true;
            this.Font_checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Font_checkBox2.Location = new System.Drawing.Point(14, 104);
            this.Font_checkBox2.Margin = new System.Windows.Forms.Padding(6);
            this.Font_checkBox2.Name = "Font_checkBox2";
            this.Font_checkBox2.Size = new System.Drawing.Size(101, 35);
            this.Font_checkBox2.TabIndex = 1;
            this.Font_checkBox2.Text = "Font";
            this.Font_checkBox2.UseVisualStyleBackColor = true;
            this.Font_checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FontColor_checkBox1
            // 
            this.FontColor_checkBox1.AutoSize = true;
            this.FontColor_checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FontColor_checkBox1.Location = new System.Drawing.Point(14, 60);
            this.FontColor_checkBox1.Margin = new System.Windows.Forms.Padding(6);
            this.FontColor_checkBox1.Name = "FontColor_checkBox1";
            this.FontColor_checkBox1.Size = new System.Drawing.Size(167, 35);
            this.FontColor_checkBox1.TabIndex = 0;
            this.FontColor_checkBox1.Text = "Font color";
            this.FontColor_checkBox1.UseVisualStyleBackColor = true;
            this.FontColor_checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "Form1";
            this.Text = "Редагування та оформлення тексту";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ттToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem textDesignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textEditiongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem defaulteParametrsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem windowResultResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underliningMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox UL_checkBox5;
        private System.Windows.Forms.CheckBox Size_checkBox4;
        private System.Windows.Forms.CheckBox BGColor_checkBox3;
        private System.Windows.Forms.CheckBox Font_checkBox2;
        private System.Windows.Forms.CheckBox FontColor_checkBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button Confirm_button1;
        private System.Windows.Forms.ToolStripMenuItem wordsBackwardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete_l_sh_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCharToolStripMenuItem;
    }
}

