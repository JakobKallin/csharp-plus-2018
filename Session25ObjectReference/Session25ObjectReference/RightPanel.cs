using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session25ObjectReference
{
    class RightPanel : TableLayoutPanel
    {
        private LeftPanel left;

        public RightPanel(LeftPanel l)
        {
            left = l;

            Button button = new Button
            {
                Text = "Right"
            };
            button.Click += OnButtonClick;

            Controls.Add(button);
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Clicks: " + left.ClickCount);
        }
    }
}
