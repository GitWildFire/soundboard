using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sounds
{
   

    public partial class Form1 : Form
    {
        private int buttonOneOn=0;
        private int buttonTwoOn=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonOneOn == 0) {
                button1.Image = new Bitmap(@"C:\\Users\\Richard\\Desktop\\Soundboard GUI\\Soundboard GUI\\Soundboard GUI\\Button_on.png");
                buttonOneOn = 1;
            }
            else {
                button1.Image = new Bitmap(@"C:\\Users\\Richard\\Desktop\\Soundboard GUI\\Soundboard GUI\\Soundboard GUI\\ButtonOff.png");
                buttonOneOn = 0;
             }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonTwoOn == 0)
            {
                button2.Image = new Bitmap(@"C:\\Users\\Richard\\Desktop\\Soundboard GUI\\Soundboard GUI\\Soundboard GUI\\Button_on.png");
                buttonTwoOn = 1;
            }
            else
            {
                button2.Image = new Bitmap(@"C:\\Users\\Richard\\Desktop\\Soundboard GUI\\Soundboard GUI\\Soundboard GUI\\ButtonOff.png");
                buttonTwoOn = 0;
            }
        }
    }
}
