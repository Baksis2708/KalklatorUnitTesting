using System;
using Xunit;
using KalkulatorWO;

namespace UnitTests
{
    public class UnitTest1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        [Fact]
        public void AdditionTest()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void AdditionTest2()
        {
            Assert.Equal(5, Add(3, 2));
        }

        [Fact]
        public void test1()
        {
            Assert.Equal(10, CurrentValue.EvaluateAsLong("7 + 3"));

        }

        [Fact]
        public static void UpdateToQwordPositive()
        {
            CurrentValue currentValue = new CurrentValue();
            currentValue.UpdateToQword<int>(12);
            Assert.Equal(12, currentValue.value);
            currentValue.UpdateToQword<int>(122);
            Assert.Equal(122, currentValue.value);
            currentValue.UpdateToQword<int>(-33);
            Assert.Equal(-33, currentValue.value);
            currentValue.UpdateToQword<int>(0);
            Assert.Equal(0, currentValue.value);
        }
        [Fact]
        public static void UpdateToQwordNegative()
        {
            CurrentValue currentValue = new CurrentValue();
            currentValue.UpdateToQword<int>(13);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToQword<int>(-33);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToQword<int>(122);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToQword<int>(-73599);
            Assert.NotEqual(12, currentValue.value);
        }
        [Fact]
        public static void UpdateToDwordPositive()
        {
            CurrentValue currentValue = new CurrentValue();
            currentValue.UpdateToDword<int>(12);
            Assert.Equal(12, currentValue.value);
            currentValue.UpdateToDword<int>(122);
            Assert.Equal(122, currentValue.value);
            currentValue.UpdateToDword<int>(-33);
            Assert.Equal(-33, currentValue.value);
            currentValue.UpdateToDword<int>(0);
            Assert.Equal(0, currentValue.value);
        }
        [Fact]
        public static void UpdateToDwordNegative()
        {
            CurrentValue currentValue = new CurrentValue();
            currentValue.UpdateToDword<int>(13);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToDword<int>(-33);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToDword<int>(122);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToDword<int>(-73599);
            Assert.NotEqual(12, currentValue.value);
        }
        [Fact]
        public static void UpdateToWordPositive()
        {
            CurrentValue currentValue = new CurrentValue();
            currentValue.UpdateToWord<int>(12);
            Assert.Equal(12, currentValue.value);
            currentValue.UpdateToWord<int>(122);
            Assert.Equal(122, currentValue.value);
            currentValue.UpdateToWord<int>(-33);
            Assert.Equal(-33, currentValue.value);
            currentValue.UpdateToWord<int>(0);
            Assert.Equal(0, currentValue.value);
        }

        [Fact]
        public static void UpdateToWordNegative()
        {
            CurrentValue currentValue = new CurrentValue();
            currentValue.UpdateToWord<int>(13);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToWord<int>(-33);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToWord<int>(122);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToWord<int>(-735);
            Assert.NotEqual(12, currentValue.value);
        }
        [Fact]
        public static void UpdateToBajtPositive()
        {
            CurrentValue currentValue = new CurrentValue();
            currentValue.UpdateToBajt<int>(12);
            Assert.Equal(12, currentValue.value);
            currentValue.UpdateToBajt<int>(122);
            Assert.Equal(122, currentValue.value);
            currentValue.UpdateToBajt<int>(-33);
            Assert.Equal(-33, currentValue.value);
            currentValue.UpdateToBajt<int>(0);
            Assert.Equal(0, currentValue.value);
        }

        [Fact]
        public static void UpdateToBajtNegative()
        {
            CurrentValue currentValue = new CurrentValue();
            currentValue.UpdateToBajt<int>(0);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToBajt<int>(-1);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToBajt<int>(2);
            Assert.NotEqual(12, currentValue.value);
            currentValue.UpdateToBajt<int>(1);
            Assert.NotEqual(12, currentValue.value);
        }
        [Fact]
        public static void EvaluatePositive()
        {
            Assert.Equal(12, CurrentValue.Evaluate("23 - 11"));
            Assert.Equal(9, CurrentValue.Evaluate("3*3"));
            Assert.Equal(6, CurrentValue.Evaluate("2 + 2 * 2"));
            Assert.Equal(0, CurrentValue.Evaluate("12 % 3"));
        }
        [Fact]
        public static void EvaluateNegative()
        {
            Assert.NotEqual(1, CurrentValue.Evaluate("23 + 14"));
            Assert.NotEqual(0, CurrentValue.Evaluate("23 / 14"));
            Assert.NotEqual(-222, CurrentValue.Evaluate("333 + 143 / 2"));
            Assert.NotEqual(8000, CurrentValue.Evaluate("23 + 14 % 6"));
        }
        [Fact]
        public static void EvaluateAsLongPositive()
        {
            Assert.Equal(12, CurrentValue.EvaluateAsLong("23 - 11"));
            Assert.Equal(9, CurrentValue.EvaluateAsLong("3*3"));
            Assert.Equal(6, CurrentValue.EvaluateAsLong("2 + 2 * 2"));
            Assert.Equal(0, CurrentValue.EvaluateAsLong("12 % 3"));
        }
        [Fact]
        public static void EvaluateAsLongNegative()
        {
            Assert.NotEqual(1, CurrentValue.EvaluateAsLong("23 + 14"));
            Assert.NotEqual(0, CurrentValue.EvaluateAsLong("23 / 14"));
            Assert.NotEqual(-222, CurrentValue.EvaluateAsLong("333 + 143 / 2"));
            Assert.NotEqual(8000, CurrentValue.EvaluateAsLong("23 + 14 % 6"));
        }
        [Fact]
        public static void RolPositive()
        {
            Assert.Equal(8, CurrentValue.Rol(4));
            Assert.Equal(2, CurrentValue.Rol(1));
            Assert.Equal(16, CurrentValue.Rol(8));
            Assert.Equal(32, CurrentValue.Rol(16));
        }
        [Fact]
        public static void RolNegative()
        {
            Assert.NotEqual(3, CurrentValue.Rol(7));
            Assert.NotEqual(8, CurrentValue.Rol(2));
            Assert.NotEqual(0, CurrentValue.Rol(3));
            Assert.NotEqual(1, CurrentValue.Rol(6));
        }
        public static void RorPositive()
        {
            Assert.Equal(4, CurrentValue.Ror(8));
            Assert.Equal(1, CurrentValue.Ror(2));
            Assert.Equal(8, CurrentValue.Ror(16));
            Assert.Equal(32, CurrentValue.Ror(16));
        }
        [Fact]
        public static void RorNegative()
        {
            Assert.NotEqual(7, CurrentValue.Ror(3));
            Assert.NotEqual(3, CurrentValue.Ror(7));
            Assert.NotEqual(8, CurrentValue.Ror(2));
            Assert.NotEqual(1, CurrentValue.Ror(6));
        }

