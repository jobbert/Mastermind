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

        public Form1()
        {
            InitializeComponent();
            
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
            count++;
        }

        private void bluebtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(1);
            colorSequence[count] = color.getColor();
            count++;
        }

        private void greenbtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(2);
            colorSequence[count] = color.getColor();
            count++;
        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(3);
            colorSequence[count] = color.getColor();
            count++;
        }

        private void whitebtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(4);
            colorSequence[count] = color.getColor();
            count++;
        }

        private void yellowbtn_Click(object sender, EventArgs e)
        {
            color = new Kleur(5);
            colorSequence[count] = color.getColor();
            count++;
        }
        //////////////////////////////
        ///* for testing purposes *///
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(colorSequence[0] + '|' + colorSequence[1] + '|' + colorSequence[2] + '|' + colorSequence[3]);
            if (count == 4)
            {
                foreach (string item in colorSequence)
                {
                    MessageBox.Show(item);
                }
                for (int i = 0; i < 4; i++)
                {
                    colorSequence[i] = null;//reset the colorSequence array
                }
                count = 0;//reset the count
                MessageBox.Show(colorSequence[0] + '|' + colorSequence[1] + '|' + colorSequence[2] + '|' + colorSequence[3]);
            }
        }
        //////////////////////////////
        //////////////////////////////
    }
}
