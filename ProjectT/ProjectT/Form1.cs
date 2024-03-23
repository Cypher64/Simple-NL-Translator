using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProjectT
{
    public partial class Form1 : Form
    {
        private const string baseUrl = "http://api.mymemory.translated.net";
        private HttpClient httpClient;
        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private async Task<string> TranslateAsync(string text, string sourceLang, string targetLang)
        {
            string url = $"{baseUrl}/get?q={Uri.EscapeDataString(text)}&langpair={sourceLang}|{targetLang}";

            HttpResponseMessage responce = await httpClient.GetAsync(url);
            responce.EnsureSuccessStatusCode();

            string responseJson = await responce.Content.ReadAsStringAsync();
            var translationResult = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);

            if (translationResult.ResponseStatus == 200)
            {
                return translationResult.TranslatedText;
            }

            return string.Empty;
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs mouseEventArgs)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            this.MouseDoubleClick += Form1_MouseDoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         


            textInput.BorderRadius = 20;
            textOutput.BorderRadius = 20;
            cmbSourceLanguage.BorderRadius = 17;
            cmbTargetLanguage.BorderRadius = 17;
            cmbSourceLanguage.Items.AddRange(new string[] { "en", "es", "fr", "de", "it" });
            cmbTargetLanguage.Items.AddRange(new string[] { "en", "es", "fr", "de", "it" });
            cmbSourceLanguage.SelectedIndex = 0;
            cmbTargetLanguage.SelectedIndex = 1;
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                string translatedText = await TranslateAsync(textInput.Text, cmbSourceLanguage.SelectedItem.ToString(), cmbTargetLanguage.SelectedItem.ToString());
                textOutput.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Translation failed. Please try again. Error: \r\n" + ex);
                throw;
            }
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneCustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTargetLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneCirclePictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                // Збільшити вікно на весь екран
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Зменшити вікно до його початкового розміру
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void siticoneCirclePictureBox4_Click(object sender, EventArgs e)
        {
            
                int selectedIndex = cmbSourceLanguage.SelectedIndex;
                cmbSourceLanguage.SelectedIndex = cmbTargetLanguage.SelectedIndex;
                cmbTargetLanguage.SelectedIndex = selectedIndex;
           
        }
    }

    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }

        [JsonProperty("respinceData")]
        public TranslationData ResponseData { get; set; }

        public string TranslatedText => ResponseData?.TranslatedText;

    }

    public class TranslationData
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }

    }




}