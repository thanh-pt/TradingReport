using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingReporter2
{
    internal class ReportData
    {
        public int WeekNumber { get; set; }
        public Dictionary<DayOfWeek, double> DailyPL { get; set; }
        public Dictionary<DayOfWeek, List<TradeData>> DailyDetail { get; set; }
        public double TotalProfit { get; set; }
    }
}
