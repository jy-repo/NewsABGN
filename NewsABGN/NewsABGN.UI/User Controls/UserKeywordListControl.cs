using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewsABGN.Logic;

namespace NewsABGN.UI.User_Controls
{
    public partial class UserKeywordListControl : UserControl
    {
        public UserKeywordListControl()
        {
            InitializeComponent();
        }

        private List<UserKeywordControl> _userKeywordControls = new List<UserKeywordControl>();

        public List<UserKeywordControl> FillKeywords(int memberId)
        {
            // get user keywords from DB
            var keywords = LogicRepository.Controller.DBbot.GetKeywords(memberId);

            // Make and fill UserKeywordControl
            // Add to flow layout panel for display
            // Add to _userKeywordControls list for data access
            foreach(var keyword in keywords)
            {
                var userKeywordControl = new UserKeywordControl(keyword.PushName);
                _userKeywordControls.Add(userKeywordControl);
                flpKeywordList.Controls.Add(userKeywordControl);
            }
            return _userKeywordControls;
        }

        public void EmptyKeywords()
        {
            _userKeywordControls.Clear();
            flpKeywordList.Controls.Clear();
        }
    }
}
