using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateRootAndIterativeDesignPattern
{
    /// <summary>
    /// Aggregate row Pattern, always go throw from root, list make it private
    /// Iterative pattern, always return IEnumerable
    /// </summary>
    public class EmployeeAddress
    {
        public EmployeeAddress()
        {
            this._addresses = new List<string>();
        }

        private IList<string> _addresses { get; set; }

        public void Add(string address)
        {
            this._addresses.Add(address);
        }

        public IEnumerable<string> Addresses // Step 3 :- To browse use enumerator
        {
            get { return _addresses; }
        }


    }
}
