using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Logic
{
    public class AppSettings
    {
        private static readonly string sr_FilePath = AppDomain.CurrentDomain.BaseDirectory + @"\AppSetting.xml";
        private readonly object r_CreateFileLock = new object();

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            using (Stream stream = createOrOpenFile())
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        private FileStream createOrOpenFile()
        {
            FileStream result = null;
            lock (r_CreateFileLock)
            {
                if (File.Exists(sr_FilePath))
                {
                    result = new FileStream(sr_FilePath, FileMode.Truncate);
                }
                else
                {
                    result = new FileStream(sr_FilePath, FileMode.CreateNew);
                }
            }

            return result;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings result = null;
            Stream stream = null;

            try
            {
                stream = new FileStream(sr_FilePath, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                result = serializer.Deserialize(stream) as AppSettings;
            }
            catch (Exception)
            {
                result = new AppSettings();
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                }
            }

            return result;
        }
    }
}
