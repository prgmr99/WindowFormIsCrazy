namespace ConvertGPT
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectLanguage = new MetroFramework.Controls.MetroComboBox();
            this.inputText = new MetroFramework.Controls.MetroTextBox();
            this.outputText = new MetroFramework.Controls.MetroTextBox();
            this.convertBtn = new MetroFramework.Controls.MetroButton();
            this.outputCopy = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // selectLanguage
            // 
            this.selectLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectLanguage.FormattingEnabled = true;
            this.selectLanguage.ItemHeight = 24;
            this.selectLanguage.Items.AddRange(new object[] {
            "C#",
            "Java",
            "Javascript",
            "Python"});
            this.selectLanguage.Location = new System.Drawing.Point(10, 71);
            this.selectLanguage.Name = "selectLanguage";
            this.selectLanguage.PromptText = "언어 선택";
            this.selectLanguage.Size = new System.Drawing.Size(880, 30);
            this.selectLanguage.Sorted = true;
            this.selectLanguage.TabIndex = 0;
            this.selectLanguage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.selectLanguage.UseSelectable = true;
            this.selectLanguage.SelectedIndexChanged += new System.EventHandler(this.selectLanguage_SelectedIndexChanged);
            // 
            // inputText
            // 
            this.inputText.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.inputText.CustomButton.Image = null;
            this.inputText.CustomButton.Location = new System.Drawing.Point(-39, 1);
            this.inputText.CustomButton.Name = "";
            this.inputText.CustomButton.Size = new System.Drawing.Size(473, 473);
            this.inputText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputText.CustomButton.TabIndex = 1;
            this.inputText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputText.CustomButton.UseSelectable = true;
            this.inputText.CustomButton.Visible = false;
            this.inputText.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.inputText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inputText.Lines = new string[0];
            this.inputText.Location = new System.Drawing.Point(10, 110);
            this.inputText.MaxLength = 32767;
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.PasswordChar = '\0';
            this.inputText.PromptText = "코드를 입력하세요.";
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputText.SelectedText = "";
            this.inputText.SelectionLength = 0;
            this.inputText.SelectionStart = 0;
            this.inputText.ShortcutsEnabled = true;
            this.inputText.Size = new System.Drawing.Size(435, 475);
            this.inputText.Style = MetroFramework.MetroColorStyle.Orange;
            this.inputText.TabIndex = 1;
            this.inputText.UseSelectable = true;
            this.inputText.WaterMark = "코드를 입력하세요.";
            this.inputText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.inputText.Click += new System.EventHandler(this.inputText_Click);
            // 
            // outputText
            // 
            this.outputText.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.outputText.CustomButton.Image = null;
            this.outputText.CustomButton.Location = new System.Drawing.Point(-39, 1);
            this.outputText.CustomButton.Name = "";
            this.outputText.CustomButton.Size = new System.Drawing.Size(473, 473);
            this.outputText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.outputText.CustomButton.TabIndex = 1;
            this.outputText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.outputText.CustomButton.UseSelectable = true;
            this.outputText.CustomButton.Visible = false;
            this.outputText.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.outputText.Lines = new string[0];
            this.outputText.Location = new System.Drawing.Point(455, 110);
            this.outputText.MaxLength = 32767;
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.PasswordChar = '\0';
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.SelectedText = "";
            this.outputText.SelectionLength = 0;
            this.outputText.SelectionStart = 0;
            this.outputText.ShortcutsEnabled = true;
            this.outputText.Size = new System.Drawing.Size(435, 475);
            this.outputText.Style = MetroFramework.MetroColorStyle.Orange;
            this.outputText.TabIndex = 2;
            this.outputText.UseSelectable = true;
            this.outputText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.outputText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.outputText.Click += new System.EventHandler(this.outputText_Click);
            // 
            // convertBtn
            // 
            this.convertBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.convertBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.convertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convertBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.convertBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.convertBtn.Location = new System.Drawing.Point(10, 600);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(435, 60);
            this.convertBtn.TabIndex = 3;
            this.convertBtn.Text = "변환";
            this.convertBtn.UseCustomBackColor = true;
            this.convertBtn.UseCustomForeColor = true;
            this.convertBtn.UseSelectable = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            this.convertBtn.MouseEnter += new System.EventHandler(this.convertBtn_MouseEnter);
            this.convertBtn.MouseLeave += new System.EventHandler(this.convertBtn_MouseLeave);
            // 
            // outputCopy
            // 
            this.outputCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputCopy.BackColor = System.Drawing.Color.DarkOrange;
            this.outputCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outputCopy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.outputCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputCopy.Location = new System.Drawing.Point(455, 600);
            this.outputCopy.Name = "outputCopy";
            this.outputCopy.Size = new System.Drawing.Size(435, 60);
            this.outputCopy.TabIndex = 4;
            this.outputCopy.Text = "Copy";
            this.outputCopy.UseCustomBackColor = true;
            this.outputCopy.UseCustomForeColor = true;
            this.outputCopy.UseSelectable = true;
            this.outputCopy.Click += new System.EventHandler(this.outputCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.Controls.Add(this.outputCopy);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.selectLanguage);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(22, 80, 22, 27);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "ConvertGPT";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox selectLanguage;
        private MetroFramework.Controls.MetroTextBox inputText;
        private MetroFramework.Controls.MetroTextBox outputText;
        private MetroFramework.Controls.MetroButton convertBtn;
        private MetroFramework.Controls.MetroButton outputCopy;
    }
}

