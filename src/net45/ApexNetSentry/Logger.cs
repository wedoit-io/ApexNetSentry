using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpRaven;
using SharpRaven.Logging;
using SharpRaven.Data;
using SharpenLevel = SharpRaven.Data.ErrorLevel;

namespace ApexNetSentry
{
         
        public enum SentryError
        {
            Info = SharpRaven.Data.ErrorLevel.Info,
            Debug = SharpRaven.Data.ErrorLevel.Debug,
            Error = SharpRaven.Data.ErrorLevel.Error,
            Fatal = SharpRaven.Data.ErrorLevel.Fatal,
            Warning = SharpRaven.Data.ErrorLevel.Warning
        };


        public static class Logger
        {
            /*
            public static void CaptureMessage(string ApiKey, string Message)
            {
                var ravenClient = new RavenClient(ApiKey);
                ravenClient.CaptureMessage(Message, ErrorLevel.Info);
            }
             */

            public static void CaptureMessage(string ApiKey, string Message, SentryError level = SentryError.Info, Dictionary<string, string> tags = null)
            {
                var ravenClient = new RavenClient(ApiKey);
                ravenClient.CaptureMessage(Message, (SharpenLevel)level, tags);
            }


            public static void CaptureException(string ApiKey, Exception ex, string Message, SentryError level = SentryError.Info, Dictionary<string, string> tags = null)
            {
                var ravenClient = new RavenClient(ApiKey);

                ravenClient.CaptureException(ex, Message, (SharpenLevel)level, tags);
            }

        }


}


