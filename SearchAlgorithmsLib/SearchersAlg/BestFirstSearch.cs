using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priority_Queue;

namespace SearchAlgorithmsLib.Searcher
{
    public class BestFirstSearch<T> : PrioritySearch<T>
    {
        public override  Solution<T> search(ISearchable<T> searchable)
        {
            addToOpenList(searchable.getInitialState());
            HashSet<State<T>> closed = new HashSet<State<T>>();
            while (OpenListSize > 0)
            {
                State<T> n = popOpenList();
                closed.Add(n);
                if (n.Equals(searchable.getGoalState()))
                {
                    return backTrace(n);
                    List<State<T>> succerssors = searchable.getAllPossibleStates(n);
                    foreach (State<T> s in succerssors)
                    {
                        // todo update the cost
                        if (!closed.Contains(s) && !IsInTheOpenList(s))
                        {
                            addToOpenList(s);
                            s.cameFrom = n;
                           // s.cost = theNewCost;
                  
                        }
                        // the cost of the new way is better
                        else if (IsInTheOpenList(s))
                        {
                            //  s.cost = theNewCost;
                            addToOpenList(s);
                            updatePriority(s, (float)s.cost);
                        }
                    }

                }
            }
            return null;
        }

        // find the backtrace
        public Solution<T> backTrace(State<T> goal)
        {
            List<State<T>> solution = new List<State<T>>();
            State<T> state = goal;
            while (state != null)
            {
                solution.Add(state);
                state = state.cameFrom;
            }
            return new Solution<T>(solution);
        }


    }
}
