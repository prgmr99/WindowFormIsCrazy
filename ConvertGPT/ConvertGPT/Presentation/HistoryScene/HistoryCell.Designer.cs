namespace ConvertGPT
{
    partial class HistoryCell
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.idLabel = new System.Windows.Forms.Label();
            this.explainLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.1414F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.8586F));
            this.tableLayoutPanel1.Controls.Add(this.idLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.explainLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.languageLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idLabel.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(10, 10);
            this.idLabel.Margin = new System.Windows.Forms.Padding(10);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(60, 60);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "id";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.idLabel.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // explainLabel
            // 
            this.explainLabel.AutoSize = true;
            this.explainLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.explainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explainLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.explainLabel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explainLabel.ForeColor = System.Drawing.Color.White;
            this.explainLabel.Location = new System.Drawing.Point(258, 10);
            this.explainLabel.Margin = new System.Windows.Forms.Padding(10);
            this.explainLabel.Name = "explainLabel";
            this.explainLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.explainLabel.Size = new System.Drawing.Size(432, 60);
            this.explainLabel.TabIndex = 5;
            this.explainLabel.Text = "이 코드는 무슨 ";
            this.explainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.explainLabel.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.languageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.languageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.languageLabel.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.languageLabel.ForeColor = System.Drawing.Color.White;
            this.languageLabel.Location = new System.Drawing.Point(90, 10);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(10);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(148, 60);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.Text = "C → C++";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.languageLabel.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // HistoryCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HistoryCell";
            this.Size = new System.Drawing.Size(700, 80);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label explainLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label idLabel;
    }
}
