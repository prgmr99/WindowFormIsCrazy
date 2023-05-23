namespace ConvertGPT
{
    partial class MainForm
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
            this.selectLanguageComboBox = new MetroFramework.Controls.MetroComboBox();
            this.inputTextBox = new MetroFramework.Controls.MetroTextBox();
            this.outputTextBox = new MetroFramework.Controls.MetroTextBox();
            this.convertBtn = new MetroFramework.Controls.MetroButton();
            this.CopyBtn = new MetroFramework.Controls.MetroButton();
            this.lblDB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectLanguageComboBox
            // 
            this.selectLanguageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectLanguageComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectLanguageComboBox.FormattingEnabled = true;
            this.selectLanguageComboBox.ItemHeight = 23;
            this.selectLanguageComboBox.Items.AddRange(new object[] {
            "C#",
            "Java",
            "Javascript",
            "Python"});
            this.selectLanguageComboBox.Location = new System.Drawing.Point(10, 71);
            this.selectLanguageComboBox.Name = "selectLanguageComboBox";
            this.selectLanguageComboBox.PromptText = "언어 선택";
            this.selectLanguageComboBox.Size = new System.Drawing.Size(880, 29);
            this.selectLanguageComboBox.Sorted = true;
            this.selectLanguageComboBox.TabIndex = 0;
            this.selectLanguageComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.selectLanguageComboBox.UseSelectable = true;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.inputTextBox.CustomButton.Image = null;
            this.inputTextBox.CustomButton.Location = new System.Drawing.Point(-39, 1);
            this.inputTextBox.CustomButton.Name = "";
            this.inputTextBox.CustomButton.Size = new System.Drawing.Size(473, 473);
            this.inputTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputTextBox.CustomButton.TabIndex = 1;
            this.inputTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputTextBox.CustomButton.UseSelectable = true;
            this.inputTextBox.CustomButton.Visible = false;
            this.inputTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.inputTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inputTextBox.Lines = new string[0];
            this.inputTextBox.Location = new System.Drawing.Point(10, 110);
            this.inputTextBox.MaxLength = 32767;
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.PasswordChar = '\0';
            this.inputTextBox.PromptText = "코드를 입력하세요.";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.SelectedText = "";
            this.inputTextBox.SelectionLength = 0;
            this.inputTextBox.SelectionStart = 0;
            this.inputTextBox.ShortcutsEnabled = true;
            this.inputTextBox.Size = new System.Drawing.Size(435, 475);
            this.inputTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.UseSelectable = true;
            this.inputTextBox.WaterMark = "코드를 입력하세요.";
            this.inputTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.inputTextBox.Click += new System.EventHandler(this.convertBtn_MouseEnter);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.outputTextBox.CustomButton.Image = null;
            this.outputTextBox.CustomButton.Location = new System.Drawing.Point(-39, 1);
            this.outputTextBox.CustomButton.Name = "";
            this.outputTextBox.CustomButton.Size = new System.Drawing.Size(473, 473);
            this.outputTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.outputTextBox.CustomButton.TabIndex = 1;
            this.outputTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.outputTextBox.CustomButton.UseSelectable = true;
            this.outputTextBox.CustomButton.Visible = false;
            this.outputTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.outputTextBox.Lines = new string[0];
            this.outputTextBox.Location = new System.Drawing.Point(455, 110);
            this.outputTextBox.MaxLength = 32767;
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.PasswordChar = '\0';
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.SelectedText = "";
            this.outputTextBox.SelectionLength = 0;
            this.outputTextBox.SelectionStart = 0;
            this.outputTextBox.ShortcutsEnabled = true;
            this.outputTextBox.Size = new System.Drawing.Size(435, 475);
            this.outputTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.UseSelectable = true;
            this.outputTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.outputTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // convertBtn
            // 
            this.convertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            // CopyBtn
            // 
            this.CopyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.CopyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.CopyBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CopyBtn.Location = new System.Drawing.Point(455, 600);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(435, 60);
            this.CopyBtn.TabIndex = 4;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.UseCustomBackColor = true;
            this.CopyBtn.UseCustomForeColor = true;
            this.CopyBtn.UseSelectable = true;
            // 
<<<<<<< HEAD
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(815, 30);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(40, 15);
            this.lblDB.TabIndex = 5;
            this.lblDB.Text = "Server";
            // 
=======
>>>>>>> main
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.selectLanguageComboBox);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(22, 80, 22, 27);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "ConvertGPT";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.MainForm_Load);
=======
            this.Resize += new System.EventHandler(this.MainForm_Resize);
>>>>>>> main
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox selectLanguageComboBox;
        private MetroFramework.Controls.MetroTextBox inputTextBox;
        private MetroFramework.Controls.MetroTextBox outputTextBox;
        private MetroFramework.Controls.MetroButton convertBtn;
        private MetroFramework.Controls.MetroButton CopyBtn;
        private System.Windows.Forms.Label lblDB;
    }
}

