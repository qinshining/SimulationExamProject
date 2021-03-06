using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationExamProject
{
    /// <summary>
    /// 试题类
    /// </summary>
    [Serializable]
    public class Question
    {
        public string Title { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public Answer Answer { get; set; }
    }
}
