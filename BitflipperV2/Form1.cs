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
        BitArray bitArray = new BitArray(8);


        //Magic:
        byte ConvertToByte(BitArray bits)
        {
            byte currentval = 0;
            
            for (byte i = 0; i < 8; i++)
            {
                if (bits[i] == true)
                {
                    currentval += (byte)(1 << i);
                }
            }
            return currentval;
        }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbx128_CheckedChanged(object sender, EventArgs e)
        {
            bitArray[7] = cbx128.Checked;
            DisplayOutput(ConvertToByte(bitArray));
            
            
            /*lbloutdec.Text = ConvertToByte(bitArray).ToString();
            lbloutbin.Text = Convert.ToString(currentval, 2).PadLeft(8, '0');
            lblouthex.Text = Convert.ToString(currentval, 16).ToUpper();
            lbloutasc.Text = Convert.ToChar(currentval).ToString();)*/
        }

        private void cbx64_CheckedChanged(object sender, EventArgs e)
        {
            bitArray[6] = cbx64.Checked;
            DisplayOutput(ConvertToByte(bitArray));

            //lbloutdec.Text = ConvertToByte(bitArray).ToString();
            //lbloutbin.Text = Convert.ToString(currentval, 2).PadLeft(8, '0');
            //lblouthex.Text = Convert.ToString(currentval, 16).ToUpper();
            //lbloutasc.Text = Convert.ToChar(currentval).ToString();
        }

        private void cbx32_CheckedChanged(object sender, EventArgs e)
        {
            bitArray[5] = cbx32.Checked;
            DisplayOutput(ConvertToByte(bitArray));

            //lbloutdec.Text = ConvertToByte(bitArray).ToString();
            //lbloutbin.Text = Convert.ToString(currentval, 2).PadLeft(8, '0');
            //lblouthex.Text = Convert.ToString(currentval, 16).ToUpper();
            //lbloutasc.Text = Convert.ToChar(currentval).ToString();
        }

        private void cbx16_CheckedChanged(object sender, EventArgs e)
        {
            bitArray[4] = cbx16.Checked;
            DisplayOutput(ConvertToByte(bitArray));

            //lbloutdec.Text = ConvertToByte(bitArray).ToString();
            //lbloutbin.Text = Convert.ToString(currentval, 2).PadLeft(8, '0');
            //lblouthex.Text = Convert.ToString(currentval, 16).ToUpper();
            //lbloutasc.Text = Convert.ToChar(currentval).ToString();
        }

        private void cbx8_CheckedChanged(object sender, EventArgs e)
        {
            bitArray[3] = cbx8.Checked;
            DisplayOutput(ConvertToByte(bitArray));

            //lbloutdec.Text = ConvertToByte(bitArray).ToString();
            //lbloutbin.Text = Convert.ToString(currentval, 2).PadLeft(8, '0');
            //lblouthex.Text = Convert.ToString(currentval, 16).ToUpper();
            //lbloutasc.Text = Convert.ToChar(currentval).ToString();
        }

        private void cbx4_CheckedChanged(object sender, EventArgs e)
        {
            bitArray[2] = cbx4.Checked;
            DisplayOutput(ConvertToByte(bitArray));

            //lbloutdec.Text = ConvertToByte(bitArray).ToString();
            //lbloutbin.Text = Convert.ToString(currentval, 2).PadLeft(8, '0');
            //lblouthex.Text = Convert.ToString(currentval, 16).ToUpper();
            //lbloutasc.Text = Convert.ToChar(currentval).ToString();
        }

        private void cbx2_CheckedChanged(object sender, EventArgs e)
        {
            bitArray[1] = cbx2.Checked;
            DisplayOutput(ConvertToByte(bitArray));

            //lbloutdec.Text = ConvertToByte(bitArray).ToString();
            //lbloutbin.Text = Convert.ToString(currentval,2 ).PadLeft(8, '0');
            //lblouthex.Text = Convert.ToString(currentval, 16).ToUpper();
            //lbloutasc.Text = Convert.ToChar(currentval).ToString();
        }

        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            bitArray[0] = cbx1.Checked;
            DisplayOutput(ConvertToByte(bitArray));

            //lbloutdec.Text = ConvertToByte(bitArray).ToString();
            //lbloutbin.Text = Convert.ToString(currentval, 2).PadLeft(8, '0');
            //lblouthex.Text = Convert.ToString(currentval, 16).ToUpper();
            //lbloutasc.Text = Convert.ToChar(currentval).ToString();
        }
    }
}
