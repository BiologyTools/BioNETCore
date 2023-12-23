namespace Bio
{
    public partial class About : Form
    {
        /* This is the constructor for the About form. It is called when the form is created. */
/// <summary>
/// Initializes a new instance of the <see cref="About"/> class.
/// </summary>
        public About()
        {
            InitializeComponent();
#if DEBUG
            MessageBox.Show("Application is running in Debug mode.");
#endif
            versionLabel.Text = "Version: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /// When the user clicks on the link, the program will open the link in the default browser
        /// 
        /// @param sender The object that raised the event.
        /// @param LinkLabelLinkClickedEventArgs This is the event that is triggered when the link is
        /// clicked.
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BiologyTools/Bio");
        }
    }
}
