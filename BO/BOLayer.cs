using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace BO
{
    public class BOLayer
    {
        Data[] pl = new Data[4];
        
        public BOLayer()
        {
            pl[0] = new Data(80, 42);
            pl[1] = new Data(423, 42);
            pl[2] = new Data(80, 260);
            pl[3] = new Data(423, 260);
        }

        public void sorting(Panel p, int x, int y, Panel p1, Panel p2, Panel p3, int flag)
        {
            Panel[] pa = new Panel[3];
     
            int[] tabNumber = new int[3];
            tabNumber[0] = p1.TabIndex;
            tabNumber[1] = p2.TabIndex;
            tabNumber[2] = p3.TabIndex;
            int e = p.TabIndex;
            int k=0;
            
            for(int i=0; i<3; i++)
            {
                int j = 0;
                while (j < 3 - (i+1))
                {
                    if (tabNumber[j] > tabNumber[j + 1])
                    {
                        int temp = tabNumber[j];
                        tabNumber[j] = tabNumber[j + 1];
                        tabNumber[j + 1] = temp;
                    }
                    j++;
                }
            }
      
            k = 0;
            for(int i=0; i<3; i++)
            {
                if(tabNumber[i] == p1.TabIndex)
                {
                    pa[k++] = p1;
                }
                else if(tabNumber[i] == p2.TabIndex)
                {
                    pa[k++] = p2;
                }
                else if(tabNumber[i] == p3.TabIndex)
                {
                    pa[k++] = p3;
                }
            }
            
            //sorting
            k = 0;
            if (flag == 3)
            {
                pa[0].Location = new Point(pl[0].X, pl[0].Y);
                pa[1].Location = new Point(pl[1].X, pl[1].Y);
                pa[2].Location = new Point(pl[3].X, pl[3].Y);
            }
            else if(flag == 1)
            {
                pa[0].Location = new Point(pl[1].X, pl[1].Y);
                pa[1].Location = new Point(pl[2].X, pl[2].Y);
                pa[2].Location = new Point(pl[3].X, pl[3].Y);
            }
            else if (flag == 2)
            {
                pa[0].Location = new Point(pl[0].X, pl[0].Y);
                pa[1].Location = new Point(pl[2].X, pl[2].Y);
                pa[2].Location = new Point(pl[3].X, pl[3].Y);
            }
            else if (flag == 4)
            {
                pa[0].Location = new Point(pl[0].X, pl[0].Y);
                pa[1].Location = new Point(pl[1].X, pl[1].Y);
                pa[2].Location = new Point(pl[2].X, pl[2].Y);
            }
        }
        Panel p;
        public void panelMovement(Panel p1, Panel p2, Panel p3, Panel p4, int x, int y)
        {
            //left down
            if (p1.Location.X > 0 && p1.Location.Y > 112 && p1.Location.X < 200 && p1.Location.Y < 350)
            {
                p = getPanel(80, 260,p1,p2,p3,p4);
                p1.Location = new Point(80, 260);
                p.Location = new Point(x, y);
                sorting(p1, 80, 260, p2, p3, p4, 3);
            }
            //right up
            else if (p1.Location.X > 330 && p1.Location.Y > 0 && p1.Location.X < 500 && p1.Location.Y < 100)
            {
                p = getPanel(423, 42, p1, p2, p3, p4);
                p1.Location = new Point(423, 42);
                p.Location = new Point(x, y);
                sorting(p1, p1.Location.X, p1.Location.Y, p2, p3, p4, 2);
            }
            //right down
            else if (p1.Location.X > 330 && p1.Location.Y > 157 && p1.Location.X < 500 && p1.Location.Y < 350)
            {
                p = getPanel(423, 260, p1, p2, p3, p4);
                p1.Location = new Point(423, 260);
                p.Location = new Point(x, y);
                sorting(p1, p1.Location.X, p1.Location.Y, p2, p3, p4, 4);
            }
            //left top
            else if (p1.Location.X > 0 && p1.Location.Y > 0 && p1.Location.X < 150 && p1.Location.Y < 150)
            {
                p = getPanel(80, 42, p1, p2, p3, p4);
                p1.Location = new Point(80, 42);
                p.Location = new Point(x, y);
                sorting(p1, p1.Location.X, p1.Location.Y, p2, p3, p4, 1);
            }
            else
                p1.Location = new Point(x, y);
        }
        Panel getPanel(int x, int y, Panel p1, Panel p2, Panel p3, Panel p4)
        {
            if (p1.Location.X == x && p1.Location.Y == y)
                return p1;
            else if (p2.Location.X == x && p2.Location.Y == y)
                return p2;
            else if (p3.Location.X == x && p3.Location.Y == y)
                return p3;
            else
                return p4;
        }
    }
}
