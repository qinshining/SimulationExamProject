using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationExamProject
{
    /// <summary>
    /// 答案类
    /// </summary>
    [Serializable]
    public class Answer
    {
        public string RightAnswer { get; set; } = string.Empty;
        public string SelectedAnswer { get; set; } = string.Empty;
        public string AnswerAnalysis { get; set; } = string.Empty;
    }
}
