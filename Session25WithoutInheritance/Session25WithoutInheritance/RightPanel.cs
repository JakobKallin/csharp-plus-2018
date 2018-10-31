using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session25WithoutInheritance
{
    class RightPanel
    {
        public TableLayoutPanel Panel { get; }
        private LeftPanel left;

        public RightPanel(LeftPanel l)
        {
            left = l;

            Panel = new TableLayoutPanel { };

            Button button = new Button
            {
                Text = "Right"
            };
            button.Click += OnButtonClick;
            Panel.Controls.Add(button);
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Clicks: " + left.ClickCount);
        }
    }
}
