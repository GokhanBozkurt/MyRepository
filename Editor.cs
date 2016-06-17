using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safiye
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lblLength.Text = "Text Length : " +  richAscii.TextLength.ToString();

        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            lblSelectedLength.Text = "Selected Length : " + richAscii.SelectedText.Length.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richAscii.Text = richAscii.Text.Replace(" ", "");
        }

        public  String ToHex(String data)
        {

            String output = String.Empty;

            foreach (Char c in data)
            {

                output += ((int)c).ToString("X");

            }

            return output;

        }

        private string ToAscii(string hexString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= hexString.Length - 2; i += 2)
            {
                sb.Append(Convert.ToString(Convert.ToChar(Int32.Parse(hexString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber))));
            }
            return sb.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            richAscii.Text = ToAscii(richHex.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richHex.Text = ToHex(richAscii.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richHex.Text = richHex.Text.Replace(" ", "");
        }

    }
}
