using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;

/*This program does not perform data validation Ie it will crash if you try to decode regular expressions e.g Hello World but it will
 Decode encoded text*/
namespace TextEncodeDecode
{
    public partial class SimpleEncodeDecodeApp : Form
    {
        public SimpleEncodeDecodeApp()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, EventArgs e)//This Segment Encodes the Text
        {
            var text = InputTextBox.Text;
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(text);
            var strModified = Convert.ToBase64String(byt);
            EncodeLabel.Text = Convert.ToString(strModified);
        }

        private void Decode_Click(object sender, EventArgs e)//This Segment Decodes the Text
        {
            try//Simple try and catch for error handling
            {
                var text = InputTextBox.Text;
                byte[] textByte = Convert.FromBase64String(text);
                text = System.Text.Encoding.UTF8.GetString(textByte);
                DecodeLabel.Text = Convert.ToString(text);
            }
            catch
            {
                var text = InputTextBox.Text;
                DecodeLabel.Text = Convert.ToString(text+":Already Decoded");
            }

        }
    }
}
