using System;

namespace TaLibTest
{
    /// <summary>
    /// Represents a candle
    /// </summary>
    public class OHLC
    {
        /// <summary>
        /// The start date of the candle
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// The start date of the candle in Unix time
        /// </summary>
        public long TimeStamp { get; set; }
        /// <summary>
        /// The highest price during the candle's period
        /// </summary>
        public decimal High { get; set; }
        /// <summary>
        /// The lowest price during the candle's period
        /// </summary>
        public decimal Low { get; set; }
        /// <summary>
        /// The opening price for the candle
        /// </summary>
        public decimal Open { get; set; }
        /// <summary>
        /// The closing price for the candle
        /// </summary>
        public decimal Close { get; set; }
        /// <summary>
        /// The number of trades during the candle's period
        /// </summary>
        public decimal Volume { get; set; }
        /// <summary>
        /// The number of trades during the candle's period
        /// </summary>
        public int TradesCount { get; set; }
        /// <summary>
        /// TradeSource
        /// </summary>
        // public TradeSource TradeSource { get; set; }

        /// <summary>
        /// Returns a visual representation of the candle (debugging)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} O:{1:0.00######} H:{2:0.00######} L:{3:0.00######} C:{4:0.00######} V:{5:0.00000000}", Date, Open, High, Low, Close, Volume);
        }
    }

    /// <summary>
    /// Represents a caculated moving average
    /// </summary>
    public class MovingAverage
    {
        /// <summary>
        /// Gets or sets the period for the average
        /// </summary>
        public int Period { get; set; }
        public int Begin { get; set; }
        public int Length { get; set; }
        public double[] Output { get; set; }
    }

    public class BollingerBand
    {
        public int Period { get; set; }
        public int Begin { get; set; }
        public int Length { get; set; }
        public double[] UpperBand { get; set; }
        public double[] MidBand { get; set; }
        public double[] LowerBand { get; set; }
    }
}
