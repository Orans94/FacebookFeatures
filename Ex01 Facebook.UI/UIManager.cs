using System;
using System.Windows.Forms;
using Ex01_Facebook.Logic;

namespace Ex01_Facebook.UI
{
    public class UIManager
    {
        private AppSettings m_AppSettings;
        private FormLogin m_FormLogin;
        private FormFacebookApp m_FormFacebookApp;
        private Engine m_Engine;

        public UIManager()
        {
            m_AppSettings = AppSettings.LoadFromFile();
            m_Engine = new Engine();
            m_FormLogin = new FormLogin(m_Engine, m_AppSettings);
            m_FormFacebookApp = new FormFacebookApp(m_Engine, m_AppSettings);
        }

        public void Run()
        {
            Application.Run(m_FormLogin);
            if (m_Engine.IsUserLoggedIn())
            {
                Application.Run(m_FormFacebookApp);
            }
        }
    }
}