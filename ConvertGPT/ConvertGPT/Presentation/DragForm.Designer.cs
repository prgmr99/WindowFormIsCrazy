namespace ConvertGPT
{
    partial class DragForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragForm));
            this.panel = new System.Windows.Forms.Panel();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.historyButton = new System.Windows.Forms.Button();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.convertDBButton = new System.Windows.Forms.Button();
            this.convertCodeButton = new System.Windows.Forms.Button();
            this.timerSliding = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bottomCheckBox = new System.Windows.Forms.CheckBox();
            this.slidePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.LightGray;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel.Location = new System.Drawing.Point(202, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(795, 734);
            this.panel.TabIndex = 2;
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.slidePanel.Controls.Add(this.bottomCheckBox);
            this.slidePanel.Controls.Add(this.historyButton);
            this.slidePanel.Controls.Add(this.favoriteButton);
            this.slidePanel.Controls.Add(this.convertDBButton);
            this.slidePanel.Controls.Add(this.convertCodeButton);
            this.slidePanel.Location = new System.Drawing.Point(3, 3);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(193, 734);
            this.slidePanel.TabIndex = 3;
            // 
            // historyButton
            // 
            this.historyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.historyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Location = new System.Drawing.Point(0, 150);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(193, 50);
            this.historyButton.TabIndex = 2;
            this.historyButton.Text = "기록";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // favoriteButton
            // 
            this.favoriteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.favoriteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.favoriteButton.FlatAppearance.BorderSize = 0;
            this.favoriteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.favoriteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.favoriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoriteButton.ForeColor = System.Drawing.Color.White;
            this.favoriteButton.Location = new System.Drawing.Point(0, 100);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(193, 50);
            this.favoriteButton.TabIndex = 1;
            this.favoriteButton.Text = "즐겨찾기";
            this.favoriteButton.UseVisualStyleBackColor = true;
            this.favoriteButton.Click += new System.EventHandler(this.favoriteButton_Click);
            // 
            // convertDBButton
            // 
            this.convertDBButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.convertDBButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertDBButton.FlatAppearance.BorderSize = 0;
            this.convertDBButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.convertDBButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.convertDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertDBButton.ForeColor = System.Drawing.Color.White;
            this.convertDBButton.Location = new System.Drawing.Point(0, 50);
            this.convertDBButton.Name = "convertDBButton";
            this.convertDBButton.Size = new System.Drawing.Size(193, 50);
            this.convertDBButton.TabIndex = 3;
            this.convertDBButton.Text = "DB 변환";
            this.convertDBButton.UseVisualStyleBackColor = true;
            this.convertDBButton.Click += new System.EventHandler(this.convertDBButton_Click);
            // 
            // convertCodeButton
            // 
            this.convertCodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.convertCodeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertCodeButton.FlatAppearance.BorderSize = 0;
            this.convertCodeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.convertCodeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.convertCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertCodeButton.ForeColor = System.Drawing.Color.White;
            this.convertCodeButton.Location = new System.Drawing.Point(0, 0);
            this.convertCodeButton.Name = "convertCodeButton";
            this.convertCodeButton.Size = new System.Drawing.Size(193, 50);
            this.convertCodeButton.TabIndex = 0;
            this.convertCodeButton.Text = "코드 변환";
            this.convertCodeButton.UseVisualStyleBackColor = true;
            this.convertCodeButton.Click += new System.EventHandler(this.convertCodeButton_Click);
            // 
            // timerSliding
            // 
            this.timerSliding.Interval = 10;
            this.timerSliding.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.1F));
            this.tableLayoutPanel1.Controls.Add(this.slidePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 740);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // bottomCheckBox
            // 
            this.bottomCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.bottomCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomCheckBox.FlatAppearance.BorderSize = 0;
            this.bottomCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bottomCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bottomCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomCheckBox.ForeColor = System.Drawing.Color.White;
            this.bottomCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("bottomCheckBox.Image")));
            this.bottomCheckBox.Location = new System.Drawing.Point(0, 684);
            this.bottomCheckBox.Name = "bottomCheckBox";
            this.bottomCheckBox.Size = new System.Drawing.Size(193, 50);
            this.bottomCheckBox.TabIndex = 4;
            this.bottomCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomCheckBox.UseVisualStyleBackColor = true;
            this.bottomCheckBox.CheckedChanged += new System.EventHandler(this.bottomCheckBox_CheckedChanged);
            // 
            // DragForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DragForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Load += new System.EventHandler(this.DragForm_Load);
            this.slidePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Button convertCodeButton;
        private System.Windows.Forms.Button convertDBButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button favoriteButton;
        private System.Windows.Forms.CheckBox bottomCheckBox;
        private System.Windows.Forms.Timer timerSliding;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}