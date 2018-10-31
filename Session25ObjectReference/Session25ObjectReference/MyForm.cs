using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session25ObjectReference
{
    class MyForm : Form
    {
        public MyForm()
        {
            // In this program, we share data by providing the right panel with a reference to the left panel, through its constructor.
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

            RightPanel right = new RightPanel(left);
            table.Controls.Add(right);
        }
    }
}
