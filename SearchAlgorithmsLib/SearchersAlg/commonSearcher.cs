using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithmsLib;
using Priority_Queue;

namespace SearchAlgorithmsLib
{
    abstract class CommonSearcher<T> : ISearcher<T>
    {
        //protected SimplePriorityQueue<State<T>> openList;
        private int evaluatedNodes;

        public CommonSearcher()
        {
           // openList = new SimplePriorityQueue<State<T>>();
            evaluatedNodes = 0;
        }


        public int getNumberOfNodesEvaluated()
        {
            return evaluatedNodes;
        }

        // public abstract Solution<T> Search<T>(ISearchable<T> searchable);
         public abstract Solution<T> search(ISearchable<T> searchable);
    }
}
