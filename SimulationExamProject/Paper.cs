using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimulationExamProject
{
    /// <summary>
    /// 试卷类
    /// </summary>
    public class Paper
    {
        private List<Question> questions = null;//试题，设置只读属性，用自动属性不好控制
        public List<Question> Questions
        {
            get { return this.questions; }
        }
        /// <summary>
        /// 根据序列化文件获取试题，若不存在，则从文本文件获取试题并保存序列化文件
        /// </summary>
        public void ExtractQuestions()
        {
            if (this.questions != null)//第一次加载时才从文件读取
            {
                return;
            }
            if (!File.Exists("questions.obj"))
            {
                FileStream fs = new FileStream("questions.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                String content = sr.ReadToEnd();
                sr.Close();
                fs.Close();
                string[] questionBlocks = content.Split('&');
                foreach (string item in questionBlocks)
                {
                    string[] questionDetails = item.Trim().Split('\r');
                    this.questions = new List<Question>();
                    this.questions.Add(new Question()
                    {
                        Title = questionDetails[0].Trim(),
                        OptionA = questionDetails[1].Trim(),
                        OptionB = questionDetails[2].Trim(),
                        OptionC = questionDetails[3].Trim(),
                        OptionD = questionDetails[4].Trim(),
                        Answer = new Answer() { RightAnswer = questionDetails[5].Trim() }
                    });
                }
                this.SaveQuestionObj();
            }
            else
            {
                FileStream fs = new FileStream("questions.obj", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                this.questions = (List<Question>)bf.Deserialize(fs);
                fs.Close();
            }
        }
        /// <summary>
        /// 保存试题问序列化文件
        /// </summary>
        public void SaveQuestionObj()
        {
            FileStream fs = new FileStream("questions.obj", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this.questions);
            fs.Close();
        }

        public int SubmitPaper()
        {
            int score = 0;
            foreach (Question item in this.questions)
            {
                if (!item.Answer.SelectedAnswer.Equals(item.Answer.RightAnswer)) continue;
                score += 5;
            }
            return score;
        }
    }
}
