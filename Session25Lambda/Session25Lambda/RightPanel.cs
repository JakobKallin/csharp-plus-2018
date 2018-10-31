using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session25Lambda
{
    class RightPanel : TableLayoutPanel
    {
        private Action onButtonClick;

        public RightPanel(Action c)
        {
            onButtonClick = c;

            Button button = new Button
            {
                Text = "Right"
            };
            button.Click += OnButtonClick;

            Controls.Add(button);
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            onButtonClick();
        }
    }
}
