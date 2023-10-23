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
            option2Lable.Text = "stay home";

            option1.BackColor = Color.MediumTurquoise;
            option1Lable.BackColor = Color.Plum;
            option2.BackColor = Color.Turquoise;
            option2Lable.BackColor = Color.Plum;
            storyoutput.BackColor = Color.MediumTurquoise;

            imageBox.Image = Properties.Resources.happy_birthday;
            sp = new SoundPlayer(Properties.Resources.fireworksindistance);
            sp.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void choise1output_Click(object sender, EventArgs e)
        {
           
        }
        private void choise1_Click(object sender, EventArgs e)
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
                page = 6;
            }
            else if (page == 6)
            {
                page = 8;
            }

            else if (page == 8)
            {
                page = 1;
            }
            else if (page  == 9)
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
            else if (page == 11)
            {
                page = 1;
            }
            else if (page ==12)
            {
                page = 1;
            }
            else if(page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                Random rangen = new Random();
                int randvalue = rangen.Next(1, 11);

                if (randvalue > 7)
                {
                    page = 6;
                }
                else
                {
                    page = 15;
                }

            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 7;
            }

            switch (page)
            {
                case 1:
                    storyoutput.Text = "It's your birthday tomorrow but you don't think anything has been planned";
                    option1Lable.Text = "Plan something with your freinds";
                    option2Lable.Text = "Stay home";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.happy_birthday;
                    sp = new SoundPlayer(Properties.Resources.fireworksindistance);
                    sp.Play();
                    break;

                case 2:
                    storyoutput.Text = "Your friends are taking you to the fair but you promised your little brother you would go with him first ";
                    option1Lable.Text = "Go with them anyways";
                    option2Lable.Text = "Go home";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.fair_pic;
                    sp = new SoundPlayer(Properties.Resources.fair_background_noise);
                    sp.Play();
                    break;

                case 3:
                    storyoutput.Text = "Your family forgot your birthday ";
                    option1Lable.Text = "Stay home and pout";
                    option2Lable.Text = "Call your friends again";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();
                    break;

                case 4:
                    storyoutput.Text = "You go to the fair and they all leave you behind. do you go home or call your brother";
                    option1Lable.Text = "go home";
                    option2Lable.Text = "call your brother";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.fair_background_noise);
                    sp.Play();
                    break;

                case 5:
                    storyoutput.Text = "Your friends take you aout to eat but while your out your mom calls";
                    option1Lable.Text = "Answer her call";
                    option2Lable.Text = "Ignore her call";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.phone_ringing;
                    sp = new SoundPlayer(Properties.Resources.ring);
                    sp.Play();
                    break;

                case 6:
                    storyoutput.Text = "Your mom is waiting and asks where you've been ";
                    option1Lable.Text = "Lie and say you were just outside";
                    option2Lable.Text = "Tell the truth";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.house;

                    sp = new SoundPlayer(Properties.Resources.uhoh);
                    sp.Play();
                    break;

                case 7:
                    storyoutput.Text = "They didn't actually forget they were planning a surprise party. Would you like to play again?";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.happy_birthday;
                    sp = new SoundPlayer(Properties.Resources.fireworksindistance);
                    sp.Play();
                    break;

                case 8:
                    storyoutput.Text = "Your mom grounds you for lying. Would you like to play again?";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();
                    break;

                case 9:
                    storyoutput.Text = "Your mom tells you to do the dishes and says you'll talk later. Would you like to play again? ";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();
                    break;

                case 10:
                    storyoutput.Text = "Your mom tells you to come home ";
                    option1Lable.Text = "Go home";
                    option2Lable.Text = "Ignore her and stay ";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.house;
                    sp = new SoundPlayer(Properties.Resources.uhoh);
                    sp.Play();
                    break;

                case 11:
                    storyoutput.Text = "You get home that night and your dad grounds you for a month. Would u like to play again? ";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();
                    break;

                case 12:
                    storyoutput.Text = "your mom is upset but gives you a present anyways. Would you like to play again?";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.present;
                    break;

                case 13:
                    storyoutput.Text = "You get home at 9 and your mom is so mad she wont even talk to you but your dad says your grounded. Would you like to play again?";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();
                    break;
                 case 14:
                    storyoutput.Text = "your brother tells you to come home";
                    option1Lable.Text = "go home";
                    option2Lable.Text = "stay";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.house;
                    sp = new SoundPlayer(Properties.Resources.uhoh);
                    sp.Play();


                    break;
                case 15:
                    storyoutput.Text = "your brother meets you at the door and tells you to come with him";
                    option1Lable.Text = "go with him";
                    option2Lable.Text = "ignore him";
                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.house;
                    sp = new SoundPlayer(Properties.Resources.uhoh);
                    sp.Play();

                    break;

                case 16:
                    storyoutput.Text = "your brother is refusing to talk to you. would you like to play again ";
                    option1Lable.Text = "yes";
                    option2Lable.Text = "no";
                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();

                    break;
                case 17:
                    storyoutput.Text = "you missed the surprise party and your brother is mad at you would you like to play again?";
                    option1Lable.Text = "no";
                    option2Lable.Text = "Yes";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();

                    break;
                case 99:
                    storyoutput.Text = "Thank you for playing";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.thankyou;
                    sp = new SoundPlayer(Properties.Resources.fireworksindistance);
                    sp.Play();
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
                page = 3;

            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 2)
            {
                page = 6;
            }
            else if (page == 4)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 99;
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
                Random rangen = new Random();
                int randvalue = rangen.Next(1, 11);

                if (randvalue > 5)
                {
                    page = 9;
                }
                else
                {
                    page = 7;
                }

            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page==16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }
            switch (page)
            {
                case 1:
                    storyoutput.Text = "It's your birthday tomorrow but you don't think anything has been planned";
                    option1Lable.Text = "Plan something with your freinds";
                    option2Lable.Text = "Stay home";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.happy_birthday;
                    sp = new SoundPlayer(Properties.Resources.fireworksindistance);
                    sp.Play();
                    break;

                case 2:
                    storyoutput.Text = "Your friends are taking you to the fair but you promised your little brother you would go with him first ";
                    option1Lable.Text = "Go with them anyways";
                    option2Lable.Text = "Go home";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.fair_pic;
                    sp = new SoundPlayer(Properties.Resources.fair_background_noise);
                    sp.Play();
                    break;

                case 3:
                    storyoutput.Text = "Your family forgot your birthday ";
                    option1Lable.Text = "Stay home and pout";
                    option2Lable.Text = "Call your friends again";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();
                    break;

                case 4:
                    storyoutput.Text = "You go to the fair and they all leave you behind. do you go home or call your brother";
                    option1Lable.Text = "go home";
                    option2Lable.Text = "call your brother";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.fair_background_noise);
                    sp.Play();
                    break;

                case 5:
                    storyoutput.Text = "Your friends take you aout to eat but while your out your mom calls";
                    option1Lable.Text = "Answer her call";
                    option2Lable.Text = "Ignore her call";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.phone_ringing;
                    sp = new SoundPlayer(Properties.Resources.ring);
                    sp.Play();
                    break;

                case 6:
                    storyoutput.Text = "Your mom is waiting and asks where you've been ";
                    option1Lable.Text = "Lie and say you were just outside";
                    option2Lable.Text = "Tell the truth";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.house;

                    sp = new SoundPlayer(Properties.Resources.uhoh);
                    sp.Play();
                    break;

                case 7:
                    storyoutput.Text = "They didn't actually forget they were planning a surprise party. Would you like to play again?";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.happy_birthday;
                    sp = new SoundPlayer(Properties.Resources.fireworksindistance);
                    sp.Play();
                    break;

                case 8:
                    storyoutput.Text = "Your mom grounds you for lying. Would you like to play again?";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();
                    break;

                case 9:
                    storyoutput.Text = "Your mom tells you to do the dishes and says you'll talk later. Would you like to play again? ";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();
                    break;

                case 10:
                    storyoutput.Text = "Your mom tells you to come home ";
                    option1Lable.Text = "Go home";
                    option2Lable.Text = "Ignore her and stay ";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.house;
                    sp = new SoundPlayer(Properties.Resources.uhoh);
                    sp.Play();
                    break;

                case 11:
                    storyoutput.Text = "You get home that night and your dad grounds you for a month. Would u like to play again? ";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();
                    break;

                case 12:
                    storyoutput.Text = "your mom is upset but gives you a present anyways. Would you like to play again?";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.present;
                    break;

                case 13:
                    storyoutput.Text = "You get home at 9 and your mom is so mad she wont even talk to you but your dad says your grounded. Would you like to play again?";
                    option1Lable.Text = "Yes";
                    option2Lable.Text = "No";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();
                    break;
                case 14:
                    storyoutput.Text = "your brother tells you to come home";
                    option1Lable.Text = "go home";
                    option2Lable.Text = "stay";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.house;
                    sp = new SoundPlayer(Properties.Resources.uhoh);
                    sp.Play();


                    break;
                case 15:
                    storyoutput.Text = "your brother meets you at the door and tells you to come with him";
                    option1Lable.Text = "go with him";
                    option2Lable.Text = "ignore him";
                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.house;
                    sp = new SoundPlayer(Properties.Resources.uhoh);
                    sp.Play();

                    break;

                case 16:
                    storyoutput.Text = "your brother is refusing to talk to you. would you like to play again ";
                    option1Lable.Text = "yes";
                    option2Lable.Text = "no";
                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();

                    break;
                case 17:
                    storyoutput.Text = "you missed the surprise party and your brother is mad at you would you like to play again?";
                    option1Lable.Text = "no";
                    option2Lable.Text = "Yes";

                    option1.BackColor = Color.LightGray;
                    option1Lable.BackColor = Color.DarkGray;
                    option2.BackColor = Color.LightGray;
                    option2Lable.BackColor = Color.DarkGray;
                    storyoutput.BackColor = Color.DarkGray;

                    imageBox.Image = Properties.Resources.sadbirthday;
                    sp = new SoundPlayer(Properties.Resources.aww);
                    sp.Play();

                    break;
                case 99:
                    storyoutput.Text = "Thank you for playing";

                    option1.BackColor = Color.MediumTurquoise;
                    option1Lable.BackColor = Color.Plum;
                    option2.BackColor = Color.MediumTurquoise;
                    option2Lable.BackColor = Color.Plum;
                    storyoutput.BackColor = Color.MediumTurquoise;

                    imageBox.Image = Properties.Resources.thankyou;
                    sp = new SoundPlayer(Properties.Resources.fireworksindistance);
                    sp.Play();
                    Refresh();
                    Thread.Sleep(2000);
                    Close();
                    break;
                default:
                    break;
            }
            

        
                  
            
        }
            
               

        
    }
}
