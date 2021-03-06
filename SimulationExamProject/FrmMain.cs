using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationExamProject
{
    public partial class FrmMain : Form
    {
        private Paper paper = new Paper();
        private int currentIndex = 0;//当前题目的索引
        public FrmMain()
        {
            InitializeComponent();
            this.tmrGetCurrentTime.Start();
        }

        #region 窗体移动
        private Point mouseOff;
        private bool leftFlag;
        private void PnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                leftFlag = true;
            }
        }
        private void PnlHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff);
                Location = mouseSet;
            }
        }
        private void PnlHead_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }
        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //定时器，设置时间，后续可扩展设置超时操作等...
        private void TmrGetCurrentTime_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString();
            this.tmrGetCurrentTime.Interval = 1000;
        }
        //上一题
        private void BtnPreQuestion_Click(object sender, EventArgs e)
        {
            this.SaveResult();
            if (this.currentIndex > 0) this.currentIndex--;
            if (this.currentIndex == 0) this.btnPreQuestion.Enabled = false;
            if (this.currentIndex < this.paper.Questions.Count - 1) this.btnNextQuestion.Enabled = true;
            this.ShowQuestion();
            this.RestCheck();
        }
        //下一题
        private void BtnNextQuestion_Click(object sender, EventArgs e)
        {
            this.SaveResult();
            if (this.currentIndex < this.paper.Questions.Count - 1) this.currentIndex++;
            if (this.currentIndex == this.paper.Questions.Count - 1) this.btnNextQuestion.Enabled = false;
            if (this.currentIndex > 0) this.btnPreQuestion.Enabled = true;
            this.ShowQuestion();
            this.RestCheck();
        }
        //保存用户所选答案
        private void SaveResult()
        {
            string selectedAnswer = string.Empty;
            if (this.ckbA.Checked) selectedAnswer += "A";
            if (this.ckbB.Checked) selectedAnswer += "B";
            if (this.ckbC.Checked) selectedAnswer += "C";
            if (this.ckbD.Checked) selectedAnswer += "D";
            this.paper.Questions[this.currentIndex].Answer.SelectedAnswer = selectedAnswer;
        }
        //重置所选答案
        private void RestCheck()
        {
            this.ckbA.Checked = this.paper.Questions[this.currentIndex].Answer.SelectedAnswer.Contains("A");
            this.ckbB.Checked = this.paper.Questions[this.currentIndex].Answer.SelectedAnswer.Contains("B");
            this.ckbC.Checked = this.paper.Questions[this.currentIndex].Answer.SelectedAnswer.Contains("C");
            this.ckbD.Checked = this.paper.Questions[this.currentIndex].Answer.SelectedAnswer.Contains("D");
        }
        //提交试卷，提交后展示分数
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            SaveResult();
            int score = this.paper.SubmitPaper();
            this.pnlCover.Visible = true;
            this.btnExtractQuestion.Visible = true;
            this.lblInfo.Text = $"考试结束，您的分数是{score}";
            //继续考试，这两个属性变化后没必要再变回去
            this.lblInfo.ForeColor = Color.Red;
            this.btnExtractQuestion.Text = "继续考试";
        }
        //抽取试题
        private void BtnExtractQuestion_Click(object sender, EventArgs e)
        {
            this.pnlCover.Visible = false;
            this.btnExtractQuestion.Visible = false;
            this.paper.ExtractQuestions();
            //继续考试后初始化
            this.currentIndex = 0;
            this.ckbA.Checked = this.ckbB.Checked = this.ckbC.Checked = this.ckbD.Checked = false;
            //获取试题后控制按钮
            this.btnPreQuestion.Enabled = false;
            if (this.paper.Questions.Count == 0)
            {
                this.btnNextQuestion.Enabled = false;
            }
            this.ShowQuestion();
        }
        //展示试题
        private void ShowQuestion()
        {
            this.lblTitle.Text = this.paper.Questions[this.currentIndex].Title;
            this.lblA.Text = this.paper.Questions[this.currentIndex].OptionA;
            this.lblB.Text = this.paper.Questions[this.currentIndex].OptionB;
            this.lblC.Text = this.paper.Questions[this.currentIndex].OptionC;
            this.lblD.Text = this.paper.Questions[this.currentIndex].OptionD;
            this.lblCurrent.Text = (this.currentIndex + 1).ToString();
            this.lblTotal.Text = this.paper.Questions.Count.ToString();
        }
    }
}
