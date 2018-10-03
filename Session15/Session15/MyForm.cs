using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Session15
{
    class MyForm : Form
    {
        public MyForm()
        {
            TableLayoutPanel table = new TableLayoutPanel
            {
                RowCount = 5,
                ColumnCount = 2,
                Dock = DockStyle.Fill
            };
            Controls.Add(table);

            Label countryLabel = new Label
            {
                Text = "Country",
                TextAlign = ContentAlignment.MiddleRight
            };
            table.Controls.Add(countryLabel);

            TextBox countryTextBox = new TextBox
            {
                Dock = DockStyle.Fill
            };
            table.Controls.Add(countryTextBox);

            Label ageLabel = new Label
            {
                Text = "Age",
                TextAlign = ContentAlignment.MiddleRight
            };
            table.Controls.Add(ageLabel);

            NumericUpDown ageBox = new NumericUpDown {
                Dock = DockStyle.Fill
            };
            table.Controls.Add(ageBox);

            Label timesLabel = new Label
            {
                Text = "Times elected",
                TextAlign = ContentAlignment.MiddleRight
            };
            table.Controls.Add(timesLabel);

            NumericUpDown timesBox = new NumericUpDown {
                Dock = DockStyle.Fill
            };
            table.Controls.Add(timesBox);

            Label worldLabel = new Label
            {
                Text = "Saved the world",
                TextAlign = ContentAlignment.MiddleRight
            };
            table.Controls.Add(worldLabel);

            CheckBox worldBox = new CheckBox {
                Checked = true
            };
            table.Controls.Add(worldBox);

            Button presidentButton = new Button
            {
                Text = "Can I Be President?",
                Dock = DockStyle.Top
            };
            table.Controls.Add(presidentButton);
            table.SetColumnSpan(presidentButton, 2);
        }
    }
}
