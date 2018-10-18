using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session20Part2
{
    class InfoPanel
    {
        public static TableLayoutPanel Create()
        {
            TableLayoutPanel infoTable = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2
            };

            Label nameLabel = new Label { Text = "Name", AutoSize = true };
            infoTable.Controls.Add(nameLabel);

            TextBox nameBox = new TextBox { Dock = DockStyle.Fill };
            infoTable.Controls.Add(nameBox);

            Label ageLabel = new Label { Text = "Age", AutoSize = true };
            infoTable.Controls.Add(ageLabel);

            NumericUpDown ageBox = new NumericUpDown { Dock = DockStyle.Fill };
            infoTable.Controls.Add(ageBox);

            Label cityLabel = new Label { Text = "City", AutoSize = true };
            infoTable.Controls.Add(cityLabel);

            TextBox cityBox = new TextBox { Dock = DockStyle.Fill };
            infoTable.Controls.Add(cityBox);

            return infoTable;
        }
    }
}
