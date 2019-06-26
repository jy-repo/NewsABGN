using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsABGN.UI.User_Controls
{
    public partial class WordCloudControl : UserControl
    {
        public WordCloudControl()
        {
            InitializeComponent();
        }

        public void FillCloud(string words)
        {
            var wordList = words.Trim().Substring(1, words.Length - 2).Replace("(", "").Split(')').ToList();
            wordList.Reverse();
            var cloud = "";
            for(int i=0; i < wordList.Count; i++)
            {
                if (wordList[i] == "]")
                    continue;
                if(wordList[i].ElementAt(0) == ',')
                {
                    wordList[i] = wordList[i].Substring(1);
                }
                wordList[i] = wordList[i].Replace(",", " ");
                cloud += wordList[i] + "\r\n";
            }

            lblWords.Text = cloud;
        }
    }
}
