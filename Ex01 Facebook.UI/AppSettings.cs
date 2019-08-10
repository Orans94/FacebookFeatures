using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ex01_Facebook.UI
{
    public class AppSettings
    {
        private static readonly string r_AppSettingsFilePath = AppDomain.CurrentDomain.BaseDirectory;

        public Point LastWindowLocation { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            LastWindowLocation = new Point(150, 30);
            RememberUser = true;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;

            if (File.Exists(r_AppSettingsFilePath + @"\appSettings.xml"))
            {
                using (Stream stream = new FileStream(r_AppSettingsFilePath + @"\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(r_AppSettingsFilePath + @"\appSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}

