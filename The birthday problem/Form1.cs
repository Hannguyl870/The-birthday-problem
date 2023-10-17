//hannah guylee
//october 2023
//choises game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace The_birthday_problem
{
    public partial class Form1 : Form
    {
        int page = 1;
        SoundPlayer sp;

        public Form1()
        {
            InitializeComponent();
            storyoutput.Text = "It's your birthday tomorrow but you don't think anything has been planned";
            option1Lable.Text = "plan something with your freinds";
            option2Label.Text = "stay home";
            imageBox.Image = Properties.Resources.happy_birthday;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void choise1output_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
           
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 8;
            }

            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 10;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 12;
            }

            switch (page)
            {
                case 1:
                    storyoutput.Text = "It's your birthday tomorrow but you don't think anything has been planned";
                    option1Lable.Text = "plan something with your freinds";
                    option2Label.Text = "stay home";

                    imageBox.Image = Properties.Resources.happy_birthday;
                    break;

                case 2:
                    storyoutput.Text = "Your friends are taking you to the fair but you promised your little brother you would go with him first ";
                    option1.Text = "go with them anyways";
                    option2.Text = " go home";

                    imageBox.Image = Properties.Resources.fair_pic;
                    break ;

                case 3:
                    storyoutput.Text = "Your family forgot your birthday ";
                    option1Lable.Text = "stay home and pout";
                    option2Label.Text = " call your friends again";
                    imageBox.Image = Properties.Resources.sadbirthday;
                    break;

                case 4:
                    storyoutput.Text = "You go to the fair and they all leave you behind.Would yo like to play again?";
                    option1.Text = "yes";
                    option2.Text = "no";
                    imageBox.Image = Properties.Resources.sadbirthday;
                    break;

                case 5:
                    storyoutput.Text = "Your friends take you aout to eat but while your out your mom calls";
                    option1Lable.Text = "answer her call";
                    option2Label.Text = "ignore her call";
                    imageBox.Image = Properties.Resources.phone_ringing;
                    break;

                case 6:
                    storyoutput.Text = "Your mom is waiting and asks where you've been ";
                    option1Lable.Text = "lie and say you were just outside";
                    option2Label.Text = "tell the truth";

                    break;

                case 7:
                    storyoutput.Text = "They didn't actually forget they were planning a surprise party. would you like to play again?";
                    option1Lable.Text = "yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.happy_birthday;
                    break;

                case 8:
                    storyoutput.Text = "Your mom grounds you for lying.Would u like to play again?";
                    option1Lable.Text = "yes";
                    option2Label.Text = "no";
                    imageBox.Image= Properties.Resources.sadbirthday;
                    break ;

                case 9:
                    storyoutput.Text = "Your mom tells you to do the dishes and says you'll talk later. would you like to play again? ";
                    option1Lable.Text = "yes";
                    option2Label.Text = "no";
                    imageBox.Image = Properties.Resources.sadbirthday;
                    break;

                case 10:
                    storyoutput.Text = "Your mom tells you to come home ";
                    option1Lable.Text = "Go home";
                    option2Label.Text = "Ignore her and stay ";
                    break;

                case 11:
                    storyoutput.Text = "You get home that night and your dad grounds you for a month. Would u like to play again? ";
                    option1Lable.Text = "yes";
                    option2Label.Text = "no";
                    imageBox.Image = //Properties.Resources.sadbirthday;
                    break;

                case 12:
                    storyoutput.Text = "your mom is upset but gives you a present anyways. would you like to play again?";
                    option1Lable.Text = "yes";
                    option2Label.Text = "no";
                    break;

                case 13:
                    storyoutput.Text = "You get home at 9 and your mom is so mad she wont even talk to you but your dad says your grounded. would you like to play again?";
                    option1Lable.Text = "yes";
                    option2Label.Text = "no";
                    imageBox.Image = Properties.Resources.sadbirthday;
                    break;

                case 99:
                    storyoutput.Text = "Thank you for playing";
                    Refresh();
                    Thread.Sleep(2000);
                    Close();
                    break;
                default:
                    break;
            }
                    
        }

        private void choise2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                Random rangen = new Random();
                int randvalue = rangen.Next(1,11);

                if (randvalue > 8)
                {
                    page = 7;
                }
                else
                {
                    page = 3;
                }
         
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 2)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 99;
            }


        }

        private void choise2output_Click(object sender, EventArgs e)
        {

        }

        private void choise1_Click(object sender, EventArgs e)
        {

        }

        private void storyoutput_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
