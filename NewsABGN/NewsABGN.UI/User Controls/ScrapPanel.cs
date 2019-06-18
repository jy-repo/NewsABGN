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
    public partial class ScrapPanel : UserControl
    {
        public ScrapPanel()
        {
            InitializeComponent();
            FillScrapPanelTest();
        }

        public void FillScrapPanel(List<Scrap> scraps)
        {
            // TODO: get db scraps
        }

        private void FillScrapPanelTest()
        {
            List<Scrap> scraps = new List<Scrap>();

            scraps.Add(new Scrap());
            scraps.Add(new Scrap());
            scraps.Add(new Scrap());
            scraps.Add(new Scrap());
            scraps.Add(new Scrap());
            scraps.Add(new Scrap());

            int x = 0;
            int y = 0;
            foreach (var scrap in scraps)
            {
                tlpScrapPanel.Controls.Add(scrap, x, y);
                x = ++x % 2;
                y = ++y / 3;
            }
        }
    }
}
