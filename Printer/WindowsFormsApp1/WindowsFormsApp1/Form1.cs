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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_fontSize.SelectedIndex = 0;
            comboBox_fontFamily.SelectedIndex = 0;
            comboBox_orientation.SelectedIndex = 0;
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            FileStream file = File.Create("file");
            StreamWriter writer = new StreamWriter(file);


            if (string.IsNullOrWhiteSpace(richTextBox_text.Text))
                return;

            writer.WriteLine("\x1B" + "&a" + Decimal.ToInt32(numericUpDown_margin.Value).ToString() + "L");

            string font = null;

            var fontFamily = (string)(comboBox_fontFamily.SelectedItem);

            switch (fontFamily)
            {
                case "Arial":
                    font = "218";
                    break;

                case "Times New Roman":
                    font = "517";
                    break;

                case "Coronet":
                    font = "4116";
                    break;
            }

            writer.WriteLine("\x1B" + "(s1p" + (string)(comboBox_fontSize.SelectedItem) + "v0s0b" + font + "T");


            // underline checkBox
            if (checkBox_underline.Checked)
                writer.WriteLine("\x1B" + "&d0D");

            // italics checkBox
            if (checkBox_italic.Checked)
                writer.WriteLine("\x1B" + "(s1S");

            // bold checkBox
            if (checkBox_bold.Checked)
                writer.WriteLine("\x1B" + "(s3B");

            // checking whether orietnation is horizontal
            if ((string)(comboBox_orientation.SelectedItem) == "horizontal")
                writer.WriteLine("\x1B" + "&l1O"); 

            // writing each character to command file,
            // except '+' which needs special encoding
            foreach (char c in richTextBox_text.Text)
            {
                if (c == '+')
                {
                    writer.WriteLine("\xA");
                } 
                else
                {
                    writer.Write(c);
                }

            }

            writer.WriteLine("\x1B" + "E"); // reset
            writer.Close();

            File.Copy("file", "LPT3");
        }
    }
}
