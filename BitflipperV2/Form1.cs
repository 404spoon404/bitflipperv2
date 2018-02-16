using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BitflipperV2
{
    public partial class Form1 : Form
    {
        //Initialises the a bitarray to simulate a Byte
        //The bitarray is an array of 8 true/false values true = 1, false = 0
        BitArray bitArray = new BitArray(8);

        //fuction to convert the array of bits to a byte
        byte ConvertToByte(BitArray bits)
        {
            //initialise the variable currentval 
            byte currentval = 0;
            
            //the for loop for the array
            for (byte i = 0; i < 8; i++)
            {
                //if position in array returns true, add byte value to currentval
                if (bits[i] == true)
                {
                    currentval += (byte)(1 << i);
                }
            }
            return currentval;
        }
        // function to change the output of the display called on click of the checkbox
        public void DisplayOutput(byte value)
        {
            lbloutdec.Text = ConvertToByte(bitArray).ToString();
            lbloutbin.Text = Convert.ToString(value, 2).PadLeft(8, '0');
            lblouthex.Text = Convert.ToString(value, 16).ToUpper();
            lbloutasc.Text = Convert.ToChar(value).ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void cbx128_CheckedChanged(object sender, EventArgs e)
        {
            //Change position 7 in bitarray to true
            bitArray[7] = cbx128.Checked;
            //Call the displayoutput function and input the current bitarray
            DisplayOutput(ConvertToByte(bitArray));
        }

        private void cbx64_CheckedChanged(object sender, EventArgs e)
        {
            //Change position 6 in bitarray to true
            bitArray[6] = cbx64.Checked;
            //Call the displayoutput function and input the current bitarray
            DisplayOutput(ConvertToByte(bitArray));
        }

        private void cbx32_CheckedChanged(object sender, EventArgs e)
        {
            //Change position 5 in bitarray to true
            bitArray[5] = cbx32.Checked;
            //Call the displayoutput function and input the current bitarray
            DisplayOutput(ConvertToByte(bitArray));
        }

        private void cbx16_CheckedChanged(object sender, EventArgs e)
        {
            //Change position 4 in bitarray to true
            bitArray[4] = cbx16.Checked;
            //Call the displayoutput function and input the current bitarray
            DisplayOutput(ConvertToByte(bitArray));
        }

        private void cbx8_CheckedChanged(object sender, EventArgs e)
        {
            //Change position 3 in bitarray to true
            bitArray[3] = cbx8.Checked;
            //Call the displayoutput function and input the current bitarray
            DisplayOutput(ConvertToByte(bitArray));

        }

        private void cbx4_CheckedChanged(object sender, EventArgs e)
        {
            //Change position 2 in bitarray to true
            bitArray[2] = cbx4.Checked;
            //Call the displayoutput function and input the current bitarray
            DisplayOutput(ConvertToByte(bitArray));

        }

        private void cbx2_CheckedChanged(object sender, EventArgs e)
        {
            //Change position 1 in bitarray to true
            bitArray[1] = cbx2.Checked;
            //Call the displayoutput function and input the current bitarray
            DisplayOutput(ConvertToByte(bitArray));

        }

        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            //Change position 0 in bitarray to true
            bitArray[0] = cbx1.Checked;
            //Call the displayoutput function and input the current bitarray
            DisplayOutput(ConvertToByte(bitArray));

        }
    }
}
