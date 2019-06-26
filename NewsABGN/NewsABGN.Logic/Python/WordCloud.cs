using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.Logic
{
    public class WordCloud
    {
        public string MakeWordCloud(string keyword)
        {
            // full path of python interpreter 
            string python = @"..\..\..\NewsABGN.Python\venv\Scripts\python.exe";

            // python app to call 
            string myPythonApp = @"..\..\..\NewsABGN.Python\WordCloudModule.py";

            // Create new process start info 
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // output to stdout 
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;

            // no prompt window on load for UI environment
            myProcessStartInfo.CreateNoWindow = true;
            
            // start python app with arguments  
            myProcessStartInfo.Arguments = myPythonApp + " " + keyword;

            Process myProcess = new Process();
            // assign start information to the process 
            myProcess.StartInfo = myProcessStartInfo;

            // start the process 
            myProcess.Start();
            StreamReader myStreamReader = myProcess.StandardOutput;
            string pythonOutput = myStreamReader.ReadToEnd();
           

            // wait exit signal from the app we called and then close it. 
            myProcess.WaitForExit();
            myProcess.Close();

            return pythonOutput;
        }

    }
}
