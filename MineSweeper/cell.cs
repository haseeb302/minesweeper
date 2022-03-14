using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    class cell:Button
    {
        int ri;
        int ci;
        bool isOpen;
        int Value;
        
        public
        cell(int r,int c,int W,int H,int dim)
        {
            ri = r;
            ci = c;
            isOpen = false;
            Value = 0;
            this.Width = W / dim - 9;
            this.Height = H / dim - 9;
        }
    }
    
}
