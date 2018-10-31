using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session25ClassVariable
{
    class MyForm : Form
    {
        public static int ClickCount { get; set; }

        public MyForm()
        {
            // In this program, we share data between objects by using an effectively "global" class variable in the main class (MyForm).
            // Note that this is only appropriate if we know that we never need more than one value of that type in the program. If at some point we need different "copies" of that value (such as multiple shopping carts), this approach will not work.
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

            RightPanel right = new RightPanel();
            table.Controls.Add(right);
        }
    }
}
