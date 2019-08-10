using Ex01_Facebook.Logic;
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
    public partial class FormLogin : Form
    {
        private Engine EngineManager { get; set; }

        public FormLogin(Engine i_Engine)
        {
            InitializeComponent();
            EngineManager = i_Engine;
        }

        private void timerForwardingFacebook_Tick(object sender, EventArgs e)
        {
            bool isUserLoggedIn, isUserWantToRetryLogin = true;

            timerForwardingFacebook.Enabled = false;
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
            Close();
        }

        private bool isLoginSuccessed()
        {
            bool isLoginConfirmed;

            isLoginConfirmed = EngineManager.LoggedInUser != null ? true : false;

            return isLoginConfirmed;
        }

        private bool isUserWantToTryLoginAgain()
        {
            bool toRetry;

            string title = "Facebook features";
            string message = string.Format("It seems like you are offline from facebook, Would you like to proceed to facebook login again?{0}No button will end the program", Environment.NewLine);
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            toRetry = result == DialogResult.Yes ? true : false;

            return toRetry;
        }
    }
}
