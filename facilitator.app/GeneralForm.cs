namespace facilitator.app
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void ButtonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonJsonFormat(object sender, EventArgs e)
        {
            var formFormatter = new FormFormatters();
            var generalForm = new GeneralForm();
            formFormatter.Show();
            generalForm.Close();
        }
    }
}
