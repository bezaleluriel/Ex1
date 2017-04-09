using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priority_Queue;

namespace SearchAlgorithmsLib.Searcher
{
    public abstract class PrioritySearch<T> : CommonSearcher<T>
    {
        protected SimplePriorityQueue<State<T>> openList;
        private int evaluatedNodes;

        // a property of openList
        public int OpenListSize
        { // it is a read-only property :)
            get { return openList.Count; }
        }

        
        // creation?
        public void PrioritySearcher()
        {
            openList = new SimplePriorityQueue<State<T>>();
            evaluatedNodes = 0;
        }

        // checks if the state is in the list
        protected bool IsInTheOpenList(State<T> s)
        {
            return openList.Contains(s);
        }

        protected State<T> popOpenList()
        {
            evaluatedNodes++;
            return openList.Dequeue();
        }

        protected void addToOpenList(State<T> s)
        {
            float floatedCost = (float)s.cost;
            // this is how we add an element to priority queue
            openList.Enqueue(s, floatedCost);
        }

        // changes the priority of a state
        protected void updatePriority(State<T> s, float p)
        {
            openList.UpdatePriority(s, p);
        }

               
        public int getNumberOfNodesEvaluated()
        {
            return evaluatedNodes;
        }

    }
}