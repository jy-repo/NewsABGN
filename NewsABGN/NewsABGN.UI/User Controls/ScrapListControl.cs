﻿using System;
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
    public partial class ScrapListControl : UserControl
    {
        public ScrapListControl()
        {
            InitializeComponent();
        }

        private List<ScrapControl> _scrapControls = new List<ScrapControl>();
        
        public List<ScrapControl> FillScrapPanel(int memberId)
        {
            var scraps = LogicRepository.Controller.DBbot.GetScraps(memberId);

            foreach(var scrap in scraps)
            {
                ScrapControl s = new ScrapControl(scrap);
                _scrapControls.Add(s);
                flpScrapPanel.Controls.Add(s);
            }

            return _scrapControls;
        }

        public void EmptyScraps()
        {
            _scrapControls.Clear();
            flpScrapPanel.Controls.Clear();
        }
    }
}
