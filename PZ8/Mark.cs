using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ8
{
    internal class Mark
    {
        private string result;
        public IControl MarkStrategy { get; set; }
        public Mark(IControl strategy)
        {
            MarkStrategy = strategy;
        }
        public void Rate(int points)
        {
            result = MarkStrategy.Rate(points);
        }
        public string GetResult()
        {
            if (result == null)
                return "Не оценено";
            return result;
        }
    }
}
