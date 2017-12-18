using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day14Star1 : IResultGenerator<int, string>
    {
        public int Get(string input)
        {
            var used = 0;
            for (var row = 0; row < 128; row++)
            {
                var knotHash = new Day10Star2().Get($"{input}-{row}");
                var bitArray = ConvertHexToBitArray(knotHash);

                for (var i = 0; i < bitArray.Count; i++)
                {
                    if (bitArray[i])
                    {
                        used++;
                    }
                }
            }

            return used;
        }

        public static BitArray ConvertHexToBitArray(string hexData)
        {
            var bitArray = new BitArray(4 * hexData.Length);
            for (int i = 0; i < hexData.Length; i++)
            {
                var b = byte.Parse(hexData[i].ToString(), NumberStyles.HexNumber);
                for (int j = 0; j < 4; j++)
                {
                    bitArray.Set(i * 4 + j, (b & (1 << (3 - j))) != 0);
                }
            }

            return bitArray;
        }
    }
}