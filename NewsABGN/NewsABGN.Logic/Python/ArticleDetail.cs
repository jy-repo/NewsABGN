using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.Logic
{
    public class ArticleDetail
    {
        public Dictionary<string, string> FillMainContent(string url)
        {
            // full path of python interpreter 
            string python = @"C:\Users\kccistc\Anaconda3\python.exe";

            // python app to call 
            string myPythonApp = @"D:\python\testing.py";

            // Create new process start info 
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // make sure we can read the output from stdout 
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;

            // start python app with arguments  
            myProcessStartInfo.Arguments = myPythonApp + " " + url;

            Process myProcess = new Process();
            // assign start information to the process 
            myProcess.StartInfo = myProcessStartInfo;

            // start the process 
            myProcess.Start();
            StreamReader myStreamReader = myProcess.StandardOutput;
            string title = myStreamReader.ReadLine();
            string content = myStreamReader.ReadToEnd();

            // wait exit signal from the app we called and then close it. 
            myProcess.WaitForExit();
            myProcess.Close();

            Dictionary<string, string> details = new Dictionary<string, string>();
            // write the output we got from python app 
            details.Add("title", title);
            details.Add("content", content);

            return details;
        }
    }
}
