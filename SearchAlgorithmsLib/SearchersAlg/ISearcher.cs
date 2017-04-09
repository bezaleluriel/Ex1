using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithmsLib;


namespace SearchAlgorithmsLib
{
    public interface ISearcher<T>
    {
        Solution<T> search(ISearchable<T> searchable);        // the search method
        int getNumberOfNodesEvaluated();                    // get how many nodes were evaluated by the algorithm
    }
}
