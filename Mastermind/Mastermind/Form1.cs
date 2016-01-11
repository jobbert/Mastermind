using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Form1 : Form
    {
        Kleur color;
        int count = 0;
        public string[] colorSequence = new string[4];
        public string[] randomSequence = new string[4];
        Button[] sequence;
        Bitmap b;

        public Form1()
        {
            InitializeComponent();
            sequence = new Button[4];
            sequence[0] = guesDot1;
            sequence[1] = guesDot2;
            sequence[2] = guesDot3;
            sequence[3] = guesDot4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
        private void alert(int count, string colorSequence)
        {
            if(count == 4)
            {
                foreach (string item in colorSequence)
                {
                    MessageBox.Show(item);
                }
            }
        }
        */
        public void blackbtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(0);
            colorSequence[count] = color.getColor();
            b = new Bitmap(@"Mastermind\kleuren\Dots\black.png");
            sequence[count].BackgroundImage = b;
            b.Dispose();
            count++;
        }

        private void bluebtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(1);
            colorSequence[count] = color.getColor();
            b = new Bitmap(@"Mastermind\kleuren\Dots\blue.png");
            sequence[count].BackgroundImage = b;
            b.Dispose();
            count++;
        }

        private void greenbtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(2);
            colorSequence[count] = color.getColor();
            b = new Bitmap(@"Mastermind\kleuren\Dots\green.png");
            sequence[count].BackgroundImage = b;
            b.Dispose();
            count++;
        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(3);
            colorSequence[count] = color.getColor();
            b = new Bitmap(@"Mastermind\kleuren\Dots\red.png");
            sequence[count].BackgroundImage = b;
            b.Dispose();
            count++;
        }

        private void whitebtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(4);
            colorSequence[count] = color.getColor();
            b = new Bitmap(@"Mastermind\kleuren\Dots\white.png");
            sequence[count].BackgroundImage = b;
            b.Dispose();
            count++;
        }

        private void yellowbtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(5);
            colorSequence[count] = color.getColor();
            b = new Bitmap(@"Mastermind\kleuren\Dots\yellow.png");
            sequence[count].BackgroundImage = b;
            b.Dispose();
            count++;
        }
        //////////////////////////////
        ///* for testing purposes *///
        private void button1_Click(object sender, EventArgs e)
        {   
            MessageBox.Show(colorSequence[0] + '|' + colorSequence[1] + '|' + colorSequence[2] + '|' + colorSequence[3]);
            if (count == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    colorSequence[i] = null;//reset the colorSequence array
                }
                count = 0;//reset the count
                MessageBox.Show("colorSequence : \n" + colorSequence[0] + '\n' + colorSequence[1] + '\n' + colorSequence[2] + '\n' + colorSequence[3]);
            }
            var random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int randomInt = random.Next(6);
                color = new Kleur(randomInt);
                randomSequence[i] = color.getColor();
                MessageBox.Show("randomSequence : \n" + randomSequence[0] + '\n' + randomSequence[1] + '\n' + randomSequence[2] + '\n' + randomSequence[3]);
                if (i == 3)
                {
                    for (int x = 0; x < 4; x++)
                    {
                        randomSequence[x] = null;//reset the colorSequence array
                    }
                }
            }
            //string[] randomSequence = { "black.png", "black.png", "black.png", "black.png" };
            Check check = new Check(colorSequence, randomSequence);
        }
        //////////////////////////////
        //////////////////////////////
    }
}
