using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Form1 : Form
    {
        bool isMovingUp = false;
        int liftSpeed = 5;
        bool isMovingDown = false;
         

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void btn_1_click (object sender, EventArgs e)
        {
            isMovingDown = false;
            isMovingUp = true;
            pictureBox6.BackColor = Color.LightGreen;
            timer1.Start();

        }
        public void btn_G_click(object sender, EventArgs e)
        {
            isMovingDown = true;
            isMovingUp = false;
            pictureBox5.BackColor = Color.LightGreen;
            timer1.Start();

        }

        public void liftTimer_tick(object sender, EventArgs e)
        {

            if (isMovingUp)
            {
                pictureBox5.Enabled = false;
                if (pictureBox1.Top > 0)
                {
                    pictureBox1.Top -= liftSpeed;
                }
                else
                {
                    pictureBox5.BackColor = Color.White;
                    pictureBox1.Top = 0;
                    timer1.Stop();
                    pictureBox5.Enabled = true;
                }
            }

            if (isMovingDown)
            {
                pictureBox6.Enabled = false;
                if (pictureBox1.Bottom < this.ClientSize.Height)
                {
                    pictureBox1.Top += liftSpeed;

                }

                else
                {
                    pictureBox6.BackColor = Color.White;
                    timer1.Stop();
                    pictureBox6.Enabled = true;

                }

                

            }
        }
    }
}
