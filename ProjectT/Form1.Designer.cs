
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
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Animated = true;
            this.textInput.AutoRoundedCorners = true;
            this.textInput.AutoSize = true;
            this.textInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.textInput.BorderRadius = 214;
            this.textInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textInput.DefaultText = "";
            this.textInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.textInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textInput.ForeColor = System.Drawing.Color.White;
            this.textInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.Location = new System.Drawing.Point(17, 214);
            this.textInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.PasswordChar = '\0';
            this.textInput.PlaceholderText = "Type in here...";
            this.textInput.SelectedText = "";
            this.textInput.Size = new System.Drawing.Size(479, 430);
            this.textInput.TabIndex = 0;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // textOutput
            // 
            this.textOutput.Animated = true;
            this.textOutput.AutoRoundedCorners = true;
            this.textOutput.AutoSize = true;
            this.textOutput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.textOutput.BorderRadius = 214;
            this.textOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textOutput.DefaultText = "";
            this.textOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textOutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.textOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOutput.ForeColor = System.Drawing.Color.White;
            this.textOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textOutput.Location = new System.Drawing.Point(557, 214);
            this.textOutput.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.PasswordChar = '\0';
            this.textOutput.PlaceholderText = "Translated Text...";
            this.textOutput.SelectedText = "";
            this.textOutput.Size = new System.Drawing.Size(479, 430);
            this.textOutput.TabIndex = 1;
            this.textOutput.TextChanged += new System.EventHandler(this.textOutput_TextChanged);
            // 
            // cmbSourceLanguage
            // 
            this.cmbSourceLanguage.AutoRoundedCorners = true;
            this.cmbSourceLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbSourceLanguage.BorderRadius = 17;
            this.cmbSourceLanguage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cmbSourceLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSourceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceLanguage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cmbSourceLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSourceLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSourceLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSourceLanguage.ForeColor = System.Drawing.Color.Silver;
            this.cmbSourceLanguage.ItemHeight = 30;
            this.cmbSourceLanguage.Location = new System.Drawing.Point(187, 48);
            this.cmbSourceLanguage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbSourceLanguage.Name = "cmbSourceLanguage";
            this.cmbSourceLanguage.Size = new System.Drawing.Size(225, 36);
            this.cmbSourceLanguage.TabIndex = 2;
            this.cmbSourceLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbSourceLanguage_SelectedIndexChanged);
            // 
            // cmbTargetLanguage
            // 
            this.cmbTargetLanguage.AutoRoundedCorners = true;
            this.cmbTargetLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbTargetLanguage.BorderRadius = 17;
            this.cmbTargetLanguage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cmbTargetLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTargetLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetLanguage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cmbTargetLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTargetLanguage.ForeColor = System.Drawing.Color.Silver;
            this.cmbTargetLanguage.ItemHeight = 30;
            this.cmbTargetLanguage.Location = new System.Drawing.Point(635, 48);
            this.cmbTargetLanguage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbTargetLanguage.Name = "cmbTargetLanguage";
            this.cmbTargetLanguage.Size = new System.Drawing.Size(225, 36);
            this.cmbTargetLanguage.TabIndex = 3;
            this.cmbTargetLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbTargetLanguage_SelectedIndexChanged);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Animated = true;
            this.btnTranslate.AutoRoundedCorners = true;
            this.btnTranslate.BorderRadius = 30;
            this.btnTranslate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTranslate.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnTranslate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTranslate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTranslate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTranslate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTranslate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTranslate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.btnTranslate.FillColor2 = System.Drawing.Color.MediumPurple;
            this.btnTranslate.FocusedColor = System.Drawing.Color.Transparent;
            this.btnTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnTranslate.ForeColor = System.Drawing.Color.White;
            this.btnTranslate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnTranslate.Location = new System.Drawing.Point(407, 127);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(240, 62);
            this.btnTranslate.TabIndex = 4;
            this.btnTranslate.Text = "Translate!";
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Animated = true;
            this.btnHelp.AutoRoundedCorners = true;
            this.btnHelp.BorderColor = System.Drawing.Color.Red;
            this.btnHelp.BorderRadius = 20;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHelp.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnHelp.FillColor2 = System.Drawing.Color.LightSteelBlue;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(19, 19);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(43, 44);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "?";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticonePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = global::ModernTranslatorTutorial.Properties.Resources.icons8_данные_в_обоих_направлениях_50;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(499, 48);
            this.siticonePictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(63, 50);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 6;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.Click += new System.EventHandler(this.siticonePictureBox1_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cmbTargetLanguage);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.siticonePictureBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnTranslate);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cmbSourceLanguage);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnHelp);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1051, 204);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(-3, -2);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1051, 204);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1047, 664);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(399, 329);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textInput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textOutput;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbSourceLanguage;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbTargetLanguage;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnTranslate;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnHelp;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

