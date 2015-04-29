using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int QuestionNo = 0;
        int True = 0;
        int False = 0;
        int time = 20;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            time = 20;
            label9.Text = time.ToString();

            button5.Text = "Next>>";
            QuestionNo++;
            label2.Text = QuestionNo.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (QuestionNo==1)
            {
                richTextBox1.Text = "The chemical symbol Ca represents the element...";
                button1.Text = "Neon";
                button2.Text = "Nickel";
                button3.Text = "Calcium";
                button4.Text = "Sulfur";

                label4.Text = "Calcium";
            }

            if (QuestionNo==2)
            {
                richTextBox1.Text = "Which of the following symbols means 'less than'?";
                button1.Text = "^";
                button2.Text = ">";
                button3.Text = "<";
                button4.Text = "||";

                label4.Text = "<";
            }
            if (QuestionNo==3)
            {
                richTextBox1.Text = "Which of the following expressions is the largest?";
                button1.Text = "16 + 4";
                button2.Text = "1-22";
                button3.Text = "19/1";
                button4.Text = "6*3";

                label4.Text = "16+4";
            }
            if (QuestionNo == 4)
            {
                richTextBox1.Text = "Most birds are covered with...";
                button1.Text = "Leaves";
                button2.Text = "Hair";
                button3.Text = "Scales";
                button4.Text = "Feathers";

                label4.Text = "Feathers";
            }
            if (QuestionNo == 5)
            {
                richTextBox1.Text = "Which one of the following measurements is the smallest?";
                button1.Text = "One yard";
                button2.Text = "One mile";
                button3.Text = "One foot";
                button4.Text = "One inch";

                label4.Text = "One inch";
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;
            label3.Text = button1.Text;
            if (label3.Text == label4.Text)
            {
                True++;
                label5.Text = True.ToString();
            }
            else
            {
                False++;
                label8.Text = False.ToString();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;

            label3.Text = button2.Text;
            if (label3.Text == label4.Text)
            {
                True++;
                label5.Text = True.ToString();
            }
            else
            {
                False++;
                label8.Text = False.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;
            
            label3.Text = button3.Text;
            if (label3.Text == label4.Text)
            {
                True++;
                label5.Text = True.ToString();
            }
            else
            {
                False++;
                label8.Text = False.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;

            label3.Text = button4.Text;
            if (label3.Text == label4.Text)
            {
                True++;
                label5.Text = True.ToString();
            }
            else
            {
                False++;
                label8.Text = False.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = Convert.ToInt32(label9.Text);

            time -= 1;
            label9.Text = time.ToString();

            if (time==0)
            {
                timer1.Enabled = false;
                False++;
                label8.Text=False.ToString();
            }
        }

    }
}
