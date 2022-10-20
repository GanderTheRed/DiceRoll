namespace DiceStartingPoint
{
    using System.Media;
    public partial class Form1 : Form
    {

        Random rnd = new Random();                      //New random instance used for the dice roll
        int intDie1, intDie2, intDie3;                  //Assigning variables to each die.
        int intDiceCorrectScore, intDiceIncorrectScore; //Assigning variables to keep track of the scores.
        Bitmap Dice1 = new Bitmap("../../../resources/1.png"); //Creating a bitmap for each dice image
        Bitmap Dice2 = new Bitmap("../../../resources/2.png");
        Bitmap Dice3 = new Bitmap("../../../resources/3.png");
        Bitmap Dice4 = new Bitmap("../../../resources/4.png");
        Bitmap Dice5 = new Bitmap("../../../resources/5.png");
        Bitmap Dice6 = new Bitmap("../../../resources/6.png");
        SoundPlayer DiceRoll = new SoundPlayer("../../../resources/diceroll.wav");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDice2_Click(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            try
            {
                int RandomNumber1 = rnd.Next(0, 6);     //Random number generators for each dice
                int RandomNumber2 = rnd.Next(0, 6);
                int RandomNumber3 = rnd.Next(0, 6);

                switch (RandomNumber1)                  //Switches for each dice to change properties depending on the random number
                {
                    case 0:
                        picDice1.Image = Dice1;         //Sets the 1st dice's image to Dice1 bitmap
                        intDie1 = 1;                    //Sets intDie1 to 1.
                        break;

                    case 1:
                        picDice1.Image = Dice2;
                        intDie1 = 2;
                        break;

                    case 2:
                        picDice1.Image = Dice3;
                        intDie1 = 3;
                        break;

                    case 3:
                        picDice1.Image = Dice4;
                        intDie1 = 4;
                        break;

                    case 4:
                        picDice1.Image = Dice5;
                        intDie1 = 5;
                        break;

                    case 5:
                        picDice1.Image = Dice6;
                        intDie1 = 6;
                        break;
                }
                switch (RandomNumber2)
                {
                    case 0:
                        picDice2.Image = Dice1;                     //Sets Dice 2 image to Dice1 image.
                        intDie2 = 1;                                //Sets intDie2 to a value of 1.
                        break;

                    case 1:
                        picDice2.Image = Dice2;
                        intDie2 = 2;
                        break;

                    case 2:
                        picDice2.Image = Dice3;
                        intDie2 = 3;
                        break;

                    case 3:
                        picDice2.Image = Dice4;
                        intDie2 = 4;
                        break;

                    case 4:
                        picDice2.Image = Dice5;
                        intDie2 = 5;
                        break;

                    case 5:
                        picDice2.Image = Dice6;
                        intDie2 = 6;
                        break;
                }
                switch (RandomNumber3)
                {
                    case 0:
                        picDice3.Image = Dice1;
                        intDie3 = 1;
                        break;

                    case 1:
                        picDice3.Image = Dice2;
                        intDie3 = 2;
                        break;

                    case 2:
                        picDice3.Image = Dice3;
                        intDie3 = 3;
                        break;

                    case 3:
                        picDice3.Image = Dice4;
                        intDie3 = 4;
                        break;

                    case 4:
                        picDice3.Image = Dice5;
                        intDie3 = 5;
                        break;

                    case 5:
                        picDice3.Image = Dice6;
                        intDie3 = 6;
                        break;
                }
                lblDice1.Text = intDie1.ToString();         //Coverts die value to a string and diplays above the dice roll
                lblDice2.Text = intDie2.ToString();
                lblDice3.Text = intDie3.ToString();

                int Guess = Int32.Parse(cmbGuess.Text);     //Converts the combo box value to an integer variable for simple use in the following if statement

                if (Guess == intDie1 + intDie2 + intDie3)       //Adds to the correct score if the sum off al dies is the same as the guess
                {
                    intDiceCorrectScore = intDiceCorrectScore + 1;                  
                }
                else
                {
                    intDiceIncorrectScore = intDiceIncorrectScore + 1;
                }

                lblScore.Text = intDiceCorrectScore.ToString() + " / " + intDiceIncorrectScore.ToString(); //Shows concatenated scores on lblscore.

                DiceRoll.Play();            //Plays a diceroll each time the button is clicked.
            }
            catch
            {
                MessageBox.Show("Exception Occured! Use the combo box, and calculate button. Make sure there is a value in the combo box."); //Exception handling if someone breaks this somehow.
            }

        }
    }
}