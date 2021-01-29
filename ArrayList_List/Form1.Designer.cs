
namespace Study_List
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbox4 = new System.Windows.Forms.PictureBox();
            this.pbox3 = new System.Windows.Forms.PictureBox();
            this.pbox2 = new System.Windows.Forms.PictureBox();
            this.lblPick4 = new System.Windows.Forms.Label();
            this.lblPick3 = new System.Windows.Forms.Label();
            this.lblPick2 = new System.Windows.Forms.Label();
            this.lblPick1 = new System.Windows.Forms.Label();
            this.pbox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgViewList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "※ 선호하는 항목을 선택해 주세요.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pbox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPick4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.47369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 203);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pbox4
            // 
            this.pbox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox4.Image = global::ArrayList_List.Properties.Resources._4;
            this.pbox4.Location = new System.Drawing.Point(474, 3);
            this.pbox4.Name = "pbox4";
            this.pbox4.Size = new System.Drawing.Size(153, 175);
            this.pbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox4.TabIndex = 11;
            this.pbox4.TabStop = false;
            this.pbox4.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox3
            // 
            this.pbox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox3.Image = global::ArrayList_List.Properties.Resources._3;
            this.pbox3.Location = new System.Drawing.Point(317, 3);
            this.pbox3.Name = "pbox3";
            this.pbox3.Size = new System.Drawing.Size(151, 175);
            this.pbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox3.TabIndex = 10;
            this.pbox3.TabStop = false;
            this.pbox3.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox2
            // 
            this.pbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox2.Image = global::ArrayList_List.Properties.Resources._2;
            this.pbox2.Location = new System.Drawing.Point(160, 3);
            this.pbox2.Name = "pbox2";
            this.pbox2.Size = new System.Drawing.Size(151, 175);
            this.pbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox2.TabIndex = 9;
            this.pbox2.TabStop = false;
            this.pbox2.Click += new System.EventHandler(this.pbox_Click);
            // 
            // lblPick4
            // 
            this.lblPick4.AutoSize = true;
            this.lblPick4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPick4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick4.Location = new System.Drawing.Point(474, 181);
            this.lblPick4.Name = "lblPick4";
            this.lblPick4.Size = new System.Drawing.Size(153, 22);
            this.lblPick4.TabIndex = 7;
            this.lblPick4.Text = "0";
            this.lblPick4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick3
            // 
            this.lblPick3.AutoSize = true;
            this.lblPick3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPick3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick3.Location = new System.Drawing.Point(317, 181);
            this.lblPick3.Name = "lblPick3";
            this.lblPick3.Size = new System.Drawing.Size(151, 22);
            this.lblPick3.TabIndex = 6;
            this.lblPick3.Text = "0";
            this.lblPick3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick2
            // 
            this.lblPick2.AutoSize = true;
            this.lblPick2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPick2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick2.Location = new System.Drawing.Point(160, 181);
            this.lblPick2.Name = "lblPick2";
            this.lblPick2.Size = new System.Drawing.Size(151, 22);
            this.lblPick2.TabIndex = 5;
            this.lblPick2.Text = "0";
            this.lblPick2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick1
            // 
            this.lblPick1.AutoSize = true;
            this.lblPick1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPick1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick1.Location = new System.Drawing.Point(3, 181);
            this.lblPick1.Name = "lblPick1";
            this.lblPick1.Size = new System.Drawing.Size(151, 22);
            this.lblPick1.TabIndex = 4;
            this.lblPick1.Text = "0";
            this.lblPick1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbox1
            // 
            this.pbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox1.Image = global::ArrayList_List.Properties.Resources._1;
            this.pbox1.Location = new System.Drawing.Point(3, 3);
            this.pbox1.Name = "pbox1";
            this.pbox1.Size = new System.Drawing.Size(151, 175);
            this.pbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox1.TabIndex = 8;
            this.pbox1.TabStop = false;
            this.pbox1.Click += new System.EventHandler(this.pbox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Count:";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(101, 265);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(15, 15);
            this.lblTotalCount.TabIndex = 8;
            this.lblTotalCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "※ List의 Data를 화면에 보여줍니다.";
            // 
            // dgViewList
            // 
            this.dgViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewList.Location = new System.Drawing.Point(172, 325);
            this.dgViewList.Name = "dgViewList";
            this.dgViewList.RowHeadersWidth = 51;
            this.dgViewList.RowTemplate.Height = 27;
            this.dgViewList.Size = new System.Drawing.Size(308, 253);
            this.dgViewList.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 590);
            this.Controls.Add(this.dgViewList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPick4;
        private System.Windows.Forms.Label lblPick3;
        private System.Windows.Forms.Label lblPick2;
        private System.Windows.Forms.Label lblPick1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgViewList;
        private System.Windows.Forms.PictureBox pbox4;
        private System.Windows.Forms.PictureBox pbox3;
        private System.Windows.Forms.PictureBox pbox2;
        private System.Windows.Forms.PictureBox pbox1;
    }
}

