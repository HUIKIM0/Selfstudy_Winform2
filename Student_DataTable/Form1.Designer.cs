
namespace Student_DataTable
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.tboxRegRef = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoRegFemale = new System.Windows.Forms.RadioButton();
            this.rdoRegMale = new System.Windows.Forms.RadioButton();
            this.tboxRegName = new System.Windows.Forms.TextBox();
            this.cboxRegClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgViewInfo = new System.Windows.Forms.DataGridView();
            this.cboxViewClass = new System.Windows.Forms.ComboBox();
            this.btnViewDataDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModify);
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.tboxRegRef);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tboxRegName);
            this.groupBox1.Controls.Add(this.cboxRegClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "등록하기";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(288, 175);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(98, 27);
            this.btnReg.TabIndex = 8;
            this.btnReg.Text = "등록";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tboxRegRef
            // 
            this.tboxRegRef.Location = new System.Drawing.Point(79, 144);
            this.tboxRegRef.Name = "tboxRegRef";
            this.tboxRegRef.Size = new System.Drawing.Size(307, 25);
            this.tboxRegRef.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoRegFemale);
            this.panel1.Controls.Add(this.rdoRegMale);
            this.panel1.Location = new System.Drawing.Point(79, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 27);
            this.panel1.TabIndex = 6;
            // 
            // rdoRegFemale
            // 
            this.rdoRegFemale.AutoSize = true;
            this.rdoRegFemale.Location = new System.Drawing.Point(68, 3);
            this.rdoRegFemale.Name = "rdoRegFemale";
            this.rdoRegFemale.Size = new System.Drawing.Size(43, 19);
            this.rdoRegFemale.TabIndex = 1;
            this.rdoRegFemale.TabStop = true;
            this.rdoRegFemale.Text = "여";
            this.rdoRegFemale.UseVisualStyleBackColor = true;
            // 
            // rdoRegMale
            // 
            this.rdoRegMale.AutoSize = true;
            this.rdoRegMale.Location = new System.Drawing.Point(0, 3);
            this.rdoRegMale.Name = "rdoRegMale";
            this.rdoRegMale.Size = new System.Drawing.Size(43, 19);
            this.rdoRegMale.TabIndex = 0;
            this.rdoRegMale.TabStop = true;
            this.rdoRegMale.Text = "남";
            this.rdoRegMale.UseVisualStyleBackColor = true;
            // 
            // tboxRegName
            // 
            this.tboxRegName.Location = new System.Drawing.Point(79, 73);
            this.tboxRegName.Name = "tboxRegName";
            this.tboxRegName.Size = new System.Drawing.Size(121, 25);
            this.tboxRegName.TabIndex = 5;
            // 
            // cboxRegClass
            // 
            this.cboxRegClass.FormattingEnabled = true;
            this.cboxRegClass.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반"});
            this.cboxRegClass.Location = new System.Drawing.Point(79, 34);
            this.cboxRegClass.Name = "cboxRegClass";
            this.cboxRegClass.Size = new System.Drawing.Size(121, 23);
            this.cboxRegClass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "특기:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "성별:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "반:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgViewInfo);
            this.groupBox2.Controls.Add(this.cboxViewClass);
            this.groupBox2.Controls.Add(this.btnViewDataDel);
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내용확인";
            // 
            // dgViewInfo
            // 
            this.dgViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewInfo.Location = new System.Drawing.Point(6, 57);
            this.dgViewInfo.Name = "dgViewInfo";
            this.dgViewInfo.RowHeadersWidth = 51;
            this.dgViewInfo.RowTemplate.Height = 27;
            this.dgViewInfo.Size = new System.Drawing.Size(754, 242);
            this.dgViewInfo.TabIndex = 10;
            // 
            // cboxViewClass
            // 
            this.cboxViewClass.FormattingEnabled = true;
            this.cboxViewClass.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반"});
            this.cboxViewClass.Location = new System.Drawing.Point(6, 26);
            this.cboxViewClass.Name = "cboxViewClass";
            this.cboxViewClass.Size = new System.Drawing.Size(121, 23);
            this.cboxViewClass.TabIndex = 9;
            this.cboxViewClass.SelectedIndexChanged += new System.EventHandler(this.cboxViewClass_SelectedIndexChanged);
            // 
            // btnViewDataDel
            // 
            this.btnViewDataDel.Location = new System.Drawing.Point(654, 23);
            this.btnViewDataDel.Name = "btnViewDataDel";
            this.btnViewDataDel.Size = new System.Drawing.Size(106, 27);
            this.btnViewDataDel.TabIndex = 9;
            this.btnViewDataDel.Text = "삭제";
            this.btnViewDataDel.UseVisualStyleBackColor = true;
            this.btnViewDataDel.Click += new System.EventHandler(this.btnViewDataDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(392, 175);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(98, 27);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "학생부";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoRegFemale;
        private System.Windows.Forms.RadioButton rdoRegMale;
        private System.Windows.Forms.TextBox tboxRegName;
        private System.Windows.Forms.ComboBox cboxRegClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tboxRegRef;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridView dgViewInfo;
        private System.Windows.Forms.ComboBox cboxViewClass;
        private System.Windows.Forms.Button btnViewDataDel;
        private System.Windows.Forms.Button btnModify;
    }
}

