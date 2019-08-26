using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01_Facebook.Logic;
using Ex01_Facebook.UI.Properties;
using FacebookWrapper.ObjectModel;

namespace Ex01_Facebook.UI
{
    public partial class FormFacebookApp : Form
    {
        public Engine EngineManager { get; set; }

        private AppSettings ApplicationSettings { get; set; }

        public FormFacebookApp(Engine i_Engine, AppSettings i_AppSettings)
        {
            InitializeComponent();
            EngineManager = i_Engine;
            ApplicationSettings = i_AppSettings;
        }

        private void FormFacebookApp_Load(object sender, EventArgs e)
        {
            updateProfilePictureBox();
            updateUserNameLables();
            initGuessingGame();
        }

        private void updateUserNameLables()
        {
            string userNameMessage = string.Format("Hello {0}!", EngineManager.GetUserName());

            labelUserName1.Text = userNameMessage;
            labelUserName2.Text = userNameMessage;
            labelUserName3.Text = userNameMessage;
        }

        private void updateProfilePictureBox()
        {
            Image profilePic = EngineManager.GetUserImageNormalSize();

            pictureBoxProfilePicture1.BackgroundImage = profilePic;
            pictureBoxProfilePicture2.BackgroundImage = profilePic;
            pictureBoxProfilePicture3.BackgroundImage = profilePic;
        }
        #region BASIC FACEBOOK FEATURES

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (ApplicationSettings.RememberUser)
            {
                this.Location = ApplicationSettings.LastWindowLocation;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ApplicationSettings.LastWindowLocation = Location;
            ApplicationSettings.RememberUser = checkBoxRememberMe.Checked;

            if (ApplicationSettings.RememberUser)
            {
                ApplicationSettings.LastAccessToken = EngineManager.GetUserAccessToken();
            }
            else
            {
                ApplicationSettings.LastAccessToken = null;
            }

            ApplicationSettings.SaveToFile();
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            foreach (Post post in EngineManager.GetUserPosts())
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (EngineManager.GetUserPosts().Count == 0)
            {
                MessageBox.Show("Sorry, No Posts to retrieve!");
            }
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelFriendPicture.Visible = true;
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            foreach (User friend in EngineManager.GetUserFriends())
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (EngineManager.GetUserFriends().Count == 0)
            {
                MessageBox.Show("No friends to retrieve");
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxSelectedFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxProfilePicture3.Image = pictureBoxProfilePicture3.ErrorImage;
                }
            }
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelEventDetails.Visible = true;
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in EngineManager.GetUserEvents())
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (EngineManager.GetUserEvents().Count == 0)
            {
                MessageBox.Show("No events to retrieve");
            }
        }

        private void linkCheckins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchCheckins();
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in EngineManager.GetUserCheckIns())
            {
                listBoxCheckins.Items.Add(checkin.Place.Name);
            }

            if (EngineManager.GetUserCheckIns().Count == 0)
            {
                MessageBox.Show("No checkins to retrieve");
            }
        }

        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelPageDetails.Visible = true;
            fetchPages();
        }

        private void fetchPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";
            foreach (Page page in EngineManager.GetUserLikedPages())
            {
                listBoxPages.Items.Add(page);
            }

            if (EngineManager.GetUserLikedPages().Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve");
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                pictureBoxEvent.LoadAsync(selectedEvent.PictureNormalURL);
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                pictureBoxPage.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = EngineManager.GetUserPosts()[listBoxPosts.SelectedIndex];
            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = selected.Comments;
        }
        #endregion

        #region DATING FACEBOOK FEATURE
        
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            filterFriends();
        }

        private void filterFriends()
        {
            string cityFilter;
            User.eGender gender;
            bool genderFilterChosen = true;
            LinkedList<UserProxy> filteredFriendsList;

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
                userProxyBindingSource.DataSource = filteredFriendsList;
            }
        }

        private void checkBoxFilterHomeTown_Click(object sender, EventArgs e)
        {
            if (checkBoxFilterHomeTown.Checked)
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
            if (checkBoxFilterHomeTown.Checked)
            {
                textBoxHomeTown.Enabled = true;
            }
        }
        #endregion

        #region GUESS MY NAME FACEBOOK FEATURE
        private void initGuessingGame()
        {
            buttonRollAFriend.Enabled = true;
            buttonGiveUp.Enabled = false;
            buttonCheckGuess.Enabled = false;
            buttonHint.Enabled = false;
            textBoxUserGuess.Enabled = false;
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

        private void updateUserState(bool i_IsUserGuessedRight, bool i_IsStrikeThree, string i_FriendName)
        {
            updateLabelUserInteractionAboutCurrentRound(i_IsUserGuessedRight, i_IsStrikeThree, i_FriendName);
            updateUserGamingData();
        }

        private void updateUserGamingData()
        {
            updateScore();
            updateHealthBar();
        }

        private void prepareNextRound()
        {
            bool isGameOver;

            isGameOver = EngineManager.IsGuessingGameOver();
            if (isGameOver)
            {
                string losingMessage = string.Format("You Lost{0}Game Score : {1}{0}Click Roll a friend! to start a new game", Environment.NewLine, EngineManager.GetUserGuessingGameScore());
                MessageBox.Show(losingMessage, "Facebook guess my name");
                EngineManager.RestartGuessingGame();
                restartGuessingGame();
            }
            else
            {
                updateInstructionForNewRound();
                clearGuessingField();
                initGuessingGame();
            }
        }

        private void restartGuessingGame()
        {
            pictureBoxFriend.BackgroundImage = null;
            textBoxUserGuess.Text = string.Empty;
            labelUserInteraction.Text = string.Empty;
            updateUserGamingData();
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
                labelUserInteraction.Text = string.Format("WRONG! The correct answer is: {0}", friendName);
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
            updateHealthBar();
            exposeFriendName();
            prepareNextRound();
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
        #endregion
    }
}