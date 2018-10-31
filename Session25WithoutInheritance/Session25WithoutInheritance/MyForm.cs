using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session25WithoutInheritance
{
    class MyForm : Form
    {
        public MyForm()
        {
            // In this program, we avoid the complexities and risks of inheritance by letting LeftPanel and RightPanel be "normal" classes.
            // The main difference is that we cannot use them as controls (such as sending them to Controls.Add), so we instead give each of them a public property containing the control that they represent, then add this to the table in the main class (MyForm).
            TableLayoutPanel table = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill
            };
            Controls.Add(table);

            LeftPanel left = new LeftPanel();
            table.Controls.Add(left.Panel);

            RightPanel right = new RightPanel(left);
            table.Controls.Add(right.Panel);
        }
    }
}
