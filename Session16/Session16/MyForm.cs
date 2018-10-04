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
        private NumericUpDown heightBox;
        private NumericUpDown weightBox;

        public MyForm() {
            TableLayoutPanel table = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill
            };
            Controls.Add(table);

            table.Controls.Add(new Label
            {
                Text = "Height",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight
            });
            heightBox = new NumericUpDown {
                Dock = DockStyle.Fill,
                DecimalPlaces = 2,
                Increment = 0.01M
            };
            table.Controls.Add(heightBox);

            table.Controls.Add(new Label
            {
                Text = "Weight",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight
            });
            weightBox = new NumericUpDown {
                Dock = DockStyle.Fill
            };
            table.Controls.Add(weightBox);

            Button bmiButton = new Button
            {
                Text = "Calculate BMI!",
                Dock = DockStyle.Top
            };
            table.Controls.Add(bmiButton);
            table.SetColumnSpan(bmiButton, 2);
            bmiButton.Click += OnBmiButtonClick;

            Button imperialButton = new Button
            {
                Text = "Calculate Imperial!",
                Dock = DockStyle.Top
            };
            table.Controls.Add(imperialButton);
            table.SetColumnSpan(imperialButton, 2);
            imperialButton.Click += OnImperialButtonClick;
        }

        private void OnBmiButtonClick(object sender, EventArgs e)
        {
            double height = (double) heightBox.Value;
            double weight = (double) weightBox.Value;
            double bmi = weight / (height * height);
            MessageBox.Show("Your BMI is: " + bmi);
        }

        private void OnImperialButtonClick(object sender, EventArgs e)
        {
            double height = (double)heightBox.Value;
            double weight = (double)weightBox.Value;
            double bmi = weight / (height * height) * 703;
            MessageBox.Show("Your BMI is: " + bmi);
        }
    }
}
