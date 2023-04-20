using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace othello
{
    class check
    {
        public static void e(DataGridView dg1, int y, int x)
        {
            if (x < 6)
            {
                if (dg1[x + 1, y].Style.BackColor == Form1.opponent && dg1[x + 2, y].Style.BackColor != Color.SandyBrown)
                {
                    int i = x + 1;
                    for (; i < 7 && dg1[i, y].Style.BackColor == Form1.opponent; i++)
                    { }
                    if (dg1[i, y].Style.BackColor != Form1.turn) goto next1;
                    for (; i > x && i >= 0; i--)
                    {
                        dg1[i - 1, y].Style.BackColor = Form1.turn;
                    }
                    dg1[x, y].Style.SelectionBackColor = Form1.turn;
                    if (Form1.turn == Color.Black)
                    {
                        Form1.count = 1;
                    }
                    else Form1.count = 0;
                }
            }
        next1:;
        }        
            public static void se(DataGridView dg1, int y, int x)
            {
                if (y < 6)
                {
                    if (dg1[x, y + 1].Style.BackColor == Form1.opponent && dg1[x, y + 2].Style.BackColor != Color.SandyBrown)
                    {
                        int j = y + 1;
                        for (; j < 7 && dg1[x, j].Style.BackColor == Form1.opponent; j++)
                        { }
                        if (dg1[x, j].Style.BackColor != Form1.turn) goto next2;
                        for (; j > y && j >= 0; j--)
                        {
                            dg1[x, j - 1].Style.BackColor = Form1.turn;
                        }
                        dg1[x, y].Style.SelectionBackColor = Form1.turn;
                        if (Form1.turn == Color.Black)
                        {
                            Form1.count = 1;
                        }
                        else Form1.count = 0;
                    }
                }
        next2:;
            }
        public static void s(DataGridView dg1, int y, int x)
        {
            if (x > 1)
            {
                if (dg1[x - 1, y].Style.BackColor == Form1.opponent && dg1[x - 2, y].Style.BackColor != Color.SandyBrown)
                {
                    int i = x - 1;

                    for (; i > 0 && dg1[i, y].Style.BackColor == Form1.opponent; i--)
                    { }
                    if (dg1[i, y].Style.BackColor != Form1.turn) goto next3;
                    for (; i < x && i <= 7; i++)
                    {
                        dg1[i + 1, y].Style.BackColor = Form1.turn;
                    }
                    dg1[x, y].Style.SelectionBackColor = Form1.turn;
                    if (Form1.turn == Color.Black)
                    {
                        Form1.count = 1;
                    }
                    else Form1.count = 0;
                }
            }
        next3:;
        }
        public static void sw(DataGridView dg1, int y, int x)
        {
            if (y > 1)
            {
                if (dg1[x, y - 1].Style.BackColor == Form1.opponent && dg1[x, y - 2].Style.BackColor != Color.SandyBrown)
                {

                    int j = y - 1;
                    for (; j > 0 && dg1[x, j].Style.BackColor == Form1.opponent; j--)
                    { }
                    if (dg1[x, j].Style.BackColor != Form1.turn) goto next4;
                    for (; j < y && j <= 7; j++)
                    {
                        dg1[x, j + 1].Style.BackColor = Form1.turn;
                    }
                    dg1[x, y].Style.SelectionBackColor = Form1.turn;
                    if (Form1.turn == Color.Black)
                    {
                        Form1.count = 1;
                    }
                    else Form1.count = 0;
                }
            }
        next4:;
        }
        public static void w(DataGridView dg1, int y, int x)
        {
            if (x < 6 && y < 6)
            {
                if (dg1[x + 1, y + 1].Style.BackColor == Form1.opponent && dg1[x + 2, y + 2].Style.BackColor != Color.SandyBrown)
                {
                    int i = x + 1;
                    int j = y + 1;
                    for (; i < 7 && j < 7 && dg1[i, j].Style.BackColor == Form1.opponent; i++, j++)
                    { }
                    if (dg1[i, j].Style.BackColor != Form1.turn) goto next5;
                    for (; i > x && i >= 0 && j > y && j >= 0; i--, j--)
                    {
                        dg1[i - 1, j - 1].Style.BackColor = Form1.turn;
                    }
                    dg1[x, y].Style.SelectionBackColor = Form1.turn;
                    if (Form1.turn == Color.Black)
                    {
                        Form1.count = 1;
                    }
                    else Form1.count = 0;
                }
            }
        next5:;
        }
        public static void nw(DataGridView dg1, int y, int x)
        {
            if (x > 1 && y < 6)
            {
                if (dg1[x - 1, y + 1].Style.BackColor == Form1.opponent && dg1[x - 2, y + 2].Style.BackColor != Color.SandyBrown)
                {
                    int i = x - 1;
                    int j = y + 1;
                    for (; i > 0 && j < 7 && dg1[i, j].Style.BackColor == Form1.opponent; i--, j++)
                    { }
                    if (dg1[i, j].Style.BackColor != Form1.turn) goto next6;
                    for (; i < x && i <= 7 && j > y && j >= 0; i++, j--)
                    {
                        dg1[i + 1, j - 1].Style.BackColor = Form1.turn;
                    }
                    dg1[x, y].Style.SelectionBackColor = Form1.turn;
                    if (Form1.turn == Color.Black)
                    {
                        Form1.count = 1;
                    }
                    else Form1.count = 0;
                }
            }
        next6:;
        }
        public static void n(DataGridView dg1, int y, int x)
        {
            if (x > 1 && y > 1)
            {
                if (dg1[x - 1, y - 1].Style.BackColor == Form1.opponent && dg1[x - 2, y - 2].Style.BackColor != Color.SandyBrown)
                {
                    int i = x - 1;
                    int j = y - 1;
                    for (; i > 0 && j > 0 && dg1[i, j].Style.BackColor == Form1.opponent; i--, j--)
                    { }
                    if (dg1[i, j].Style.BackColor != Form1.turn) goto next7;
                    for (; i < x && i <= 7 && j < y && j <= 7; i++, j++)
                    {
                        dg1[i + 1, j + 1].Style.BackColor = Form1.turn;
                    }
                    dg1[x, y].Style.SelectionBackColor = Form1.turn;
                    if (Form1.turn == Color.Black)
                    {
                        Form1.count = 1;
                    }
                    else Form1.count = 0;
                }
            }
        next7:;
        }
        public static void ne(DataGridView dg1, int y, int x)
        {
            if (x < 6 && y > 1)
            {
                if (dg1[x + 1, y - 1].Style.BackColor == Form1.opponent && dg1[x + 2, y - 2].Style.BackColor != Color.SandyBrown)
                {
                    int i = x + 1;
                    int j = y - 1;
                    for (; i < 7 && j > 0 && dg1[i, j].Style.BackColor == Form1.opponent; i++, j--)
                    { }
                    if (dg1[i, j].Style.BackColor != Form1.turn) goto next8;
                    for (; i > x && i >= 0 && j < y && j <= 7; i--, j++)
                    {
                        dg1[i - 1, j + 1].Style.BackColor = Form1.turn;
                    }
                    dg1[x, y].Style.SelectionBackColor = Form1.turn;
                    if (Form1.turn == Color.Black)
                    {
                        Form1.count = 1;
                    }
                    else Form1.count = 0;
                }
            }
        next8:;
        }
    }
}
