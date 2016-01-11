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

    }
    
}
