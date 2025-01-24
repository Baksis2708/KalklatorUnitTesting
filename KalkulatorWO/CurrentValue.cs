using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KalkulatorWO;

namespace KalkulatorWO
{
    public class CurrentValue
    {
        


        public enum DigitSystem
        {
            Hex,
            Dec,
            Oct,
            Bin
        }
        public enum Words
        {
            QWord,
            DWord,
            Word,
            Bajt
        }

        //
        public string textBox1Expression {  get; set; }
        public string element1 { get; set; }
        public string element2 { get; set; }
        public string currentOperation { get; set; }
        public DigitSystem digitSystem {  get; set; }
        public Words words { get; set; }
        //Form1 form1 { get; set; }
        public CurrentValue()
        {
            this.textBox1Expression = "";
            this.element1 = "";
            this.element2 = "";
            this.currentOperation = "";
            this.digitSystem = DigitSystem.Dec;
            this.words = Words.QWord;
        }
        //


        long tempResult { get; set; }
        long value { get; set; }
        string stringValue { get; set; }
        string hex;
        string dec;
        string oct;
        string bin;
        //DigitSystem digitSystem = DigitSystem.Dec;
        //Words words = Words.QWord;
        

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



        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        public static long EvaluateAsLong(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            double temp = double.Parse((string)row["expression"]);
            return (long)temp;
        }

        public void ZmienSystemLiczbowy(DigitSystem systemDocelowy)
        {
            this.digitSystem = systemDocelowy;
            this.AktualizujAktywneCyfry();
        }

        public void AktualizujAktywneCyfry()
        {
            switch(this.digitSystem)
            {
                case DigitSystem.Hex:
                    //form1.btn1.Enabled = true;


                    break;
                case DigitSystem.Dec:



                    break;
                case DigitSystem.Oct:



                    break;
                case DigitSystem.Bin:



                    break;
                default:
                    break;

            }
        }
    }
}
