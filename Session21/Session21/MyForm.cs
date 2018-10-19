using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Session21
{
    class MyForm : Form
    {
        public MyForm()
        {
            TableLayoutPanel table = CreateTable();
            Button b = CreateButton();
            ComboBox c = CreateComboBox();
            Label l = CreateLabel();

            Controls.Add(table);
            table.Controls.Add(b);
            table.Controls.Add(c);
            table.Controls.Add(l);
        }

        private static TableLayoutPanel CreateTable()
        {
            return new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                BackColor = Color.Green
            };
        }

        private static Label CreateLabel()
        {
            return new Label
            {
                Text = "Some text",
                ForeColor = Color.Orange,
                BackColor = Color.Purple
            };
        }

        private static ComboBox CreateComboBox()
        {
            ComboBox c = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = Color.Blue,
                ForeColor = Color.Yellow
            };
            c.Items.Add("Johnny Depp");
            c.Items.Add("Brad Pitt");
            c.Items.Add("Tom Cruise");
            return c;
        }

        private Button CreateButton()
        {
            return new Button
            {
                Text = "Hello",
                Dock = DockStyle.Fill,
                ForeColor = Color.Red,
                BackColor = Color.Black
            };
        }
    }
}
