namespace DigitalLibraryManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnDocGia = new Button();
            btnDauSach = new Button();
            btnNXB = new Button();
            btnTacGia = new Button();
            dataGridView1 = new DataGridView();
            btnTheLoai = new Button();
            btnLichSu = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnLichSu);
            splitContainer1.Panel1.Controls.Add(btnTheLoai);
            splitContainer1.Panel1.Controls.Add(btnDocGia);
            splitContainer1.Panel1.Controls.Add(btnDauSach);
            splitContainer1.Panel1.Controls.Add(btnNXB);
            splitContainer1.Panel1.Controls.Add(btnTacGia);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnDocGia
            // 
            btnDocGia.Location = new Point(45, 68);
            btnDocGia.Name = "btnDocGia";
            btnDocGia.Size = new Size(169, 50);
            btnDocGia.TabIndex = 3;
            btnDocGia.Text = "Độc giả";
            btnDocGia.UseVisualStyleBackColor = true;
            // 
            // btnDauSach
            // 
            btnDauSach.Location = new Point(45, 124);
            btnDauSach.Name = "btnDauSach";
            btnDauSach.Size = new Size(169, 50);
            btnDauSach.TabIndex = 2;
            btnDauSach.Text = "Đầu sách";
            btnDauSach.UseVisualStyleBackColor = true;
            // 
            // btnNXB
            // 
            btnNXB.Location = new Point(45, 180);
            btnNXB.Name = "btnNXB";
            btnNXB.Size = new Size(169, 50);
            btnNXB.TabIndex = 1;
            btnNXB.Text = "Nhà xuất bản";
            btnNXB.UseVisualStyleBackColor = true;
            // 
            // btnTacGia
            // 
            btnTacGia.Location = new Point(45, 12);
            btnTacGia.Name = "btnTacGia";
            btnTacGia.Size = new Size(169, 50);
            btnTacGia.TabIndex = 0;
            btnTacGia.Text = "Tác giả";
            btnTacGia.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(524, 444);
            dataGridView1.TabIndex = 0;
            // 
            // btnTheLoai
            // 
            btnTheLoai.Location = new Point(45, 236);
            btnTheLoai.Name = "btnTheLoai";
            btnTheLoai.Size = new Size(169, 50);
            btnTheLoai.TabIndex = 4;
            btnTheLoai.Text = "Thể loại";
            btnTheLoai.UseVisualStyleBackColor = true;
            // 
            // btnLichSu
            // 
            btnLichSu.Location = new Point(45, 292);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.Size = new Size(169, 50);
            btnLichSu.TabIndex = 5;
            btnLichSu.Text = "Lịch sử";
            btnLichSu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnDocGia;
        private Button btnDauSach;
        private Button btnNXB;
        private Button btnTacGia;
        private DataGridView dataGridView1;
        private Button btnLichSu;
        private Button btnTheLoai;
    }
}
