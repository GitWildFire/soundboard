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
        private int buttonThreeOn = 0;
        private int buttonFourOn = 0;

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



        private void button4_Click(object sender, EventArgs e)
        {
            if (buttonFourOn == 0)
            {
                button4.Image = new Bitmap(@"C:\\Users\\Richard\\Desktop\\Soundboard GUI\\Soundboard GUI\\Soundboard GUI\\Button_on.png");
                buttonFourOn = 1;
            }
            else
            {
                button4.Image = new Bitmap(@"C:\\Users\\Richard\\Desktop\\Soundboard GUI\\Soundboard GUI\\Soundboard GUI\\ButtonOff.png");
                buttonFourOn = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (buttonThreeOn == 0)
                {
                    button3.Image = new Bitmap(@"C:\\Users\\Richard\\Desktop\\Soundboard GUI\\Soundboard GUI\\Soundboard GUI\\Button_on.png");
                    buttonThreeOn = 1;
                }
                else
                {
                    button3.Image = new Bitmap(@"C:\\Users\\Richard\\Desktop\\Soundboard GUI\\Soundboard GUI\\Soundboard GUI\\ButtonOff.png");
                    buttonThreeOn = 0;
                }

            
        }
    }
}
