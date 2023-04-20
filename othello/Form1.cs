using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace othello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(8);
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Rows[i].Height = (dataGridView1.Height - 2) / 8;
            }
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    dataGridView1[i, j].Style.BackColor = Color.SandyBrown;

            dataGridView1[3, 3].Style.BackColor = Color.White;
            dataGridView1[3, 4].Style.BackColor = Color.Black;
            dataGridView1[4, 3].Style.BackColor = Color.Black;
            dataGridView1[4, 4].Style.BackColor = Color.White;
            dataGridView1[0, 0].Style.SelectionBackColor= Color.SandyBrown;
            dataGridView2.Rows.Add(4);
            dataGridView2[0, 0].Style.SelectionBackColor = Color.White;
            dataGridView2[0, 0].Style.SelectionForeColor = Color.Black;
            dataGridView2[0, 0].Value = "Rəng";
            dataGridView2[0, 1].Value = "qara";
            dataGridView2[0, 2].Value = "ağ";
            dataGridView2[0, 4].Value = "növbə";
            dataGridView2[1, 0].Value = "Sayı";
            dataGridView2[1, 1].Value = "2";
            dataGridView2[1, 2].Value = "2";
            dataGridView2[1, 4].Value = "qara";
            dataGridView2[0, 3].Value = "-----------------";
            dataGridView2[1, 3].Value = "-----------------";
            dataGridView2[0, 3].Style.BackColor = Color.CornflowerBlue;
            dataGridView2[1, 3].Style.BackColor = Color.CornflowerBlue;

        }
        public static int count = 0;
        public static Color turn = new Color();       
        public static Color opponent = new Color();
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex;
            int x = e.ColumnIndex;
            if (count == 0)
            {
                turn = Color.Black;
                opponent = Color.White;               
            }
            else if (count == 1)
            {
                turn = Color.White;
                opponent = Color.Black;
            }
            if (dataGridView1[x, y].Style.BackColor == Color.SandyBrown) {
                check.e(dataGridView1, y, x);
                check.se(dataGridView1, y, x);
                check.s(dataGridView1, y, x);
                check.sw(dataGridView1, y, x);
                check.w(dataGridView1, y, x);
                check.nw(dataGridView1, y, x);
                check.n(dataGridView1, y, x);
                check.ne(dataGridView1, y, x);
            }            
            dataGridView2[1, 1].Value = pointcheck.pointsblack(dataGridView1);
            dataGridView2[1, 2].Value = pointcheck.pointswhite(dataGridView1);
            if (count == 1)
            {
                dataGridView2[1, 4].Value = "ağ";
            }
            else dataGridView2[1, 4].Value = "qara";
        }
    }
}

