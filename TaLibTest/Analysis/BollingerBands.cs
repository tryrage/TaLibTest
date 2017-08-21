using System.Collections.Generic;
using System.Linq;
using TicTacTec.TA.Library;

namespace TaLibTest.Analysis
{
    class BollingerBands
    {
        public static BollingerBand CalculateBB(IList<OHLC> candles, int periodsAverage)
        {
            var upperDeviation = 1.00;
            var lowerDeviation = 0.50;

            double[] closePrice = candles.Select(x => (double)x.Close).ToArray();
            double[] upperBand = new double[closePrice.Length];
            double[] midBand = new double[closePrice.Length];
            double[] lowerBand = new double[closePrice.Length];
            int begin;
            int length;

            Core.RetCode retCode = Core.Bbands(0, closePrice.Length - 1, closePrice, periodsAverage, upperDeviation, lowerDeviation, Core.MAType.Ema, out begin, out length, upperBand, midBand, lowerBand);

            if (retCode == Core.RetCode.Success)
                return new BollingerBand() { Begin = begin, Length = length, UpperBand = upperBand, MidBand = midBand, LowerBand = lowerBand, Period = periodsAverage };

            return null;
        }
    }
}
