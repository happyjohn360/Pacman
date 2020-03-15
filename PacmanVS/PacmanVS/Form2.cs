using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace PacmanVS
{
    public partial class Form2 : Form
    {
        int state = 1;
        bool PAUSED = false;
        bool ALREADY = false;
        const int pacSize = 20;
        int dWidth = 2, dLength = 4;
        int count_1 = 0, count1_1 = 0, count_2 = 0, count1_2;
        /* Map */
        int Map_X_draw = 100, Map_Y_draw = 50;
        const int Map_X = 100, Map_Y = 50;
        int p1item1 = -1, p1item2 = -1, p2item1 = -1, p2item2 = -1;
        int time = 0;
        int now,whpoint;
        int score_1 = 0, score_2 = 0;
        int fever1 = 1,fever2=1;
        int CDIndex = 0;
        static int t = 0, t1 = 0;
        int [] pathx = new int[] {t*t/128};
        int[] pathy = new int[] {t};
        void point1(ref int pt)
        {
            pt += time*fever1;
        }
        void point2(ref int pt)
        {
            pt += time *fever2;
        }
        int[,] Map1 = new int[21, 17]
       {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1},
            {1,0,1,1,0,1,1,0,1,0,1,1,0,1,1,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,1,1,0,1,0,1,1,1,0,1,0,1,1,0,1},
            {1,0,0,0,0,1,0,0,1,0,0,1,0,0,0,0,1},
            {1,1,1,1,0,1,1,0,1,0,1,1,0,1,1,1,1},
            {1,1,1,1,0,1,0,0,0,0,0,1,0,1,1,1,1},
            {1,1,1,1,0,1,0,1,0,1,0,1,0,1,1,1,1},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {1,1,1,1,0,1,0,1,0,1,0,1,0,1,1,1,1},
            {1,1,1,1,0,1,0,0,0,0,0,1,0,1,1,1,1},
            {1,1,1,1,0,1,0,1,1,1,0,1,0,1,1,1,1},
            {1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1},
            {1,0,1,1,0,1,1,0,1,0,1,1,0,1,1,0,1},
            {1,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,1},
            {1,1,0,1,0,1,0,1,1,1,0,1,0,1,0,1,1},
            {1,0,0,0,0,1,0,0,1,0,0,1,0,0,0,0,1},
            {1,0,1,1,1,1,1,0,1,0,1,1,1,1,1,0,1},
            {1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
       };
        int[,] Map = new int[21, 17]
        {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,3,0,0,0,0,0,0,1,0,0,0,0,0,0,3,1},
            {1,0,1,1,0,1,1,0,1,0,1,1,0,1,1,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,1,1,0,1,0,1,1,1,0,1,0,1,1,0,1},
            {1,0,0,0,0,1,0,0,1,0,0,1,0,0,0,0,1},
            {1,1,1,1,0,1,1,0,1,0,1,1,0,1,1,1,1},
            {1,1,1,1,0,1,0,0,0,0,0,1,0,1,1,1,1},
            {1,1,1,1,0,1,0,1,0,1,0,1,0,1,1,1,1},
            {-2,0,0,0,0,0,0,5,0,5,0,0,0,0,0,0,-2},
            {1,1,1,1,0,1,0,1,0,1,0,1,0,1,1,1,1},
            {1,1,1,1,0,1,0,0,0,0,0,1,0,1,1,1,1},
            {1,1,1,1,0,1,0,1,1,1,0,1,0,1,1,1,1},
            {1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1},
            {1,0,1,1,0,1,1,0,1,0,1,1,0,1,1,0,1},
            {1,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,1},
            {1,1,0,1,0,1,0,1,1,1,0,1,0,1,0,1,1},
            {1,0,0,0,0,1,0,0,1,0,0,1,0,0,0,0,1},
            {1,0,1,1,1,1,1,0,1,0,1,1,1,1,1,0,1},
            {1,3,0,0,0,0,0,0,1,0,0,0,0,0,0,3,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
        };//171
        bool empty = true;
        /* P1 Spec */
        int pacIndex_1 = 0;
        int x_1 = 327, y_1 = 277;
        int ctrl_1 = 3;
        int ctrl_1t = 3;

        /* P2 Spec */
        int pacIndex_2 = 0;
        int x_2 = 277, y_2 = 277;
        int ctrl_2 = 4;
        int ctrl_2t = 4;
        int[] k = new int[7];
        private void timer5_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<21;i++)
                for(int j=0;j<17;j++)
                    if (Map[i,j] == 4)
                        Map[i,j] = 3;
        }
        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Bitmap scr = new Bitmap(800,600);
            Graphics dr1 = Graphics.FromImage(scr);
            Graphics dr2 = Graphics.FromImage(scr);
            Graphics dr3 = Graphics.FromImage(scr);

            Point pt1 = Cursor.Position;
            pt1 = this.PointToClient(pt1);
            Pen myPen = new Pen(Color.LightBlue, 2);
            Brush myBrush = new SolidBrush(Color.Blue);
            Brush pointBrush= new SolidBrush(Color.White);
            Brush bombbrush = new SolidBrush(Color.Orange);
            Random rnd = new Random();           
            Map_X_draw =100; Map_Y_draw = 50;

            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (Map[i, j] ==1)
                    {
                        dr1.FillRectangle(myBrush, Map_X_draw, Map_Y_draw, 25, 25);
                    }
                    if (Map[i, j] == 0)
                    {
                        dr1.FillEllipse(pointBrush, Map_X_draw + 8, Map_Y_draw + 8, 8, 8);
                        empty = false;
                    }
                    if (Map[i, j] == 3)
                    {
                        dr1.DrawImage(Properties.Resources.barbed_sun, Map_X_draw, Map_Y_draw,25,25);
                    }
                    if (Map1[i, j] == 2)
                        dr1.DrawImage(bomb.Images[bombindex], Map_X_draw-12, Map_Y_draw-10);
                    if (Map1[i, j] == 2)
                        dr1.DrawImage(bomb.Images[bombindex0], Map_X_draw - 12, Map_Y_draw - 10);                   
                    Map_X_draw += 25;                   
                }
                Map_X_draw = 100;
                Map_Y_draw += 25;            
            }            
            //Map_X = 100; Map_Y = 50;
            //Draw P1
            switch (ctrl_1t)
            {
                case 0:
                    dr2.DrawImage(P1_Death.Images[pacIndex_1], x_1, y_1);
                    break;
                case 1:
                    dr2.DrawImage(P1_Up.Images[pacIndex_1], x_1, y_1);
                    break;
                case 2:
                    dr2.DrawImage(P1_Down.Images[pacIndex_1], x_1, y_1);
                    break;
                case 3:
                    dr2.DrawImage(P1_Left.Images[pacIndex_1], x_1, y_1);
                    break;
                case 4:
                    dr2.DrawImage(P1_Right.Images[pacIndex_1], x_1, y_1);
                    break;
            }
            //Draw P2
            switch (ctrl_2t)
            {
                case 0:
                    dr3.DrawImage(P2_Death.Images[pacIndex_2], x_2, y_2);
                    break;
                case 1:
                    dr3.DrawImage(P2_Up.Images[pacIndex_2], x_2, y_2);
                    break;
                case 2:
                    dr3.DrawImage(P2_Down.Images[pacIndex_2], x_2, y_2);
                    break;
                case 3:
                    dr3.DrawImage(P2_Left.Images[pacIndex_2], x_2, y_2);
                    break;
                case 4:
                    dr3.DrawImage(P2_Right.Images[pacIndex_2], x_2, y_2);
                    break;
            }

            
            if (Items1.Enabled)
            {
                pictureBox1.Image = Hourglass.Images[CDIndex];
                //dr3.DrawImage(Hourglass.Images[CDIndex], 545, 25);
            }
            if (Items2.Enabled)
            {
                pictureBox3.Image = Hourglass.Images[CDIndex];
                //dr3.DrawImage(Hourglass.Images[CDIndex], 12, 39);
            }

            label2.Enabled = false;
            label2.Visible = false;
            //label2.Text =x_2.ToString()+" "+y_2.ToString()+"      "+pt1.X.ToString()+" "+pt1.Y.ToString();                       
            e.Graphics.DrawImage(scr, 0, 0);
            score1.Text = score_1.ToString();
            score2.Text = score_2.ToString();
            second.Text = "Time: " + time.ToString();

            
            
            //!!
            if (empty)
            {
                //gameOver();
                if(ALREADY == false)
                {
                    gameOver.Enabled = true;
                    ALREADY = true;
                    Pause.Visible = true;
                    Pause.Text = "FINISHED!";
                    timer1.Interval = 300;
                    timer3.Interval = 300;
                    timer5.Enabled = false;
                    clock.Enabled = false;
                    timer2.Interval = 300;
                    timer4.Interval = 300;
                    Items1.Enabled = false;
                    Items2.Enabled = false;
                    jumpclock.Enabled = false;
                    jumpclock2.Enabled = false;
                }
                if (gameOver.Enabled == false)
                {
                    Form3 res = new Form3(score1.Text, score2.Text);
                    System.Threading.Thread.Sleep(2000);
                    res.Show();
                    this.Dispose(false);
                }                              
            }
            empty = true;
            //!!
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //P1 Control
            if (e.KeyCode == Keys.Up && t == 0 && PAUSED == false) 
            {
                if ( Math.Abs(x_1 - x_2) <= pacSize&& Math.Abs(y_1 - y_2 - 15)  <= pacSize)
                    timer2.Enabled = false;
                else
                {
                    timer2.Enabled = true;
                    ctrl_1 = 1;
                }
            }
            else if ( e.KeyCode == Keys.Down && t == 0 && PAUSED == false)
            {
                if ( Math.Abs(x_1 - x_2) <= pacSize && Math.Abs(y_1  - y_2+15)  <= pacSize)
                    timer2.Enabled = false;
                else
                {
                    timer2.Enabled = true;
                    ctrl_1 = 2;
                }
            }
            else if (e.KeyCode == Keys.Left && t == 0 && PAUSED == false)
            {
                if ( Math.Abs(y_1 - y_2) <= pacSize&& Math.Abs(x_1 - x_2-15) <= pacSize)
                    timer2.Enabled = false;
                else
                {
                    timer2.Enabled = true;
                    ctrl_1 = 3;
                }
            }
            else if (e.KeyCode == Keys.Right && t == 0 && PAUSED == false)
            {
                if (Math.Abs(y_1 - y_2) <= pacSize  && Math.Abs(x_1  - x_2+15) <= pacSize)              
                    timer2.Enabled = false;
                else
                {
                    timer2.Enabled = true;
                    ctrl_1 = 4;
                }
            }
            if (e.KeyCode == Keys.OemSemicolon && p1item1 != -1 && Items1.Enabled == false && PAUSED == false) 
            {
                useItem(1, p1item1);
            }

            if (e.KeyCode == Keys.OemQuestion && t == 0 && PAUSED == false) 
            {
                jump(ref x_1,ref y_1, ctrl_1t, x_2, y_2);
                
            }

            //P2 Control
            if (e.KeyCode == Keys.W && t1 == 0 && PAUSED == false)
            {
                if (Math.Abs(x_1 - x_2) <= pacSize&& Math.Abs(y_1 - y_2 + 15)  <= pacSize)
                    timer4.Enabled = false;
                else
                {
                    timer4.Enabled = true;
                    ctrl_2 = 1;
                }
            }
            else if (e.KeyCode == Keys.S && t1 == 0 && PAUSED == false)
            {
                if ( Math.Abs(x_1 - x_2) <= pacSize && Math.Abs(y_1- y_2-15) <= pacSize)
                    timer4.Enabled = false;
                else
                {
                    timer4.Enabled = true;
                    ctrl_2 = 2;
                }
            }
            else if (e.KeyCode == Keys.A && t1 == 0 && PAUSED == false)
            {
                if (Math.Abs(y_1 - y_2) <= pacSize  && Math.Abs(x_1-x_2+15 ) <= pacSize)
                    timer4.Enabled = false;
                else
                {
                    timer4.Enabled = true;
                    ctrl_2 =3;
                }
            }
            else if (e.KeyCode == Keys.D && t1 == 0 && PAUSED == false)
            {
                if (Math.Abs(y_1 - y_2) <= pacSize && Math.Abs(x_1- x_2-15d) <= pacSize)
                    timer4.Enabled = false;
                else
                {
                    timer4.Enabled = true;
                    ctrl_2 = 4;
                }
            }

            if (e.KeyCode == Keys.ShiftKey && p2item1 != -1 && Items2.Enabled == false && PAUSED == false)
            {
                useItem(2, p2item1);
                
            }
            if (e.KeyCode == Keys.ControlKey&&t1== 0 && PAUSED == false)
            {
                jump(ref x_2, ref y_2, ctrl_2t, x_1, y_1);
            }
            //!!
            if (e.KeyCode == Keys.U && PAUSED == true) 
            {
                Form3 res = new Form3(score1.Text, score2.Text);
                res.Show();
                this.Dispose(false);
            }
            /*
            if (e.KeyCode == Keys.Space && PAUSED == false)
            {
                //ctrl_1 = 5;
                timer2.Enabled = false;
                timer4.Enabled = false;
            }
            */
            if (e.KeyCode == Keys.Escape && PAUSED == false) 
            {
                Form3 res = new Form3(score1.Text, score2.Text);
                res.Show();
                this.Dispose(false);
            }
            //!!
        }
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                pauseGame(PAUSED);
                PAUSED = !PAUSED;
            }
        }
        //Timeclock
        private void clock_Tick(object sender, EventArgs e)
        {
            n++;
            if (n / 10 == 1)
            {
                time++;
                n = 0;
            }
        }
        int left = 0, right = 0;
        //P1 jump
        private void jumpclock_Tick(object sender, EventArgs e)
        {
            t-=5;
            switch(ctrl_1t)
            {
                case 1:
                    y_1 -= 5; ;
                    break;
                case 2:
                    y_1 += 5; 
                    break;
                case 3:
                    x_1 -= 5;
                    break;
                case 4:
                    x_1 += 5;
                    break;
            }
            if ((t <= (temp / 2)  && ctrl_1t == 1) || (t > (temp / 2)  && ctrl_1t == 2))
            {
                if((t <= (temp / 2)  && ctrl_1t == 1)&&right>0)
                {
                    x_1 += 1;                    
                    right--;
                }
                if((t > (temp / 2) && ctrl_1t == 2))
                {
                    x_1 += 1;
                    left++;
                }
                
            }                
            else if (t > (temp / 2)  && ctrl_1t == 1|| (t <= (temp / 2)  && ctrl_1t == 2))
            {
                if ((t > (temp / 2) && ctrl_1t == 1))
                {
                    x_1 -= 1;
                    right++;
                }
                if ((t <= (temp / 2)  && ctrl_1t == 2)&&left>0)
                {
                    x_1 -= 1;
                    left--;
                }
            }               
            else if ((t >(temp / 2) ) && (ctrl_1t == 3 || ctrl_1t == 4))
            {
                y_1 -= 1;
                left++;
            }               
            else if ((t <=(temp / 2) ) && (ctrl_1t == 3|| ctrl_1t == 4) && left > 0)
            {
                y_1 += 1;
                left--;
            }               
            if (t==0)
            {
                left = 0;
                right = 0;
                jumpclock.Enabled = false;              
            }
                       
        }
        int n = 0,right1=0,left1=0;
        //P2 jump
        private void jumpclock2_Tick(object sender, EventArgs e)
        {
            t1 -= 5;
            switch (ctrl_2t)
            {
                case 1:
                    y_2 -= 5; ;
                    break;
                case 2:
                    y_2 += 5;
                    break;
                case 3:
                    x_2 -= 5;
                    break;
                case 4:
                    x_2 += 5;
                    break;
            }
            if ((t1 <= (temp1 / 2)   && ctrl_2t == 1) || (t1 > (temp1 / 2)+1  && ctrl_2t == 2))
            {
                if((t1 <= (temp1 / 2)  && ctrl_2t == 1)&&left1>0)
                {
                    x_2 += 1;
                    left1--;
                }
                if((t1 > (temp1 / 2) + 1  && ctrl_2t == 2))
                {
                    x_2 += 1;
                    right1++;
                }
            }
                
            else if (t1 > (temp1 / 2)+1  && ctrl_2t == 1 || (t1 <= (temp1 / 2)  && ctrl_2t == 2))
            {
                if(t1 > (temp1 / 2) + 1  && ctrl_2t == 1)
                {
                    x_2 -= 1;
                    left1++;
                }
                if((t1 <= (temp1 / 2) && ctrl_2t == 2)&&right1>0)
                {
                    x_2 -= 1;
                    right1--;
                }
            }               
            else if ((t1 >= (temp1 / 2) ) && (ctrl_2t == 3 || ctrl_2t == 4))
                y_2 -= 1;
            else if ((t1 < (temp1 / 2) ) && (ctrl_2t == 3 || ctrl_2t == 4))
                y_2 += 1;
            if (t1 == 0)
            {
                jumpclock2.Enabled = false;
            }
        }
        private void Collect_Tick(object sender, EventArgs e)
        {    
            this.Invalidate();
            //GC.Collect();          
        }

        private void CD_Tick(object sender, EventArgs e)
        {
            if (CDIndex <= 9)
                CDIndex++;

            if (CDIndex == 10)
                CDIndex = 0;
           
        }

        //P1_Animation
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pacIndex_1 <= 9)
            {
                if (!P1death.Enabled)
                    pacIndex_1++;
                else if (P1death.Enabled && pacIndex_1 != 9)
                    pacIndex_1++;

            }

            if (pacIndex_1 == 10)
            {
                pacIndex_1 = 0;
            }
            //this.Invalidate();
        }
        //P2_Animation
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pacIndex_2 <= 9)
            {
                if (!P2death.Enabled)
                    pacIndex_2++;
                else if (P2death.Enabled && pacIndex_2 != 9)
                    pacIndex_2++;

            }

            if (pacIndex_2 == 10)
            {
                pacIndex_2 = 0;
            }
            //this.Invalidate();
        }
        void reset(int whpoint)
        {
            Random rnd1 = new Random();
            Random rnd2= new Random();
            for (int i=rnd1.Next(0,9);i<21;i++)
            {
                for(int j= rnd1.Next(0, 8); j<17;j++)
                {
                    if (whpoint == 0)
                        break;
                    if (Map[i,j]==-1)
                    {
                        Map[i, j] = 0;
                        whpoint--;
                    }
                    
                }
            }
        }
        int bombindex = 0,bombindex0=0;
        //P1 death
        private void P1death_Tick(object sender, EventArgs e)
        {
            if (pacIndex_1 >= 9)
            {
                timer1.Enabled = false;
                pacIndex_1 = 8;
            }
            timer2.Enabled = false;
            if (time - now >= 3)
            {
                now = 0;
                x_1 = 327;
                y_1 = 277;
                PAUSED = false;
                ctrl_1t = 3;
                ctrl_1 = 3;
                timer1.Enabled = true;
                P1death.Enabled = false;
            }
        }

        

        private void bom_Tick(object sender, EventArgs e)
        {
            bombindex++;
            if(bombindex==9)
            {
                bombindex = 0;
            }
            if (Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X) / 25] == 2 || Map1[(y_1 - Map_Y + pacSize) / 25, (x_1 - Map_X + pacSize) / 25] == 2) 
            {
                
                System.Threading.Thread.Sleep(20);
                //bom2.Enabled = false;
                now = time;
                pacIndex_1 = 0;
                ctrl_1 = 0;
                ctrl_1t = 0;
               // PAUSED = true;
                P1death.Enabled = true;
                score_2 += 300;
                whpoint = (score_1 / 10) / time;
                score_1 -= (score_1 / 10);
                reset(whpoint);
            }
        }     
        //P2 death
        private void P2death_Tick(object sender, EventArgs e)
        {
            if (pacIndex_2 >= 9)
            {
                timer3.Enabled = false;
                pacIndex_2 = 8;
            }
            timer4.Enabled = false;
            if (time - now >= 3)
            {
                now = 0;
                x_2 = 277;
                y_2 = 277;
                PAUSED = false;
                ctrl_2t = 4;
                ctrl_2 = 4;
                timer3.Enabled = true;
                P2death.Enabled = false;
            }
        }
        private void bom1_Tick(object sender, EventArgs e)
        {
            bombindex0++;
            if (bombindex0 == 9)
            {
                bombindex0 = 0;
            }
            if (Map1[(y_2 - Map_Y) / 25, (x_2 - Map_X) / 25] == 2 || Map1[(y_2 - Map_Y + pacSize) / 25, (x_2 - Map_X + pacSize) / 25] == 2) 
            {
                System.Threading.Thread.Sleep(20);
                //bom1.Enabled = false;
                now = time;
                pacIndex_2 = 0;
                ctrl_2 = 0;
                ctrl_2t = 0;
                // PAUSED = true;
                P2death.Enabled = true;
                score_1 += 300;
                whpoint = (score_2 / 10) / time;
                score_2 -= (score_2 /10);
                reset(whpoint);
            }
        }
        //P1_Detect
        private void timer2_Tick(object sender, EventArgs e)
        {
            dLength = 4;
            ctrl_1t = ctrl_1;
            if ((Map[(y_1 - Map_Y +0- dLength) / 25, (x_1 - Map_X +dWidth+0) / 25] == 1|| Map[(y_1 - Map_Y +0- dLength) / 25, (x_1 - Map_X + pacSize-dWidth+0) / 25]==1) && ctrl_1 == 1)
            {
                timer2.Enabled = false;
                ctrl_1 = 5;
            }
            if ((Map[(y_1 - Map_Y + pacSize+ dLength) / 25, (x_1 - Map_X + dWidth +0) / 25] == 1 || Map[(y_1 - Map_Y +pacSize + dLength) / 25, (x_1 - Map_X + pacSize-dWidth +0) / 25] == 1) && ctrl_1 == 2)
            {
                timer2.Enabled = false;
                ctrl_1 = 5;
            }
            if ((Map[(y_1 - Map_Y + dWidth + 0) / 25, (x_1 - Map_X + 0- dLength) / 25] == 1 || Map[(y_1 -Map_Y+pacSize-dWidth+0) / 25, (x_1 - Map_X+0 - dLength) / 25] == 1) && ctrl_1 == 3)
            {
                timer2.Enabled = false;
                ctrl_1 = 5;
            }
            //
            if ((x_1 <= 127 ) && ctrl_1 == 3&&x_2<=477)
            {
                x_1 = 497;
                dLength = 0;
            }
            //

            if ((Map[(y_1 - Map_Y + dWidth + 0) / 25, (x_1 - Map_X + pacSize + dLength) / 25] == 1 || Map[(y_1 - Map_Y  +pacSize-dWidth+0) / 25, (x_1 - Map_X + pacSize+dLength) / 25] == 1) && ctrl_1 == 4)
            {
                timer2.Enabled = false;
                ctrl_1 = 5;
            }
            //
            if ((x_1 >= 477 ) && ctrl_1 == 4&&x_2>=127)
            {
                x_1 = 107;
                dLength = 0;
            }
            //
            //
            //ctrl_1t = ctrl_1;
            count_1 = 0;
            count1_1 = 0;
            for (int i = 0; i < 5; i++)
            {
                switch (ctrl_1)
                {
                    case 1:
                        y_1 -= 1;
                        if(ctrl_2!=1)
                            count1_1--;
                        break;
                    case 2:
                        y_1 += 1;
                        if ( ctrl_2 != 2)
                            count1_1--;
                        break;
                    case 3:
                        x_1 -= 1;
                        if ( ctrl_2 != 3)
                            count_1--;
                        break;
                    case 4:
                        x_1 += 1;
                        if (ctrl_2 != 4)
                            count_1--;
                        break;
                    default:
                        break;
                }
                if (Map[(y_1 - Map_Y + 10) / 25, (x_1 - Map_X + 10) / 25] == 0)
                {
                    Map[(y_1 - Map_Y + 10) / 25, (x_1 - Map_X + 10) / 25] = -1;
                    point1(ref score_1);
                }
                if (Map[(y_1 - Map_Y + 10) / 25, (x_1 - Map_X + 10) / 25] == 3)
                {
                    Map[(y_1 - Map_Y + 10) / 25, (x_1 - Map_X + 10) / 25] = 4;
                    if (pictureBox1.Image == null)
                    {
                        p1item1 = selectitem();
                        pictureBox1.Image = item.Images[p1item1];

                    }
                    else if (pictureBox2.Image == null)
                    {
                        p1item2 = selectitem();
                        pictureBox2.Image = item.Images[p1item2];
                    }
                    
                }
                if (Math.Abs(x_1 - x_2) + count_1 <= pacSize && Math.Abs(y_1 - y_2) + count1_1 <= pacSize)
                {
                    state = 0;
                    timer2.Enabled = false;
                }
                //this.Invalidate();
            }                                                
        }       
        int temp = 0,temp1=0;             
        //P2_Detect
        private void timer4_Tick(object sender, EventArgs e)
        {
            dLength = 4;
            ctrl_2t = ctrl_2;
            if ((Map[(y_2 - Map_Y + 0 - dLength) / 25, (x_2 - Map_X + dWidth + 0) / 25] == 1 || Map[(y_2 - Map_Y + 0 - dLength) / 25, (x_2 - Map_X + pacSize - dWidth + 0) / 25] == 1) && ctrl_2 == 1)
            {
                timer4.Enabled = false;
                ctrl_2 = 5;
            }
            if ((Map[(y_2 - Map_Y + pacSize + dLength) / 25, (x_2 - Map_X + dWidth + 0) / 25] == 1 || Map[(y_2 - Map_Y + pacSize + dLength) / 25, (x_2 - Map_X + pacSize - dWidth + 0) / 25] == 1) && ctrl_2 == 2)
            {
                timer4.Enabled = false;
                ctrl_2 = 5;
            }
            if ((Map[(y_2 - Map_Y + dWidth + 0) / 25, (x_2 - Map_X + 0 - dLength) / 25] == 1 || Map[(y_2 - Map_Y + pacSize - dWidth + 0) / 25, (x_2 - Map_X + 0 - dLength) / 25] == 1) && ctrl_2 == 3)
            {
                timer4.Enabled = false;
                ctrl_2 = 5;
            }
            //
            if ((x_2 <= 127) && ctrl_2 == 3 && x_1 <= 477)
            {
                x_2 = 497;
                dLength = 0;
            }
            //
            if ((Map[(y_2 - Map_Y + dWidth + 0) / 25, (x_2 - Map_X + pacSize + dLength) / 25] == 1 || Map[(y_2 - Map_Y + pacSize - dWidth + 0) / 25, (x_2 - Map_X + pacSize + dLength) / 25] == 1) && ctrl_2 == 4)
            {
                timer4.Enabled = false;
                ctrl_2 = 5;
            }
            //
            if ((x_2 >= 477 ) && ctrl_2 == 4 && x_1>= 127)
            {
                x_2 = 107;
                dLength = 0;
            }
            //
            count1_2 = 0;
            count_2 = 0;          
            for (int i = 0; i < 5; i++)
            {              
                switch (ctrl_2)
                {
                    case 1:
                        y_2 -= 1;
                        if (ctrl_1 != 1 )
                            count_2--;
                        break;
                    case 2:
                        y_2 += 1;
                        if (ctrl_1 != 2 )
                            count_2--;
                        break;
                    case 3:
                        x_2 -= 1;
                        if (ctrl_1 != 3 )
                            count1_2--;
                        break;
                    case 4:
                        x_2 += 1;
                        if (ctrl_1 != 4)
                            count1_2--;
                        break;

                    default:
                        break;
                }
                if (Map[(y_2 - Map_Y + 10) / 25, (x_2 - Map_X + 10) / 25] == 0)
                {
                    Map[(y_2 - Map_Y + 10) / 25, (x_2 - Map_X + 10) / 25] = -1;
                    point2(ref score_2);
                }
                if (Map[(y_2 - Map_Y + 10) / 25, (x_2 - Map_X + 10) / 25] == 3)
                {
                    Map[(y_2 - Map_Y + 10) / 25, (x_2 - Map_X + 10) / 25] = 4;
                    if (pictureBox3.Image == null)
                    {
                        p2item1 = selectitem();
                        pictureBox3.Image = item.Images[p2item1];
                    }
                    else if (pictureBox4.Image == null)
                    {
                        p2item2 = selectitem();
                        pictureBox4.Image = item.Images[p2item2];
                    }
                }
                if (Math.Abs(x_1 - x_2)+count1_2 <= pacSize && Math.Abs(y_1 - y_2)+count_2<=pacSize)
                {
                    state = 0;                   
                    timer4.Enabled = false;
                }
                //this.Invalidate();
            }                    
        }
        //jump function
        void jump(ref int x, ref int y, int direction, int x1, int y1)
        {
            switch (direction)
            {
                case 1:
                    for (int i = 2; i < 4; i++)
                    {
                        if ((y - Map_Y + 10) / 25 - i > 0 && (x - Map_X + 10) / 25 > 0 && (y - Map_Y + 10) / 25 - i < 21 && (x - Map_X + 10) / 25 < 17)
                            if (Map[(y - Map_Y) / 25 - i, (x - Map_X) / 25] != 1 && Map[(y - Map_Y + pacSize) / 25 - i, (x - Map_X + pacSize) / 25] != 1 && (Map[(y - Map_Y) / 25 - 1, (x - Map_X) / 25] == 1 || Map[(y - Map_Y + pacSize) / 25 - 1, (x - Map_X + pacSize) / 25] == 1))
                            {
                                if (Math.Abs(x - x1) > pacSize || Math.Abs((y - 25 * i) - y1) > pacSize)
                                {
                                    if (x1 == x_2)
                                    {
                                        t = (i * 25);
                                        temp = t;
                                        jumpclock.Enabled = true;
                                        break;
                                    }
                                    else
                                    {
                                        t1 = (i * 25);
                                        temp1 = t1;
                                        jumpclock2.Enabled = true;
                                        break;
                                    }
                                }
                            }

                    }
                    break;
                case 2:
                    for (int i = 1; i < 4; i++)
                    {
                        if ((y - Map_Y + 10) / 25 + i > 0 && (x - Map_X + 10) / 25 > 0 && (y - Map_Y + 10) / 25 + i < 21 && (x - Map_X + 10) / 25 < 17)
                            if (Map[(y - Map_Y) / 25 + i, (x - Map_X) / 25] != 1 && Map[(y - Map_Y + pacSize) / 25 + i, (x - Map_X + pacSize) / 25] != 1 && (Map[(y - Map_Y) / 25 + 1, (x - Map_X) / 25] == 1 || Map[(y - Map_Y + pacSize) / 25 + 1, (x - Map_X + pacSize) / 25] == 1))
                            {
                                if (Math.Abs(x - x1) > pacSize || Math.Abs((y + 25 * i) - y1) > pacSize)
                                {
                                    if (x1 == x_2)
                                    {
                                        t = (i * 25);
                                        temp = t;
                                        jumpclock.Enabled = true;
                                        break;
                                    }
                                    else
                                    {
                                        t1 = (i * 25);
                                        temp1 = t1;
                                        jumpclock2.Enabled = true;
                                        break;
                                    }

                                }
                            }
                    }
                    break;
                case 3:
                    for (int i = 1; i < 4; i++)
                    {
                        if ((y - Map_Y + 10) / 25 > 0 && (x - Map_X + 10) / 25 - i > 0 && (y - Map_Y + 10) / 25 < 21 && (x - Map_X + 10) / 25 - i < 17)
                            if (Map[(y - Map_Y) / 25, (x - Map_X) / 25 - i] != 1 && Map[(y - Map_Y + pacSize) / 25, (x - Map_X + pacSize) / 25 - i] != 1 && (Map[(y - Map_Y) / 25, (x - Map_X) / 25 - 1] == 1 || Map[(y - Map_Y + pacSize) / 25, (x - Map_X + pacSize) / 25 - 1] == 1))
                            {
                                if (Math.Abs((x - 25 * i) - x1) > pacSize || Math.Abs(y - y1) > pacSize)
                                {
                                    if (x1 == x_2)
                                    {
                                        t = (i * 25);
                                        temp = t;
                                        jumpclock.Enabled = true;
                                        break;
                                    }
                                    else
                                    {
                                        t1 = (i * 25);
                                        temp1 = t1;
                                        jumpclock2.Enabled = true;
                                        break;
                                    }
                                }
                            }                
                    }
                    break;
                case 4:
                    for (int i = 1; i < 4; i++)
                    {
                        if ((y - Map_Y) / 25 > 0 && (x - Map_X) / 25 + i > 0 && (y - Map_Y) / 25 < 21 && (x - Map_X) / 25 + i < 17)
                            if (Map[(y - Map_Y) / 25, (x - Map_X) / 25 + i] != 1 && Map[(y - Map_Y + pacSize) / 25, (x - Map_X + pacSize) / 25 + i] != 1 && (Map[(y - Map_Y) / 25, (x - Map_X) / 25 + 1] == 1 || Map[(y - Map_Y + pacSize) / 25, (x - Map_X + pacSize) / 25 + 1] == 1))
                            {
                                if (Math.Abs((x + 25 * i) - x1) > pacSize || Math.Abs(y - y1) > pacSize)
                                {
                                    if (x1 == x_2)
                                    {
                                        t = (i * 25);
                                        temp = t;
                                        jumpclock.Enabled = true;
                                        break;
                                    }
                                    else
                                    {
                                        t1 = (i * 25);
                                        temp1 = t1;
                                        jumpclock2.Enabled = true;
                                        break;
                                    }
                                }
                            }
                    }
                    break;
                default:
                    break;
            }
        }
        //itemselect
        int selectitem()
        {
            Random rnd = new Random();
            return rnd.Next(0, 5);
        }
        int eventCount1 = 0, eventCount2 = 0;
        int current1, current2;
        int i1, j1;
        //item use
        void useItem(int p, int itm)
        {
            if (p == 1)
            {
                i1 = (y_1 - Map_Y) / 25;
                j1 = (x_1 - Map_X) / 25;
                Items1.Enabled = true;
                current1 = itm;
            }
            else
            {
                i1 = (y_2 - Map_Y) / 25;
                j1 = (x_2 - Map_X) / 25;
                Items2.Enabled = true;
                current2 = itm;
            }
        }
        //P1 item
        private void Items1_Tick_1(object sender, EventArgs e)
        {

            switch (current1)
            {
                case 0:
                    int t;
                    t = x_1;
                    x_1 = x_2;
                    x_2 = t;
                    t = y_1;
                    y_1 = y_2;
                    y_2 = t;
                    Items1.Enabled = false;

                    pictureBox1.Image = pictureBox2.Image;
                    p1item1 = p1item2;
                    pictureBox2.Image = null;
                    p1item2 = -1;
                    break;
                case 1:
                    timer1.Interval = 30;
                    timer2.Interval = 30;
                    eventCount1++;
                    if (eventCount1 == 50)
                    {
                        eventCount1 = 0;
                        timer1.Interval = 100;
                        timer2.Interval = 100;
                        Items1.Enabled = false;

                        pictureBox1.Image = pictureBox2.Image;
                        p1item1 = p1item2;
                        pictureBox2.Image = null;
                        p1item2 = -1;
                    }
                    break;
                case 2:
                    timer3.Enabled = false;
                    pacIndex_2 = 10;
                    eventCount1++;
                    if (eventCount1 == 50)
                    {
                        eventCount1 = 0;
                        pacIndex_2 = 0;
                        timer1.Interval = 100;
                        timer2.Interval = 100;
                        timer3.Enabled = true;
                        Items1.Enabled = false;

                        pictureBox1.Image = pictureBox2.Image;
                        p1item1 = p1item2;
                        pictureBox2.Image = null;
                        p1item2 = -1;
                    }
                    break;
                case 3:
                    fever1 = 2;
                    eventCount1++;
                    if (eventCount1 == 50)
                    {
                        eventCount1 = 0;
                        fever1 = 1;
                        Items1.Enabled = false;

                        pictureBox1.Image = pictureBox2.Image;
                        p1item1 = p1item2;
                        pictureBox2.Image = null;
                        p1item2 = -1;
                    }
                    break;
                case 4:
                    eventCount1++;
                    int i3 = 0, j3 = 0;
                    while (i3 == 0)
                    {
                        i3 = i1 - 1;
                        while (i3 >= 0)
                        {

                            if (Map1[i3, j1] == 0)
                                Map1[i3, j1] = 2;
                            else if (Map1[i3, j1] == 1)
                                break;
                            i3--;
                            if (i3 == 0)
                                break;
                        }
                        i3 = i1 + 1;
                        while (i3 < 21)
                        {

                            if (Map1[i3, j1] == 0)
                                Map1[i3, j1] = 2;
                            else if (Map1[i3, j1] == 1)
                                break;
                            i3++;
                            if (i3 == 21)
                                break;
                        }
                        j3 = j1 - 1;
                        while (j3 >= 0)
                        {

                            if (Map1[i1, j3] == 0)
                                Map1[i1, j3] = 2;
                            else if (Map1[i1, j3] == 1)
                                break;
                            j3--;
                            if (j3 == 0)
                                break;
                        }
                        j3 = j1 + 1;
                        while (j3 < 17)
                        {

                            if (Map1[i1, j3] == 0)
                                Map1[i1, j3] = 2;
                            else if (Map1[i1, j3] == 1)
                                break;
                            j3++;
                            if (j3 == 17)
                                break;
                        }
                        break;
                    }
                    bom1.Enabled = true;
                    if (eventCount1 == 5)
                    {
                        eventCount1 = 0;
                        for (int i2 = 0; i2 < 21; i2++)
                        {
                            for (int j2 = 0; j2 < 17; j2++)
                            {
                                if (Map1[i2, j2] == 2)
                                    Map1[i2, j2] = 0;
                                
                            }
                        }
                        Items1.Enabled = false;

                        pictureBox1.Image = pictureBox2.Image;
                        p1item1 = p1item2;
                        pictureBox2.Image = null;
                        p1item2 = -1;

                        bom1.Enabled = false;
                        bombindex0 = 0;
                    }

                    break;
                default:
                    Items1.Enabled = false;

                    pictureBox1.Image = pictureBox2.Image;
                    p1item1 = p1item2;
                    pictureBox2.Image = null;
                    p1item2 = -1;
                    break;
            }
        }
        //P2 item
        private void Items2_Tick(object sender, EventArgs e)
        {
            switch (current2)
            {
                case 0:
                    int t;
                    t = x_1;
                    x_1 = x_2;
                    x_2 = t;
                    t = y_1;
                    y_1 = y_2;
                    y_2 = t;
                    Items2.Enabled = false;

                    pictureBox3.Image = pictureBox4.Image;
                    p2item1 = p2item2;
                    pictureBox4.Image = null;
                    p2item2 = -1;
                    break;
                case 1:
                    timer3.Interval = 30;
                    timer4.Interval = 30;
                    eventCount2++;
                    if (eventCount2 == 50)
                    {
                        eventCount2 = 0;
                        timer3.Interval = 100;
                        timer4.Interval = 100;
                        Items2.Enabled = false;

                        pictureBox3.Image = pictureBox4.Image;
                        p2item1 = p2item2;
                        pictureBox4.Image = null;
                        p2item2 = -1;
                    }
                    break;
                case 2:
                    timer1.Enabled = false;
                    pacIndex_1 = 10;
                    eventCount2++;
                    if (eventCount2 == 50)
                    {
                        eventCount2 = 0;
                        pacIndex_1 = 0;
                        timer3.Interval = 100;
                        timer4.Interval = 100;
                        timer1.Enabled = true;
                        Items2.Enabled = false;

                        pictureBox3.Image = pictureBox4.Image;
                        p2item1 = p2item2;
                        pictureBox4.Image = null;
                        p2item2 = -1;
                    }
                    break;
                case 3:
                    fever2 = 2;
                    eventCount2++;
                    if (eventCount2 == 50)
                    {
                        eventCount2 = 0;
                        fever2 = 1;
                        Items2.Enabled = false;

                        pictureBox3.Image = pictureBox4.Image;
                        p2item1 = p2item2;
                        pictureBox4.Image = null;
                        p2item2 = -1;
                    }
                    break;
                case 4:
                    eventCount2++;
                    int i3 = 0, j3 = 0;
                    while (i3 == 0)
                    {
                        i3 = i1 - 1;
                        while (i3 >= 0)
                        {

                            if (Map1[i3, j1] == 0)
                                Map1[i3, j1] = 2;
                            else if (Map1[i3, j1] == 1)
                                break;
                            i3--;
                            if (i3 == 0)
                                break;
                        }
                        i3 = i1 + 1;
                        while (i3 < 21)
                        {

                            if (Map1[i3, j1] == 0)
                                Map1[i3, j1] = 2;
                            else if (Map1[i3, j1] == 1)
                                break;
                            i3++;
                            if (i3 == 21)
                                break;
                        }
                        j3 = j1 - 1;
                        while (j3 >= 0)
                        {

                            if (Map1[i1, j3] == 0)
                                Map1[i1, j3] = 2;
                            else if (Map1[i1, j3] == 1)
                                break;
                            j3--;
                            if (j3 == 0)
                                break;
                        }
                        j3 = j1 + 1;
                        while (j3 < 17)
                        {

                            if (Map1[i1, j3] == 0)
                                Map1[i1, j3] = 2;
                            else if (Map1[i1, j3] == 1)
                                break;
                            j3++;
                            if (j3 == 17)
                                break;
                        }
                        break;

                    }
                    bom2.Enabled = true;
                    if (eventCount2 == 5)
                    {
                       
                        eventCount2 = 0;
                        for (int i2 = 0; i2 < 21; i2++)
                        {
                            for (int j2 = 0; j2 < 17; j2++)
                            {
                                if (Map1[i2, j2] == 2)
                                {
                                    Map1[i2, j2] = 0;
                                }                                  
                            }
                        }
                        Items2.Enabled = false;

                        pictureBox3.Image = pictureBox4.Image;
                        p2item1 = p2item2;
                        pictureBox4.Image = null;
                        p2item2 = -1;

                        bom2.Enabled = false;
                        bombindex = 0;
                    }
                    break;
                default:
                    Items2.Enabled = false;

                    pictureBox3.Image = pictureBox4.Image;
                    p2item1 = p2item2;
                    pictureBox4.Image = null;
                    p2item2 = -1;
                    break;
            }
        }
        bool wasEnabled2 = false, wasEnabled4 = false;
        bool wasEnabled_I1 = false, wasEnabled_I2 = false;
        bool wasEnabled_J1 = false, wasEnabled_J2 = false;
        void pauseGame(bool PAUSED)
        {
            //PAUSED = !PAUSED;
            if (PAUSED == false) 
            {
                
                Pause.Visible = true;
                Pause.Text = "PAUSED";
                help.Visible = true;
                help.Text = "Press P Again to Resume.\nPress U to Quit.";
                timer1.Enabled = false;
                timer3.Enabled = false;
                timer5.Enabled = false;
                clock.Enabled = false;

                if (timer2.Enabled)
                {
                    timer2.Enabled = false;
                    wasEnabled2 = true;
                }
                if (timer4.Enabled)
                {
                    timer4.Enabled = false;
                    wasEnabled4 = true;
                }

                if (Items1.Enabled)
                {
                    Items1.Enabled = false;
                    wasEnabled_I1 = true;
                }
                if (Items2.Enabled)
                {
                    Items2.Enabled = false;
                    wasEnabled_I2 = true;
                }

                if (jumpclock.Enabled)
                {
                    jumpclock.Enabled = false;
                    wasEnabled_J1 = true;
                }
                if (jumpclock2.Enabled)
                {
                    jumpclock2.Enabled = false;
                    wasEnabled_J2 = true;
                }

            }
            if (PAUSED == true) 
            {
                
                Pause.Visible = false;
                Pause.Text = null;
                help.Visible = false;
                help.Text = null;
                timer1.Enabled = true;
                timer3.Enabled = true;
                timer5.Enabled = true;
                clock.Enabled = true;

                if (wasEnabled2)
                {
                    timer2.Enabled = true;
                    wasEnabled2 = false;
                }
                if (wasEnabled4)
                {
                    timer4.Enabled = true;
                    wasEnabled4 = false;
                }

                if (wasEnabled_I1)
                {
                    Items1.Enabled = true;
                    wasEnabled_I1 = false;
                }
                if (wasEnabled_I2)
                {
                    Items2.Enabled = true;
                    wasEnabled_I2 = false;
                }

                if (wasEnabled_J1)
                {
                    jumpclock.Enabled = true;
                    wasEnabled_J1 = false;
                }
                if (wasEnabled_J2)
                {
                    jumpclock2.Enabled = true;
                    wasEnabled_J2 = false;
                }
            }
        }
        
        private void gameOver_Tick(object sender, EventArgs e)
        {           
            gameOver.Enabled = false;
        }
    }
}
