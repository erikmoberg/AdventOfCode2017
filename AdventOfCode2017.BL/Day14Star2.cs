using AdventOfCode2017.BL.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day14Star2 : IResultGenerator<int, string>
    {
        public int Get(string input)
        {
            var bitArrays = new List<BitArray>();
            for (var row = 0; row < 128; row++)
            {
                var knotHash = new Day10Star2().Get($"{input}-{row}");
                var bitArray = ConvertHexToBitArray(knotHash);
                bitArrays.Add(bitArray);
            }

            var regions = new List<Region>();
            for (var row = 0; row < bitArrays.Count; row++)
            {
                for (var column = 0; column < bitArrays[row].Count; column++)
                {
                    if (bitArrays[row][column])
                    {
                        var existing = regions.FirstOrDefault(r => r.Coordinates.Any(c => c.X == column && c.Y == row));
                        if (existing == null)
                        {
                            existing = new Region();
                            existing.Coordinates.Add(new Coordinate { X = column, Y = row });
                            regions.Add(existing);
                        }

                        for (var i = column + 1; i < bitArrays[row].Count; i++)
                        {
                            // search right
                            if (bitArrays[row][i])
                            {
                                TryMerge(regions, existing, i, row);
                                existing.Coordinates.Add(new Coordinate { X = i, Y = row });
                            }
                            else
                            {
                                break;
                            }
                        }

                        for (var i = row + 1; i < bitArrays.Count; i++)
                        {
                            // search down
                            if (bitArrays[i][column])
                            {
                                TryMerge(regions, existing, column, i);
                                existing.Coordinates.Add(new Coordinate { X = column, Y = i });
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            
            return regions.Count;
        }

        private static void TryMerge(List<Region> regions, Region existing, int column, int row)
        {
            var existing2 = regions.FirstOrDefault(r => r.Coordinates.Any(c => c.X == column && c.Y == row));
            if (existing2 != null && existing != existing2)
            {
                existing.Coordinates.AddRange(existing2.Coordinates);
                regions.Remove(existing2);
            }
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