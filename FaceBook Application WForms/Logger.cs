using System;
using System.IO;
using System.Text;

namespace FaceBook_Application_WForms
{
    public static class Logger
    {
        private const string ks_FileName = @"\ErrorLog.txt";

        public static void WriteException(Exception i_Exception)
        {
            string endError = new string('-', 30);
            string filePath = AppDomain.CurrentDomain.BaseDirectory + ks_FileName;
            StringBuilder errorText = new StringBuilder();
            errorText.AppendLine(string.Format(
                "Message : {0}{1}Date : {2}",
                i_Exception.Message,
                Environment.NewLine,
                DateTime.Now.ToString()));
            errorText.AppendLine(endError);
            File.AppendAllText(filePath, errorText.ToString());
        }

        public static void WriteException(string i_ExceptionMsg)
        {
            WriteException(new Exception(i_ExceptionMsg));
        }
    }
}
