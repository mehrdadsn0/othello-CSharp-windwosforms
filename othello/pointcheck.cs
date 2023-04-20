using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace othello
{
    class pointcheck
    {
        public static int pointswhite(DataGridView dg) {
            int point = 0;
            for (int i = 0; i < 8; i++)
            {
                for(int j = 0; j<8; j++)
                {
                    if (dg[i, j].Style.BackColor == Color.White) point++;
                }
            }
            return point;
        }
        public static int pointsblack(DataGridView dg)
        {
            int point = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (dg[i, j].Style.BackColor == Color.Black) point++;
                }
            }
            return point;
        }
    }
}
