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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(232, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(242, 30);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "아래 언어로 변환할게요.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.47899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.52101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pythonButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.swiftButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.javaScriptButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.javaButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cSharpButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cppButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(112, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 162);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(367, 84);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 75);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(240, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 75);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // pythonButton
            // 
            this.pythonButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pythonButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pythonButton.Location = new System.Drawing.Point(115, 84);
            this.pythonButton.Name = "pythonButton";
            this.pythonButton.Size = new System.Drawing.Size(119, 75);
            this.pythonButton.TabIndex = 5;
            this.pythonButton.Text = "Python";
            this.pythonButton.UseVisualStyleBackColor = false;
            this.pythonButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // swiftButton
            // 
            this.swiftButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.swiftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swiftButton.Location = new System.Drawing.Point(3, 84);
            this.swiftButton.Name = "swiftButton";
            this.swiftButton.Size = new System.Drawing.Size(106, 75);
            this.swiftButton.TabIndex = 4;
            this.swiftButton.Text = "Swift";
            this.swiftButton.UseVisualStyleBackColor = false;
            this.swiftButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // javaScriptButton
            // 
            this.javaScriptButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.javaScriptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.javaScriptButton.Location = new System.Drawing.Point(367, 3);
            this.javaScriptButton.Name = "javaScriptButton";
            this.javaScriptButton.Size = new System.Drawing.Size(109, 75);
            this.javaScriptButton.TabIndex = 3;
            this.javaScriptButton.Text = "JavaScript";
            this.javaScriptButton.UseVisualStyleBackColor = false;
            this.javaScriptButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // javaButton
            // 
            this.javaButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.javaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.javaButton.Location = new System.Drawing.Point(240, 3);
            this.javaButton.Name = "javaButton";
            this.javaButton.Size = new System.Drawing.Size(121, 75);
            this.javaButton.TabIndex = 2;
            this.javaButton.Text = "Java";
            this.javaButton.UseVisualStyleBackColor = false;
            this.javaButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // cSharpButton
            // 
            this.cSharpButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cSharpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cSharpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cSharpButton.Location = new System.Drawing.Point(115, 3);
            this.cSharpButton.Name = "cSharpButton";
            this.cSharpButton.Size = new System.Drawing.Size(119, 75);
            this.cSharpButton.TabIndex = 1;
            this.cSharpButton.Text = "C#";
            this.cSharpButton.UseVisualStyleBackColor = false;
            this.cSharpButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // cppButton
            // 
            this.cppButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cppButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cppButton.Location = new System.Drawing.Point(3, 3);
            this.cppButton.Name = "cppButton";
            this.cppButton.Size = new System.Drawing.Size(106, 75);
            this.cppButton.TabIndex = 0;
            this.cppButton.Text = "C++";
            this.cppButton.UseVisualStyleBackColor = false;
            this.cppButton.Click += new System.EventHandler(this.languageButton_Clicked);
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 301);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LanguageForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}