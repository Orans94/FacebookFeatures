using Ex01_Facebook.Logic;
using System;

namespace Ex01_Facebook.UI
{
    public class UIManager
    {
        private Engine m_Engine;
        private FormLogin m_FormLogin;
        private FormFacebookApp m_FormFacebookApp;

        public UIManager()
        {
            m_Engine = new Engine();
            m_FormLogin = new FormLogin(m_Engine);
            m_FormFacebookApp = new FormFacebookApp();
        }

        public void Run()
        {
            
        }
    }
}