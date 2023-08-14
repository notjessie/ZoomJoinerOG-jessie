using System;
using System.Windows.Forms;

namespace ZoomJoiner
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        string loginroyan = "lex";
        string passroyan = "Royan2007_+!";
        string loginvlad = "Skeden";
        string passvlad = "skeden01";
        string loginmaks = "shev";
        string passmaks = "shev01";
        string loginartyom = "arutemu";
        string passartyom = "HYPE";

        void TimerSmooth()
        {
            Opacity = 0;
            bool fadingIn = true;

            Timer timer = new Timer();
            timer.Tick += new EventHandler((s, e1) =>
            {
                if (fadingIn)
                {
                    if ((Opacity += 0.1d) >= 1)
                    {
                        fadingIn = false;
                    }
                }
            });
            timer.Interval = 100;
            timer.Start();
        }


            private void button1_Click(object sender, EventArgs e)
            {
                if (textBox1.Text == loginroyan)
                {
                    if (textBox2.Text == passroyan)
                    {
                        Hide();
                        var form1 = new Form1();
                        form1.Closed += (s, args) => Close();
                        form1.Show();
                    }
                else
                {
                    MessageBox.Show("password and login incorrect", "yep", MessageBoxButtons.OK);
                }
                }

            else if (textBox1.Text == loginvlad)
            {
                if (textBox2.Text == passvlad)
                {
                    Hide();
                    var form1 = new Form1();
                    form1.Closed += (s, args) => Close();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("password and login incorrect", "yep", MessageBoxButtons.OK);
                }
            }

            else if(textBox1.Text == loginmaks)
            {
                if (textBox2.Text == passmaks)
                {
                    Hide();
                    var form1 = new Form1();
                    form1.Closed += (s, args) => Close();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("password and login incorrect", "yep", MessageBoxButtons.OK);
                }
            }


            else if(textBox1.Text == loginartyom)
            {
                if (textBox2.Text == passartyom)
                {
                    Hide();
                    var form1 = new Form4();
                    form1.Closed += (s, args) => Close();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("password and login incorrect", "yep", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("password and login incorrect", "yep", MessageBoxButtons.OK);
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            TimerSmooth();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
    } 
