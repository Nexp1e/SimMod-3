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

        int GetBoolean(int num, int power)
        {
            return (num / (int)Math.Pow(2, power)) % 2;
        }

        void SetConversions(int rule)
        {
            conversions.Clear();
            conversions.Add(0);
            for (int i = 0; i < 8; i++)
            {
                conversions.Add(0);
                conversions[i] = GetBoolean(rule, i);
            }
        }

        void Mod(params int[] nums)
        {
            //уже забыл, зачем оно надо
            //return (nums[2] * 4 + nums[1] * 2 + nums[0])
        }

        void Clear()
        {
            time = 0;
            CellsTable.Rows.Clear();
            CellsTable.Rows[0].Cells[0].Value = 0;
        }

        public Form1()
        {
            InitializeComponent();
            conversions = new List<int>(8);
            prevCells = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
            currCells = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;

            int rowIndex = CellsTable.Rows.AddCopy(0);
            CellsTable.Rows[rowIndex].Cells[0].Value = time;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
                Clear();
                SetConversions((int)inputRule.Value);
            }
        }

        private void CellTable1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
            if (prevCells[e.ColumnIndex - 1] == 1)
            {
                prevCells[e.ColumnIndex - 1] = 1;
                CellStyle.BackColor = CellsTable.DefaultCellStyle.BackColor;
            }
            else
            {
                prevCells[e.ColumnIndex - 1] = 0;
                CellStyle.BackColor = Color.Red;
            }
            CellsTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = CellStyle;
            //CellsTable.CurrentCell.Selected = false;
        }
    }
}
