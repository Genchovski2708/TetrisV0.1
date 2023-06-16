﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_1
{
    internal class Shape4 : Shape
    {
        public Shape4(Dot firstPoint, int ixRow, int ixColumn, int limitLeft, int limitRight) : base(firstPoint, ixRow, ixColumn, limitLeft, limitRight)
        {

        }

        public override void FillMatrix()
        {
            switch (Stage)
            {
                case 0:
                case 2:
                    Matrix[0, 0] = true;
                    Matrix[1, 0] = true;
                    Matrix[1, 1] = true;
                    Matrix[2, 1] = true;
                    Width = 2;
                    Height = 3;
                    break; 
                case 1:
                case 3:
                    Matrix[0, 1] = true;
                    Matrix[0, 2] = true;
                    Matrix[1, 0] = true;
                    Matrix[1, 1] = true;
                    Width = 3;
                    Height = 2;
                    break;
            }
            StartingWidthIndex = 0;
            StartingHeightIndex = 0;
        }
    }
}