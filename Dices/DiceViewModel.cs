using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Dices
{
    public class DiceViewModel 
    {
        private readonly IDispatcher _dispatcher;

        public DiceViewModel(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

    }
}
