using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        int turn = 1;
        public string[] colorSequence = new string[4];
        public string[] randomSequence = new string[4];
        public Button[] guess = new Button[4];
        public Button[] sequence = new Button[4];
        //string dir = Path.GetDirectoryName(Application.ExecutablePath);

        public Form1()
        {
            InitializeComponent();
            guess[0] = guessDot1;
            guess[1] = guessDot2; 
            guess[2] = guessDot3; 
            guess[3] = guessDot4; 
            sequence[0] = sequenceDot1;
            sequence[1] = sequenceDot2;
            sequence[2] = sequenceDot3;
            sequence[3] = sequenceDot4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setRandomSequence();
            var random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int randomInt = random.Next(6);
                color = new Kleur(randomInt);
                randomSequence[i] = color.getColor();
                string val = randomSequence[i];
                sequence[i].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(val);
            }
        }
        //public Array setRandomSequence()
        //{
        //    var random = new Random();
        //    for (int i = 0; i < 4; i++)
        //    {
        //        int randomInt = random.Next(6);
        //        color = new Kleur(randomInt);
        //        randomSequence[i] = color.getColor();
        //        string val = randomSequence[i];
        //        sequence[i].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(val);
        //    }
        //    return randomSequence;
        //}
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
            //b = new Bitmap(@"..\kleuren\Dots\black.png");
            //sequence[count].BackgroundImage = b;
            guess[count].BackgroundImage = ((System.Drawing.Image)(Properties.Resources.black));
            //b.Dispose();
            count++;
        }

        private void bluebtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(1);
            colorSequence[count] = color.getColor();
            //b = new Bitmap(@"..\kleuren\Dots\blue.png");
            //sequence[count].BackgroundImage = b;
            //b.Dispose();
            guess[count].BackgroundImage = ((System.Drawing.Image)(Properties.Resources.blue));
            count++;
        }

        private void greenbtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(2);
            colorSequence[count] = color.getColor();
            //b = new Bitmap(@"..\kleuren\Dots\green.png");
            //sequence[count].BackgroundImage = b;
            //b.Dispose();
            guess[count].BackgroundImage = ((System.Drawing.Image)(Properties.Resources.green));
            count++;
        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(3);
            colorSequence[count] = color.getColor();
            //b = new Bitmap(@"..\kleuren\Dots\red.png");
            //sequence[count].BackgroundImage = b;
            //b.Dispose();
            guess[count].BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
            count++;
        }

        private void whitebtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(4);
            colorSequence[count] = color.getColor();
            //b = new Bitmap(@"..\kleuren\Dots\white.png");
            //sequence[count].BackgroundImage = b;
            //b.Dispose();
            guess[count].BackgroundImage = ((System.Drawing.Image)(Properties.Resources.white));
            count++;
        }

        private void yellowbtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(5);
            colorSequence[count] = color.getColor();
            //b = new Bitmap(@"..\kleuren\Dots\yellow.png");
            //sequence[count].BackgroundImage = b;
            //b.Dispose();
            guess[count].BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yellow));
            count++;
        }
        private void go_Click(object sender, EventArgs e)
        {
            MessageBox.Show(count.ToString());
            MessageBox.Show("colorSequence : \n" + colorSequence[0] + '\n' + colorSequence[1] + '\n' + colorSequence[2] + '\n' + colorSequence[3]);
            if (count == 4)
            {
                count = 0;//reset the count
                if(turn > 0 && turn < 8)
                {
                    MessageBox.Show("randomSequence : \n" + randomSequence[0] + '\n' + randomSequence[1] + '\n' + randomSequence[2] + '\n' + randomSequence[3]);
                    Check Check = new Check(colorSequence, randomSequence);

                    MessageBox.Show(turn.ToString());
                    for (int i = 0; i < 4; i++)
                    {
                        //before the next line runs the sequence needs to be transfered to its fixed turn position and its checkDots need to be filled
                        //colorSequence[i] = null;//reset the colorSequence array
                        guess[i].BackgroundImage = ((System.Drawing.Image)(Properties.Resources.hole));//reset the guess array
                    }
                    //dit moet zoiets worden
                    //Beurt setSequence = new Beurt(turn, guess);

                    Form1 form = new Form1();
                    Beurt beurt = new Beurt(turn, form);
                    beurt.setSequence(turn, colorSequence);

                    turn++;
                }
                if (turn == 8)
                {
                    Check Check = new Check(colorSequence, randomSequence);
                    int p = Check.getScore();
                    if (p == 4)
                    {
                        MessageBox.Show("you win!");
                    }
                    else
                    {
                        MessageBox.Show("you lose!");
                    }
                    turn = 0;
                }
            }
            //Check check = new Check(colorSequence, randomSequence);


            //turn++;
        }
    }
}
