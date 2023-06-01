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
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(0, 60);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1000, 740);
            this.panel.TabIndex = 2;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // DragForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.panel);
            this.Name = "DragForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "DragForm";
            this.Load += new System.EventHandler(this.DragForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragForm_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.DragForm_DragOver);
            this.DragLeave += new System.EventHandler(this.DragForm_DragLeave);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.DragForm_GiveFeedback);
            this.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.DragForm_QueryContinueDrag);
            this.Resize += new System.EventHandler(this.DragForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel panel;
    }
}