        [Fact]
        public static void ZmienSystemLiczbowyPositive()
        {
            CurrentValue currentValue = new CurrentValue();
            currentValue.ZmienSystemLiczbowy(CurrentValue.DigitSystem.Hex);
            Assert.Equal(CurrentValue.DigitSystem.Hex, currentValue.digitSystem);
        }

        [Fact]
        public static void ZmienSystemLiczbowyNegative()
        {
            CurrentValue currentValue = new CurrentValue();
            currentValue.ZmienSystemLiczbowy(CurrentValue.DigitSystem.Bin);
            Assert.NotEqual(CurrentValue.DigitSystem.Oct, currentValue.digitSystem);
        }
        [Fact]
        public static void initEvalGraniczny()
        {
            Form1 form1 = new Form1();
            CurrentValue currentValue = new CurrentValue();
            currentValue.textBox1Expression = " 0";
            Assert.Equal("0", form1.initEval());
        }
        [Fact]
        public static void initEvalPositive()
        {
            Form1 form1 = new Form1();
            CurrentValue currentValue = new CurrentValue();
            currentValue.textBox1Expression = " 3 + 6 - 9";
            Assert.Equal("0", form1.initEval());
        }
        [Fact]
        public static void initEvalNegative()
        {
            Form1 form1 = new Form1();
            CurrentValue currentValue = new CurrentValue();
            currentValue.textBox1Expression = " 3 + 6 % 90";
            Assert.NotEqual("99999", form1.initEval());
        }

        [Fact]
        public static void InvertNumberSignPositive()
        {
            Form1 form1 = new Form1();
            Assert.Equal("-100", form1.InvertNumberSign("100"));
            Assert.Equal("-1", form1.InvertNumberSign("1"));
            Assert.Equal("8", form1.InvertNumberSign("-8"));
            Assert.Equal("100", form1.InvertNumberSign("-100"));
            Assert.Equal("8", form1.InvertNumberSign("-8"));
        }
        [Fact]
        public static void InvertNumberSignNegative()
        {
            Form1 form1 = new Form1();
            Assert.NotEqual("300", form1.InvertNumberSign("900"));
            Assert.NotEqual("700", form1.InvertNumberSign("8"));
            Assert.NotEqual("30", form1.InvertNumberSign("90"));
            Assert.NotEqual("-100000", form1.InvertNumberSign("900"));
        }
        //teraz bede robil IsNumericToken1(string token)
        [Fact]
        public static void IsNumericToken1Positive()
        {
            Form1 form1 = new Form1();
            Assert.Equal(true, form1.IsNumericToken1("900"));
            Assert.Equal(true, form1.IsNumericToken1("1"));
            Assert.Equal(true, form1.IsNumericToken1("-3"));
            Assert.Equal(true, form1.IsNumericToken1("893253125"));
        }
        [Fact]
        public static void IsNumericToken1Negative()
        {
            Form1 form1 = new Form1();
            Assert.NotEqual(true, form1.IsNumericToken1("9s0"));
            Assert.NotEqual(true, form1.IsNumericToken1("iawef !!!!;"));
            Assert.NotEqual(true, form1.IsNumericToken1("-3-"));
            Assert.NotEqual(true, form1.IsNumericToken1(" ;aefk aeola l"));
        }
        [Fact]
        public static void IsNumericTokenPositive()
        {
            Form1 form1 = new Form1();
            Assert.Equal(true, form1.IsNumericToken("900"));
            Assert.Equal(true, form1.IsNumericToken("1"));
            Assert.Equal(true, form1.IsNumericToken("-3"));
            Assert.Equal(true, form1.IsNumericToken("893253125"));
        }
        [Fact]
        public static void IsNumericTokenNegative()
        {
            Form1 form1 = new Form1();
            Assert.NotEqual(true, form1.IsNumericToken("9s0"));
            Assert.NotEqual(true, form1.IsNumericToken("iawef !!!!;"));
            Assert.NotEqual(true, form1.IsNumericToken("-3-"));
            Assert.NotEqual(true, form1.IsNumericToken(" ;aefk aeola l"));
        }

    }
}

