using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLib;
using MazeGeneratorLib;
using SearchAlgorithmsLib;

namespace Ex1
{
    class SearchableMaze<T> : ISearchable<T>
    {
        //MEMBERS
        Maze maze;
        public State<T> initialState { get; set; }
        public State<T> goalState { get; set; }
        public List<State<T>> allPossibleStates { get; set; }

        //CONSTRUCTOR
        public Searchable(State<T> initialState, State<T> goalState)
        {
            this.initialState = initialState;
            this.goalState = goalState;
        }

        /**
        getAllPossibleStates - returns a list with all of the states that are possible to reach(neighbors).
        **/
        public List<State<T>> getAllPossibleStates(State<T> s)
        {

            return allPossibleStates;
        }

        /**
        getGoalState - returns the goal state.
        **/
        public State<T> getGoalState()
        {
            return;
        }

        /**
        getInitialState - returns the initial state.
        **/
        public State<T> getInitialState()
        {
            return initialState;
        }
    }
}
