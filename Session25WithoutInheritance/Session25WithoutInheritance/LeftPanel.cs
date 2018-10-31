using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session25WithoutInheritance
{
    class LeftPanel
    {
        public TableLayoutPanel Panel { get; }
        public int ClickCount { get; set; }

        public LeftPanel()
        {
            Panel = new TableLayoutPanel { };

            Button button = new Button
            {
                Text = "Left"
            };
            button.Click += OnButtonClick;
            Panel.Controls.Add(button);
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            ClickCount += 1;
        }
    }
}
