using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session25Lambda
{
    class MyForm : Form
    {
        public MyForm()
        {
            // In this program, the main class (MyForm) decides what the right panel's button should do, by sending a lambda to it.
            // We also make LeftPanel and RightPanel subclasses of TableLayoutPanel, so that we can treat them like any other control (and send to Controls.Add, for example).
            // We do not need to use inheritance for LeftPanel and RightPanel; see "Session25WithoutInheritance" for an example without it.
            TableLayoutPanel table = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill
            };
            Controls.Add(table);

            LeftPanel left = new LeftPanel();
            table.Controls.Add(left);

            // "Action" is like "Func" except with no return value.
            Action onRightButtonClick = () =>
            {
                MessageBox.Show("Clicks: " + left.ClickCount);
            };

            RightPanel right = new RightPanel(onRightButtonClick);
            table.Controls.Add(right);
        }
    }
}
