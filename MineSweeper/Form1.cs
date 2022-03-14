using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MineSweeper : Form
    {
        int dimension;
        cell[][] cellsmap;
        int MinesCount;

        public MineSweeper()
        {
            InitializeComponent();
        }

        void MineGenerator()
        {
            int ri, ci;

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(Easy.Checked == true)
            {
                dimension = 5;
                MinesCount = 5;
            }
            else if(Medium.Checked == true)
            {
                dimension = 7;
                MinesCount = 10;
            }
            else if(Hard.Checked == true)
            {
                dimension = 10;
                MinesCount = 15;
            }
            else 
            {
                MessageBox.Show("Enter Difficulty Level");
            }
            cellsmap = new cell[dimension][];
            for(int i=0;i<dimension;i++)
            {
                cellsmap[i] = new cell[dimension];
            }
            CellPanel.Controls.Clear();
            for(int r=0;r<dimension;r++)
            {
                for(int c=0;c<dimension;c++)
                {
                    cellsmap[r][c] = new cell(r,c,CellPanel.Width,CellPanel.Height,dimension);
                    CellPanel.Controls.Add(cellsmap[r][c]);
                }
            }
            MineGenerator();
        }

       
    }
}
