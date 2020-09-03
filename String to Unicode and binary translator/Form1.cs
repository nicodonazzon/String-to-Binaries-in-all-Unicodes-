using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_to_Unicode_and_binary_translator
{
    public partial class Form1 : Form
    {
        public void Printer(int option, string stringtext)
        {
            CodePrinter CodPrint = new CodePrinter();
            byte[] binaries;
            string binarieswords = " ";
            string unicodestring = " ";
            switch (option)
            {
                case 1:
                    binaries = CodPrint.Printer7(stringtext).Item1;
                    binarieswords = CodPrint.Printer7(stringtext).Item2;
                    unicodestring = Encoding.UTF7.GetString(binaries);
                    SetTextBox(2, unicodestring);
                    SetTextBox(3, binarieswords);
                    break;
                case 2:
                    binaries = CodPrint.Printer8(stringtext).Item1;
                    binarieswords = CodPrint.Printer8(stringtext).Item2;
                    unicodestring = Encoding.UTF8.GetString(binaries);
                    SetTextBox(2, unicodestring);
                    SetTextBox(3, binarieswords);
                    break;
                case 3:
                    binaries = CodPrint.Printer16(stringtext).Item1;
                    binarieswords = CodPrint.Printer16(stringtext).Item2;
                    unicodestring = Encoding.Unicode.GetString(binaries);
                    SetTextBox(2, unicodestring);
                    SetTextBox(3, binarieswords);
                    break;
                case 4:
                    binaries = CodPrint.Printer32(stringtext).Item1;
                    binarieswords = CodPrint.Printer32(stringtext).Item2;
                    unicodestring = Encoding.UTF32.GetString(binaries);
                    SetTextBox(2, unicodestring);
                    SetTextBox(3, binarieswords);
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Printer(1, textBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Printer(2, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Printer(3, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Printer(4, textBox1.Text);
        }

    }
}
