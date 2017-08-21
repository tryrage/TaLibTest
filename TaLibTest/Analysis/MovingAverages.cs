using System.Collections.Generic;
using System.Linq;
using TicTacTec.TA.Library;

namespace TaLibTest.Analysis
{
    class MovingAverages
    {
        public static MovingAverage CalculateEMA(IList<OHLC> candles, int periodsAverage)
        {
            double[] closePrice = candles.Select(x => (double)x.Close).ToArray();
            double[] output = new double[closePrice.Length];

            int begin;
            int length;

            Core.RetCode retCode = Core.Ema(0, closePrice.Length - 1, closePrice, periodsAverage, out begin, out length, output);

            if (retCode == Core.RetCode.Success)
                return new MovingAverage() { Begin = begin, Length = length, Output = output, Period = periodsAverage };

            return null;
        }
    }
}
