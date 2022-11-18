namespace WindowsFormsApp1
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
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.checkBox_bold = new System.Windows.Forms.CheckBox();
            this.checkBox_underline = new System.Windows.Forms.CheckBox();
            this.checkBox_italic = new System.Windows.Forms.CheckBox();
            this.comboBox_fontFamily = new System.Windows.Forms.ComboBox();
            this.comboBox_fontSize = new System.Windows.Forms.ComboBox();
            this.button_print = new System.Windows.Forms.Button();
            this.numericUpDown_margin = new System.Windows.Forms.NumericUpDown();
            this.comboBox_orientation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_margin)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.Location = new System.Drawing.Point(36, 22);
            this.richTextBox_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.Size = new System.Drawing.Size(406, 417);
            this.richTextBox_text.TabIndex = 0;
            this.richTextBox_text.Text = "";
            // 
            // checkBox_bold
            // 
            this.checkBox_bold.AutoSize = true;
            this.checkBox_bold.Location = new System.Drawing.Point(470, 42);
            this.checkBox_bold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_bold.Name = "checkBox_bold";
            this.checkBox_bold.Size = new System.Drawing.Size(57, 20);
            this.checkBox_bold.TabIndex = 1;
            this.checkBox_bold.Text = "Bold";
            this.checkBox_bold.UseVisualStyleBackColor = true;
            // 
            // checkBox_underline
            // 
            this.checkBox_underline.AutoSize = true;
            this.checkBox_underline.Location = new System.Drawing.Point(470, 108);
            this.checkBox_underline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_underline.Name = "checkBox_underline";
            this.checkBox_underline.Size = new System.Drawing.Size(87, 20);
            this.checkBox_underline.TabIndex = 8;
            this.checkBox_underline.Text = "Underline";
            this.checkBox_underline.UseVisualStyleBackColor = true;
            // 
            // checkBox_italic
            // 
            this.checkBox_italic.AutoSize = true;
            this.checkBox_italic.Location = new System.Drawing.Point(470, 77);
            this.checkBox_italic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_italic.Name = "checkBox_italic";
            this.checkBox_italic.Size = new System.Drawing.Size(56, 20);
            this.checkBox_italic.TabIndex = 9;
            this.checkBox_italic.Text = "Italic";
            this.checkBox_italic.UseVisualStyleBackColor = true;
            // 
            // comboBox_fontFamily
            // 
            this.comboBox_fontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fontFamily.FormattingEnabled = true;
            this.comboBox_fontFamily.Items.AddRange(new object[] {
            "Arial",
            "Coronet",
            "Times New Roman"});
            this.comboBox_fontFamily.Location = new System.Drawing.Point(470, 190);
            this.comboBox_fontFamily.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_fontFamily.Name = "comboBox_fontFamily";
            this.comboBox_fontFamily.Size = new System.Drawing.Size(108, 24);
            this.comboBox_fontFamily.TabIndex = 10;
            // 
            // comboBox_fontSize
            // 
            this.comboBox_fontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fontSize.FormattingEnabled = true;
            this.comboBox_fontSize.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.comboBox_fontSize.Location = new System.Drawing.Point(470, 151);
            this.comboBox_fontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_fontSize.Name = "comboBox_fontSize";
            this.comboBox_fontSize.Size = new System.Drawing.Size(107, 24);
            this.comboBox_fontSize.TabIndex = 11;
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(468, 363);
            this.button_print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(109, 76);
            this.button_print.TabIndex = 12;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // numericUpDown_margin
            // 
            this.numericUpDown_margin.Location = new System.Drawing.Point(471, 239);
            this.numericUpDown_margin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_margin.Name = "numericUpDown_margin";
            this.numericUpDown_margin.Size = new System.Drawing.Size(107, 22);
            this.numericUpDown_margin.TabIndex = 13;
            // 
            // comboBox_orientation
            // 
            this.comboBox_orientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_orientation.FormattingEnabled = true;
            this.comboBox_orientation.Items.AddRange(new object[] {
            "vertical",
            "horizontal"});
            this.comboBox_orientation.Location = new System.Drawing.Point(469, 294);
            this.comboBox_orientation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_orientation.Name = "comboBox_orientation";
            this.comboBox_orientation.Size = new System.Drawing.Size(108, 24);
            this.comboBox_orientation.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 465);
            this.Controls.Add(this.comboBox_orientation);
            this.Controls.Add(this.numericUpDown_margin);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.comboBox_fontSize);
            this.Controls.Add(this.comboBox_fontFamily);
            this.Controls.Add(this.checkBox_italic);
            this.Controls.Add(this.checkBox_underline);
            this.Controls.Add(this.checkBox_bold);
            this.Controls.Add(this.richTextBox_text);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_margin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_text;
        private System.Windows.Forms.CheckBox checkBox_bold;
        private System.Windows.Forms.CheckBox checkBox_underline;
        private System.Windows.Forms.CheckBox checkBox_italic;
        private System.Windows.Forms.ComboBox comboBox_fontFamily;
        private System.Windows.Forms.ComboBox comboBox_fontSize;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.NumericUpDown numericUpDown_margin;
        private System.Windows.Forms.ComboBox comboBox_orientation;
    }
}

