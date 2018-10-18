using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Session20Part2
{
    class MyForm : Form
    {
        private TableLayoutPanel table;
        private NumericUpDown weightBox;
        private NumericUpDown heightBox;
        private Label bmiResultLabel;

        public MyForm()
        {
            table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2
            };
            Controls.Add(table);

            CreateBMIPanel();
            TableLayoutPanel infoTable = InfoPanel.Create();
            table.Controls.Add(infoTable);
        }

        private void CreateBMIPanel()
        {
            TableLayoutPanel bmiTable = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2
            };
            table.Controls.Add(bmiTable);

            Label weightLabel = CustomLabel("Weight");
            bmiTable.Controls.Add(weightLabel);

            weightBox = new NumericUpDown { Dock = DockStyle.Fill };
            bmiTable.Controls.Add(weightBox);
            weightBox.ValueChanged += OnBMIValueChanged;

            Label heightLabel = CustomLabel("Height");
            bmiTable.Controls.Add(heightLabel);

            heightBox = new NumericUpDown { Dock = DockStyle.Fill };
            bmiTable.Controls.Add(heightBox);
            heightBox.ValueChanged += OnBMIValueChanged;

            Label bmiLabel = CustomLabel("BMI");
            bmiTable.Controls.Add(bmiLabel);

            bmiResultLabel = CustomLabel("Your BMI will be shown here");
            bmiTable.Controls.Add(bmiResultLabel);
        }

        private void OnBMIValueChanged(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(weightBox.Value);
            double height = Convert.ToDouble(heightBox.Value);
            double bmi = weight / (height * height);
            bmiResultLabel.Text = Convert.ToString(bmi);
        }

        private static Label CustomLabel(string text)
        {
            Label label = new Label {
                Text = text,
                AutoSize = true,
                Dock = DockStyle.Fill
            };
            return label;
        }
    }
}
