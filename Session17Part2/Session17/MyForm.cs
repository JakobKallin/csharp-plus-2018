using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Session17
{
    class Film
    {
        public string Title;
        public int Year;
        public string Summary;
    }

    class MyForm : Form
    {
        private Film[] movies;
        private Label summaryLabel;

        public MyForm()
        {
            Text = "Movie Info";
            Size = new Size(400, 300);
            Font = new Font("Arial", 20);

            movies = new Film[]
            {
                new Film { Title = "Star Wars", Year = 1977, Summary = "War in space."},
                new Film { Title = "The Matrix", Year = 1999, Summary = "Folk i svarta kappor käkar röda piller." },
                new Film { Title = "Se7en", Year = 1995, Summary = "Brad Pitt och Morgan Freeman jagar en seriemördare." },
                new Film { Title = "Sjunde inseglet", Year = 1957, Summary = "Jag är döden, vill du spela schack?"},
                new Film { Title = "Man on the Moon", Year = 1999, Summary = "En man som trollar showbusinessvärlden." },
                new Film { Title = "Superman", Year = 1978, Summary = "Is it a bird or a plane? No, it's me!"}
            };

            TableLayoutPanel table = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill
            };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            Controls.Add(table);

            foreach (Film m in movies)
            {
                if (m.Year >= 1990)
                {
                    Label movieLabel = new Label
                    {
                        Text = m.Title + " (" + m.Year + ")",
                        Dock = DockStyle.Fill,
                        AutoSize = true
                    };
                    table.Controls.Add(movieLabel);
                    Button movieButton = new Button
                    {
                        Text = "Show Summary",
                        AutoSize = true
                    };
                    movieButton.Tag = m;
                    movieButton.Click += SummaryButtonClicked;
                    table.Controls.Add(movieButton);
                }
            }
        }

        private void SummaryButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Film m = (Film)button.Tag;
            MessageBox.Show("Summary: " + m.Summary);
        }
    }
}
