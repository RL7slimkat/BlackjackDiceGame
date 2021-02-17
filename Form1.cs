using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*author: RLisasi
 * channel: RL7_slimkat video: Blackjack dice c# game demo
https://youtu.be/j06kMyWUe_8
 */
namespace Blackjack21
{
    public partial class Form1 : Form
    {
        //Result of the dice roll property
        private static int result1, result2, totalSum, sum = 0;
        Random rnd = new Random();

        //attach images to image objects
        Bitmap leftDice1 = Properties.Resources.leftDice1;
        Bitmap leftDice2 = Properties.Resources.leftDice2;
        Bitmap leftDice3 = Properties.Resources.leftDice3;
        Bitmap leftDice4 = Properties.Resources.leftDice4;
        Bitmap leftDice5 = Properties.Resources.leftDice5;
        Bitmap leftDice6 = Properties.Resources.leftDice6;

        Bitmap rightDice1 = Properties.Resources.rightDice1;
        Bitmap rightDice2 = Properties.Resources.rightDice2;
        Bitmap rightDice3 = Properties.Resources.rightDice3;
        Bitmap rightDice4 = Properties.Resources.rightDice4;
        Bitmap rightDice5 = Properties.Resources.rightDice5;
        Bitmap rightDice6 = Properties.Resources.rightDice6;


        public Form1()
        {
            InitializeComponent();
            //set everything to 0
            setNull();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //timers for animations
            if (dicePickupTimer.Enabled == false && handTimer.Enabled == false && diceThrowTimer.Enabled == false)
            {
                dicePickupTimer.Enabled = true;
                handTimer.Enabled = true;
                diceThrowTimer.Enabled = true;
            }
            //only show 1 dice after 15
            if (totalSum >= 15)
            {
                rollDice1();
                totalSum += sum;
                diceBox2.Image = null;
            }
            //continue to roll before 15
            if (totalSum < 15)
            {
                rollDice2();
                totalSum += sum;
            }


            handGif.Enabled = true;

            //show message when you win
            if (totalSum == 21)
            {
                totalSum = 0;
                sum = 0;
                lblResult.Text = "WIN";
                // exit confirmation prompt
                DialogResult confirmExit = MessageBox.Show("You hit 21, smash yes to replay or no to exit",
                "WIN", MessageBoxButtons.YesNo);

                if (confirmExit == DialogResult.Yes)
                {
                    //close the message box
                    setNull();
                    //enable button
                    btnPlay.Enabled = true;
                }
                else
                {
                    //exit
                    this.Close();
                }
            }
            //hhandle losing
            if (totalSum > 21)
            {
                totalSum = 0;
                sum = 0;
                lblResult.Text = "BUST";
                // exit confirmation prompt
                DialogResult confirmExit = MessageBox.Show("You went over 21, smash yes to replay or no to exit",
                "BUST", MessageBoxButtons.YesNo);

                if (confirmExit == DialogResult.Yes)
                {
                    //close the message box
                    setNull();
                    //enable button
                    btnPlay.Enabled = true;
                }
                else
                {
                    //exit
                    this.Close();
                }

            }


        }
        //timer for the hand
        private void handTimer_Tick(object sender, EventArgs e)
        {
            handGif.Enabled = false;
            handTimer.Enabled = false;
            btnPlay.Enabled = true;
        }
        //timer for picking up the dice
        private void dicePickupTimer_Tick(object sender, EventArgs e)
        {
            diceBox1.Image = null;
            diceBox2.Image = null;
            diceBox1.Visible = false;
            diceBox2.Visible = false;
            dicePickupTimer.Enabled = false;
        }
        //timer for throwing the dice
        private void diceThrowTimer_Tick(object sender, EventArgs e)
        {
            setDiceImg();
            diceThrowTimer.Enabled = false;
            lblResult.Text = (totalSum).ToString();
            diceBox1.Visible = true;
            diceBox2.Visible = true;
        }
        //what happens when you roll 2 dice
        public void rollDice2()
        {
            //Generate random number between 1 and 6 for roll 1
            result1 = rnd.Next(1, 7);
            result2 = rnd.Next(1, 7);
            sum = result1 + result2;
            Console.WriteLine($"you rolled 2 dice of {sum} and your total is {totalSum + sum}");
            //disable button while dice is being thrown
            btnPlay.Enabled = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // exit confirmation prompt
            DialogResult confirmExit = MessageBox.Show("You roll dice in an attempt to hit exactly 21.  If you go over 21, you lose.  If you hit 21 exactly, you win. At first you will roll 2 dice.  Once your total hits 15 or above, you will only roll one dice.",
            "HELP", MessageBoxButtons.OK);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit confirmation prompt
            DialogResult confirmExit = MessageBox.Show("Are you sure you'd like to exit?",
            "QUIT", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                //exit
                this.Close();
            }
            else
            {
                //return to game
            btnPlay.Enabled = true;
            }

        }

        //what happens when you roll 1 die
        public void rollDice1()
        {
            result2 = 0;
            result1 = rnd.Next(1, 7);
            sum = result1;
            Console.WriteLine($"you rolled 1 die of {sum} and your total is {totalSum + sum}");
            //enable button
            btnPlay.Enabled = false;
        }
        //reset everything
        public void setNull()
        {
            handGif.Enabled = false;
            dicePickupTimer.Enabled = false;
            handTimer.Enabled = false;
            diceThrowTimer.Enabled = false;
            diceBox1.Image = null;
            diceBox2.Image = null;
            totalSum = sum = 0;
            lblResult.Text = (totalSum + sum).ToString();
            //enable button
            btnPlay.Enabled = true;
        }
        //set the image according to the result
        public void setDiceImg()
        {
            switch (result1)
            {
                //set dice 1
                case 1:
                    diceBox1.Image = leftDice1;
                    break;
                case 2:
                    diceBox1.Image = leftDice2;
                    break;
                case 3:
                    diceBox1.Image = leftDice3;
                    break;
                case 4:
                    diceBox1.Image = leftDice4;
                    break;
                case 5:
                    diceBox1.Image = leftDice5;
                    break;
                case 6:
                    diceBox1.Image = leftDice6;
                    break;
                default:
                    diceBox1.Image = null;
                    break;
            }
            //set dice 2
            switch (result2)
            {
                case 1:
                    diceBox2.Image = rightDice1;
                    break;
                case 2:
                    diceBox2.Image = rightDice2;
                    break;
                case 3:
                    diceBox2.Image = rightDice3;
                    break;
                case 4:
                    diceBox2.Image = rightDice4;
                    break;
                case 5:
                    diceBox2.Image = rightDice5;
                    break;
                case 6:
                    diceBox2.Image = rightDice6;
                    break;
                default:
                    diceBox2.Image = null;
                    break;
            }
        }
    }
}
