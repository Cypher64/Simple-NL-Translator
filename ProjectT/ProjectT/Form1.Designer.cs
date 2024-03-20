namespace ProjectT
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
            this.cmbSourceLanguage = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.textInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnTranslate = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.textOutput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cmbTargetLanguage = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.SuspendLayout();
            // 
            // cmbSourceLanguage
            // 
            this.cmbSourceLanguage.AutoRoundedCorners = true;
            this.cmbSourceLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbSourceLanguage.BorderRadius = 17;
            this.cmbSourceLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSourceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceLanguage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cmbSourceLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSourceLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSourceLanguage.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbSourceLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSourceLanguage.ItemHeight = 30;
            this.cmbSourceLanguage.Location = new System.Drawing.Point(78, 283);
            this.cmbSourceLanguage.Name = "cmbSourceLanguage";
            this.cmbSourceLanguage.Size = new System.Drawing.Size(222, 36);
            this.cmbSourceLanguage.TabIndex = 1;
            this.cmbSourceLanguage.UseWaitCursor = true;
            this.cmbSourceLanguage.SelectedIndexChanged += new System.EventHandler(this.siticoneComboBox2_SelectedIndexChanged);
            // 
            // textInput
            // 
            this.textInput.Animated = true;
            this.textInput.BorderRadius = 20;
            this.textInput.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textInput.DefaultText = "";
            this.textInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.textInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.textInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.Location = new System.Drawing.Point(31, 41);
            this.textInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.PasswordChar = '\0';
            this.textInput.PlaceholderText = "Type in here...";
            this.textInput.SelectedText = "";
            this.textInput.Size = new System.Drawing.Size(333, 213);
            this.textInput.TabIndex = 2;
            this.textInput.UseWaitCursor = true;
            this.textInput.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Animated = true;
            this.btnTranslate.AutoRoundedCorners = true;
            this.btnTranslate.BackColor = System.Drawing.Color.Transparent;
            this.btnTranslate.BorderRadius = 30;
            this.btnTranslate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTranslate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTranslate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTranslate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTranslate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTranslate.FillColor = System.Drawing.Color.Black;
            this.btnTranslate.FillColor2 = System.Drawing.Color.Maroon;
            this.btnTranslate.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.btnTranslate.ForeColor = System.Drawing.Color.White;
            this.btnTranslate.Location = new System.Drawing.Point(315, 353);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(157, 62);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "Translate!";
            this.btnTranslate.UseWaitCursor = true;
            this.btnTranslate.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // textOutput
            // 
            this.textOutput.Animated = true;
            this.textOutput.BorderRadius = 20;
            this.textOutput.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textOutput.DefaultText = "";
            this.textOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textOutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.textOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textOutput.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.textOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textOutput.Location = new System.Drawing.Point(437, 41);
            this.textOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.PasswordChar = '\0';
            this.textOutput.PlaceholderText = "Translated text...";
            this.textOutput.SelectedText = "";
            this.textOutput.Size = new System.Drawing.Size(333, 213);
            this.textOutput.TabIndex = 4;
            this.textOutput.UseWaitCursor = true;
            // 
            // cmbTargetLanguage
            // 
            this.cmbTargetLanguage.AutoRoundedCorners = true;
            this.cmbTargetLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbTargetLanguage.BorderRadius = 17;
            this.cmbTargetLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTargetLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetLanguage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cmbTargetLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetLanguage.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbTargetLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTargetLanguage.ItemHeight = 30;
            this.cmbTargetLanguage.Location = new System.Drawing.Point(487, 283);
            this.cmbTargetLanguage.Name = "cmbTargetLanguage";
            this.cmbTargetLanguage.Size = new System.Drawing.Size(222, 36);
            this.cmbTargetLanguage.TabIndex = 5;
            this.cmbTargetLanguage.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(875, 449);
            this.Controls.Add(this.cmbTargetLanguage);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.cmbSourceLanguage);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbSourceLanguage;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textInput;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnTranslate;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textOutput;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbTargetLanguage;
    }
}

