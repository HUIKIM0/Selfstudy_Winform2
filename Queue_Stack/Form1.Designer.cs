﻿
namespace Queue_Stack
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
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblQueue1 = new System.Windows.Forms.Label();
            this.lblQueue2 = new System.Windows.Forms.Label();
            this.lblQueue3 = new System.Windows.Forms.Label();
            this.lblQueue4 = new System.Windows.Forms.Label();
            this.lblQueue5 = new System.Windows.Forms.Label();
            this.lblQueue6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblStack5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblStack4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStack3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStack2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStack1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblStack6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDataIn = new System.Windows.Forms.Button();
            this.btnAutoDataOut = new System.Windows.Forms.Button();
            this.btnDataOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.label13, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 122);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(510, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 72);
            this.label13.TabIndex = 11;
            this.label13.Text = "[0]";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(306, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 72);
            this.label11.TabIndex = 9;
            this.label11.Text = "[2]";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(204, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 72);
            this.label10.TabIndex = 8;
            this.label10.Text = "[3]";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(102, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 72);
            this.label9.TabIndex = 7;
            this.label9.Text = "[4]";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue1
            // 
            this.lblQueue1.AutoSize = true;
            this.lblQueue1.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue1.Location = new System.Drawing.Point(513, 3);
            this.lblQueue1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblQueue1.Name = "lblQueue1";
            this.lblQueue1.Size = new System.Drawing.Size(105, 44);
            this.lblQueue1.TabIndex = 5;
            this.lblQueue1.Text = "-";
            this.lblQueue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue2
            // 
            this.lblQueue2.AutoSize = true;
            this.lblQueue2.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue2.Location = new System.Drawing.Point(411, 3);
            this.lblQueue2.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue2.Name = "lblQueue2";
            this.lblQueue2.Size = new System.Drawing.Size(96, 44);
            this.lblQueue2.TabIndex = 4;
            this.lblQueue2.Text = "-";
            this.lblQueue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue3
            // 
            this.lblQueue3.AutoSize = true;
            this.lblQueue3.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue3.Location = new System.Drawing.Point(309, 3);
            this.lblQueue3.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue3.Name = "lblQueue3";
            this.lblQueue3.Size = new System.Drawing.Size(96, 44);
            this.lblQueue3.TabIndex = 3;
            this.lblQueue3.Text = "-";
            this.lblQueue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue4
            // 
            this.lblQueue4.AutoSize = true;
            this.lblQueue4.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue4.Location = new System.Drawing.Point(207, 3);
            this.lblQueue4.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue4.Name = "lblQueue4";
            this.lblQueue4.Size = new System.Drawing.Size(96, 44);
            this.lblQueue4.TabIndex = 2;
            this.lblQueue4.Text = "-";
            this.lblQueue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue5
            // 
            this.lblQueue5.AutoSize = true;
            this.lblQueue5.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue5.Location = new System.Drawing.Point(105, 3);
            this.lblQueue5.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue5.Name = "lblQueue5";
            this.lblQueue5.Size = new System.Drawing.Size(96, 44);
            this.lblQueue5.TabIndex = 1;
            this.lblQueue5.Text = "-";
            this.lblQueue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue6
            // 
            this.lblQueue6.AutoSize = true;
            this.lblQueue6.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue6.Location = new System.Drawing.Point(0, 3);
            this.lblQueue6.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblQueue6.Name = "lblQueue6";
            this.lblQueue6.Size = new System.Drawing.Size(99, 44);
            this.lblQueue6.TabIndex = 0;
            this.lblQueue6.Text = "-";
            this.lblQueue6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(408, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 72);
            this.label12.TabIndex = 10;
            this.label12.Text = "[1]";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(0, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 72);
            this.label8.TabIndex = 6;
            this.label8.Text = "[5]";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.Controls.Add(this.lblStack6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label17, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblStack5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label15, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblStack4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblStack3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStack2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStack1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(203, 235);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 254);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(198, 168);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 42);
            this.label17.TabIndex = 9;
            this.label17.Text = "label17";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack5
            // 
            this.lblStack5.AutoSize = true;
            this.lblStack5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStack5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack5.Location = new System.Drawing.Point(3, 168);
            this.lblStack5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack5.Name = "lblStack5";
            this.lblStack5.Size = new System.Drawing.Size(192, 39);
            this.lblStack5.TabIndex = 8;
            this.lblStack5.Text = "-";
            this.lblStack5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(198, 126);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 42);
            this.label15.TabIndex = 7;
            this.label15.Text = "label15";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack4
            // 
            this.lblStack4.AutoSize = true;
            this.lblStack4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStack4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack4.Location = new System.Drawing.Point(3, 126);
            this.lblStack4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack4.Name = "lblStack4";
            this.lblStack4.Size = new System.Drawing.Size(192, 39);
            this.lblStack4.TabIndex = 6;
            this.lblStack4.Text = "-";
            this.lblStack4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(198, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 42);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack3
            // 
            this.lblStack3.AutoSize = true;
            this.lblStack3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStack3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack3.Location = new System.Drawing.Point(3, 84);
            this.lblStack3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack3.Name = "lblStack3";
            this.lblStack3.Size = new System.Drawing.Size(192, 39);
            this.lblStack3.TabIndex = 4;
            this.lblStack3.Text = "-";
            this.lblStack3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(198, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 42);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack2
            // 
            this.lblStack2.AutoSize = true;
            this.lblStack2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStack2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack2.Location = new System.Drawing.Point(3, 42);
            this.lblStack2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack2.Name = "lblStack2";
            this.lblStack2.Size = new System.Drawing.Size(192, 39);
            this.lblStack2.TabIndex = 2;
            this.lblStack2.Text = "-";
            this.lblStack2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(198, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack1
            // 
            this.lblStack1.AutoSize = true;
            this.lblStack1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack1.Location = new System.Drawing.Point(3, 0);
            this.lblStack1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack1.Name = "lblStack1";
            this.lblStack1.Size = new System.Drawing.Size(192, 39);
            this.lblStack1.TabIndex = 0;
            this.lblStack1.Text = "-";
            this.lblStack1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 474);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 15);
            this.label18.TabIndex = 3;
            this.label18.Text = "Stack";
            // 
            // lblStack6
            // 
            this.lblStack6.AutoSize = true;
            this.lblStack6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStack6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack6.Location = new System.Drawing.Point(3, 210);
            this.lblStack6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack6.Name = "lblStack6";
            this.lblStack6.Size = new System.Drawing.Size(192, 41);
            this.lblStack6.TabIndex = 10;
            this.lblStack6.Text = "-";
            this.lblStack6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(198, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDataIn
            // 
            this.btnDataIn.Location = new System.Drawing.Point(35, 180);
            this.btnDataIn.Name = "btnDataIn";
            this.btnDataIn.Size = new System.Drawing.Size(87, 38);
            this.btnDataIn.TabIndex = 4;
            this.btnDataIn.Text = "In";
            this.btnDataIn.UseVisualStyleBackColor = true;
            this.btnDataIn.Click += new System.EventHandler(this.btnDataIn_Click);
            // 
            // btnAutoDataOut
            // 
            this.btnAutoDataOut.Location = new System.Drawing.Point(437, 180);
            this.btnAutoDataOut.Name = "btnAutoDataOut";
            this.btnAutoDataOut.Size = new System.Drawing.Size(115, 38);
            this.btnAutoDataOut.TabIndex = 5;
            this.btnAutoDataOut.Text = "Auto Out";
            this.btnAutoDataOut.UseVisualStyleBackColor = true;
            this.btnAutoDataOut.Click += new System.EventHandler(this.btnAutoDataOut_Click);
            // 
            // btnDataOut
            // 
            this.btnDataOut.Location = new System.Drawing.Point(561, 180);
            this.btnDataOut.Name = "btnDataOut";
            this.btnDataOut.Size = new System.Drawing.Size(87, 38);
            this.btnDataOut.TabIndex = 6;
            this.btnDataOut.Text = "Out";
            this.btnDataOut.UseVisualStyleBackColor = true;
            this.btnDataOut.Click += new System.EventHandler(this.btnDataOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 531);
            this.Controls.Add(this.btnDataOut);
            this.Controls.Add(this.btnAutoDataOut);
            this.Controls.Add(this.btnDataIn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblQueue1;
        private System.Windows.Forms.Label lblQueue2;
        private System.Windows.Forms.Label lblQueue3;
        private System.Windows.Forms.Label lblQueue4;
        private System.Windows.Forms.Label lblQueue5;
        private System.Windows.Forms.Label lblQueue6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblStack5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblStack4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStack3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStack2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStack1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblStack6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDataIn;
        private System.Windows.Forms.Button btnAutoDataOut;
        private System.Windows.Forms.Button btnDataOut;
    }
}

