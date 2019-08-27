using System;
using System.Windows.Forms;
using Ex01_Facebook.Logic;

namespace Ex01_Facebook.UI
{
    public class UIManager
    {
        private AppSettings m_AppSettings;
        private LoginForm m_FormLogin;
        private FacebookAppForm m_FormFacebookApp;
        private Engine m_Engine;

        public UIManager()
        {
            m_AppSettings = AppSettings.LoadFromFile();
            m_Engine = new Engine();
            m_FormLogin = new LoginForm(m_Engine, m_AppSettings);
            m_FormFacebookApp = FacebookAppForm.Instance;
        }

        public void Run()
        {
            Application.Run(m_FormLogin);
            m_FormFacebookApp.ConfigureAppAfterLogin(m_Engine, m_AppSettings);
            if (m_Engine.IsUserLoggedIn())
            {
                Application.Run(m_FormFacebookApp);
            }
        }
    }
}