using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grossberg_crypto_system
{
    public partial class Form1 : Form
    {
        GrossbergNet Enigma;
        string source = "Aabcdefghijkl mnopqrsTtuvwxyz";//"abcdefghijklmnopqrstuvwxyz";
        string result = "!#$%^&*()-=+0123456789;:<>?[]";// "!#$%^&*()-_=+0123456789;:<";
        public Form1()
        {
            InitializeComponent();

            Enigma = new GrossbergNet();
            
            Enigma.Train(source, result);
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            string source = TextInput.Text;
            TextOutput.Text = Enigma.Encode(source);
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            string source = TextInput.Text;
            TextOutput.Text = Enigma.Decode(source);
        }

        private void TextOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enigma = new GrossbergNet();
            //string source = "Aabcdefghijkl mnopqrsTtuvwxyz";//"abcdefghijklmnopqrstuvwxyz";
            //string result = "!#$%^&*()-=+0123456789;:<>?[]";// "!#$%^&*()-_=+0123456789;:<";
            Enigma.Train(source, result);
        }
    }
}
