using Ex01_Facebook.Logic;
using Ex01_Facebook.UI.Properties;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01_Facebook.UI
{
    public partial class FormFacebookApp : Form
    {
        public Engine EngineManager { get; set; }

        public FormFacebookApp(Engine i_Engine)
        {
            InitializeComponent();
            EngineManager = i_Engine;
        }

        private void FormFacebookApp_Load(object sender, EventArgs e)
        {
            updateProfilePictureBox();
            initGuessingGame();
        }

        private void updateProfilePictureBox()
        {
            pictureBoxProfilePicture1.BackgroundImage = EngineManager.LoggedInUser.ImageNormal;
            pictureBoxProfilePicture2.BackgroundImage = EngineManager.LoggedInUser.ImageNormal;
        }

        private void initGuessingGame()
        {
            buttonRollAFriend.Enabled = true;
            buttonGiveUp.Enabled = false;
            buttonCheckGuess.Enabled = false;
            buttonHint.Enabled = false;
            textBoxUserGuess.Enabled = false;
        }



        private void buttonFilter_Click(object sender, EventArgs e)
        {
            filterFriends();
        }

        private void filterFriends()
        {
            string cityFilter;
            User.eGender gender;
            bool genderFilterChosen = true;
            LinkedList<User> filteredFriendsList;

            if (checkBoxFilterHomeTown.Checked)
            {
                cityFilter = textBoxHomeTown.Text;
            }
            else
            {
                cityFilter = "all";
            }

            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Please choose a gender filter");
                genderFilterChosen = false;
            }
            if (genderFilterChosen)
            {
                gender = radioButtonMale.Checked ? User.eGender.male : User.eGender.female;
                filteredFriendsList = EngineManager.MatchMe(cityFilter, gender);
                userBindingSource.DataSource = filteredFriendsList;
            }
        }

        private void checkBoxFilterHomeTown_Click(object sender, EventArgs e)
        {
            if(checkBoxFilterHomeTown.Checked)
            {
                textBoxHomeTown.Enabled = true;
            }
            else
            {
                textBoxHomeTown.Enabled = false;
            }
        }

        private void checkBoxFilterHomeTown_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFilterHomeTown.Checked)
            {
                textBoxHomeTown.Enabled = true;
            }
        }

        private void buttonRollAFriend_Click(object sender, EventArgs e)
        {
            rollAFriend();
        }

        private void rollAFriend()
        {
            initGuessingGame();
            clearUserInteractionLabelField();
            User friendToGuess = EngineManager.PickRandomFriend();
            pictureBoxFriend.BackgroundImage = friendToGuess.ImageLarge;
            activateActiveButtonsInGuessingGame();
            labelInstruction.Text = string.Empty;
            Console.WriteLine(friendToGuess.Name); //TODO DELETE
        }

        private void activateActiveButtonsInGuessingGame()
        {
            textBoxUserGuess.Enabled = true;
            buttonRollAFriend.Enabled = false;
            buttonGiveUp.Enabled = true;
            buttonCheckGuess.Enabled = true;
            buttonHint.Enabled = true;
        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            hint();
        }

        private void hint()
        {
            labelUserInteraction.ForeColor = Color.White;
            labelUserInteraction.Text = EngineManager.GetHint();
            buttonHint.Enabled = false;
        }

        private void buttonCheckGuess_Click(object sender, EventArgs e)
        {
            checkGuess();
        }

        private void checkGuess()
        {
            bool isUserGuessedRight, isStrikeThree;
            string friendName;

            // validate user guess
            isUserGuessedRight = EngineManager.IsUserGuessCorrect(textBoxUserGuess.Text);
            isStrikeThree = EngineManager.IsUserWorthyExtraHealth(isUserGuessedRight);
            EngineManager.UpdateUserDueToHisGuess(isUserGuessedRight);
            friendName = EngineManager.GetFriendToGuess().Name;
            updateUserState(isUserGuessedRight, isStrikeThree, friendName);
            prepareNextRound();
        }

        private void updateUserState(bool isUserGuessedRight, bool isStrikeThree, string friendName)
        {
            updateLabelUserInteractionAboutCurrentRound(isUserGuessedRight, isStrikeThree, friendName);
            updateScore();
            updateHealthBar();
        }

        private void prepareNextRound()
        {
            updateInstructionForNewRound();
            clearGuessingField();
            initGuessingGame();
        }

        private void updateLabelUserInteractionAboutCurrentRound(bool isUserGuessedRight, bool isStrikeThree, string friendName)
        {
            if (isUserGuessedRight)
            {
                labelUserInteraction.ForeColor = Color.Lime;
                labelUserInteraction.Text = isStrikeThree ? string.Format("PERFECT! You got extra health!") : string.Format("{0} is a CORRECT ANSWER! ", friendName);
            }
            else
            {
                labelUserInteraction.ForeColor = Color.Red;
                labelUserInteraction.Text = string.Format("WRONG! The answer is: {0}", friendName);
            }
        }

        private void clearGuessingField()
        {
            textBoxUserGuess.Text = string.Empty;
        }

        private void clearUserInteractionLabelField()
        {
            labelUserInteraction.Text = string.Empty;
        }

        private void updateInstructionForNewRound()
        {
            labelInstruction.Text = "Click Roll a friend button for another round!";
        }

        private void updateScore()
        {
            string newScoreText;
            int score;

            score = EngineManager.GetUserGuessingGameScore();
            newScoreText = string.Format("SCORE : {0}", score);
            labelScore.Text = newScoreText;
        }

        private void updateHealthBar()
        {
            int health = EngineManager.GetHealthGuessingGame();

            pictureBoxHealthBar.BackgroundImage = getHealthBarImageFromResources(health);
        }
        private Bitmap getHealthBarImageFromResources(int i_CurrentHealth)
        {
            Bitmap healthBarToSet = null;

            switch (i_CurrentHealth)
            {
                case 6:
                    healthBarToSet = Resources.life6;
                    break;
                case 5:
                    healthBarToSet = Resources.life5;
                    break;
                case 4:
                    healthBarToSet = Resources.life4;
                    break;
                case 3:
                    healthBarToSet = Resources.life3;
                    break;
                case 2:
                    healthBarToSet = Resources.life2;
                    break;
                case 1:
                    healthBarToSet = Resources.life1;
                    break;
                case 0:
                    healthBarToSet = Resources.life0;
                    break;
            }

            return healthBarToSet;
        }

        private void buttonGiveUp_Click(object sender, EventArgs e)
        {
            giveUp();
        }

        private void giveUp()
        {
            EngineManager.GiveUpGuessingGame();
            clearGuessingField();
            initGuessingGame();
            updateHealthBar();
            updateInstructionForNewRound();
            exposeFriendName();
        }

        private void exposeFriendName()
        {
            string friendName = EngineManager.GetFriendToGuess().Name;
            labelUserInteraction.ForeColor = Color.Red;
            labelUserInteraction.Text = string.Format("The friend's name is: {0}", friendName);
        }

        private void textBoxUserGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                checkGuess();
            }
        }
    }
}
