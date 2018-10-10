using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Session17
{
    class MyForm : Form
    {
        private FlowLayoutPanel flow;

        public MyForm()
        {
            flow = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Dock = DockStyle.Fill
            };
            Controls.Add(flow);

            string[] filenames = Directory.GetFiles("images");
            foreach (string name in filenames)
            {
                CreatePicture(name);
            }
        }

        private void CreatePicture(string path)
        {
            PictureBox box1 = new PictureBox
            {
                Image = Image.FromFile(path),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 150,
                Height = 150
            };
            flow.Controls.Add(box1);
        }
    }
}
