namespace FunctionOnlyOSK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }
    }
}