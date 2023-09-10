using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingReporter2
{
    internal class TradeData
    {
        public int OrderNo { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public double ProfitLoss { get; set; }
    }
}
