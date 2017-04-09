using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmsLib
{
    public class State<T>
    {
        //MEMBERS:
        private T state { get; set; }                 // the state represented by T.
        public double cost { get; set; }             // cost to reach this state (set by a setter)
        public State<T> cameFrom { get; set; }       // the state we came from to this state (setter)

        /**
        CONSTRUCTOR.
        **/
        public State(T state)                                    
        {
            this.state = state;
        }

        /**
        Equals - we overload Object's Equals method.
        **/
        public bool Equals(State<T> s)                           
        {
            return state.Equals(s.state);
        }

    }
}
