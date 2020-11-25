using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RomanNumerals
{
    public static class Extensions
    {
        private enum PlaceValue : uint
        {
            Units     = 1,
            Tens      = 10,
            Hundreds  = 100,
            Thousands = 1000
        }

        public static string ToRomanNumeralString(this int number)
        {
            if (number < 0 || number >= 4000)
            {
                throw new ArgumentOutOfRangeException("Argument must be between 0 and 3999", "number");
            }

            String roman = "";

            roman += ConvertPlaceValue(number, PlaceValue.Thousands);
            roman += ConvertPlaceValue(number, PlaceValue.Hundreds);
            roman += ConvertPlaceValue(number, PlaceValue.Tens);
            roman += ConvertPlaceValue(number, PlaceValue.Units);

            return roman;
        }

        private static string ConvertPlaceValue(int numberIn, PlaceValue placeValue)
        {
            var symbols = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            var map = new Dictionary<int, int>() {
                { 1, 0 }, { 10, 2 }, { 100, 4 }, { 1000, 6 }
            };
            int unit = (int)placeValue;
            int number = numberIn % (unit * 10);

            String roman = "";

            if (number >= 9 * unit)
            {
                roman += symbols[map[unit]];
                roman += symbols[map[unit] + 2];
                number -= 9 * unit;
            }

            if (number >= 5 * unit)
            {
                roman += symbols[map[unit] + 1];
                number -= 5 * unit;
            }

            if (number >= 4 * unit)
            {
                roman += symbols[map[unit]];
                roman += symbols[map[unit] + 1];
                number -= 4 * unit;
            }

            while (number >= 1 * unit)
            {
                roman += symbols[map[unit]];
                number -= 1 * unit;
            }

            return roman;
        }
    }
}
