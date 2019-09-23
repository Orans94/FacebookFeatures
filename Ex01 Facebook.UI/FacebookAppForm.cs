using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Ex01_Facebook.Logic;
using Ex01_Facebook.UI.Properties;
using FacebookWrapper.ObjectModel;

namespace Ex01_Facebook.UI
{
    public partial class FacebookAppForm : Form
    {
        private static FacebookAppForm s_Instance = null;
        private static object s_Locker = new object();

        public static FacebookAppForm Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_Locker)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookAppForm();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public Engine EngineManager { get; set; }

        private AppSettings ApplicationSettings { get; set; }

        private FacebookAppForm()
        {
            InitializeComponent();
        }

        public void ConfigureAppAfterLogin(Engine i_Engine, AppSettings i_AppSettings)
        {
            EngineManager = i_Engine;
            ApplicationSettings = i_AppSettings;
            EngineManager.GuessMyNameScoreChanged += new ScoreChangeHandler(updateScore);
            EngineManager.GuessMyNameHealthChanged += new HealthChangeHandler(updateHealthBar);
        }

        private void FormFacebookApp_Load(object sender, EventArgs e)
        {
            EngineManager.initGuessingGame();
            new Thread(updateProfilePictureBox).Start();
            new Thread(updateUserNameLables).Start();
            initGuessingGame();
        }

        private void updateUserNameLables()
        {
            string userNameMessage = string.Format("Hello {0}!", EngineManager.GetUserName());

            labelUserName1.Invoke(new Action(() => labelUserName1.Text = userNameMessage));
            labelUserName2.Invoke(new Action(() => labelUserName2.Text = userNameMessage));
            labelUserName3.Invoke(new Action(() => labelUserName3.Text = userNameMessage));
        }

        private void updateProfilePictureBox()
        {
            Image profilePic = EngineManager.GetUserImageNormalSize();

            pictureBoxProfilePicture1.Invoke(new Action(() => pictureBoxProfilePicture1.BackgroundImage = profilePic));
            pictureBoxProfilePicture2.Invoke(new Action(() => pictureBoxProfilePicture2.BackgroundImage = profilePic));
            pictureBoxProfilePicture3.Invoke(new Action(() => pictureBoxProfilePicture3.BackgroundImage = profilePic));
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
            new Thread(fetchPosts).Start();
        }

        private void fetchPosts()
        {
            foreach (Post post in EngineManager.GetUserPosts())
            {
                if (post.Message != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
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
            new Thread(fetchFriends).Start();
        }

        private void fetchFriends()
        {
            listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));
            listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));
            foreach (User friend in EngineManager.GetUserFriends())
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
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
                    pictureBoxFriends.LoadAsync(selectedFriend.PictureNormalURL);
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
            new Thread(fetchEvents).Start();
        }

        private void fetchEvents()
        {
            listBoxFriends.Invoke(new Action(() => listBoxEvents.Items.Clear()));
            listBoxFriends.Invoke(new Action(() => listBoxEvents.DisplayMember = "Name"));
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
            new Thread(fetchCheckins).Start();
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in EngineManager.GetUserCheckIns())
            {
                listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add(checkin.Place.Name)));
            }

            if (EngineManager.GetUserCheckIns().Count == 0)
            {
                MessageBox.Show("No checkins to retrieve");
            }
        }

        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelPageDetails.Visible = true;
            new Thread(fetchPages).Start();
        }

        private void fetchPages()
        {
            listBoxCheckins.Invoke(new Action(() => listBoxPages.Items.Clear()));
            listBoxCheckins.Invoke(new Action(() => listBoxPages.DisplayMember = "Name"));
            foreach (Page page in EngineManager.GetUserLikedPages())
            {
                listBoxPages.Items.Add(page);
            }

            if (EngineManager.GetUserLikedPages().Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve");
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
            FacebookUserProxyCollection filteredFriendsList;

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
                if(radioButtonAscendingSort.Checked)
                {
                    EngineManager.Comparer = new AscendingUserNameComparer();
                }
                else
                {
                    EngineManager.Comparer = new DescendingUserNameComparer();
                }

                gender = radioButtonMale.Checked ? User.eGender.male : User.eGender.female;
                filteredFriendsList = EngineManager.MatchMe(cityFilter, gender);
                if (filteredFriendsList.Count() != 0)
                {
                    userProxyBindingSource.DataSource = filteredFriendsList;
                }
                else
                {
                    MessageBox.Show("Sorry, there is no match for you");
                }
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
            updateLabelUserInteractionAboutCurrentRound(isUserGuessedRight, isStrikeThree, friendName);
            prepareNextRound();
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
            initGuessingGame();
        }

        private void updateLabelUserInteractionAboutCurrentRound(bool i_IsUserGuessedRight, bool i_IsStrikeThree, string i_FriendName)
        {
            if (i_IsUserGuessedRight)
            {
                labelUserInteraction.ForeColor = Color.Lime;
                labelUserInteraction.Text = i_IsStrikeThree ? string.Format("PERFECT! You got extra health!") : string.Format("{0} is a CORRECT ANSWER! ", i_FriendName);
            }
            else
            {
                labelUserInteraction.ForeColor = Color.Red;
                labelUserInteraction.Text = string.Format("WRONG! The correct answer is: {0}", i_FriendName);
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

        private void updateScore(int i_NewScore)
        {
            string newScoreText;

            newScoreText = string.Format("SCORE : {0}", i_NewScore);
            labelScore.Text = newScoreText;
        }

        private void updateHealthBar(int i_NewHealth)
        {
            pictureBoxHealthBar.BackgroundImage = getHealthBarImageFromResources(i_NewHealth);
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