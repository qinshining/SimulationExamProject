namespace SimulationExamProject
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnPreQuestion = new System.Windows.Forms.Button();
            this.ckbD = new System.Windows.Forms.CheckBox();
            this.ckbC = new System.Windows.Forms.CheckBox();
            this.ckbB = new System.Windows.Forms.CheckBox();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmrGetCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.pnlCover = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnExtractQuestion = new System.Windows.Forms.Button();
            this.ckbA = new System.Windows.Forms.CheckBox();
            this.pnlHead.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlCover.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(248)))));
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Controls.Add(this.label1);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(600, 50);
            this.pnlHead.TabIndex = 0;
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseDown);
            this.pnlHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseMove);
            this.pnlHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(248)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(563, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "计算机等级考试模拟练习";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblCurrent);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 35);
            this.panel2.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(102, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(81, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "/";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(60, 8);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(18, 19);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "题目：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(440, 8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(95, 19);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "currentTime";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlCover);
            this.pnlMain.Controls.Add(this.btnSubmit);
            this.pnlMain.Controls.Add(this.btnNextQuestion);
            this.pnlMain.Controls.Add(this.btnPreQuestion);
            this.pnlMain.Controls.Add(this.ckbD);
            this.pnlMain.Controls.Add(this.ckbC);
            this.pnlMain.Controls.Add(this.ckbB);
            this.pnlMain.Controls.Add(this.ckbA);
            this.pnlMain.Controls.Add(this.lblD);
            this.pnlMain.Controls.Add(this.lblC);
            this.pnlMain.Controls.Add(this.lblB);
            this.pnlMain.Controls.Add(this.lblA);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Location = new System.Drawing.Point(9, 56);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(583, 253);
            this.pnlMain.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(485, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 35);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提交试卷";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.ForeColor = System.Drawing.Color.White;
            this.btnNextQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnNextQuestion.Image")));
            this.btnNextQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextQuestion.Location = new System.Drawing.Point(219, 200);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 35);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "下一题";
            this.btnNextQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.BtnNextQuestion_Click);
            // 
            // btnPreQuestion
            // 
            this.btnPreQuestion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPreQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreQuestion.ForeColor = System.Drawing.Color.White;
            this.btnPreQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnPreQuestion.Image")));
            this.btnPreQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreQuestion.Location = new System.Drawing.Point(55, 200);
            this.btnPreQuestion.Name = "btnPreQuestion";
            this.btnPreQuestion.Size = new System.Drawing.Size(75, 35);
            this.btnPreQuestion.TabIndex = 2;
            this.btnPreQuestion.Text = "上一题";
            this.btnPreQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreQuestion.UseVisualStyleBackColor = false;
            this.btnPreQuestion.Click += new System.EventHandler(this.BtnPreQuestion_Click);
            // 
            // ckbD
            // 
            this.ckbD.AutoSize = true;
            this.ckbD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbD.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbD.Location = new System.Drawing.Point(55, 169);
            this.ckbD.Name = "ckbD";
            this.ckbD.Size = new System.Drawing.Size(12, 11);
            this.ckbD.TabIndex = 1;
            this.ckbD.UseVisualStyleBackColor = true;
            // 
            // ckbC
            // 
            this.ckbC.AutoSize = true;
            this.ckbC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbC.Location = new System.Drawing.Point(55, 135);
            this.ckbC.Name = "ckbC";
            this.ckbC.Size = new System.Drawing.Size(12, 11);
            this.ckbC.TabIndex = 1;
            this.ckbC.UseVisualStyleBackColor = true;
            // 
            // ckbB
            // 
            this.ckbB.AutoSize = true;
            this.ckbB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbB.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbB.Location = new System.Drawing.Point(55, 101);
            this.ckbB.Name = "ckbB";
            this.ckbB.Size = new System.Drawing.Size(12, 11);
            this.ckbB.TabIndex = 1;
            this.ckbB.UseVisualStyleBackColor = true;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lblD.ForeColor = System.Drawing.Color.Navy;
            this.lblD.Location = new System.Drawing.Point(74, 165);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(18, 17);
            this.lblD.TabIndex = 0;
            this.lblD.Tag = "optionD";
            this.lblD.Text = "D";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lblC.ForeColor = System.Drawing.Color.Navy;
            this.lblC.Location = new System.Drawing.Point(74, 131);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(16, 17);
            this.lblC.TabIndex = 0;
            this.lblC.Tag = "optionC";
            this.lblC.Text = "C";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lblB.ForeColor = System.Drawing.Color.Navy;
            this.lblB.Location = new System.Drawing.Point(74, 97);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 17);
            this.lblB.TabIndex = 0;
            this.lblB.Tag = "optionB";
            this.lblB.Text = "B";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblA.ForeColor = System.Drawing.Color.Navy;
            this.lblA.Location = new System.Drawing.Point(74, 63);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Tag = "optionA";
            this.lblA.Text = "A";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(51, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "题目：等待答题...";
            // 
            // tmrGetCurrentTime
            // 
            this.tmrGetCurrentTime.Interval = 1;
            this.tmrGetCurrentTime.Tick += new System.EventHandler(this.TmrGetCurrentTime_Tick);
            // 
            // pnlCover
            // 
            this.pnlCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCover.Controls.Add(this.btnExtractQuestion);
            this.pnlCover.Controls.Add(this.lblInfo);
            this.pnlCover.Location = new System.Drawing.Point(22, 17);
            this.pnlCover.Name = "pnlCover";
            this.pnlCover.Size = new System.Drawing.Size(545, 218);
            this.pnlCover.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(248)))));
            this.lblInfo.Location = new System.Drawing.Point(57, 76);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(230, 27);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "试卷密封中，等待抽题...";
            // 
            // btnExtractQuestion
            // 
            this.btnExtractQuestion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExtractQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractQuestion.ForeColor = System.Drawing.Color.White;
            this.btnExtractQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnExtractQuestion.Image")));
            this.btnExtractQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtractQuestion.Location = new System.Drawing.Point(371, 76);
            this.btnExtractQuestion.Name = "btnExtractQuestion";
            this.btnExtractQuestion.Size = new System.Drawing.Size(80, 27);
            this.btnExtractQuestion.TabIndex = 3;
            this.btnExtractQuestion.Text = "抽取试题";
            this.btnExtractQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExtractQuestion.UseVisualStyleBackColor = false;
            this.btnExtractQuestion.Click += new System.EventHandler(this.BtnExtractQuestion_Click);
            // 
            // ckbA
            // 
            this.ckbA.AutoSize = true;
            this.ckbA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbA.Location = new System.Drawing.Point(55, 67);
            this.ckbA.Name = "ckbA";
            this.ckbA.Size = new System.Drawing.Size(12, 11);
            this.ckbA.TabIndex = 1;
            this.ckbA.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模拟考试";
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlCover.ResumeLayout(false);
            this.pnlCover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnPreQuestion;
        private System.Windows.Forms.CheckBox ckbD;
        private System.Windows.Forms.CheckBox ckbC;
        private System.Windows.Forms.CheckBox ckbB;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Timer tmrGetCurrentTime;
        private System.Windows.Forms.Panel pnlCover;
        private System.Windows.Forms.Button btnExtractQuestion;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox ckbA;
    }
}

