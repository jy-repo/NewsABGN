using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;

namespace NewsABGN.UI.User_Controls.Result
{
    public partial class NewsResult : UserControl
    {
        private const int lineLengthTitle = 36;
        private const int lineLengthContent = 55;

        private string _link;

        public NewsResult()
        {
            InitializeComponent();
        }

        public NewsResult(Dictionary<string, string> news) : this()
        {
            lblTitle.Text = FitWidth(news["title"], "title");
            lblContents.Text =
                FitWidth(news["pubDate"], "content") + 
                "\r\n\r\n" +
                FitWidth(news["description"], "content");
            _link = news["link"];
        }

        private string FitWidth(string str, string type)
        {
            string result = "";
            int i = 1;

            //Console.WriteLine("Enter a string having '&', '<', '>' or '\"' in it: ");
            //string myString = Console.ReadLine();

            //// Encode the string.
            //string myEncodedString = HttpUtility.HtmlEncode(myString);

            //Console.WriteLine($"HTML Encoded string is: {myEncodedString}");
            StringWriter myWriter = new StringWriter();

            // Decode the encoded string.
            HttpUtility.HtmlDecode(str, myWriter);

            str = myWriter.ToString();
           



            foreach (var letter in str)
            {
                if (i == lineLengthTitle * 2 - 3 && type == "title")
                {
                    result += "...";
                    i++;
                    break;
                }
                if (i == lineLengthContent * 2 - 3 && type == "content")
                {
                    result += "...";
                    i++;
                    break; ;
                }
                result += letter;
                if (type == "title" && i % lineLengthTitle == 0)
                    result += "\r\n";
                if (type == "content" && i % lineLengthContent == 0)
                    result += "\r\n";
                i++;
               
            }

            return result;
        }

        private void Open_Article(object sender, EventArgs e)
        {
            ArticleForm articleForm = new ArticleForm(_link);
            articleForm.ShowDialog();
        }
    }
}
