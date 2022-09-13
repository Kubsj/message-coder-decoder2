using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int shiftNumber;
        string alphabet = "abcdefghijklmnopqrstuwvxyz";
        string inputText;
        string finalText;
        int a; 
        private void btnCode_Click(object sender, EventArgs e)
        {
            shiftNumber = Convert.ToInt32(nudNumber.Value);
            inputText = txtBoxInput.Text;
            foreach(int i in alphabet)
            {
                a = i + shiftNumber;
                if (i + shiftNumber > alphabet.Length)
                {
                    a = a - alphabet.Length;

                }
                else
                {
                    finalText += alphabet[a];
                }

                txtBoxFinal.Text = finalText;
            
            
            }
        }
    }
}
