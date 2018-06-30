using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne2
{
    class TwentyOneDealer : Dealer
    {
        public List<Card> Hand { get; set; } = new List<Card>();
        public bool Stay { get; set; }
        public bool IsBusted { get; set; }
       
    }
}
