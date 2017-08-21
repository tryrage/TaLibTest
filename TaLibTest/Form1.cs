using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaLibTest
{
    public partial class Form1 : Form
    {
        int _shortEMAPeriod = 7;
        int _longEMAPeriod = 15;

        public Form1()
        {
            InitializeComponent();

            // 用假數據填入K棒List
            List<OHLC> candles = new List<OHLC>();
            int closePrice = 5000;
            for (int i = 0; i < 100; i ++)
            {
                OHLC item = new OHLC();
                item.Close = i < 50 ? closePrice + i : closePrice + 100 - i;
                candles.Add(item);
            }

            GetResult(candles);
        }

        public void GetResult(IList<OHLC> candles)
        {
            // 長、短週期EMA計算
            var shortMA = Analysis.MovingAverages.CalculateEMA(candles, _shortEMAPeriod);
            var longMA = Analysis.MovingAverages.CalculateEMA(candles, _longEMAPeriod);

            // 布林通道計算
            var bbs = Analysis.BollingerBands.CalculateBB(candles, _shortEMAPeriod);

            Console.WriteLine("Done.");
        }
    }
}
