using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace facilitator.app
{
    public partial class FormFormatters : Form
    {
        public FormFormatters()
        {
            InitializeComponent();
        }

        private void ButtonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonBack(object sender, EventArgs e)
        {
            var generalForm = new GeneralForm();
            var formFormatter = new FormFormatters();
            generalForm.Show();
            formFormatter.Close();
        }

        private void ButtonClear(object sender, EventArgs e)
        {
            jsonDataFormated.Clear();
            jsonDataUrl.Clear();
        }

        private void ButtonProcess(object sender, EventArgs e)
        {
            try
            {
                var jsonDataUrl = this.jsonDataUrl.Text;

                var parsedJson = JToken.Parse(jsonDataUrl);
                var formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);

                jsonDataFormated.Text = formattedJson;
            }
            catch (JsonReaderException ex)
            {
                MessageBox.Show("JSON invalid: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
