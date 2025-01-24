using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorWO
{
    public class CurrentValue
    {
        enum DigitSystem
        {
            Hex,
            Dec,
            Oct,
            Bin
        }
        enum Words
        {
            QWord,
            DWord,
            Word,
            Bajt
        }
        long tempResult { get; set; }
        long value { get; set; }
        string stringValue { get; set; }
        string hex;
        string dec;
        string oct;
        string bin;
        DigitSystem digitSystem = DigitSystem.Dec;
        Words words = Words.QWord;
        

        //long ValueToLong()
        //{
        //    switch(digitSystem)
        //    {
        //        case DigitSystem.Hex:
        //            return Convert.ToInt64(stringValue);
        //            break;
        //        case DigitSystem.Dec:
        //            return Convert.ToInt32(stringValue);
        //            break;
        //        case DigitSystem.Oct:
        //            return Convert.ToInt16(stringValue);
        //            break;
        //        case DigitSystem.Bin:
        //            return Convert.ToSByte(stringValue);
        //            break;
        //        default:
        //            return 0;
        //            break;
        //    }
        //}
        string ConvertFromBaseToBase(string number, int fromBase, int toBase)
        {
            switch (words)
            {
                case (Words.QWord):
                    return Convert.ToString(Convert.ToInt64(number, fromBase), toBase);
                    break;
                case (Words.DWord):
                    return Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
                    break;
                case (Words.Word):
                    return Convert.ToString(Convert.ToInt16(number, fromBase), toBase);
                    break;
                case (Words.Bajt):
                    return Convert.ToString(Convert.ToSByte(number, fromBase), toBase);
                    break;
                default:
                    return "";
                    break;
            }





        }
        void UpdateToQword<T>(T value)
        {
            this.value = Convert.ToInt64(value);
            words = Words.QWord;
        }
        void UpdateToDword<T>(T value)
        {
            this.value = Convert.ToInt32(value);
            words = Words.DWord;
        }
        void UpdateToWord<T>(T value)
        {
            this.value = Convert.ToInt16(value);
            words = Words.Word;
        }
        void UpdateToBajt<T>(T value)
        {
            this.value = Convert.ToSByte(value);
            words = Words.Bajt;
        }
        
    }
}
