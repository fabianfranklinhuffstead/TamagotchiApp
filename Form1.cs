using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tamogochiApp
{
/// <summary>
/// Tamogochi Program: User play, feed, heal, Talk using GUI to keep Tamogochi alive
/// Fabian Franklin-Huffstead, 04/01/12
/// SID: 1210275
/// Tamogochi 
/// </summary>
       
    public partial class Form1 : Form
    {
        static Tamogochi myTamogochi = new Tamogochi(); //tamogochi object.
        
        const int feed = 20; //feed value each time you feed the tamogochi this value is used.
        const int play = 20; //play value each time you played with your tamogochi this value is used
        const int heal = 10; //heal value each time tamogochi is healed this value is used.

        //these values will never need to be changed ergo the reason for them being set as const values.
        
        public Form1()
        {
            MessageBox.Show("Press \"OK\" to start.");
            InitializeComponent();
        }

        int ScoreNumber = 0;// this variable is used to store the number for the the score.

        private void timer1_Tick(object sender, EventArgs e)// the main timer.
        {
            
            myTamogochi.Hunger++; 
            myTamogochi.Bored++;
            // each 1 second the tamogochi hunger and boredness is increased by one.
            ScoreNumber++; //increases the scorenumber by one each second.

            scoreLabel.Text = "Score:" + ScoreNumber.ToString(); //this adds the score number(converted into string format) to the stated text so that each second scoreLabel is updated.
            if (myTamogochi.Health == 0)
            {
                timer1.Stop(); //timer stops when tamogochi health equals zero.
                MessageBox.Show("Your \"Tamogochi\" ("+myTamogochi.Name +") has passed away.\nCongratulations your score is: " + ScoreNumber + "\n\nPlease click the \"OK\" button to close.");
                Environment.Exit(0);
            }//end if
            if (myTamogochi.Ill == true)
            {
                myTamogochi.Health--; //this is the illness effect if illness is true then health is reduced by one each second.
            }//end if
            if (myTamogochi.Hunger == 100)
            {
                myTamogochi.Bored++;//if the tamogochi is not being feed at all then boredness is increased by an addtional value.
                myTamogochi.Health--;//if tamogochi is starving then health goes down by an additional value.
            }//end if
            if (myTamogochi.Bored == 100)
            {
                myTamogochi.Hunger++;//hunger is increased by an additional value to over copensate for owner neglecting tamogochi.
            }//end if
        }//end timer1_Tick

        private void RandomIll_Tick(object sender, EventArgs e)//made a sperate timer to make it more clearer if reading in perpective of designer.Orginally timer was at the same value as the exisiting one but was increased whilst testing.
        {
            int myRoller;
            Random roller = new Random(); //creates a random class object and calls it roller.
            myRoller = roller.Next(10); //stores my random number. Value will be between 0 and 9.
            if (myRoller == 0)// if that value is equal to 0 then the code inside the braces will be performed.
            {
                myTamogochi.Ill = true; 
            }//end if
        }//end RandomIll_Tick

        private void enterButton_Click(object sender, EventArgs e) //enter name button. //When the event is triggered then the code in the braces is performed.
        {
            tamogochiName.Text = nameTextBox.Text;
            myTamogochi.Name += nameTextBox.Text;
            nameTextBox.Clear(); //The text box is also cleared to avoid any confusion.
        }//end enterButton_Click

        private void playButton_Click(object sender, EventArgs e)//click to play
        {
            if (myTamogochi.Bored < 20 && myTamogochi.Health != 0)
            {
                MessageBox.Show("Your Tamogochi is not bored.\n\nTry talking to your \"Tamogochi\" to see how they feel.");
            }//end if
            else if (myTamogochi.Bored >= play)
            {
                myTamogochi.Bored -= play;
                MessageBox.Show("You have played with your Tamogochi.");
            }//end else if
        }//end playbutton_Click

        private void FeedButton_Click(object sender, EventArgs e)//click to feed.
        {
            if (myTamogochi.Hunger < 20 && myTamogochi.Health != 0)
            {
                MessageBox.Show("Your Tamogochi is not hungry.\n\nTry talking to your \"Tamogochi\" to see how they feel.");
            }//end if
            else if (myTamogochi.Hunger >= feed)
            {
                myTamogochi.Hunger -= feed; //takes away from existing value
                MessageBox.Show("You have fed your Tamogochi.");
            }//end else if
        }//end FeedButton_Click

        private void healButton_Click(object sender, EventArgs e)//healh button
        {
            
            if (myTamogochi.Health <= 90 && myTamogochi.Health != 0) //adds to health
            {
                myTamogochi.Health += heal;//adds to existing value.
                MessageBox.Show("You heal your Tamogochi.");
            }//end if
            if (myTamogochi.Ill == true)//cure tamogochi's ailments
            {
                myTamogochi.Ill = false;
                MessageBox.Show("You cure your Tamogochi it is no longer ill");
            }//end if
            else if (myTamogochi.Health > 90 && myTamogochi.Ill == false)
            {
                MessageBox.Show("Your Tamogochi does not need Healing.\n\nTry talking to your \"Tamogochi\" to see how they feel.");
            }//end else if
        }//end healButton_Click

        private void helpButton_Click(object sender, EventArgs e)//click to help
        {
            MessageBox.Show("Please refer to your \"Tamogochi\" user guide for help.");
        }//end helpButton_Click


        private void talkButton_Click(object sender, EventArgs e)//click to make tamogochi talk.
        {
            Talk();
        }//end talkButton_Click

        public static void Talk() //Start talk method.
        {

            if (myTamogochi.Hunger >= 70)
            {
                MessageBox.Show("\"I'm hungry!\"");
            }//end if

            if (myTamogochi.Bored >= 70)
            {
                MessageBox.Show("\"I'm bored!\"");
            }//end if

            if (myTamogochi.Health <= 70)
            {
                MessageBox.Show("\"I'm hurt!\"");
            }//end if

            if (myTamogochi.Ill == true)
            {
                MessageBox.Show("\"I don't feel good... i'm probably ill!\"");
            }//end if

            else if (myTamogochi.Hunger < 70 && myTamogochi.Bored < 70 && myTamogochi.Health > 70 && myTamogochi.Ill == false)
            {
                MessageBox.Show("\"I feel healthy!\"");
            }//end if else
        }//end talk method

        private void ExitButton_Click(object sender, EventArgs e)//click to exit program
        {
            Environment.Exit(0);
        }//end exitbutton

    }// end form class

    class Tamogochi
    {
        //fields
        private string name;
        private int hunger = 0;
        private int bored = 0;
        private int health = 100;
        private bool ill = false;
        //set the values for the tamogochi's excluding the name as this will be retrieved from the user.
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
            }
        }
        public int Bored
        {
            get
            {
                return bored;
            }
            set
            {
                bored = value;
            }
        }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public bool Ill
        {
            get
            {
                return ill;
            }
            set
            {
                ill = value;
            }
        }
    }//end class Tamogochi

}