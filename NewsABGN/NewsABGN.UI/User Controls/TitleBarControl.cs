using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsABGN.UI.User_Controls.TitleBar
{
    public partial class TitleBarControl : UserControl
    {
        public TitleBarControl()
        {
            InitializeComponent();
        }

        private void PicbExit_Click(object sender, EventArgs e)
        {
            OnExitButtonClicked();
        }

        #region ExitButtonClicked event things for C# 3.0
        public event EventHandler<ExitButtonClickedEventArgs> ExitButtonClicked;

        protected virtual void OnExitButtonClicked(ExitButtonClickedEventArgs e)
        {
            if (ExitButtonClicked != null)
                ExitButtonClicked(this, e);
        }

        private ExitButtonClickedEventArgs OnExitButtonClicked()
        {
            ExitButtonClickedEventArgs args = new ExitButtonClickedEventArgs();
            OnExitButtonClicked(args);

            return args;
        }

        /*private ExitButtonClickedEventArgs OnExitButtonClickedForOut()
        {
            ExitButtonClickedEventArgs args = new ExitButtonClickedEventArgs();
            OnExitButtonClicked(args);

            return args;
        }*/

        public class ExitButtonClickedEventArgs : EventArgs
        {


            /*public ExitButtonClickedEventArgs()
            {
            }

            public ExitButtonClickedEventArgs()
            {

            }*/
        }
        #endregion
    }
}
