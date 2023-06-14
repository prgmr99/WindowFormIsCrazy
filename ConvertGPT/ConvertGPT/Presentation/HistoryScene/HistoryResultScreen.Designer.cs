namespace ConvertGPT
{
    partial class HistoryResultScreen
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
            this.explainResultTextBox = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.convertResultTextBox = new ScintillaNET.Scintilla();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // explainResultTextBox
            // 
            // 
            // 
            // 
            this.explainResultTextBox.CustomButton.Image = null;
            this.explainResultTextBox.CustomButton.Location = new System.Drawing.Point(-194, 1);
            this.explainResultTextBox.CustomButton.Name = "";
            this.explainResultTextBox.CustomButton.Size = new System.Drawing.Size(693, 693);
            this.explainResultTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.explainResultTextBox.CustomButton.TabIndex = 1;
            this.explainResultTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.explainResultTextBox.CustomButton.UseSelectable = true;
            this.explainResultTextBox.CustomButton.Visible = false;
            this.explainResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explainResultTextBox.Lines = new string[0];
            this.explainResultTextBox.Location = new System.Drawing.Point(500, 45);
            this.explainResultTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.explainResultTextBox.MaxLength = 32767;
            this.explainResultTextBox.Multiline = true;
            this.explainResultTextBox.Name = "explainResultTextBox";
            this.explainResultTextBox.PasswordChar = '\0';
            this.explainResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.explainResultTextBox.SelectedText = "";
            this.explainResultTextBox.SelectionLength = 0;
            this.explainResultTextBox.SelectionStart = 0;
            this.explainResultTextBox.ShortcutsEnabled = true;
            this.explainResultTextBox.Size = new System.Drawing.Size(500, 695);
            this.explainResultTextBox.TabIndex = 3;
            this.explainResultTextBox.UseSelectable = true;
            this.explainResultTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.explainResultTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.explainResultTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.convertResultTextBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 740);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.Controls.Add(this.backButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCopy, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.languageLabel, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(500, 45);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.DimGray;
            this.btnCopy.BackgroundImage = global::ConvertGPT.Properties.Resources.icon_copy;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(455, 0);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(45, 45);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.BackColor = System.Drawing.Color.DimGray;
            this.languageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.languageLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.languageLabel.ForeColor = System.Drawing.Color.White;
            this.languageLabel.Location = new System.Drawing.Point(48, 0);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(404, 45);
            this.languageLabel.TabIndex = 1;
            this.languageLabel.Text = "Language";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertResultTextBox
            // 
            this.convertResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.convertResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertResultTextBox.HScrollBar = false;
            this.convertResultTextBox.Location = new System.Drawing.Point(3, 47);
            this.convertResultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.convertResultTextBox.Margins.Capacity = 0;
            this.convertResultTextBox.Name = "convertResultTextBox";
            this.convertResultTextBox.ScrollWidth = 1000;
            this.convertResultTextBox.Size = new System.Drawing.Size(494, 691);
            this.convertResultTextBox.TabIndex = 4;
            this.convertResultTextBox.WrapMode = ScintillaNET.WrapMode.Word;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1000, 740);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DimGray;
            this.backButton.BackgroundImage = global::ConvertGPT.Properties.Resources.icon_left;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 45);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // HistoryResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "HistoryResultScreen";
            this.Size = new System.Drawing.Size(1000, 740);
            this.Load += new System.EventHandler(this.ResultScene_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox explainResultTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label label2;
        private ScintillaNET.Scintilla convertResultTextBox;
        private System.Windows.Forms.Button backButton;
    }
}
