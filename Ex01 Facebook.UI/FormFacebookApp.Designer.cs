namespace Ex01_Facebook.UI
{
    partial class FormFacebookApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelAbout;
            System.Windows.Forms.Label labelBirthday;
            System.Windows.Forms.Label labelEmail;
            System.Windows.Forms.Label labelLink;
            System.Windows.Forms.Label labelFriendName;
            System.Windows.Forms.Label labelRelationshipStatus;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFinderDating = new System.Windows.Forms.TabPage();
            this.panelMatch = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.textBoxHomeTown = new System.Windows.Forms.TextBox();
            this.listBoxFilteredFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxFilterHomeTown = new System.Windows.Forms.CheckBox();
            this.pictureBoxProfilePicture1 = new System.Windows.Forms.PictureBox();
            this.panelMatchDetails = new System.Windows.Forms.Panel();
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.PictureBoxFriendPicture = new System.Windows.Forms.PictureBox();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.labelRelationshipStatus1 = new System.Windows.Forms.Label();
            this.tabPageGuessFriendName = new System.Windows.Forms.TabPage();
            this.labelRules = new System.Windows.Forms.Label();
            this.pictureBoxHealthBar = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelUserInteraction = new System.Windows.Forms.Label();
            this.buttonGiveUp = new System.Windows.Forms.Button();
            this.buttonHint = new System.Windows.Forms.Button();
            this.buttonCheckGuess = new System.Windows.Forms.Button();
            this.textBoxUserGuess = new System.Windows.Forms.TextBox();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.labelDescription1 = new System.Windows.Forms.Label();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.buttonRollAFriend = new System.Windows.Forms.Button();
            this.pictureBoxProfilePicture2 = new System.Windows.Forms.PictureBox();
            labelAbout = new System.Windows.Forms.Label();
            labelBirthday = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelLink = new System.Windows.Forms.Label();
            labelFriendName = new System.Windows.Forms.Label();
            labelRelationshipStatus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageFinderDating.SuspendLayout();
            this.panelMatch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture1)).BeginInit();
            this.panelMatchDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriendPicture)).BeginInit();
            this.tabPageGuessFriendName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Location = new System.Drawing.Point(137, 344);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new System.Drawing.Size(49, 17);
            labelAbout.TabIndex = 0;
            labelAbout.Text = "About:";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new System.Drawing.Point(137, 304);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new System.Drawing.Size(64, 17);
            labelBirthday.TabIndex = 2;
            labelBirthday.Text = "Birthday:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new System.Drawing.Point(137, 262);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(46, 17);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // labelLink
            // 
            labelLink.AutoSize = true;
            labelLink.Location = new System.Drawing.Point(137, 225);
            labelLink.Name = "labelLink";
            labelLink.Size = new System.Drawing.Size(38, 17);
            labelLink.TabIndex = 8;
            labelLink.Text = "Link:";
            // 
            // labelFriendName
            // 
            labelFriendName.AutoSize = true;
            labelFriendName.Location = new System.Drawing.Point(137, 155);
            labelFriendName.Name = "labelFriendName";
            labelFriendName.Size = new System.Drawing.Size(49, 17);
            labelFriendName.TabIndex = 10;
            labelFriendName.Text = "Name:";
            // 
            // labelRelationshipStatus
            // 
            labelRelationshipStatus.AutoSize = true;
            labelRelationshipStatus.Location = new System.Drawing.Point(137, 189);
            labelRelationshipStatus.Name = "labelRelationshipStatus";
            labelRelationshipStatus.Size = new System.Drawing.Size(134, 17);
            labelRelationshipStatus.TabIndex = 12;
            labelRelationshipStatus.Text = "Relationship Status:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFinderDating);
            this.tabControl1.Controls.Add(this.tabPageGuessFriendName);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFinderDating
            // 
            this.tabPageFinderDating.AutoScroll = true;
            this.tabPageFinderDating.BackgroundImage = global::Ex01_Facebook.UI.Properties.Resources.finder_dating;
            this.tabPageFinderDating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageFinderDating.Controls.Add(this.panelMatch);
            this.tabPageFinderDating.Controls.Add(this.pictureBoxProfilePicture1);
            this.tabPageFinderDating.Controls.Add(this.panelMatchDetails);
            this.tabPageFinderDating.Location = new System.Drawing.Point(4, 25);
            this.tabPageFinderDating.Name = "tabPageFinderDating";
            this.tabPageFinderDating.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinderDating.Size = new System.Drawing.Size(999, 554);
            this.tabPageFinderDating.TabIndex = 0;
            this.tabPageFinderDating.Text = "Finder Dating";
            this.tabPageFinderDating.UseVisualStyleBackColor = true;
            // 
            // panelMatch
            // 
            this.panelMatch.Controls.Add(this.groupBox1);
            this.panelMatch.Controls.Add(this.buttonFilter);
            this.panelMatch.Controls.Add(this.textBoxHomeTown);
            this.panelMatch.Controls.Add(this.listBoxFilteredFriends);
            this.panelMatch.Controls.Add(this.checkBoxFilterHomeTown);
            this.panelMatch.Location = new System.Drawing.Point(3, 97);
            this.panelMatch.Name = "panelMatch";
            this.panelMatch.Size = new System.Drawing.Size(300, 428);
            this.panelMatch.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Location = new System.Drawing.Point(7, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interested in";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(33, 57);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(33, 21);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(150, 92);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(121, 53);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "Find My Matches!";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxHomeTown
            // 
            this.textBoxHomeTown.Enabled = false;
            this.textBoxHomeTown.Location = new System.Drawing.Point(150, 53);
            this.textBoxHomeTown.Name = "textBoxHomeTown";
            this.textBoxHomeTown.Size = new System.Drawing.Size(136, 22);
            this.textBoxHomeTown.TabIndex = 5;
            // 
            // listBoxFilteredFriends
            // 
            this.listBoxFilteredFriends.BackColor = System.Drawing.Color.LightGray;
            this.listBoxFilteredFriends.DataSource = this.userBindingSource;
            this.listBoxFilteredFriends.DisplayMember = "Name";
            this.listBoxFilteredFriends.FormattingEnabled = true;
            this.listBoxFilteredFriends.ItemHeight = 16;
            this.listBoxFilteredFriends.Location = new System.Drawing.Point(3, 165);
            this.listBoxFilteredFriends.Name = "listBoxFilteredFriends";
            this.listBoxFilteredFriends.Size = new System.Drawing.Size(268, 260);
            this.listBoxFilteredFriends.TabIndex = 1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // checkBoxFilterHomeTown
            // 
            this.checkBoxFilterHomeTown.AutoSize = true;
            this.checkBoxFilterHomeTown.Location = new System.Drawing.Point(150, 15);
            this.checkBoxFilterHomeTown.Name = "checkBoxFilterHomeTown";
            this.checkBoxFilterHomeTown.Size = new System.Drawing.Size(136, 21);
            this.checkBoxFilterHomeTown.TabIndex = 4;
            this.checkBoxFilterHomeTown.Text = "Filter HomeTown";
            this.checkBoxFilterHomeTown.UseVisualStyleBackColor = true;
            this.checkBoxFilterHomeTown.CheckedChanged += new System.EventHandler(this.checkBoxFilterHomeTown_CheckedChanged);
            this.checkBoxFilterHomeTown.Click += new System.EventHandler(this.checkBoxFilterHomeTown_Click);
            // 
            // pictureBoxProfilePicture1
            // 
            this.pictureBoxProfilePicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfilePicture1.Location = new System.Drawing.Point(3, 6);
            this.pictureBoxProfilePicture1.Name = "pictureBoxProfilePicture1";
            this.pictureBoxProfilePicture1.Size = new System.Drawing.Size(87, 85);
            this.pictureBoxProfilePicture1.TabIndex = 2;
            this.pictureBoxProfilePicture1.TabStop = false;
            // 
            // panelMatchDetails
            // 
            this.panelMatchDetails.Controls.Add(labelAbout);
            this.panelMatchDetails.Controls.Add(this.aboutLabel1);
            this.panelMatchDetails.Controls.Add(labelBirthday);
            this.panelMatchDetails.Controls.Add(this.birthdayLabel1);
            this.panelMatchDetails.Controls.Add(labelEmail);
            this.panelMatchDetails.Controls.Add(this.emailLabel1);
            this.panelMatchDetails.Controls.Add(this.PictureBoxFriendPicture);
            this.panelMatchDetails.Controls.Add(labelLink);
            this.panelMatchDetails.Controls.Add(this.linkLinkLabel);
            this.panelMatchDetails.Controls.Add(labelFriendName);
            this.panelMatchDetails.Controls.Add(this.nameLabel1);
            this.panelMatchDetails.Controls.Add(labelRelationshipStatus);
            this.panelMatchDetails.Controls.Add(this.labelRelationshipStatus1);
            this.panelMatchDetails.Location = new System.Drawing.Point(566, 0);
            this.panelMatchDetails.Name = "panelMatchDetails";
            this.panelMatchDetails.Size = new System.Drawing.Size(425, 503);
            this.panelMatchDetails.TabIndex = 0;
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true));
            this.aboutLabel1.Location = new System.Drawing.Point(277, 344);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(100, 23);
            this.aboutLabel1.TabIndex = 1;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(277, 304);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel1.TabIndex = 3;
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(277, 262);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(100, 23);
            this.emailLabel1.TabIndex = 5;
            // 
            // PictureBoxFriendPicture
            // 
            this.PictureBoxFriendPicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.PictureBoxFriendPicture.Location = new System.Drawing.Point(140, 38);
            this.PictureBoxFriendPicture.Name = "PictureBoxFriendPicture";
            this.PictureBoxFriendPicture.Size = new System.Drawing.Size(142, 108);
            this.PictureBoxFriendPicture.TabIndex = 7;
            this.PictureBoxFriendPicture.TabStop = false;
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(277, 225);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.linkLinkLabel.TabIndex = 9;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(203, 153);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(191, 23);
            this.nameLabel1.TabIndex = 11;
            // 
            // labelRelationshipStatus1
            // 
            this.labelRelationshipStatus1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "RelationshipStatus", true));
            this.labelRelationshipStatus1.Location = new System.Drawing.Point(277, 189);
            this.labelRelationshipStatus1.Name = "labelRelationshipStatus1";
            this.labelRelationshipStatus1.Size = new System.Drawing.Size(100, 23);
            this.labelRelationshipStatus1.TabIndex = 13;
            // 
            // tabPageGuessFriendName
            // 
            this.tabPageGuessFriendName.BackgroundImage = global::Ex01_Facebook.UI.Properties.Resources.blog_facebook1;
            this.tabPageGuessFriendName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageGuessFriendName.Controls.Add(this.labelRules);
            this.tabPageGuessFriendName.Controls.Add(this.pictureBoxHealthBar);
            this.tabPageGuessFriendName.Controls.Add(this.labelScore);
            this.tabPageGuessFriendName.Controls.Add(this.labelUserInteraction);
            this.tabPageGuessFriendName.Controls.Add(this.buttonGiveUp);
            this.tabPageGuessFriendName.Controls.Add(this.buttonHint);
            this.tabPageGuessFriendName.Controls.Add(this.buttonCheckGuess);
            this.tabPageGuessFriendName.Controls.Add(this.textBoxUserGuess);
            this.tabPageGuessFriendName.Controls.Add(this.labelInstruction);
            this.tabPageGuessFriendName.Controls.Add(this.labelDescription1);
            this.tabPageGuessFriendName.Controls.Add(this.pictureBoxFriend);
            this.tabPageGuessFriendName.Controls.Add(this.buttonRollAFriend);
            this.tabPageGuessFriendName.Controls.Add(this.pictureBoxProfilePicture2);
            this.tabPageGuessFriendName.Location = new System.Drawing.Point(4, 25);
            this.tabPageGuessFriendName.Name = "tabPageGuessFriendName";
            this.tabPageGuessFriendName.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGuessFriendName.Size = new System.Drawing.Size(999, 554);
            this.tabPageGuessFriendName.TabIndex = 1;
            this.tabPageGuessFriendName.Text = "How really do you know your friends on facebook?";
            this.tabPageGuessFriendName.UseVisualStyleBackColor = true;
            // 
            // labelRules
            // 
            this.labelRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRules.ForeColor = System.Drawing.Color.White;
            this.labelRules.Location = new System.Drawing.Point(8, 335);
            this.labelRules.Name = "labelRules";
            this.labelRules.Size = new System.Drawing.Size(307, 115);
            this.labelRules.TabIndex = 12;
            this.labelRules.Text = "Rules:\r\nCorrect guess => +10 to score\r\nWrong guess => -6 to health bar\r\nThree cor" +
    "rect guesses in a row => +3 to health bar\r\nGiveup => -3 to health bar";
            // 
            // pictureBoxHealthBar
            // 
            this.pictureBoxHealthBar.BackgroundImage = global::Ex01_Facebook.UI.Properties.Resources.life6;
            this.pictureBoxHealthBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHealthBar.Location = new System.Drawing.Point(618, 0);
            this.pictureBoxHealthBar.Name = "pictureBoxHealthBar";
            this.pictureBoxHealthBar.Size = new System.Drawing.Size(348, 100);
            this.pictureBoxHealthBar.TabIndex = 11;
            this.pictureBoxHealthBar.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(757, 122);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(92, 20);
            this.labelScore.TabIndex = 10;
            this.labelScore.Text = "SCORE : 0";
            // 
            // labelUserInteraction
            // 
            this.labelUserInteraction.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInteraction.ForeColor = System.Drawing.Color.White;
            this.labelUserInteraction.Location = new System.Drawing.Point(246, 315);
            this.labelUserInteraction.Name = "labelUserInteraction";
            this.labelUserInteraction.Size = new System.Drawing.Size(464, 38);
            this.labelUserInteraction.TabIndex = 9;
            this.labelUserInteraction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGiveUp
            // 
            this.buttonGiveUp.Location = new System.Drawing.Point(334, 400);
            this.buttonGiveUp.Name = "buttonGiveUp";
            this.buttonGiveUp.Size = new System.Drawing.Size(94, 50);
            this.buttonGiveUp.TabIndex = 8;
            this.buttonGiveUp.Text = "Give up";
            this.buttonGiveUp.UseVisualStyleBackColor = true;
            this.buttonGiveUp.Click += new System.EventHandler(this.buttonGiveUp_Click);
            // 
            // buttonHint
            // 
            this.buttonHint.Location = new System.Drawing.Point(445, 400);
            this.buttonHint.Name = "buttonHint";
            this.buttonHint.Size = new System.Drawing.Size(94, 50);
            this.buttonHint.TabIndex = 7;
            this.buttonHint.Text = "HINT";
            this.buttonHint.UseVisualStyleBackColor = true;
            this.buttonHint.Click += new System.EventHandler(this.buttonHint_Click);
            // 
            // buttonCheckGuess
            // 
            this.buttonCheckGuess.Location = new System.Drawing.Point(554, 400);
            this.buttonCheckGuess.Name = "buttonCheckGuess";
            this.buttonCheckGuess.Size = new System.Drawing.Size(94, 50);
            this.buttonCheckGuess.TabIndex = 6;
            this.buttonCheckGuess.Text = "Check your guess";
            this.buttonCheckGuess.UseVisualStyleBackColor = true;
            this.buttonCheckGuess.Click += new System.EventHandler(this.buttonCheckGuess_Click);
            // 
            // textBoxUserGuess
            // 
            this.textBoxUserGuess.Location = new System.Drawing.Point(364, 359);
            this.textBoxUserGuess.Name = "textBoxUserGuess";
            this.textBoxUserGuess.Size = new System.Drawing.Size(253, 22);
            this.textBoxUserGuess.TabIndex = 5;
            this.textBoxUserGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUserGuess_KeyPress);
            // 
            // labelInstruction
            // 
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstruction.ForeColor = System.Drawing.Color.White;
            this.labelInstruction.Location = new System.Drawing.Point(6, 242);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(357, 85);
            this.labelInstruction.TabIndex = 4;
            this.labelInstruction.Text = "Click Roll a friend! button to get random friend photo and try to guess his name!" +
    "";
            // 
            // labelDescription1
            // 
            this.labelDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription1.ForeColor = System.Drawing.Color.White;
            this.labelDescription1.Location = new System.Drawing.Point(6, 153);
            this.labelDescription1.Name = "labelDescription1";
            this.labelDescription1.Size = new System.Drawing.Size(370, 89);
            this.labelDescription1.TabIndex = 3;
            this.labelDescription1.Text = "Let\'s see how really you know your friends on Facebook...";
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFriend.Location = new System.Drawing.Point(382, 21);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(218, 184);
            this.pictureBoxFriend.TabIndex = 2;
            this.pictureBoxFriend.TabStop = false;
            // 
            // buttonRollAFriend
            // 
            this.buttonRollAFriend.Location = new System.Drawing.Point(382, 240);
            this.buttonRollAFriend.Name = "buttonRollAFriend";
            this.buttonRollAFriend.Size = new System.Drawing.Size(218, 58);
            this.buttonRollAFriend.TabIndex = 1;
            this.buttonRollAFriend.Text = "Roll a friend!";
            this.buttonRollAFriend.UseVisualStyleBackColor = true;
            this.buttonRollAFriend.Click += new System.EventHandler(this.buttonRollAFriend_Click);
            // 
            // pictureBoxProfilePicture2
            // 
            this.pictureBoxProfilePicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfilePicture2.Location = new System.Drawing.Point(3, 6);
            this.pictureBoxProfilePicture2.Name = "pictureBoxProfilePicture2";
            this.pictureBoxProfilePicture2.Size = new System.Drawing.Size(87, 85);
            this.pictureBoxProfilePicture2.TabIndex = 0;
            this.pictureBoxProfilePicture2.TabStop = false;
            // 
            // FormFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 607);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormFacebookApp";
            this.Text = "Facebook features";
            this.Load += new System.EventHandler(this.FormFacebookApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFinderDating.ResumeLayout(false);
            this.panelMatch.ResumeLayout(false);
            this.panelMatch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture1)).EndInit();
            this.panelMatchDetails.ResumeLayout(false);
            this.panelMatchDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriendPicture)).EndInit();
            this.tabPageGuessFriendName.ResumeLayout(false);
            this.tabPageGuessFriendName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFinderDating;
        private System.Windows.Forms.TabPage tabPageGuessFriendName;
        private System.Windows.Forms.Panel panelMatchDetails;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture1;
        private System.Windows.Forms.ListBox listBoxFilteredFriends;
        private System.Windows.Forms.BindingNavigator userBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panelMatch;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TextBox textBoxHomeTown;
        private System.Windows.Forms.CheckBox checkBoxFilterHomeTown;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture2;
        private System.Windows.Forms.Button buttonRollAFriend;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label aboutLabel1;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.PictureBox PictureBoxFriendPicture;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label labelRelationshipStatus1;
        private System.Windows.Forms.Button buttonCheckGuess;
        private System.Windows.Forms.TextBox textBoxUserGuess;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Label labelDescription1;
        private System.Windows.Forms.Button buttonGiveUp;
        private System.Windows.Forms.Button buttonHint;
        private System.Windows.Forms.Label labelUserInteraction;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxHealthBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRules;
    }
}