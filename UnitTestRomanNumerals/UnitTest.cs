
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Windows.Data.Text;
using Windows.Media.Devices;
using RomanNumerals;

namespace UnitTestRomanNumerals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] public void Test0() { Assert.AreEqual("", 0.ToRomanNumeralString()); }

        [TestMethod] public void Test1() { Assert.AreEqual("I",    1.ToRomanNumeralString()); }
        [TestMethod] public void Test2() { Assert.AreEqual("II",   2.ToRomanNumeralString()); }
        [TestMethod] public void Test3() { Assert.AreEqual("III",  3.ToRomanNumeralString()); }
        [TestMethod] public void Test4() { Assert.AreEqual("IV",   4.ToRomanNumeralString()); }
        [TestMethod] public void Test5() { Assert.AreEqual("V",    5.ToRomanNumeralString()); }
        [TestMethod] public void Test6() { Assert.AreEqual("VI",   6.ToRomanNumeralString()); }
        [TestMethod] public void Test7() { Assert.AreEqual("VII",  7.ToRomanNumeralString()); }
        [TestMethod] public void Test8() { Assert.AreEqual("VIII", 8.ToRomanNumeralString()); }
        [TestMethod] public void Test9() { Assert.AreEqual("IX",   9.ToRomanNumeralString()); }

        [TestMethod] public void Test10() { Assert.AreEqual("X",     10.ToRomanNumeralString()); }
        [TestMethod] public void Test11() { Assert.AreEqual("XI",    11.ToRomanNumeralString()); }
        [TestMethod] public void Test12() { Assert.AreEqual("XII",   12.ToRomanNumeralString()); }
        [TestMethod] public void Test13() { Assert.AreEqual("XIII",  13.ToRomanNumeralString()); }
        [TestMethod] public void Test14() { Assert.AreEqual("XIV",   14.ToRomanNumeralString()); }
        [TestMethod] public void Test15() { Assert.AreEqual("XV",    15.ToRomanNumeralString()); }
        [TestMethod] public void Test16() { Assert.AreEqual("XVI",   16.ToRomanNumeralString()); }
        [TestMethod] public void Test17() { Assert.AreEqual("XVII",  17.ToRomanNumeralString()); }
        [TestMethod] public void Test18() { Assert.AreEqual("XVIII", 18.ToRomanNumeralString()); }
        [TestMethod] public void Test19() { Assert.AreEqual("XIX",   19.ToRomanNumeralString()); }

        [TestMethod] public void Test20() { Assert.AreEqual("XX",     20.ToRomanNumeralString()); }
        [TestMethod] public void Test21() { Assert.AreEqual("XXI",    21.ToRomanNumeralString()); }
        [TestMethod] public void Test22() { Assert.AreEqual("XXII",   22.ToRomanNumeralString()); }
        [TestMethod] public void Test23() { Assert.AreEqual("XXIII",  23.ToRomanNumeralString()); }
        [TestMethod] public void Test24() { Assert.AreEqual("XXIV",   24.ToRomanNumeralString()); }
        [TestMethod] public void Test25() { Assert.AreEqual("XXV",    25.ToRomanNumeralString()); }
        [TestMethod] public void Test26() { Assert.AreEqual("XXVI",   26.ToRomanNumeralString()); }
        [TestMethod] public void Test27() { Assert.AreEqual("XXVII",  27.ToRomanNumeralString()); }
        [TestMethod] public void Test28() { Assert.AreEqual("XXVIII", 28.ToRomanNumeralString()); }
        [TestMethod] public void Test29() { Assert.AreEqual("XXIX",   29.ToRomanNumeralString()); }

        [TestMethod] public void Test30() { Assert.AreEqual("XXX",     30.ToRomanNumeralString()); }
        [TestMethod] public void Test31() { Assert.AreEqual("XXXI",    31.ToRomanNumeralString()); }
        [TestMethod] public void Test32() { Assert.AreEqual("XXXII",   32.ToRomanNumeralString()); }
        [TestMethod] public void Test33() { Assert.AreEqual("XXXIII",  33.ToRomanNumeralString()); }
        [TestMethod] public void Test34() { Assert.AreEqual("XXXIV",   34.ToRomanNumeralString()); }
        [TestMethod] public void Test35() { Assert.AreEqual("XXXV",    35.ToRomanNumeralString()); }
        [TestMethod] public void Test36() { Assert.AreEqual("XXXVI",   36.ToRomanNumeralString()); }
        [TestMethod] public void Test37() { Assert.AreEqual("XXXVII",  37.ToRomanNumeralString()); }
        [TestMethod] public void Test38() { Assert.AreEqual("XXXVIII", 38.ToRomanNumeralString()); }
        [TestMethod] public void Test39() { Assert.AreEqual("XXXIX",   39.ToRomanNumeralString()); }

        [TestMethod] public void Test40() { Assert.AreEqual("XL",     40.ToRomanNumeralString()); }
        [TestMethod] public void Test41() { Assert.AreEqual("XLI",    41.ToRomanNumeralString()); }
        [TestMethod] public void Test42() { Assert.AreEqual("XLII",   42.ToRomanNumeralString()); }
        [TestMethod] public void Test43() { Assert.AreEqual("XLIII",  43.ToRomanNumeralString()); }
        [TestMethod] public void Test44() { Assert.AreEqual("XLIV",   44.ToRomanNumeralString()); }
        [TestMethod] public void Test45() { Assert.AreEqual("XLV",    45.ToRomanNumeralString()); }
        [TestMethod] public void Test46() { Assert.AreEqual("XLVI",   46.ToRomanNumeralString()); }
        [TestMethod] public void Test47() { Assert.AreEqual("XLVII",  47.ToRomanNumeralString()); }
        [TestMethod] public void Test48() { Assert.AreEqual("XLVIII", 48.ToRomanNumeralString()); }
        [TestMethod] public void Test49() { Assert.AreEqual("XLIX",   49.ToRomanNumeralString()); }

        [TestMethod] public void Test50() { Assert.AreEqual("L",     50.ToRomanNumeralString()); }
        [TestMethod] public void Test51() { Assert.AreEqual("LI",    51.ToRomanNumeralString()); }
        [TestMethod] public void Test52() { Assert.AreEqual("LII",   52.ToRomanNumeralString()); }
        [TestMethod] public void Test53() { Assert.AreEqual("LIII",  53.ToRomanNumeralString()); }
        [TestMethod] public void Test54() { Assert.AreEqual("LIV",   54.ToRomanNumeralString()); }
        [TestMethod] public void Test55() { Assert.AreEqual("LV",    55.ToRomanNumeralString()); }
        [TestMethod] public void Test56() { Assert.AreEqual("LVI",   56.ToRomanNumeralString()); }
        [TestMethod] public void Test57() { Assert.AreEqual("LVII",  57.ToRomanNumeralString()); }
        [TestMethod] public void Test58() { Assert.AreEqual("LVIII", 58.ToRomanNumeralString()); }
        [TestMethod] public void Test59() { Assert.AreEqual("LIX",   59.ToRomanNumeralString()); }

        [TestMethod] public void Test60() { Assert.AreEqual("LX",     60.ToRomanNumeralString()); }
        [TestMethod] public void Test61() { Assert.AreEqual("LXI",    61.ToRomanNumeralString()); }
        [TestMethod] public void Test62() { Assert.AreEqual("LXII",   62.ToRomanNumeralString()); }
        [TestMethod] public void Test63() { Assert.AreEqual("LXIII",  63.ToRomanNumeralString()); }
        [TestMethod] public void Test64() { Assert.AreEqual("LXIV",   64.ToRomanNumeralString()); }
        [TestMethod] public void Test65() { Assert.AreEqual("LXV",    65.ToRomanNumeralString()); }
        [TestMethod] public void Test66() { Assert.AreEqual("LXVI",   66.ToRomanNumeralString()); }
        [TestMethod] public void Test67() { Assert.AreEqual("LXVII",  67.ToRomanNumeralString()); }
        [TestMethod] public void Test68() { Assert.AreEqual("LXVIII", 68.ToRomanNumeralString()); }
        [TestMethod] public void Test69() { Assert.AreEqual("LXIX",   69.ToRomanNumeralString()); }

        [TestMethod] public void Test70() { Assert.AreEqual("LXX",     70.ToRomanNumeralString()); }
        [TestMethod] public void Test71() { Assert.AreEqual("LXXI",    71.ToRomanNumeralString()); }
        [TestMethod] public void Test72() { Assert.AreEqual("LXXII",   72.ToRomanNumeralString()); }
        [TestMethod] public void Test73() { Assert.AreEqual("LXXIII",  73.ToRomanNumeralString()); }
        [TestMethod] public void Test74() { Assert.AreEqual("LXXIV",   74.ToRomanNumeralString()); }
        [TestMethod] public void Test75() { Assert.AreEqual("LXXV",    75.ToRomanNumeralString()); }
        [TestMethod] public void Test76() { Assert.AreEqual("LXXVI",   76.ToRomanNumeralString()); }
        [TestMethod] public void Test77() { Assert.AreEqual("LXXVII",  77.ToRomanNumeralString()); }
        [TestMethod] public void Test78() { Assert.AreEqual("LXXVIII", 78.ToRomanNumeralString()); }
        [TestMethod] public void Test79() { Assert.AreEqual("LXXIX",   79.ToRomanNumeralString()); }

        [TestMethod] public void Test80() { Assert.AreEqual("LXXX",     80.ToRomanNumeralString()); }
        [TestMethod] public void Test81() { Assert.AreEqual("LXXXI",    81.ToRomanNumeralString()); }
        [TestMethod] public void Test82() { Assert.AreEqual("LXXXII",   82.ToRomanNumeralString()); }
        [TestMethod] public void Test83() { Assert.AreEqual("LXXXIII",  83.ToRomanNumeralString()); }
        [TestMethod] public void Test84() { Assert.AreEqual("LXXXIV",   84.ToRomanNumeralString()); }
        [TestMethod] public void Test85() { Assert.AreEqual("LXXXV",    85.ToRomanNumeralString()); }
        [TestMethod] public void Test86() { Assert.AreEqual("LXXXVI",   86.ToRomanNumeralString()); }
        [TestMethod] public void Test87() { Assert.AreEqual("LXXXVII",  87.ToRomanNumeralString()); }
        [TestMethod] public void Test88() { Assert.AreEqual("LXXXVIII", 88.ToRomanNumeralString()); }
        [TestMethod] public void Test89() { Assert.AreEqual("LXXXIX",   89.ToRomanNumeralString()); }

        [TestMethod] public void Test90() { Assert.AreEqual("XC",     90.ToRomanNumeralString()); }
        [TestMethod] public void Test91() { Assert.AreEqual("XCI",    91.ToRomanNumeralString()); }
        [TestMethod] public void Test92() { Assert.AreEqual("XCII",   92.ToRomanNumeralString()); }
        [TestMethod] public void Test93() { Assert.AreEqual("XCIII",  93.ToRomanNumeralString()); }
        [TestMethod] public void Test94() { Assert.AreEqual("XCIV",   94.ToRomanNumeralString()); }
        [TestMethod] public void Test95() { Assert.AreEqual("XCV",    95.ToRomanNumeralString()); }
        [TestMethod] public void Test96() { Assert.AreEqual("XCVI",   96.ToRomanNumeralString()); }
        [TestMethod] public void Test97() { Assert.AreEqual("XCVII",  97.ToRomanNumeralString()); }
        [TestMethod] public void Test98() { Assert.AreEqual("XCVIII", 98.ToRomanNumeralString()); }
        [TestMethod] public void Test99() { Assert.AreEqual("XCIX",   99.ToRomanNumeralString()); }

        [TestMethod] public void Test100() { Assert.AreEqual("C",        100.ToRomanNumeralString()); }
        [TestMethod] public void Test101() { Assert.AreEqual("CI",       101.ToRomanNumeralString()); }
        [TestMethod] public void Test112() { Assert.AreEqual("CXII",     112.ToRomanNumeralString()); }
        [TestMethod] public void Test123() { Assert.AreEqual("CXXIII",   123.ToRomanNumeralString()); }
        [TestMethod] public void Test134() { Assert.AreEqual("CXXXIV",   134.ToRomanNumeralString()); }
        [TestMethod] public void Test145() { Assert.AreEqual("CXLV",     145.ToRomanNumeralString()); }
        [TestMethod] public void Test156() { Assert.AreEqual("CLVI",     156.ToRomanNumeralString()); }
        [TestMethod] public void Test167() { Assert.AreEqual("CLXVII",   167.ToRomanNumeralString()); }
        [TestMethod] public void Test178() { Assert.AreEqual("CLXXVIII", 178.ToRomanNumeralString()); }
        [TestMethod] public void Test189() { Assert.AreEqual("CLXXXIX",  189.ToRomanNumeralString()); }
        [TestMethod] public void Test197() { Assert.AreEqual("CXCVII",   197.ToRomanNumeralString()); }

        [TestMethod] public void Test1000() { Assert.AreEqual("M",        1000.ToRomanNumeralString()); }
        [TestMethod] public void Test1010() { Assert.AreEqual("MX",       1010.ToRomanNumeralString()); }
        [TestMethod] public void Test1120() { Assert.AreEqual("MCXX",     1120.ToRomanNumeralString()); }
        [TestMethod] public void Test1230() { Assert.AreEqual("MCCXXX",   1230.ToRomanNumeralString()); }
        [TestMethod] public void Test1340() { Assert.AreEqual("MCCCXL",   1340.ToRomanNumeralString()); }
        [TestMethod] public void Test1450() { Assert.AreEqual("MCDL",     1450.ToRomanNumeralString()); }
        [TestMethod] public void Test1560() { Assert.AreEqual("MDLX",     1560.ToRomanNumeralString()); }
        [TestMethod] public void Test1670() { Assert.AreEqual("MDCLXX",   1670.ToRomanNumeralString()); }
        [TestMethod] public void Test1780() { Assert.AreEqual("MDCCLXXX", 1780.ToRomanNumeralString()); }
        [TestMethod] public void Test1890() { Assert.AreEqual("MDCCCXC",  1890.ToRomanNumeralString()); }
        [TestMethod] public void Test1970() { Assert.AreEqual("MCMLXX",   1970.ToRomanNumeralString()); }

        [TestMethod] public void Test3999() { Assert.AreEqual("MMMCMXCIX", 3999.ToRomanNumeralString()); }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMinus1() { (-1).ToRomanNumeralString(); }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))] 
        public void Test4000() { 4000.ToRomanNumeralString(); }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test4245() { 4245.ToRomanNumeralString(); }
    }
}
