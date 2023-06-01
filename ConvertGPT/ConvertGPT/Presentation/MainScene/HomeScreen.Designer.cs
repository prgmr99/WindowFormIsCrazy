namespace ConvertGPT.MainScene
{

    partial class HomeScreen
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextButton = new System.Windows.Forms.Button();
            this.inputTextBox = new MetroFramework.Controls.MetroTextBox();
            this.explainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.nextButton.FlatAppearance.BorderSize = 4;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.nextButton.Location = new System.Drawing.Point(20, 630);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(605, 95);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "코드 변환하기";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.AllowDrop = true;
            // 
            // 
            // 
            this.inputTextBox.CustomButton.Image = null;
            this.inputTextBox.CustomButton.Location = new System.Drawing.Point(-5, 2);
            this.inputTextBox.CustomButton.Name = "";
            this.inputTextBox.CustomButton.Size = new System.Drawing.Size(607, 607);
            this.inputTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputTextBox.CustomButton.TabIndex = 1;
            this.inputTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputTextBox.CustomButton.UseSelectable = true;
            this.inputTextBox.CustomButton.Visible = false;
            this.inputTextBox.Lines = new string[0];
            this.inputTextBox.Location = new System.Drawing.Point(20, 12);
            this.inputTextBox.MaxLength = 32767;
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.PasswordChar = '\0';
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.SelectedText = "";
            this.inputTextBox.SelectionLength = 0;
            this.inputTextBox.SelectionStart = 0;
            this.inputTextBox.ShortcutsEnabled = true;
            this.inputTextBox.Size = new System.Drawing.Size(605, 612);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.UseSelectable = true;
            this.inputTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // explainLabel
            // 
            this.explainLabel.AllowDrop = true;
            this.explainLabel.AutoSize = true;
            this.explainLabel.BackColor = System.Drawing.Color.White;
            this.explainLabel.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explainLabel.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.explainLabel.Location = new System.Drawing.Point(677, 278);
            this.explainLabel.Margin = new System.Windows.Forms.Padding(0);
            this.explainLabel.Name = "explainLabel";
            this.explainLabel.Size = new System.Drawing.Size(246, 96);
            this.explainLabel.TabIndex = 0;
            this.explainLabel.Text = "코드 붙혀넣거나\r\n파일을 드래그 하세요\r\n\r\n";
            this.explainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(675, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "언어: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.explainLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(1000, 740);
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.HomeScreen_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.HomeScreen_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.HomeScreen_DragOver);
            this.DragLeave += new System.EventHandler(this.HomeScreen_DragLeave);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.HomeScreen_GiveFeedback);
            this.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.HomeScreen_QueryContinueDrag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private MetroFramework.Controls.MetroTextBox inputTextBox;
        private System.Windows.Forms.Label explainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
