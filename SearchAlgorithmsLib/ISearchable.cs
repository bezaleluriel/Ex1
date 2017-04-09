using SearchAlgorithmsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmsLib
{
    public interface ISearchable<T>
    {
        /**
        getInitialState - returns the initial state.
        **/
        State<T> getInitialState();
        
        /**
        getGoalState - returns the goal state.
        **/
        State<T> getGoalState();
        
        /**
        getInitialState - returns the initial state.
        **/
        List<State<T>> getAllPossibleStates(State<T> s);
    }
}
