using AdventOfCode2017.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day03Star1
    {
        public int Get(int input)
        {
            var currentWidth = 0;
            var currentHeight = 0;
            var currentX = 0;
            var currentY = 0;
            var direction = 0;
            var squares = new List<Square>();
            squares.Add(new Square { X = 0, Y = 0, Number = 1 });
            for (var i = 0; i < input - 1; i++)
            {
                if (direction == 0)
                {
                    // right
                    if (currentX <= currentWidth)
                    {
                        currentX++;
                        if (currentX > currentWidth)
                        {
                            // go up
                            direction = 1;
                        }
                    }
                }
                else if (direction == 1)
                {
                    // up
                    if (currentY <= currentHeight)
                    {
                        currentY++;
                        if (currentY > currentHeight)
                        {
                            // go left
                            direction = 2;
                        }
                    }
                }
                else if (direction == 2)
                {
                    // left
                    if (-currentX <= currentWidth - 1)
                    {
                        currentX--;
                        if (-currentX > currentWidth - 1)
                        {
                            // go down
                            direction = 3;
                        }
                    }
                }
                else if (direction == 3)
                {
                    // down
                    if (-currentY <= currentHeight - 1)
                    {
                        currentY--;
                        if (-currentY > currentHeight - 1)
                        {
                            // go right
                            direction = 0;
                        }
                    }
                }

                currentWidth = Math.Max(currentX, currentWidth);
                currentHeight = Math.Max(currentY, currentHeight);
                squares.Add(new Square { Number = i + 2, X = currentX, Y = currentY });
            }

            var square = squares.FirstOrDefault(x => x.Number == input);
            return Math.Abs(square.X) + Math.Abs(square.Y);
        }
    }
}
