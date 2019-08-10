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
            pictureBoxProfilePicture1.BackgroundImage = EngineManager.LoggedInUser.ImageNormal;
            pictureBoxProfilePicture2.BackgroundImage = EngineManager.LoggedInUser.ImageNormal;

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFilter_Click(object sender, EventArgs e)
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
            if(genderFilterChosen)
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

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonMale.Checked)
            {
                radioButtonFemale.Checked = false;
            }
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonFemale.Checked)
            {
                radioButtonMale.Checked = false;
            }
        }

        private void checkBoxFilterHomeTown_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFilterHomeTown.Checked)
            {
                textBoxHomeTown.Enabled = true;
            }
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonRollAFriend_Click(object sender, EventArgs e)
        {
            User friendToGuess = EngineManager.PickRandomFriend();
            pictureBoxFriend.Image = friendToGuess.ImageLarge;
            buttonRollAFriend.Enabled = false;
            labelInstruction.Text = string.Empty;
        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            labelHint.Text = EngineManager.GetHint();
            buttonHint.Enabled = false;
        }

        private void buttonCheckGuess_Click(object sender, EventArgs e)
        {
            int currentUserScore;
            bool isUserGuessedRight = EngineManager.IsUserGuessCorrect(textBoxUserGuess.Text);
            EngineManager.UpdateUserDueToHisGuess(isUserGuessedRight);

            labelInstruction.Text = isUserGuessedRight ? "Correct!" : "Wrong!";
            currentUserScore = EngineManager.GetUserGuessingGameScore();
            updateHealthBar(currentUserScore);
        }

        private void updateHealthBar(int currentUserScore)
        {
            int health = EngineManager.GetHealthGuessingGame();
            pictureBoxHealthBar.Image = getHealthBar(health);
        }
        private Bitmap getHealthBar(int i_CurrentHealth)
        {
            Bitmap healthBarToSet = null;

            switch (i_CurrentHealth)
            {
                case 100:
                    healthBarToSet = Resources.life100;
                    break;
                case 80:
                    healthBarToSet = Resources.life80;
                    break;
                case 60:
                    healthBarToSet = Resources.life60;
                    break;
                case 40:
                    healthBarToSet = Resources.life40;
                    break;
                case 20:
                    healthBarToSet = Resources.life20;
                    break;
            }

            return healthBarToSet;
        }

        private void buttonGiveUp_Click(object sender, EventArgs e)
        {

        }
    }
}
