using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimMod_3
{
    public partial class Form1 : Form
    {
        List<int> conversions;
        int time;
        List<int> prevCells;
        List<int> currCells;

        int Pow(int num, int pow)
        {
            int res = 1;
            for (int i = 0; i < pow; i++)
            {
                res *= num;
            }
            return res;
        }

        void Step()
        {
            prevCells = new List<int>(currCells);

            for (int i = 0; i < 12; i++)
            {
                currCells[i] = GetNewCellValByIndex(i);
            }
        }

        DataGridViewRow ColorNewRow(DataGridViewRow row)
        {
            for (int i = 1; i <= 12; i++)
            {
                if (currCells[i - 1] == 1)
                {
                    row.Cells[i].Style.BackColor = Color.Red;
                }
            }
            return row;
        }
        int NewFromTriplet(int[] nums)
        {
            return conversions[7 - (nums[0] * 4 + nums[1] * 2 + nums[2])];
        }

        int GetNewCellValByIndex(int index)
        {
            int[] vals = new int[3];
            vals[0] = prevCells[index - 1 < 0 ? index - 1 + 12 : index - 1];
            vals[1] = prevCells[index];
            vals[2] = prevCells[index + 1 >= 12 ? index + 1 - 12 : index + 1];

            return NewFromTriplet(vals);
        }

        int GetBoolean(int num, int power)
        {
            return (num & Pow(2, power)) != 0 ? 1 : 0;
        }

        void SetConversions(int rule)
        {
            conversions.Clear();
            conversions.Add(0);
            for (int i = 0; i < 8; i++)
            {
                conversions.Add(0);
                conversions[i] = GetBoolean(rule, 7 - i);
            }
        }

        void Clear()
        {
            time = 0;
            DataGridViewRow row = (DataGridViewRow)CellsTable.Rows[0].Clone();
            CellsTable.Rows.Clear();
            CellsTable.Rows.Add(row);
            CellsTable.Rows[0].Cells[0].Value = 0;
        }

        void FillCellDataFromColors()
        {
            var row = CellsTable.Rows[0];
            for (int i = 0; i < 12; i++)
            {
                if (row.Cells[i + 1].Style.BackColor == Color.Red)
                {
                    currCells[i] = 1;
                }
            }
        }

        void ResetVals()
        {
            prevCells = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            currCells = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public Form1()
        {
            InitializeComponent();
            conversions = new List<int>(8);
            ResetVals();
            Clear();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;

            DataGridViewRow row = (DataGridViewRow)CellsTable.Rows[0].Clone();
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = Color.White;
            }
            row.Cells[0].Value = time;

            Step();
            row = ColorNewRow(row);





            CellsTable.Rows.Insert(CellsTable.Rows.Count - 1, row);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                ResetVals();
            }
            else
            {
                FillCellDataFromColors();
                Clear();
                SetConversions((int)inputRule.Value);
                timer1.Start();
            }
        }

        private void CellTable1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellsTable.CurrentCell.Selected = false;
            if (e.ColumnIndex == 0)
            {
                return;
            }
            DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
            if (currCells[e.ColumnIndex - 1] == 1)
            {
                currCells[e.ColumnIndex - 1] = 0;
                CellStyle.BackColor = CellsTable.DefaultCellStyle.BackColor;
            }
            else
            {
                currCells[e.ColumnIndex - 1] = 1;
                CellStyle.BackColor = Color.Red;
            }
            CellsTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = CellStyle;
            
        }
    }
}
