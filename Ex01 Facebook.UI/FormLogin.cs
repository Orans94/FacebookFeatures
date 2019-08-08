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
        private Engine m_Engine;

        public FormLogin(Engine i_Engine)
        {
            InitializeComponent();
            m_Engine = i_Engine;
        }

        private void timerForwardingFacebook_Tick(object sender, EventArgs e)
        {
            timerForwardingFacebook.Enabled = false;
            m_Engine.LoginToFacebook();
            Close();
        }
    }
}
