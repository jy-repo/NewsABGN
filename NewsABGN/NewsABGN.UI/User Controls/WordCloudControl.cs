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
            var wordListTmp = words.Trim().Substring(1, words.Length - 4).Replace("(", "").Replace("), ", "|").Replace(")", "").Split('|');

            foreach (var word in wordListTmp.Reverse())
            {
                var NewWord = word.Replace(", ", "|").Split('|');
                Label wordLabel = new Label();
                wordLabel.Width = 200;
                wordLabel.Text = $"{NewWord[0],-10} ---- {NewWord[1],5}";
                flpWordCloudList.Controls.Add(wordLabel);
            }
        }
    }
}
