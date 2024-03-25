using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ModernTranslatorTutorial
{
    public partial class Form1 : Form
    {
        private HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();

            this.MinimumSize = new System.Drawing.Size(600, 500);

            this.Resize += Form1_Resize;

            this.Load += Form1_Load;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(800, 520);

            textInput.BorderRadius = 20;
            textOutput.BorderRadius = 20;
            cmbSourceLanguage.BorderRadius = 17;
            cmbTargetLanguage.BorderRadius = 17;
            cmbSourceLanguage.Items.AddRange(new string[] { "en", "uk", "es", "fr", "de", "zh" });
            cmbTargetLanguage.Items.AddRange(new string[] { "en", "uk", "es", "fr", "de", "zh" });
            cmbSourceLanguage.SelectedIndex = 0;
            cmbTargetLanguage.SelectedIndex = 1;
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            int CharacterCount = 0;
            for (int i = 0; i < textInput.Text.Length; i++)
            {
                CharacterCount++;
            }

            if (CharacterCount < 501)
            {
                try
                {
                    string translatedText = await TranslateAsync(textInput.Text, cmbSourceLanguage.SelectedItem.ToString(), cmbTargetLanguage.SelectedItem.ToString());
                    textOutput.Text = translatedText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Translation failed. Please try again. Error: \r\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("The max character limit for the input is 500! While your input was: " + CharacterCount);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
        }

        private async Task<string> TranslateAsync(string text, string sourceLang, string targetLang)
        {
            string url = $"http://api.mymemory.translated.net/get?q={Uri.EscapeDataString(text)}&langpair={sourceLang}|{targetLang}";

            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            var translationResult = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);

            if (translationResult.ResponseStatus == 200)
            {
                return translationResult.TranslatedText;
            }

            return string.Empty;
        }

        private void textOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }

        [JsonProperty("responseData")]
        public TranslationData ResponseData { get; set; }

        public string TranslatedText => ResponseData?.TranslatedText;
    }

    public class TranslationData
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }
    }
}

