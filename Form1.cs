using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayAutoCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int mousespeed = 25;
            if (e.KeyData == Keys.A && pictureBox1.Left > 180)
                pictureBox1.Location = new Point(pictureBox1.Location.X - mousespeed, pictureBox1.Location.Y);
            if (e.KeyData == Keys.D && pictureBox1.Left < 420)
                pictureBox1.Location = new Point(pictureBox1.Location.X + mousespeed, pictureBox1.Location.Y);
            if (e.KeyData == Keys.W)
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - mousespeed);
            if (e.KeyData == Keys.S)
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + mousespeed);
            if (e.KeyData == Keys.Left && mashinka2.Left > 600)
                mashinka2.Location = new Point(mashinka2.Location.X - mousespeed, mashinka2.Location.Y);
            if (e.KeyData == Keys.Right && mashinka2.Left < 840)
                mashinka2.Location = new Point(mashinka2.Location.X + mousespeed, mashinka2.Location.Y);
            if (e.KeyData == Keys.Up)
                mashinka2.Location = new Point(mashinka2.Location.X, mashinka2.Location.Y - mousespeed);
            if (e.KeyData == Keys.Down)
                mashinka2.Location = new Point(mashinka2.Location.X, mashinka2.Location.Y + mousespeed);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (shetchik1 == 30)
            {
                timer1.Stop();
                MessageBox.Show("Порше выиграл!");
                this.Close();
            }
            else if (shetchik2 == 30)
            {
                timer1.Stop();
                MessageBox.Show("Феррари выиграл");
                this.Close();
            }
            int speed = 10;
            Doroga2.Top += speed;
            Doroga.Top += speed;
            if (Doroga2.Top >= 450) { Doroga2.Top = 0; Doroga.Top = -450; }
            int babkaspeed = 10;
            babka_ferrari.Top += babkaspeed;
            babka_porshe.Top += babkaspeed;
            if (babka_porshe.Top >= 545)
            {
                babka_porshe.Top = -100;
                Random rand = new Random();
                babka_porshe.Left = rand.Next(180, 450);
            }
            if (babka_ferrari.Top >= 545)
            {
                babka_ferrari.Top = -100;
                Random rand1 = new Random();
                babka_ferrari.Left = rand1.Next(600, 840);
            }

            if (pictureBox1.Bounds.IntersectsWith(babka_porshe.Bounds))
            {
                babka_porshe.Top = -100;
                Random rand = new Random();
                babka_porshe.Left = rand.Next(180, 450);
                shetchik1 = shetchik1 - 1;
            }
            else { }

            if (mashinka2.Bounds.IntersectsWith(babka_ferrari.Bounds))
            {
                babka_ferrari.Top = -100;
                Random rand1 = new Random();
                babka_ferrari.Left = rand1.Next(600, 840);
                shetchik2 = shetchik2 - 1;
            }
            else { }
            
            int coinspeed = 10;
            coin1.Top += coinspeed;
            coin2.Top += coinspeed;
            if (coin1.Top >= 545)
            {
                coin1.Top = -100;
                Random rand = new Random();
                coin1.Left = rand.Next(150, 500);
            }
            if (coin2.Top >= 545)
            {
                coin2.Top = -100;
                Random rand1 = new Random();
                coin2.Left = rand1.Next(550, 900);
            }

            if (pictureBox1.Bounds.IntersectsWith(coin1.Bounds))
            {
                coin1.Top = -100;
                Random rand = new Random();
                coin1.Left = rand.Next(180, 450);
                shetchik1 = shetchik1 + 1;
                label1.Text = Convert.ToString(shetchik1);
                
            }
            if (mashinka2.Bounds.IntersectsWith(coin2.Bounds))
            {
                coin2.Top = -100;
                Random rand1 = new Random();
                coin2.Left = rand1.Next(600, 840);
                shetchik2 = shetchik2 + 1;
                label2.Text = Convert.ToString(shetchik2);
                
                }
                else { }


            }
            double shetchik1 = 0;
            double shetchik2 = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void babka_porshe_Click(object sender, EventArgs e)
        {

        }
    }
}

