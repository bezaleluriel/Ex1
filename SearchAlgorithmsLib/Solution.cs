using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithmsLib;

namespace SearchAlgorithmsLib
{
    public class Solution<T>
    {
        //MEMBERS
        private List<State<T>> solution;

        public List<State<T>> path { get; set; }
        public List<Action<T>> actions { get; set; }


        public Solution(List<State<T>> solution)
        {
            this.solution = solution;
        }

    }
}
