using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session25ObjectReference
{
    class LeftPanel : TableLayoutPanel
    {
        public int ClickCount { get; set; }

        public LeftPanel()
        {
            Button button = new Button
            {
                Text = "Left"
            };
            button.Click += OnButtonClick;

            Controls.Add(button);
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            ClickCount += 1;
        }
    }
}
