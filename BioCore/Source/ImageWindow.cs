﻿namespace Bio
{
    public partial class ImageWindow : Form
    {
        public ImageWindow(BioImage im)
        {
            InitializeComponent();
            ImageView iv = new ImageView(im);
            iv.Dock = DockStyle.Fill;
            this.Controls.Add(iv);
            this.Text = System.IO.Path.GetFileName(im.ID);
            this.Size = new Size(im.SizeX, im.SizeY);
            this.Show();
        }
    }
}
