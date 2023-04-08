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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int input = int.Parse(textBox1.Text);
                textBox1.Text = "";
                if (input > 999 || input < 100)
                {
                    MessageBox.Show("Number is not in range");
                    return;
                }
                counter++;
                label2.Text = "Round: " + counter.ToString();
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
                    label2.Text += " - You WIN";
                    button1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            rnd = r.Next(100,999);
            label1.Text = rnd.ToString();
            label2.Text = "Round: " + counter.ToString();
        }
    }
}
