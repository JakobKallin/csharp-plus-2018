using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Session16
{
    class MyForm : Form
    {
        private TextBox NameBox = new TextBox { };

        public MyForm() {
            TableLayoutPanel table = new TableLayoutPanel
            {
                RowCount = 2,
                ColumnCount = 2
            };
            Controls.Add(table);
            
            table.Controls.Add(NameBox);

            Button button = new Button
            {
                Text = "Say Hello"
            };
            table.Controls.Add(button);

            // När "Click" sker på knappen, anropa "OnButtonClick".
            button.Click += OnButtonClick;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + NameBox.Text);
        }
    }
}
