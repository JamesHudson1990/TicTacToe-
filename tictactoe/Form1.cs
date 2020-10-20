using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool Bool_Turn = true;
        int int_TurnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            if (butPlay.Text == "Play") //play
            {


                if (txtPlayerOne.Text == "")
                {
                    MessageBox.Show("Please enter player one's name");
                }


                else if (txtPlayerTwo.Text == "")
                {
                        MessageBox.Show("Please enter player two's name");
                }

                
                        else
                        {
                        butPlay.Text = ("Quit"); //changes buttons text to name

                        butA1.Enabled = true; // activates buttons
                        butA2.Enabled = true;
                        butA3.Enabled = true;
                        butB1.Enabled = true;
                        butB2.Enabled = true;
                        butB3.Enabled = true;
                        butC1.Enabled = true;
                        butC2.Enabled = true;
                        butC3.Enabled = true;

                        butA1.BackColor = Color.Gold; //changes background colour of the button
                        butA2.BackColor = Color.Gold;
                        butA3.BackColor = Color.Gold;
                        butB1.BackColor = Color.Gold;
                        butB2.BackColor = Color.Gold;
                        butB3.BackColor = Color.Gold;
                        butC1.BackColor = Color.Gold;
                        butC2.BackColor = Color.Gold;
                        butC3.BackColor = Color.Gold;

                        }

            }


            else //quit
            {
                butPlay.Text = ("Play"); //changes buttons text to Play

                butA1.Enabled = false; // deactivates buttons
                butA2.Enabled = false;
                butA3.Enabled = false;
                butB1.Enabled = false;
                butB2.Enabled = false;
                butB3.Enabled = false;
                butC1.Enabled = false;
                butC2.Enabled = false;
                butC3.Enabled = false;

                butA1.BackColor = Color.DarkRed; //changes background colour of the button
                butA2.BackColor = Color.DarkRed;
                butA3.BackColor = Color.DarkRed;
                butB1.BackColor = Color.DarkRed;
                butB2.BackColor = Color.DarkRed;
                butB3.BackColor = Color.DarkRed;
                butC1.BackColor = Color.DarkRed;
                butC2.BackColor = Color.DarkRed;
                butC3.BackColor = Color.DarkRed;


                butA1.Text = "";
                butA2.Text = "";
                butA3.Text = "";
                butB1.Text = "";
                butB2.Text = "";
                butB3.Text = "";
                butC1.Text = "";
                butC2.Text = "";
                butC3.Text = "";

            }
        }


        private void butA1_Click(object sender, EventArgs e)
        {
            Button ButClickPlay = (Button)sender;

            if (Bool_Turn)
            {
                ButClickPlay.Text = "O";
            }
            else
            {
                ButClickPlay.Text = "X";

            }
            
            if(ButClickPlay.Text == "O")
            {
                butA1.ForeColor = Color.Red;
            }
            else
            {
                butA1.ForeColor = Color.Green;
            }
            Bool_Turn = !Bool_Turn; // changes the turns
            int_TurnCount++;
            CheckForWinner();
            ButClickPlay.Enabled = false;
            
        }

        private void CheckForWinner()
        {
            bool bool_CheckForWinner = false;
            string str_winner;


            if ((butA1.Text == butA2.Text) && (butA2.Text == butA3.Text) && (butA1.Enabled == false))
            {
                bool_CheckForWinner = true;               
            } // Checks for Top Horizontal Win
            else if((butB1.Text == butB2.Text) && (butB2.Text == butB3.Text) && (butB1.Enabled == false))
            {
                bool_CheckForWinner = true;
            } // checks Mid horizontal Win
            else if((butC1.Text == butC2.Text) && (butC2.Text == butC3.Text) && (butC1.Enabled == false))
            {
                bool_CheckForWinner = true;
            } // checks bot horizontal win
            else if((butA1.Text == butB1.Text) && (butB1.Text == butC1.Text) && (butA1.Enabled == false))
            {
                bool_CheckForWinner = true;
            } // checks left column win
            else if((butA2.Text == butB2.Text) && (butB2.Text == butC2.Text) && (butA2.Enabled == false))
            {
                bool_CheckForWinner = true;
            } // checks mid column win
            else if((butA3.Text == butB3.Text) && (butB3.Text == butC3.Text) && (butA3.Enabled == false))
            {
                bool_CheckForWinner = true;
            }// checks right column win
            else if ((butA1.Text == butB2.Text) && (butB2.Text == butC3.Text) && (butA1.Enabled == false))
            {
                bool_CheckForWinner = true;
            } // checks Diagonal top left to right
            else if ((butA3.Text == butB2.Text) && (butB2.Text == butC1.Text) && (butA3.Enabled == false))
            {
                bool_CheckForWinner = true;
            }
          

            if (bool_CheckForWinner)
            {

                if (Bool_Turn)
                {
                    str_winner = "X";

                    MessageBox.Show(txtPlayerTwo.Text + " wins", "Congratulations");
                   
                    DialogResult PlayAgain = MessageBox.Show("Would you like to play again?", "Play again", MessageBoxButtons.YesNo);
                    if(PlayAgain == DialogResult.Yes)
                    {
                        butPlay.Text = ("Play"); //changes buttons text to Play

                        butA1.Enabled = false; // deactivates buttons
                        butA2.Enabled = false;
                        butA3.Enabled = false;
                        butB1.Enabled = false;
                        butB2.Enabled = false;
                        butB3.Enabled = false;
                        butC1.Enabled = false;
                        butC2.Enabled = false;
                        butC3.Enabled = false;

                        butA1.BackColor = Color.DarkRed; //changes background colour of the button
                        butA2.BackColor = Color.DarkRed;
                        butA3.BackColor = Color.DarkRed;
                        butB1.BackColor = Color.DarkRed;
                        butB2.BackColor = Color.DarkRed;
                        butB3.BackColor = Color.DarkRed;
                        butC1.BackColor = Color.DarkRed;
                        butC2.BackColor = Color.DarkRed;
                        butC3.BackColor = Color.DarkRed;

                        butA1.Text = "";
                        butA2.Text = "";
                        butA3.Text = "";
                        butB1.Text = "";
                        butB2.Text = "";
                        butB3.Text = "";
                        butC1.Text = "";
                        butC2.Text = "";
                        butC3.Text = "";

                        int_TurnCount = 0;
                        Bool_Turn = true;
                    }
                    else if (PlayAgain == DialogResult.No)
                    {
                        Close();

                    }

                    DialogResult ChangeName = MessageBox.Show("Would you like to change your name?", "Change Name?", MessageBoxButtons.YesNo);

                    if(ChangeName == DialogResult.Yes)
                    {
                        txtPlayerOne.Text = "";
                        txtPlayerTwo.Text = "";
                    }
                    else if(ChangeName == DialogResult.No)
                    {
                        
                    }
                }

                else
                {
                    str_winner = "O";
                    MessageBox.Show(txtPlayerOne.Text + " Wins","Congratulations");
                    DialogResult PlayAgain = MessageBox.Show("Would you like to play again?", "Play again", MessageBoxButtons.YesNo);
                    if (PlayAgain == DialogResult.Yes)
                    {
                        butPlay.Text = ("Play"); //changes buttons text to Play

                        butA1.Enabled = false; // deactivates buttons
                        butA2.Enabled = false;
                        butA3.Enabled = false;
                        butB1.Enabled = false;
                        butB2.Enabled = false;
                        butB3.Enabled = false;
                        butC1.Enabled = false;
                        butC2.Enabled = false;
                        butC3.Enabled = false;

                        butA1.BackColor = Color.DarkRed; //changes background colour of the button
                        butA2.BackColor = Color.DarkRed;
                        butA3.BackColor = Color.DarkRed;
                        butB1.BackColor = Color.DarkRed;
                        butB2.BackColor = Color.DarkRed;
                        butB3.BackColor = Color.DarkRed;
                        butC1.BackColor = Color.DarkRed;
                        butC2.BackColor = Color.DarkRed;
                        butC3.BackColor = Color.DarkRed;

                        butA1.Text = "";
                        butA2.Text = "";
                        butA3.Text = "";
                        butB1.Text = "";
                        butB2.Text = "";
                        butB3.Text = "";
                        butC1.Text = "";
                        butC2.Text = "";
                        butC3.Text = "";

                        int_TurnCount = 0;
                        Bool_Turn = true;
                    }
                    else if (PlayAgain == DialogResult.No)
                    {
                        Close();

                    }
                    DialogResult ChangeName = MessageBox.Show("Would you like to change your name?", "Change Name?", MessageBoxButtons.YesNo);

                    if (ChangeName == DialogResult.Yes)
                    {
                        txtPlayerOne.Text = "";
                        txtPlayerTwo.Text = "";
                    }
                    else if (ChangeName == DialogResult.No)
                    {

                    }
                }
            
             butA1.Enabled = false; // Disabling buttons after winner
             butA2.Enabled = false;
             butA3.Enabled = false;
             butB1.Enabled = false;
             butB2.Enabled = false;
             butB3.Enabled = false;
             butC1.Enabled = false;
             butC2.Enabled = false;
             butC3.Enabled = false;


                
            
            }           
            else
            {
                if (int_TurnCount == 9)
                {
                    MessageBox.Show("This game is a draw", "Bummer!");
                    int_TurnCount = 0;
                    Bool_Turn = true;

                }
                else
                {
                    // something here
                }
            }


        }

    }
}
