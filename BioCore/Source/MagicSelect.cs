﻿namespace Bio
{
    public partial class MagicSelect : Form
    {
        public MagicSelect(int index)
        {
            InitializeComponent();
            thBox.SelectedIndex = index;
        }
        private bool numeric = false;

        public bool Numeric
        {
            get
            {
                return numeric;
            }
        }

        public int Threshold
        {
            get
            {
                return (int)numBox.Value;
            }
        }

        public int Min
        {
            get { return (int)minBox.Value; }
        }
        public int Max
        {
            get { return (int)maxBox.Value; }
        }
        public int Index
        {
            get
            {
                return thBox.SelectedIndex;
            }
        }
        private void numericBox_CheckedChanged(object sender, EventArgs e)
        {
            numeric = numericBox.Checked;
        }

        private void okBut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
