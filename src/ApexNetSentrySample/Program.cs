using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApexNetSentry;


namespace ApexNetSentrySample
{
    class Program
    {
        static void Main(string[] args)
        {

            string ApiKey = "http://1cff7fad696c346e8966d0b0c82439df8:79df31b6aa9642a3bef837f21f4132f1@sentry.apexnet.it/12";

            
            Logger.CaptureMessage(ApiKey, "Messaggio 1");

            Logger.CaptureMessage(ApiKey, "Messaggio 2", SentryError.Warning);

            Dictionary<string, string> tags = new Dictionary<string, string>();
            tags["TAG"] = "TAG1";
            Logger.CaptureMessage(ApiKey, "Messaggio 3", SentryError.Info, tags);

            var a = new Exception();

            Logger.CaptureException(ApiKey, a, "n" , SentryError.Info, tags);



        }
    }
}
