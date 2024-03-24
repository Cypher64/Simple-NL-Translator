
namespace ModernTranslatorTutorial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.textOutput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cmbSourceLanguage = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cmbTargetLanguage = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.btnTranslate = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnHelp = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Animated = true;
            this.textInput.AutoRoundedCorners = true;
            this.textInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.textInput.BorderRadius = 186;
            this.textInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textInput.DefaultText = "";
            this.textInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.textInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.textInput.ForeColor = System.Drawing.Color.White;
            this.textInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.Location = new System.Drawing.Point(23, 33);
            this.textInput.Margin = new System.Windows.Forms.Padding(5);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.PasswordChar = '\0';
            this.textInput.PlaceholderText = "Type in here...";
            this.textInput.SelectedText = "";
            this.textInput.Size = new System.Drawing.Size(480, 374);
            this.textInput.TabIndex = 0;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // textOutput
            // 
            this.textOutput.Animated = true;
            this.textOutput.AutoRoundedCorners = true;
            this.textOutput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.textOutput.BorderRadius = 186;
            this.textOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textOutput.DefaultText = "";
            this.textOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textOutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.textOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textOutput.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.textOutput.ForeColor = System.Drawing.Color.White;
            this.textOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textOutput.Location = new System.Drawing.Point(544, 33);
            this.textOutput.Margin = new System.Windows.Forms.Padding(5);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.PasswordChar = '\0';
            this.textOutput.PlaceholderText = "Translated Text...";
            this.textOutput.SelectedText = "";
            this.textOutput.Size = new System.Drawing.Size(480, 374);
            this.textOutput.TabIndex = 1;
            // 
            // cmbSourceLanguage
            // 
            this.cmbSourceLanguage.AutoRoundedCorners = true;
            this.cmbSourceLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbSourceLanguage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.cmbSourceLanguage.BorderRadius = 17;
            this.cmbSourceLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSourceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceLanguage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cmbSourceLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSourceLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSourceLanguage.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSourceLanguage.ForeColor = System.Drawing.Color.Silver;
            this.cmbSourceLanguage.ItemHeight = 30;
            this.cmbSourceLanguage.Location = new System.Drawing.Point(148, 428);
            this.cmbSourceLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSourceLanguage.Name = "cmbSourceLanguage";
            this.cmbSourceLanguage.Size = new System.Drawing.Size(225, 36);
            this.cmbSourceLanguage.TabIndex = 2;
            // 
            // cmbTargetLanguage
            // 
            this.cmbTargetLanguage.AutoRoundedCorners = true;
            this.cmbTargetLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbTargetLanguage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.cmbTargetLanguage.BorderRadius = 17;
            this.cmbTargetLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTargetLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetLanguage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cmbTargetLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetLanguage.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTargetLanguage.ForeColor = System.Drawing.Color.Silver;
            this.cmbTargetLanguage.ItemHeight = 30;
            this.cmbTargetLanguage.Location = new System.Drawing.Point(683, 428);
            this.cmbTargetLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTargetLanguage.Name = "cmbTargetLanguage";
            this.cmbTargetLanguage.Size = new System.Drawing.Size(225, 36);
            this.cmbTargetLanguage.TabIndex = 3;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Animated = true;
            this.btnTranslate.AutoRoundedCorners = true;
            this.btnTranslate.BorderRadius = 26;
            this.btnTranslate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTranslate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTranslate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTranslate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTranslate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTranslate.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.ForeColor = System.Drawing.Color.White;
            this.btnTranslate.Location = new System.Drawing.Point(409, 501);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(4);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(240, 55);
            this.btnTranslate.TabIndex = 4;
            this.btnTranslate.Text = "Translate!";
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Animated = true;
            this.btnHelp.AutoRoundedCorners = true;
            this.btnHelp.BorderRadius = 21;
            this.btnHelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHelp.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(943, 528);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(99, 44);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1057, 587);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.cmbTargetLanguage);
            this.Controls.Add(this.cmbSourceLanguage);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Translator | v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textInput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textOutput;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbSourceLanguage;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbTargetLanguage;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnTranslate;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnHelp;
    }
}

