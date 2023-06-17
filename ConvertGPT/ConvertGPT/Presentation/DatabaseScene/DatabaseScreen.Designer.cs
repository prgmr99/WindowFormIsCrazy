namespace ConvertGPT
{
    partial class DatabaseScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FileNameIabel = new System.Windows.Forms.Label();
            this.DBDiagramImg = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBDiagramImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(258, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 64);
            this.label1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.FileNameIabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DBDiagramImg, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.21622F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.78378F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 740);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // FileNameIabel
            // 
            this.FileNameIabel.AutoSize = true;
            this.FileNameIabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileNameIabel.Location = new System.Drawing.Point(3, 0);
            this.FileNameIabel.Name = "FileNameIabel";
            this.FileNameIabel.Size = new System.Drawing.Size(794, 83);
            this.FileNameIabel.TabIndex = 0;
            this.FileNameIabel.Text = "DB파일을 드래그 드랍하세요";
            this.FileNameIabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FileNameIabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // DBDiagramImg
            // 
            this.DBDiagramImg.Location = new System.Drawing.Point(3, 86);
            this.DBDiagramImg.Name = "DBDiagramImg";
            this.DBDiagramImg.Size = new System.Drawing.Size(794, 651);
            this.DBDiagramImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DBDiagramImg.TabIndex = 1;
            this.DBDiagramImg.TabStop = false;
            this.DBDiagramImg.Paint += new System.Windows.Forms.PaintEventHandler(this.DBDiagramImg_Paint);
            this.DBDiagramImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DBDiagramImg_MouseDown);
            this.DBDiagramImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DBDiagramImg_MouseMove);
            this.DBDiagramImg.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.DBDiagramImg_MouseWheel);
            // 
            // DatabaseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "DatabaseScreen";
            this.Size = new System.Drawing.Size(800, 740);
            this.Load += new System.EventHandler(this.DatabaseScreen_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DatabaseScreen_DragDropAsync);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DatabaseScreen_DragEnter);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBDiagramImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label FileNameIabel;
        private System.Windows.Forms.PictureBox DBDiagramImg;
    }
}
