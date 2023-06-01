 namespace ConvertGPT.MainScene
{
    partial class LanguageForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pythonButton = new System.Windows.Forms.Button();
            this.swiftButton = new System.Windows.Forms.Button();
            this.javaScriptButton = new System.Windows.Forms.Button();
            this.javaButton = new System.Windows.Forms.Button();
            this.cSharpButton = new System.Windows.Forms.Button();
            this.cppButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(212, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(279, 30);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "변환할 언어를 선택해주세요";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pythonButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.swiftButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.javaScriptButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.javaButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cSharpButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cppButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 175);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(525, 90);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(169, 82);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(351, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 82);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // pythonButton
            // 
            this.pythonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pythonButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pythonButton.FlatAppearance.BorderSize = 0;
            this.pythonButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pythonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pythonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pythonButton.ForeColor = System.Drawing.Color.White;
            this.pythonButton.Location = new System.Drawing.Point(177, 90);
            this.pythonButton.Name = "pythonButton";
            this.pythonButton.Size = new System.Drawing.Size(168, 82);
            this.pythonButton.TabIndex = 5;
            this.pythonButton.Text = "Python";
            this.pythonButton.UseVisualStyleBackColor = false;
            this.pythonButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // swiftButton
            // 
            this.swiftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.swiftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swiftButton.FlatAppearance.BorderSize = 0;
            this.swiftButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.swiftButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.swiftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swiftButton.ForeColor = System.Drawing.Color.White;
            this.swiftButton.Location = new System.Drawing.Point(3, 90);
            this.swiftButton.Name = "swiftButton";
            this.swiftButton.Size = new System.Drawing.Size(168, 82);
            this.swiftButton.TabIndex = 4;
            this.swiftButton.Text = "Swift";
            this.swiftButton.UseVisualStyleBackColor = false;
            this.swiftButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // javaScriptButton
            // 
            this.javaScriptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.javaScriptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.javaScriptButton.FlatAppearance.BorderSize = 0;
            this.javaScriptButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.javaScriptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.javaScriptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.javaScriptButton.ForeColor = System.Drawing.Color.White;
            this.javaScriptButton.Location = new System.Drawing.Point(525, 3);
            this.javaScriptButton.Name = "javaScriptButton";
            this.javaScriptButton.Size = new System.Drawing.Size(169, 81);
            this.javaScriptButton.TabIndex = 3;
            this.javaScriptButton.Text = "JavaScript";
            this.javaScriptButton.UseVisualStyleBackColor = false;
            this.javaScriptButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // javaButton
            // 
            this.javaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.javaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.javaButton.FlatAppearance.BorderSize = 0;
            this.javaButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.javaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.javaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.javaButton.ForeColor = System.Drawing.Color.White;
            this.javaButton.Location = new System.Drawing.Point(351, 3);
            this.javaButton.Name = "javaButton";
            this.javaButton.Size = new System.Drawing.Size(168, 81);
            this.javaButton.TabIndex = 2;
            this.javaButton.Text = "Java";
            this.javaButton.UseVisualStyleBackColor = false;
            this.javaButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // cSharpButton
            // 
            this.cSharpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cSharpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cSharpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cSharpButton.FlatAppearance.BorderSize = 0;
            this.cSharpButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cSharpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cSharpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cSharpButton.ForeColor = System.Drawing.Color.White;
            this.cSharpButton.Location = new System.Drawing.Point(177, 3);
            this.cSharpButton.Name = "cSharpButton";
            this.cSharpButton.Size = new System.Drawing.Size(168, 81);
            this.cSharpButton.TabIndex = 1;
            this.cSharpButton.Text = "C#";
            this.cSharpButton.UseVisualStyleBackColor = false;
            this.cSharpButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // cppButton
            // 
            this.cppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cppButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cppButton.FlatAppearance.BorderSize = 0;
            this.cppButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cppButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cppButton.ForeColor = System.Drawing.Color.White;
            this.cppButton.Location = new System.Drawing.Point(3, 3);
            this.cppButton.Name = "cppButton";
            this.cppButton.Size = new System.Drawing.Size(168, 81);
            this.cppButton.TabIndex = 0;
            this.cppButton.Text = "C++";
            this.cppButton.UseVisualStyleBackColor = false;
            this.cppButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(703, 241);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 301);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "LanguageForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button pythonButton;
        private System.Windows.Forms.Button swiftButton;
        private System.Windows.Forms.Button javaScriptButton;
        private System.Windows.Forms.Button javaButton;
        private System.Windows.Forms.Button cSharpButton;
        private System.Windows.Forms.Button cppButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}