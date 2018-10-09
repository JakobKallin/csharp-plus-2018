using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Session17
{
    class Movie
    {
        public string Title;
        public int Year;
        public string Summary;
    }

    class MyForm : Form
    {
        private ComboBox movieBox;
        private Movie[] movies;
        private Label summaryLabel;

        public MyForm()
        {
            Text = "Movie Info";
            Size = new Size(400, 300);
            Font = new Font("Arial", 20);

            movies = new Movie[]
            {
                new Movie { Title = "The Matrix", Year = 1999, Summary = "Folk i svarta kappor käkar röda piller." },
                new Movie { Title = "Se7en", Year = 1995, Summary = "Brad Pitt och Morgan Freeman jagar en seriemördare." },
                new Movie { Title = "Man on the Moon", Year = 1999, Summary = "En man som trollar showbusinessvärlden." }
            };

            TableLayoutPanel table = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 2,
                Dock = DockStyle.Fill
            };
            Controls.Add(table);

            movieBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Dock = DockStyle.Fill
            };
            table.Controls.Add(movieBox);
            movieBox.SelectedIndexChanged += ComboboxChanged;

            foreach (Movie m in movies)
            {
                movieBox.Items.Add(m.Title + " (" + m.Year + ")");
            }

            summaryLabel = new Label
            {
                Text = "This text will show the movie summary.",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            table.Controls.Add(summaryLabel);
        }

        private void ComboboxChanged(object sender, EventArgs e)
        {
            Movie m = movies[movieBox.SelectedIndex];
            summaryLabel.Text = m.Summary;
        }
    }
}
