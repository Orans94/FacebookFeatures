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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelMatch = new System.Windows.Forms.Panel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.textBoxHomeTown = new System.Windows.Forms.TextBox();
            this.listBoxFilteredFriends = new System.Windows.Forms.ListBox();
            this.checkBoxFilterHomeTown = new System.Windows.Forms.CheckBox();
            this.labelInterestedIn = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.pictureBoxProfilePicture1 = new System.Windows.Forms.PictureBox();
            this.panelMatchDetails = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.buttonRollAFriend = new System.Windows.Forms.Button();
            this.pictureBoxProfilePicture2 = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.PictureBoxFriendPicture = new System.Windows.Forms.PictureBox();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.labelRelationshipStatus1 = new System.Windows.Forms.Label();
            labelAbout = new System.Windows.Forms.Label();
            labelBirthday = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelLink = new System.Windows.Forms.Label();
            labelFriendName = new System.Windows.Forms.Label();
            labelRelationshipStatus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture1)).BeginInit();
            this.panelMatchDetails.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriendPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackgroundImage = global::Ex01_Facebook.UI.Properties.Resources.finder_dating;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.panelMatch);
            this.tabPage1.Controls.Add(this.pictureBoxProfilePicture1);
            this.tabPage1.Controls.Add(this.panelMatchDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(999, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Finder Dating";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panelMatch
            // 
            this.panelMatch.Controls.Add(this.buttonFilter);
            this.panelMatch.Controls.Add(this.textBoxHomeTown);
            this.panelMatch.Controls.Add(this.listBoxFilteredFriends);
            this.panelMatch.Controls.Add(this.checkBoxFilterHomeTown);
            this.panelMatch.Controls.Add(this.labelInterestedIn);
            this.panelMatch.Controls.Add(this.radioButtonFemale);
            this.panelMatch.Controls.Add(this.radioButtonMale);
            this.panelMatch.Location = new System.Drawing.Point(3, 97);
            this.panelMatch.Name = "panelMatch";
            this.panelMatch.Size = new System.Drawing.Size(300, 428);
            this.panelMatch.TabIndex = 3;
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
            this.listBoxFilteredFriends.DataSource = this.userBindingSource;
            this.listBoxFilteredFriends.DisplayMember = "Name";
            this.listBoxFilteredFriends.FormattingEnabled = true;
            this.listBoxFilteredFriends.ItemHeight = 16;
            this.listBoxFilteredFriends.Location = new System.Drawing.Point(3, 165);
            this.listBoxFilteredFriends.Name = "listBoxFilteredFriends";
            this.listBoxFilteredFriends.Size = new System.Drawing.Size(268, 260);
            this.listBoxFilteredFriends.TabIndex = 1;
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
            // labelInterestedIn
            // 
            this.labelInterestedIn.AutoSize = true;
            this.labelInterestedIn.Location = new System.Drawing.Point(4, 15);
            this.labelInterestedIn.Name = "labelInterestedIn";
            this.labelInterestedIn.Size = new System.Drawing.Size(86, 17);
            this.labelInterestedIn.TabIndex = 2;
            this.labelInterestedIn.Text = "Interested in";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(7, 81);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(7, 45);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
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
            this.panelMatchDetails.Location = new System.Drawing.Point(578, 0);
            this.panelMatchDetails.Name = "panelMatchDetails";
            this.panelMatchDetails.Size = new System.Drawing.Size(425, 548);
            this.panelMatchDetails.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Ex01_Facebook.UI.Properties.Resources.blog_facebook1;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage2.Controls.Add(this.pictureBoxFriend);
            this.tabPage2.Controls.Add(this.buttonRollAFriend);
            this.tabPage2.Controls.Add(this.pictureBoxProfilePicture2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(999, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(376, 34);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(157, 147);
            this.pictureBoxFriend.TabIndex = 2;
            this.pictureBoxFriend.TabStop = false;
            // 
            // buttonRollAFriend
            // 
            this.buttonRollAFriend.Location = new System.Drawing.Point(346, 225);
            this.buttonRollAFriend.Name = "buttonRollAFriend";
            this.buttonRollAFriend.Size = new System.Drawing.Size(218, 58);
            this.buttonRollAFriend.TabIndex = 1;
            this.buttonRollAFriend.Text = "Roll a friend!";
            this.buttonRollAFriend.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfilePicture2
            // 
            this.pictureBoxProfilePicture2.Location = new System.Drawing.Point(29, 21);
            this.pictureBoxProfilePicture2.Name = "pictureBoxProfilePicture2";
            this.pictureBoxProfilePicture2.Size = new System.Drawing.Size(159, 160);
            this.pictureBoxProfilePicture2.TabIndex = 0;
            this.pictureBoxProfilePicture2.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
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
            // aboutLabel1
            // 
            this.aboutLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true));
            this.aboutLabel1.Location = new System.Drawing.Point(277, 344);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(100, 23);
            this.aboutLabel1.TabIndex = 1;
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
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(277, 304);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel1.TabIndex = 3;
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
            // labelLink
            // 
            labelLink.AutoSize = true;
            labelLink.Location = new System.Drawing.Point(137, 225);
            labelLink.Name = "labelLink";
            labelLink.Size = new System.Drawing.Size(38, 17);
            labelLink.TabIndex = 8;
            labelLink.Text = "Link:";
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(277, 225);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.linkLinkLabel.TabIndex = 9;
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
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(203, 153);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 11;
            this.nameLabel1.Text = "label1";
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
            // labelRelationshipStatus1
            // 
            this.labelRelationshipStatus1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "RelationshipStatus", true));
            this.labelRelationshipStatus1.Location = new System.Drawing.Point(277, 189);
            this.labelRelationshipStatus1.Name = "labelRelationshipStatus1";
            this.labelRelationshipStatus1.Size = new System.Drawing.Size(100, 23);
            this.labelRelationshipStatus1.TabIndex = 13;
            // 
            // FormFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 607);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormFacebookApp";
            this.Text = "FormFacebookApp";
            this.Load += new System.EventHandler(this.FormFacebookApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelMatch.ResumeLayout(false);
            this.panelMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture1)).EndInit();
            this.panelMatchDetails.ResumeLayout(false);
            this.panelMatchDetails.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriendPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Label labelInterestedIn;
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
    }
}