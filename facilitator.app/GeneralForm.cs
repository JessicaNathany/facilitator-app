namespace facilitator.app
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void btnJsonFormatter_Click(object sender, EventArgs e)
        {


            /*
             *  try
            {
                var jsonDataUrl = richTextBox1.Text;

                var parsedJson = JToken.Parse(jsonDataUrl);
                string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);

                jsonformattedData.Text = formattedJson;
            }
            catch (Exception ex)
            {
                MessageBox.Show("JSON invalid. " + ex.Message);

                // Limpa os campos de texto.
                jsonformattedData.Clear();
                richTextBox1.Clear();
            }
             */
        }

    }
}