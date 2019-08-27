using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01_Facebook.Logic;

namespace Ex01_Facebook.UI
{
    public partial class LoginForm : Form
    {
        private Engine EngineManager { get; set; }

        private AppSettings ApplicationSettings { get; set; }

        public LoginForm(Engine i_Engine, AppSettings i_AppSettings)
        {
            InitializeComponent();
            EngineManager = i_Engine;
            ApplicationSettings = i_AppSettings;
        }

        private void timerForwardingFacebook_Tick(object sender, EventArgs e)
        {
            bool isUserLoggedIn, isUserWantToRetryLogin = true;

            timerForwardingFacebook.Enabled = false;
            if (ApplicationSettings.LastAccessToken == null)
            {
                EngineManager.LoginToFacebook();
                isUserLoggedIn = isLoginSuccessed();
                while (!isUserLoggedIn && isUserWantToRetryLogin)
                {
                    isUserWantToRetryLogin = isUserWantToTryLoginAgain();
                    if (isUserWantToRetryLogin)
                    {
                        EngineManager.LoginToFacebook();
                        isUserLoggedIn = isLoginSuccessed();
                    }
                }
            }
            else
            {
                EngineManager.ConnectToFacebookWithLastAccessToken(ApplicationSettings.LastAccessToken);
            }

            Close();
        }

        private bool isLoginSuccessed()
        {
            bool isLoginConfirmed;

            isLoginConfirmed = EngineManager.IsUserLoggedIn();

            return isLoginConfirmed;
        }

        private bool isUserWantToTryLoginAgain()
        {
            bool toRetry;

            string title = "Facebook Login";
            string message = string.Format("It seems like you are offline from facebook, Would you like to proceed to facebook login again?{0}No button will end the program", Environment.NewLine);
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            toRetry = result == DialogResult.Yes ? true : false;

            return toRetry;
        }
    }
}
