using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int rnd = 0, counter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        int input;
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                button2.Enabled = true;
                 input = int.Parse(textBox1.Text);
                if (input > 999 || input < 100)
                {
                    MessageBox.Show("Number is not in range");
                    return;
                }
                counter++;
              
                if (counter > 10)
                {
                    MessageBox.Show("Game Over!");
                    button1.Enabled = false;
                    return;
                }
                listBox1.Items.Add(input);
                if (input > rnd)
                    MessageBox.Show("Your Guess > this Number");
                else if (input < rnd)
                    MessageBox.Show("Your Guess < this Number");
                else
                {
                    MessageBox.Show("WIN");
                    button1.Enabled = false;
                }
                label1.Text ="Rond"+ counter.ToString();
                textBox1.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            random();
            listBox1.Items.Clear();
            counter = 0;
            label1.Text = "Round";
            textBox1.Clear();
            textBox1.Focus();
            label2.Text = rnd.ToString();
            button2.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random();

            label2.Text = rnd.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int i=0;
            input = 550;
            int min = 100;
            int max = 999;
            while (input!= rnd)
            {
                
                i++;
                if (input > rnd)
                {
                    max = input;
                    input = (input - min) / 2 + min; ;

                }
                else if(input<rnd)
                {
                    min = input;
                    input = (max - input) / 2 + input;
                }
                listBox1.Items.Add(input);
            }
            MessageBox.Show("you win with " + i + " try");
            button2.Enabled = true;

        }
        

        private void random ()
        {
            Random r = new Random();
            rnd = r.Next(100, 999);
        }

    }
}
