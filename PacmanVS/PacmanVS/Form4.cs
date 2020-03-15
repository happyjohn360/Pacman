using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanVS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int state = 1;
        bool PAUSED = false;
        bool ALREADY = false;
        const int pacSize = 20;
        int dWidth = 2, dLength = 4;
        const int redSize = 20;
        int Map_X_draw = 100, Map_Y_draw = 50;
        const int Map_X = 100, Map_Y = 50;
        int p1item1 = -1, p1item2 = -1;
        int time = 0;
        int fever1 = 1;
        int CDIndex = 0;
        int nowRed = 0, nowSky = 0, nowCherry = 0, nowAqua = 0;

        static int t = 0, t1 = 0;
        
        int[] pathx = new int[] { t * t / 128 };      
        int[] pathy = new int[] { t };
        int[,] Map2 = new int[21, 17]
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
        int[,] Map1 = new int[21, 17]
       {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,2,0,0,2,0,0,2,1,2,0,0,2,0,0,2,1},
            {1,0,1,1,0,1,1,0,1,0,1,1,0,1,1,0,1},
            {1,2,0,0,2,0,2,0,0,0,2,0,2,0,0,2,1},
            {1,0,1,1,0,1,0,1,1,1,0,1,0,1,1,0,1},
            {1,2,0,0,2,1,0,2,1,2,0,1,2,0,0,2,1},
            {1,1,1,1,0,1,1,0,1,0,1,1,0,1,1,1,1},
            {1,1,1,1,0,1,2,0,2,0,2,1,0,1,1,1,1},
            {1,1,1,1,0,1,0,1,0,1,0,1,0,1,1,1,1},
            {1,0,0,0,2,0,2,0,2,0,2,0,2,0,0,0,1},
            {1,1,1,1,0,1,0,1,0,1,0,1,0,1,1,1,1},
            {1,1,1,1,0,1,2,0,2,0,2,1,0,1,1,1,1},
            {1,1,1,1,0,1,0,1,1,1,0,1,0,1,1,1,1},
            {1,2,0,0,2,0,2,0,1,2,0,0,2,0,0,2,1},
            {1,0,1,1,0,1,1,0,1,0,1,1,0,1,1,0,1},
            {1,0,2,1,2,0,2,0,0,0,2,0,2,1,2,0,1},
            {1,1,0,1,0,1,0,1,1,1,0,1,0,1,0,1,1},
            {1,2,0,0,2,1,2,0,1,0,2,1,2,0,0,2,1},
            {1,0,1,1,1,1,1,0,1,0,1,1,1,1,1,0,1},
            {1,2,0,0,0,0,0,2,1,2,0,0,0,0,0,2,1},
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
            {-1,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,-1},
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
        };
        bool empty = true;

        private void Collect_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            //GC.Collect();
        }

        

        int pacIndex_1 = 0;
        


        int x_1 = 302, y_1 = 277;
        int ctrl_1 = 3;
        int ctrl_1t = 3;

        int pacLives = 4;

        int ghostIndex = 0;

        int x_red = 477, y_red = 527;
        int ctrl_red = 5;
        int x_sky = 127, y_sky = 77;
        int ctrl_sky = 5;
        int x_cherry = 127, y_cherry = 527;
        int ctrl_cherry = 5;
        int x_aqua = 477, y_aqua = 77;
        int ctrl_aqua = 5;

        private void timer5_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 17; j++)
                    if (Map[i, j] == 4)
                        Map[i, j] = 3;
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Bitmap scr = new Bitmap(800, 600);
            Graphics dr1 = Graphics.FromImage(scr);
            Graphics dr2 = Graphics.FromImage(scr);
            Graphics dr3 = Graphics.FromImage(scr);

            Point pt1 = Cursor.Position;
            pt1 = this.PointToClient(pt1);
            Pen myPen = new Pen(Color.LightBlue, 2);
            Brush myBrush = new SolidBrush(Color.Blue);
            Brush pointBrush = new SolidBrush(Color.White);
            Random rnd = new Random();

            Map_X_draw = 100; Map_Y_draw = 50;

            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 17; j++)
                {

                    if (Map[i, j] == 1)
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
                        dr1.DrawImage(Properties.Resources.barbed_sun, Map_X_draw, Map_Y_draw, 25, 25);
                    }
                    if (Map2[i, j] == 2)
                        dr1.DrawImage(bomb.Images[bombindex], Map_X_draw - 12, Map_Y_draw - 10);
                    Map_X_draw += 25;

                }
                Map_X_draw = 100;
                Map_Y_draw += 25;
                
            }
            switch (ctrl_red)
            {

                case 1:
                    dr3.DrawImage(Red_Up.Images[ghostIndex], x_red, y_red);
                    break;
                case 2:
                    dr3.DrawImage(Red_Down.Images[ghostIndex], x_red, y_red);
                    break;
                case 3:
                    dr3.DrawImage(Red_Left.Images[ghostIndex], x_red, y_red);
                    break;
                case 4:
                    dr3.DrawImage(Red_Right.Images[ghostIndex], x_red, y_red);
                    break;
            }
            switch (ctrl_sky)
            {

                case 1:
                    dr3.DrawImage(Sky_Up.Images[ghostIndex], x_sky, y_sky);
                    break;
                case 2:
                    dr3.DrawImage(Sky_Down.Images[ghostIndex], x_sky, y_sky);
                    break;
                case 3:
                    dr3.DrawImage(Sky_Left.Images[ghostIndex], x_sky, y_sky);
                    break;
                case 4:
                    dr3.DrawImage(Sky_Right.Images[ghostIndex], x_sky, y_sky);
                    break;
            }
            switch (ctrl_cherry)
            {

                case 1:
                    dr3.DrawImage(Cherry_Up.Images[ghostIndex], x_cherry, y_cherry);
                    break;
                case 2:
                    dr3.DrawImage(Cherry_Down.Images[ghostIndex], x_cherry, y_cherry);
                    break;
                case 3:
                    dr3.DrawImage(Cherry_Left.Images[ghostIndex], x_cherry, y_cherry);
                    break;
                case 4:
                    dr3.DrawImage(Cherry_Right.Images[ghostIndex], x_cherry, y_cherry);
                    break;
            }
            switch (ctrl_aqua)
            {

                case 1:
                    dr3.DrawImage(Aqua_Up.Images[ghostIndex], x_aqua, y_aqua);
                    break;
                case 2:
                    dr3.DrawImage(Aqua_Down.Images[ghostIndex], x_aqua, y_aqua);
                    break;
                case 3:
                    dr3.DrawImage(Aqua_Left.Images[ghostIndex], x_aqua, y_aqua);
                    break;
                case 4:
                    dr3.DrawImage(Aqua_Right.Images[ghostIndex], x_aqua, y_aqua);
                    break;
            }

            //Draw
            switch (ctrl_1t)
            {

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

                case 0:
                    
                    dr2.DrawImage(P1_Death.Images[pacIndex_1], x_1, y_1);
                    break;
            }

            if (Items1.Enabled)
            {
                pictureBox1.Image = Hourglass.Images[CDIndex];
            }

            e.Graphics.DrawImage(scr, 0, 0);
            Lives.Text = "❤×" + pacLives.ToString();
            second.Text = "Time: " + time.ToString();

            if (time - nowRed >= 5)
            {
                nowRed = 0;
                timer3.Enabled = true;
            }
            if (time - nowSky >= 5)
            {
                nowSky = 0;
                timer4.Enabled = true;
            }
            if (time - nowCherry >= 5)
            {
                nowCherry = 0;
                timer6.Enabled = true;
            }
            if (time - nowAqua >= 5)
            {
                nowAqua = 0;
                timer7.Enabled = true;
            }

            //!!
            if (empty || pacLives == 0)
            {
                //gameOver();
                if (ALREADY == false)
                {
                    gameOver.Enabled = true;
                    ALREADY = true;
                    Pause.Visible = true;
                    Pause.Text = "FINISHED!";
                    timer1.Interval = 300;
                    timer5.Enabled = false;
                    clock.Enabled = false;
                    timer2.Interval = 300;
                    Items1.Enabled = false;
                    jumpclock.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    timer6.Enabled = false;
                    timer7.Enabled = false;
                }

                if (gameOver.Enabled == false)
                {

                    Form3 res;
                    System.Threading.Thread.Sleep(2000);
                    if (pacLives == 0)
                    {
                        res = new Form3();
                        res.Show();
                    }
                    else
                    {
                        res = new Form3(time.ToString());
                        res.Show();
                    }
                    this.Dispose(false);
                }
            }
            empty = true;
            //!!
        }

        //*********
        int now = 0;
        //*********
        int det = 1;
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && t == 0 && PAUSED == false&&det==1)
            {
                
                timer2.Enabled = true;
                ctrl_1 = 1;
                
            }
            else if (e.KeyCode == Keys.Down && t == 0 && PAUSED == false && det == 1)
            {
                
                timer2.Enabled = true;
                ctrl_1 = 2;
                
            }
            else if (e.KeyCode == Keys.Left && t == 0 && PAUSED == false && det == 1)
            {
                
                timer2.Enabled = true;
                ctrl_1 = 3;
                
            }
            else if (e.KeyCode == Keys.Right && t == 0 && PAUSED == false && det == 1)
            {
                
                timer2.Enabled = true;
                ctrl_1 = 4;
                
            }
            if (e.KeyCode == Keys.OemSemicolon && p1item1 != -1 && Items1.Enabled == false && PAUSED == false)
            {
                useItem(p1item1);
            }

            if (e.KeyCode == Keys.OemQuestion && t == 0 && PAUSED == false && det == 1)
            {
                jump(ref x_1, ref y_1, ctrl_1t);
            }

            //!!
            if (e.KeyCode == Keys.U && PAUSED == true)
            {
                Form3 res = new Form3();
                res.Show();
                this.Dispose(false);
            }
            /*
            if (e.KeyCode == Keys.Space && PAUSED == false)
            {
                timer2.Enabled = false;
            }
            */
            if (e.KeyCode == Keys.Escape && PAUSED == false)
            {
                Form3 res = new Form3(time.ToString());
                res.Show();
                this.Dispose(false);
            }
            /*
            if (e.KeyCode == Keys.D && PAUSED == false)
            {
                System.Threading.Thread.Sleep(500);
                now = time;
                Death.Enabled = true;
                pacIndex_1 = 0;              
                ctrl_1 = 0;
                ctrl_1t = 0;
                PAUSED = true;                                                       
            }
            */
            //!!
        }
        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                pauseGame(PAUSED);
                PAUSED = !PAUSED;
            }
        }

        int n = 0;
        private void clock_Tick(object sender, EventArgs e)
        {
            n++;
            if (n / 10 == 1)
            {
                time++;
                n = 0;
            }
            
        }

        int temp = 0, left = 0, right = 0;
        private void jumpclock_Tick(object sender, EventArgs e)
        {
            t -= 5;
            switch (ctrl_1t)
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
            if ((t <= (temp / 2)  && ctrl_1t == 1) || (t > (temp / 2) && ctrl_1t == 2))
            {
                if ((t <= (temp / 2) && ctrl_1t == 1) && right > 0)
                {
                    x_1 += 1;
                    right--;
                }
                if ((t > (temp / 2)  && ctrl_1t == 2))
                {
                    x_1 += 1;
                    left++;
                }

            }
            else if (t > (temp / 2)  && ctrl_1t == 1 || (t <= (temp / 2)  && ctrl_1t == 2))
            {
                if ((t > (temp / 2)&& ctrl_1t == 1))
                {
                    x_1 -= 1;
                    right++;
                }
                if ((t <= (temp / 2)  && ctrl_1t == 2) && left > 0)
                {
                    x_1 -= 1;
                    left--;
                }
            }
            else if ((t > (temp / 2) ) && (ctrl_1t == 3 || ctrl_1t == 4))
            {
                y_1 -= 1;
                left++;
            }
            else if ((t <= (temp / 2) ) && (ctrl_1t == 3 || ctrl_1t == 4) && left > 0)
            {
                y_1 += 1;
                left--;
            }
            if (t == 0)
            {
                left = 0;
                right = 0;
                jumpclock.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            ghostIndex++;
            if (pacIndex_1 <= 9)
            {
                if(!Death.Enabled)
                    pacIndex_1++;
                else if(Death.Enabled && pacIndex_1!=9)
                    pacIndex_1++;

            }
                
            if (pacIndex_1 == 10)
            {
                pacIndex_1 = 0;
            }
           
          

            if (ghostIndex == 2)
            {
                ghostIndex = 0;
            }
        }
        int conx = 0, cony = 0, jud;
        private void timer2_Tick(object sender, EventArgs e)
        {
            dLength = 4;
            if (ctrl_1 != 5)
                ctrl_1t = ctrl_1;
            if (Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X + 13) / 25] == 2 && Map1[((y_1 - Map_Y) / 25) - 1, (x_1 - Map_X + 13) / 25] == 0 && ctrl_1 == 1 && y_1 == ((y_1 - Map_Y) / 25) * 25 + Map_Y + 2 && (Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X) / 25] == 0 ))
            {
                conx = 25 * ((x_1 - Map_X + 13) / 25) + Map_X + 2;
                //timer2.Enabled = false;
                jud = 1;
                det = 0;
                autogo.Enabled = true;
                ctrl_1 = 5;
            }
            else if (Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X -5) / 25] == 2 && Map1[((y_1 - Map_Y) / 25) - 1, (x_1 - Map_X-5 ) / 25] == 0 && ctrl_1 == 1 && y_1 == ((y_1 - Map_Y) / 25) * 25 + Map_Y + 2 && Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X) / 25 + 1] == 0)
            {
                conx = 25 * ((x_1 - Map_X -5) / 25) + Map_X + 2;
                //timer2.Enabled = false;
                jud = 2;
                det = 0;
                autogo.Enabled = true;
                ctrl_1 = 5;
            }
            else if (Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X + 13) / 25] == 2 && Map1[((y_1 - Map_Y) / 25) + 1, (x_1 - Map_X + 13) / 25] == 0 && ctrl_1 == 2 && y_1 == ((y_1 - Map_Y) / 25) * 25 + Map_Y + 2 && Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X) / 25] == 0)
            {
                conx = 25 * ((x_1 - Map_X + 13) / 25) + Map_X + 2;
                //timer2.Enabled = false;
                jud = 3;
                det = 0;
                autogo.Enabled = true;
                ctrl_1 = 5;
            }
            else if (Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X ) / 25] == 2 && ctrl_1 == 2 && Map1[((y_1 - Map_Y) / 25) + 1, (x_1 - Map_X - 5) / 25] == 0 && y_1 == ((y_1 - Map_Y) / 25) * 25 + Map_Y + 2 && Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X) / 25 + 1] == 0)
            {
                conx = 25 * ((x_1 - Map_X ) / 25) + Map_X + 2;
                //timer2.Enabled = false;
                jud = 4;
                det = 0;
                autogo.Enabled = true;
                ctrl_1 = 5;
            }
            if (Map1[(y_1 - Map_Y - 5) / 25, (x_1 - Map_X) / 25] == 2 && Map1[((y_1 - Map_Y ) / 25) + 1, (x_1 - Map_X) / 25] == 0 && ctrl_1 == 4 && x_1 == ((x_1 - Map_X) / 25) * 25 + Map_X + 2 && Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X) / 25 + 1] == 0)
            {
                cony = 25 * ((y_1 - Map_Y - 5) / 25) + Map_Y + 2;
                jud = 5;
                det = 0;
                autogo.Enabled = true;
                ctrl_1 = 5;
            }
            else if (Map1[(y_1 - Map_Y + 13) / 25, (x_1 - Map_X) / 25] == 2 && Map1[((y_1 - Map_Y) / 25), (x_1 - Map_X) / 25] == 0 && ctrl_1 == 4 && x_1 == ((x_1 - Map_X) / 25) * 25 + Map_X + 2 && Map1[(y_1 - Map_Y + 13) / 25, (x_1 - Map_X) / 25 + 1] == 0)
            {
                cony = 25 * ((y_1 - Map_Y + 13) / 25) + Map_Y + 2;
                jud = 6;
                det = 0;
                autogo.Enabled = true;
                ctrl_1 = 5;
            }
            else if (Map1[(y_1 - Map_Y - 5) / 25, (x_1 - Map_X) / 25] == 2 && Map1[((y_1 - Map_Y ) / 25) + 1, (x_1 - Map_X) / 25] == 0 && ctrl_1 == 3 && x_1 == ((x_1 - Map_X) / 25) * 25 + Map_X + 2 && Map1[(y_1 - Map_Y) / 25, (x_1 - Map_X) / 25 - 1] == 0)
            {
                cony = 25 * ((y_1 - Map_Y - 5) / 25) + Map_Y + 2;
                jud = 7;
                det = 0;
                autogo.Enabled = true;
                ctrl_1 = 5;
            }
            else if (Map1[(y_1 - Map_Y + 13) / 25, (x_1 - Map_X) / 25] == 2 && Map1[((y_1 - Map_Y) / 25), (x_1 - Map_X) / 25] == 0 && ctrl_1 == 3 && x_1 == ((x_1 - Map_X) / 25) * 25 + Map_X + 2 && Map1[(y_1 - Map_Y + 13) / 25, (x_1 - Map_X) / 25 - 1] == 0)
            {
                cony = 25 * ((y_1 - Map_Y + 13) / 25) + Map_Y + 2;
                jud = 8;
                det = 0;
                autogo.Enabled = true;
                ctrl_1 = 5;
            }
            if ((Map[(y_1 - Map_Y + 0 - dLength) / 25, (x_1 - Map_X + dWidth + 0) / 25] == 1 || Map[(y_1 - Map_Y + 0 - dLength) / 25, (x_1 - Map_X + pacSize - dWidth + 0) / 25] == 1) && ctrl_1 == 1)
            {
                timer2.Enabled = false;

                ctrl_1 = 5;
            }
            if ((Map[(y_1 - Map_Y + pacSize + dLength) / 25, (x_1 - Map_X + dWidth + 0) / 25] == 1 || Map[(y_1 - Map_Y + pacSize + dLength) / 25, (x_1 - Map_X + pacSize - dWidth + 0) / 25] == 1) && ctrl_1 == 2)
            {
                timer2.Enabled = false;

                ctrl_1 = 5;
            }
            if ((Map[(y_1 - Map_Y + dWidth + 0) / 25, (x_1 - Map_X + 0 - dLength) / 25] == 1 || Map[(y_1 - Map_Y + pacSize - dWidth + 0) / 25, (x_1 - Map_X + 0 - dLength) / 25] == 1) && ctrl_1 == 3)
            {
                timer2.Enabled = false;

                ctrl_1 = 5;
            }
            //
            if ((Map[(y_1 - Map_Y + dWidth + 0) / 25, (x_1 - Map_X + pacSize + dLength) / 25] == 1 || Map[(y_1 - Map_Y + pacSize - dWidth + 0) / 25, (x_1 - Map_X + pacSize + dLength) / 25] == 1) && ctrl_1 == 4)
            {
                timer2.Enabled = false;

                ctrl_1 = 5;
            }
            if ((x_1 >= 477) && ctrl_1 == 4)
            {
                x_1 = 107;
                dLength = 0;
            }
            //
            if ((x_1 <= 127) && ctrl_1 == 3)
            {
                x_1 = 497;
                dLength = 0;
            }
                for (int i = 0; i < 5; i++)
            {
                switch (ctrl_1)
                {
                    case 1:
                        y_1 -= 1;
                        break;
                    case 2:
                        y_1 += 1;
                        break;
                    case 3:
                        x_1 -= 1;
                        break;
                    case 4:
                        x_1 += 1;
                        break;
                    default:
                        break;
                }
                
                if (Map[(y_1 - Map_Y + 10) / 25, (x_1 - Map_X + 10) / 25] == 0)
                {
                    Map[(y_1 - Map_Y + 10) / 25, (x_1 - Map_X + 10) / 25] = 2;
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
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            dLength = 4;
            List<int> dir = new List<int>();
            if (Map[(y_red - Map_Y - dLength) / 25, (x_red - Map_X) / 25] != 1 && Map[(y_red - Map_Y - dLength) / 25, (x_red - Map_X + pacSize) / 25] != 1 && ctrl_red != 2) 
            {
                dir.Add(1);
            }
            if (Map[(y_red - Map_Y + pacSize + dLength) / 25, (x_red - Map_X) / 25] != 1 && Map[(y_red - Map_Y + pacSize + dLength) / 25, (x_red - Map_X + pacSize) / 25] != 1 && ctrl_red != 1)
            {
                dir.Add(2);
            }
            if (Map[(y_red - Map_Y) / 25, (x_red - Map_X - dLength) / 25] != 1 && Map[(y_red - Map_Y + pacSize) / 25, (x_red - Map_X - dLength) / 25] != 1 && ctrl_red != 4)
            {
                dir.Add(3);
            }
            if (Map[(y_red - Map_Y) / 25, (x_red - Map_X + pacSize + dLength) / 25] != 1 && Map[(y_red - Map_Y + pacSize) / 25, (x_red - Map_X + pacSize + dLength) / 25] != 1 && ctrl_red != 3)
            {
                dir.Add(4);
            }

            if ((Math.Abs(y_red - y_1) + Math.Abs(x_red - x_1)) <= 125 || (time / 30) % 4 == 0) 
            {
                Chase(dir, x_red, y_red, x_1, y_1, ref ctrl_red);
            }
            else
            {
                Chase(dir, x_red, y_red, 477, 527, ref ctrl_red);
            }

            if ((x_red < 127) && ctrl_red == 3)
            {
                x_red = 497;
                dLength = 0;
            }
            if ((x_red > 477) && ctrl_red == 4)
            {
                x_red = 107;
                dLength = 0;
            }

            if (Math.Abs(x_1 - x_red) <= pacSize - 4 && Math.Abs(y_1 - y_red) <= pacSize - 4)
            {
                System.Threading.Thread.Sleep(500);
                now = time;
                pacIndex_1 = 0;
                ctrl_1 = 0;
                ctrl_1t = 0;
                PAUSED = true;
                Death.Enabled = true;
            }

            if (red != 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    switch (ctrl_red)
                    {
                        case 1:
                            y_red -= 1;
                            break;
                        case 2:
                            y_red += 1;
                            break;
                        case 3:
                            x_red -= 1;
                            break;
                        case 4:
                            x_red += 1;
                            break;
                        default:
                            break;
                    }

                }
            }
            else
                red1++;
            if (red1 == 50)
            {
                red = 1;
                red1 = 0;
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            dLength = 4;
            List<int> dir = new List<int>();
            if (Map[(y_sky - Map_Y - dLength) / 25, (x_sky - Map_X) / 25] != 1 && Map[(y_sky - Map_Y - dLength) / 25, (x_sky - Map_X + pacSize) / 25] != 1 && ctrl_sky != 2)
            {
                dir.Add(1);
            }
            if (Map[(y_sky - Map_Y + pacSize + dLength) / 25, (x_sky - Map_X) / 25] != 1 && Map[(y_sky - Map_Y + pacSize + dLength) / 25, (x_sky - Map_X + pacSize) / 25] != 1 && ctrl_sky != 1)
            {
                dir.Add(2);
            }
            if (Map[(y_sky - Map_Y) / 25, (x_sky - Map_X - dLength) / 25] != 1 && Map[(y_sky - Map_Y + pacSize) / 25, (x_sky - Map_X - dLength) / 25] != 1 && ctrl_sky != 4)
            {
                dir.Add(3);
            }
            if (Map[(y_sky - Map_Y) / 25, (x_sky - Map_X + pacSize + dLength) / 25] != 1 && Map[(y_sky - Map_Y + pacSize) / 25, (x_sky - Map_X + pacSize + dLength) / 25] != 1 && ctrl_sky != 3)
            {
                dir.Add(4);
            }

            if ((Math.Abs(y_sky - y_1) + Math.Abs(x_sky - x_1)) <= 125 || (time / 30) % 4 == 1)
            {
                Chase(dir, x_sky, y_sky, x_1, y_1, ref ctrl_sky);
            }
            else
            {
                Chase(dir, x_sky, y_sky, 127, 77, ref ctrl_sky);
            }

            if ((x_sky < 127) && ctrl_sky == 3)
            {
                x_sky = 497;
                dLength = 0;
            }
            if ((x_sky > 477) && ctrl_sky == 4)
            {
                x_sky = 107;
                dLength = 0;
            }

            if (Math.Abs(x_1 - x_sky) <= pacSize - 4 && Math.Abs(y_1 - y_sky) <= pacSize - 4)
            {
                System.Threading.Thread.Sleep(500);
                now = time;
                pacIndex_1 = 0;
                ctrl_1 = 0;
                ctrl_1t = 0;
                PAUSED = true;
                Death.Enabled = true;
            }


            if (sky != 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    switch (ctrl_sky)
                    {
                        case 1:
                            y_sky -= 1;
                            break;
                        case 2:
                            y_sky += 1;
                            break;
                        case 3:
                            x_sky -= 1;
                            break;
                        case 4:
                            x_sky += 1;
                            break;
                        default:
                            break;
                    }

                }
            }
            else
                sky1++;
            if (sky1 == 50)
            {
                sky = 1;
                sky1 = 0;
            }
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            dLength = 4;
            List<int> dir = new List<int>();
            if (Map[(y_cherry - Map_Y - dLength) / 25, (x_cherry - Map_X) / 25] != 1 && Map[(y_cherry - Map_Y - dLength) / 25, (x_cherry - Map_X + pacSize) / 25] != 1 && ctrl_cherry != 2)
            {
                dir.Add(1);
            }
            if (Map[(y_cherry - Map_Y + pacSize + dLength) / 25, (x_cherry - Map_X) / 25] != 1 && Map[(y_cherry - Map_Y + pacSize + dLength) / 25, (x_cherry - Map_X + pacSize) / 25] != 1 && ctrl_cherry != 1)
            {
                dir.Add(2);
            }
            if (Map[(y_cherry - Map_Y) / 25, (x_cherry - Map_X - dLength) / 25] != 1 && Map[(y_cherry - Map_Y + pacSize) / 25, (x_cherry - Map_X - dLength) / 25] != 1 && ctrl_cherry != 4)
            {
                dir.Add(3);
            }
            if (Map[(y_cherry - Map_Y) / 25, (x_cherry - Map_X + pacSize + dLength) / 25] != 1 && Map[(y_cherry - Map_Y + pacSize) / 25, (x_cherry - Map_X + pacSize + dLength) / 25] != 1 && ctrl_cherry != 3)
            {
                dir.Add(4);
            }

            if ((Math.Abs(y_cherry - y_1) + Math.Abs(x_cherry - x_1)) <= 125 || (time/30)%4==2)
            {
                Chase(dir, x_cherry, y_cherry, x_1, y_1, ref ctrl_cherry);
            }
            else
            {
                Chase(dir, x_cherry, y_cherry, 127, 527, ref ctrl_cherry);
            }

            if ((x_cherry < 127) && ctrl_cherry == 3)
            {
                x_cherry = 497;
                dLength = 0;
            }
            if ((x_cherry > 477) && ctrl_cherry == 4)
            {
                x_cherry = 107;
                dLength = 0;
            }

            if (Math.Abs(x_1 - x_cherry) <= pacSize - 4 && Math.Abs(y_1 - y_cherry) <= pacSize - 4)
            {
                System.Threading.Thread.Sleep(500);
                now = time;
                pacIndex_1 = 0;
                ctrl_1 = 0;
                ctrl_1t = 0;
                PAUSED = true;
                Death.Enabled = true;
            }
            if (cherry != 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    switch (ctrl_cherry)
                    {
                        case 1:
                            y_cherry -= 1;
                            break;
                        case 2:
                            y_cherry += 1;
                            break;
                        case 3:
                            x_cherry -= 1;
                            break;
                        case 4:
                            x_cherry += 1;
                            break;
                        default:
                            break;
                    }

                }
            }
            else
                cherry1++;
            if (cherry1 == 50)
            {
                cherry = 1;
                cherry1 = 0;
            }
        }

        private void autogo_Tick(object sender, EventArgs e)
        {
            if (jud == 1 || jud == 3)
                for (int i = 0; i < 5; i++)
                {
                    
                    x_1++;
                    if (x_1 == conx)
                    {
                        det = 1;
                        conx = 0;
                        autogo.Enabled = false;
                        timer2.Enabled = true;
                        if (jud == 1)
                        {
                            ctrl_1 = 1;
                            ctrl_1t = 1;
                        }
                        else
                        {
                            ctrl_1 = 2;
                            ctrl_1t = 2;
                        }

                    }
                }
            if (jud == 2 || jud == 4)
                for (int i = 0; i < 5; i++)
                {
                    
                    x_1--;
                    if (x_1 == conx)
                    {
                        det = 1;
                        conx = 0;
                        autogo.Enabled = false;
                        timer2.Enabled = true;
                        if (jud == 2)
                        {
                            ctrl_1 = 1;
                            ctrl_1t = 1;
                        }
                        else
                        {
                            ctrl_1 = 2;
                            ctrl_1t = 2;
                        }
                    }
                }
            if (jud == 5 || jud == 7)
            {
                for (int i = 0; i < 5; i++)
                {
                    
                    y_1--;
                    if (y_1 == cony)
                    {
                        det = 1;
                        cony = 0;
                        autogo.Enabled = false;
                        timer2.Enabled = true;
                        if (jud == 5)
                        {
                            ctrl_1 = 4;
                            ctrl_1t = 4;
                        }
                        else
                        {
                            ctrl_1 = 3;
                            ctrl_1t = 3;
                        }
                    }
                }
            }
            if (jud == 6 || jud == 8)
            {
                for (int i = 0; i < 5; i++)
                {
                   
                    y_1++;
                    if (y_1 == cony)
                    {
                        det = 1;
                        cony = 0;
                        autogo.Enabled = false;
                        timer2.Enabled = true;
                        if (jud == 6)
                        {
                            ctrl_1 = 4;
                            ctrl_1t = 4;
                        }
                        else
                        {
                            ctrl_1 = 3;
                            ctrl_1t = 3;
                        }
                    }
                }
            }
        }
        
        private void bom1_Tick(object sender, EventArgs e)
        {
            bombindex++;
            if (bombindex == 9)
            {
                bombindex = 0;
            }
            if (Map2[(y_red - Map_Y) / 25, (x_red - Map_X) / 25] == 2 || Map2[(y_red - Map_Y + pacSize) / 25, (x_red - Map_X + pacSize) / 25] == 2)
            {
                nowRed = time;
                timer3.Enabled = false;
                x_red = 477;
                y_red = 527;
            }
            if (Map2[(y_sky - Map_Y) / 25, (x_sky - Map_X) / 25] == 2 || Map2[(y_sky - Map_Y + pacSize) / 25, (x_sky - Map_X + pacSize) / 25] == 2)
            {
                nowSky = time;
                timer4.Enabled = false;
                x_sky = 127;
                y_sky = 77;
            }
            if (Map2[(y_cherry - Map_Y) / 25, (x_cherry - Map_X) / 25] == 2 || Map2[(y_cherry - Map_Y + pacSize) / 25, (x_cherry - Map_X + pacSize) / 25] == 2)
            {
                nowCherry = time;
                timer6.Enabled = false;
                x_cherry = 127;
                y_cherry = 527;
            }
            if (Map2[(y_aqua - Map_Y) / 25, (x_aqua - Map_X) / 25] == 2 || Map2[(y_aqua - Map_Y + pacSize) / 25, (x_aqua - Map_X + pacSize) / 25] == 2)
            {
                nowAqua = time;
                timer7.Enabled = false;
                x_aqua = 477;
                y_aqua = 77;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            dLength = 4;
            List<int> dir = new List<int>();
            if (Map[(y_aqua - Map_Y - dLength) / 25, (x_aqua - Map_X) / 25] != 1 && Map[(y_aqua - Map_Y - dLength) / 25, (x_aqua - Map_X + pacSize) / 25] != 1 && ctrl_aqua != 2)
            {
                dir.Add(1);
            }
            if (Map[(y_aqua - Map_Y + pacSize + dLength) / 25, (x_aqua - Map_X) / 25] != 1 && Map[(y_aqua - Map_Y + pacSize + dLength) / 25, (x_aqua - Map_X + pacSize) / 25] != 1 && ctrl_aqua != 1)
            {
                dir.Add(2);
            }
            if (Map[(y_aqua - Map_Y) / 25, (x_aqua - Map_X - dLength) / 25] != 1 && Map[(y_aqua - Map_Y + pacSize) / 25, (x_aqua - Map_X - dLength) / 25] != 1 && ctrl_aqua != 4)
            {
                dir.Add(3);
            }
            if (Map[(y_aqua - Map_Y) / 25, (x_aqua - Map_X + pacSize + dLength) / 25] != 1 && Map[(y_aqua - Map_Y + pacSize) / 25, (x_aqua - Map_X + pacSize + dLength) / 25] != 1 && ctrl_aqua != 3)
            {
                dir.Add(4);
            }

            if ((Math.Abs(y_aqua - y_1) + Math.Abs(x_aqua - x_1)) <= 125 || (time / 30) % 4 == 3)
            {
                Chase(dir, x_aqua, y_aqua, x_1, y_1, ref ctrl_aqua);
            }
            else
            {
                Chase(dir, x_aqua, y_aqua, 477, 77, ref ctrl_aqua);
            }

            if ((x_aqua < 127) && ctrl_aqua == 3)
            {
                x_aqua = 497;
                dLength = 0;
            }
            if ((x_aqua > 477) && ctrl_aqua == 4)
            {
                x_aqua = 107;
                dLength = 0;
            }

            if (Math.Abs(x_1 - x_aqua) <= pacSize - 4 && Math.Abs(y_1 - y_aqua) <= pacSize - 4)
            {
                System.Threading.Thread.Sleep(500);
                now = time;
                pacIndex_1 = 0;
                ctrl_1 = 0;
                ctrl_1t = 0;
                PAUSED = true;
                Death.Enabled = true;
            }

            if (aqua != 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    switch (ctrl_aqua)
                    {
                        case 1:
                            y_aqua -= 1;
                            break;
                        case 2:
                            y_aqua += 1;
                            break;
                        case 3:
                            x_aqua -= 1;
                            break;
                        case 4:
                            x_aqua += 1;
                            break;
                        default:
                            break;
                    }

                }
            }
            else
                aqua1++;
            if (aqua1 == 50)
            {
                aqua = 1;
                aqua1 = 0;
            }
        }
        int red = 1, sky = 1, cherry = 1, aqua = 1;

        private void CD_Tick(object sender, EventArgs e)
        {
            if (CDIndex <= 9)
                CDIndex++;

            if (CDIndex == 10)
                CDIndex = 0;
        }

        int red1 = 0, sky1 = 0, cherry1 = 0, aqua1 = 0;
        int bombindex = 0;
        private void Death_Tick(object sender, EventArgs e)
        {
            if (pacIndex_1 >= 9)
            {
                timer1.Enabled = false;
                pacIndex_1 = 8;
                
            }
            red = sky = cherry = aqua = 1;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer2.Enabled = false;
            if (time - now >= 3)
            {
                now = 0;
                x_1 = 302;
                y_1 = 277;
                x_red = 477; y_red = 527;
                ctrl_red = 5;
                x_sky = 127; y_sky = 77;
                ctrl_sky = 5;
                x_cherry = 127; y_cherry = 527;
                ctrl_cherry = 5;
                x_aqua = 477; y_aqua = 77;
                ctrl_aqua = 5;
                timer3.Enabled = true;
                timer4.Enabled = true;
                timer6.Enabled = true;
                timer7.Enabled = true;               
                PAUSED = false;
                ctrl_1t = 3;
                ctrl_1 = 3;
                pacLives--;
                timer1.Enabled = true;
                Death.Enabled = false;
            }
        }

        void Chase(List<int> dir, int x, int y, int xDest, int yDest, ref int ctrl)
        {
            double dist = 0;
            double minLen = 0;
            for (int i = 0; i < dir.Count; i++)
            {

                switch (dir[i])
                {
                    case 1:
                        dist = Math.Pow((y - yDest - 25), 2) + Math.Pow((x - xDest), 2);
                        if (minLen == 0)
                        {
                            minLen = dist;
                            ctrl = 1;
                        }
                        else if (minLen > dist)
                        {
                            minLen = dist;
                            ctrl = 1;
                        }
                        break;
                    case 2:
                        dist = Math.Pow((y - yDest + 25), 2) + Math.Pow((x - xDest), 2);
                        if (minLen == 0)
                        {
                            minLen = dist;
                            ctrl = 2;
                        }
                        else if (minLen > dist)
                        {
                            minLen = dist;
                            ctrl = 2;
                        }
                        break;
                    case 3:
                        dist = Math.Pow((y - yDest), 2) + Math.Pow((x - xDest - 25), 2);

                        if (minLen == 0)
                        {
                            minLen = dist;
                            ctrl = 3;
                        }
                        else if (minLen > dist)
                        {
                            minLen = dist;
                            ctrl = 3;
                        }
                        break;
                    case 4:
                        dist = Math.Pow((y - yDest), 2) + Math.Pow((x - xDest + 25), 2);
                        if (minLen == 0)
                        {
                            minLen = dist;
                            ctrl = 4;
                        }
                        else if (minLen > dist)
                        {
                            minLen = dist;
                            ctrl = 4;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        void jump(ref int x, ref int y, int direction)
        {
            switch (direction)
            {
                case 1:
                    for (int i = 2; i < 5; i++)
                    {
                        if ((y - Map_Y + 10) / 25 - i > 0 && (x - Map_X + 10) / 25 > 0 && (y - Map_Y + 10) / 25 - i < 21 && (x - Map_X + 10) / 25 < 17)
                            if (Map[(y - Map_Y) / 25 - i, (x - Map_X) / 25] != 1 && Map[(y - Map_Y + pacSize) / 25 - i, (x - Map_X + pacSize) / 25] != 1 && (Map[(y - Map_Y) / 25 - 1, (x - Map_X) / 25] == 1 || Map[(y - Map_Y + pacSize) / 25 - 1, (x - Map_X + pacSize) / 25] == 1))
                            {
                                t = (i * 25);
                                temp = t;
                                jumpclock.Enabled = true;
                                break;
                            }
                    }
                    break;

                case 2:
                    for (int i = 1; i < 5; i++)
                    {
                        if ((y - Map_Y + 10) / 25 + i > 0 && (x - Map_X + 10) / 25 > 0 && (y - Map_Y + 10) / 25 + i < 21 && (x - Map_X + 10) / 25 < 17)
                            if (Map[(y - Map_Y) / 25 + i, (x - Map_X) / 25] != 1 && Map[(y - Map_Y + pacSize) / 25 + i, (x - Map_X + pacSize) / 25] != 1 && (Map[(y - Map_Y) / 25 + 1, (x - Map_X) / 25] == 1 || Map[(y - Map_Y + pacSize) / 25 + 1, (x - Map_X + pacSize) / 25] == 1))
                            {
                                t = (i * 25);
                                temp = t;
                                jumpclock.Enabled = true;
                                break;
                            }
                    }
                    break;

                case 3:
                    for (int i = 1; i < 5; i++)
                    {
                        if ((y - Map_Y + 10) / 25 > 0 && (x - Map_X + 10) / 25 - i > 0 && (y - Map_Y + 10) / 25 < 21 && (x - Map_X + 10) / 25 - i < 17)
                            if (Map[(y - Map_Y) / 25, (x - Map_X) / 25 - i] != 1 && Map[(y - Map_Y + pacSize) / 25, (x - Map_X + pacSize) / 25 - i] != 1 && (Map[(y - Map_Y) / 25, (x - Map_X) / 25 - 1] == 1 || Map[(y - Map_Y + pacSize) / 25, (x - Map_X + pacSize) / 25 - 1] == 1))
                            {
                                t = (i * 25);
                                temp = t;
                                jumpclock.Enabled = true;
                                break;
                            }
                    }
                    break;

                case 4:
                    for (int i = 1; i < 5; i++)
                    {
                        if ((y - Map_Y) / 25 > 0 && (x - Map_X) / 25 + i > 0 && (y - Map_Y) / 25 < 21 && (x - Map_X) / 25 + i < 17)
                            if (Map[(y - Map_Y) / 25, (x - Map_X) / 25 + i] != 1 && Map[(y - Map_Y + pacSize) / 25, (x - Map_X + pacSize) / 25 + i] != 1 && (Map[(y - Map_Y) / 25, (x - Map_X) / 25 + 1] == 1 || Map[(y - Map_Y + pacSize) / 25, (x - Map_X + pacSize) / 25 + 1] == 1))
                            {
                                t = (i * 25);
                                temp = t;
                                jumpclock.Enabled = true;
                                break;
                            }
                    }
                    break;

                default:
                    break;
            }
        }

        

        int selectitem()
        {
            Random rnd = new Random();
            return rnd.Next(0, 3);
        }

        

        int eventCount1;
        int current1;
        int i1, j1;
        void useItem(int itm)
        {
            i1 = (y_1 - Map_Y) / 25;
            j1 = (x_1 - Map_X) / 25;
            Items1.Enabled = true;
            current1 = itm;
        }

        private void Items1_Tick(object sender, EventArgs e)
        {
            switch (current1)
            {
                case 0:
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

                case 1:
                    timer3.Interval = 300;
                    timer4.Interval = 300;
                    timer6.Interval = 300;
                    timer7.Interval = 300;
                    eventCount1++;
                    if (eventCount1 == 70)
                    {
                        eventCount1 = 0;
                        timer3.Interval = 120;
                        timer4.Interval = 120;
                        timer6.Interval = 120;
                        timer7.Interval = 120;
                        Items1.Enabled = false;

                        pictureBox1.Image = pictureBox2.Image;
                        p1item1 = p1item2;
                        pictureBox2.Image = null;
                        p1item2 = -1;
                    }
                    break;

                case 2:
                    eventCount1++;
                    int i3 = 0, j3 = 0;
                    while (i3 == 0)
                    {
                        i3 = i1 - 1;
                        while (i3 >= 0)
                        {

                            if (Map2[i3, j1] == 0)
                                Map2[i3, j1] = 2;
                            else if (Map2[i3, j1] == 1)
                                break;
                            i3--;
                            if (i3 == 0)
                                break;
                        }
                        i3 = i1 + 1;
                        while (i3 < 21)
                        {

                            if (Map2[i3, j1] == 0)
                                Map2[i3, j1] = 2;
                            else if (Map2[i3, j1] == 1)
                                break;
                            i3++;
                            if (i3 == 21)
                                break;
                        }
                        j3 = j1 - 1;
                        while (j3 >= 0)
                        {

                            if (Map2[i1, j3] == 0)
                                Map2[i1, j3] = 2;
                            else if (Map2[i1, j3] == 1)
                                break;
                            j3--;
                            if (j3 == 0)
                                break;
                        }
                        j3 = j1 + 1;
                        while (j3 < 17)
                        {

                            if (Map2[i1, j3] == 0)
                                Map2[i1, j3] = 2;
                            else if (Map2[i1, j3] == 1)
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
                                if (Map2[i2, j2] == 2)
                                    Map2[i2, j2] = 0;

                            }
                        }
                        bom1.Enabled = false;
                        bombindex = 0;
                        Items1.Enabled = false;

                        pictureBox1.Image = pictureBox2.Image;
                        p1item1 = p1item2;
                        pictureBox2.Image = null;
                        p1item2 = -1;
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

        bool wasEnabled2 = false;
        bool wasEnabled_I = false;
        bool wasEnabled_J = false;
        void pauseGame(bool PAUSED)
        {
            if (PAUSED == false)
            {

                Pause.Visible = true;
                Pause.Text = "PAUSED";
                help.Visible = true;
                help.Text = "Press P Again to Resume.\nPress U to Quit.";
                timer1.Enabled = false;
                timer5.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer6.Enabled = false;
                timer7.Enabled = false;
                clock.Enabled = false;

                if (timer2.Enabled)
                {
                    timer2.Enabled = false;
                    wasEnabled2 = true;
                }
                
                if (Items1.Enabled)
                {
                    Items1.Enabled = false;
                    wasEnabled_I = true;
                }
                
                if (jumpclock.Enabled)
                {
                    jumpclock.Enabled = false;
                    wasEnabled_J = true;
                }
                
            }
            if (PAUSED == true)
            {

                Pause.Visible = false;
                Pause.Text = null;
                help.Visible = false;
                help.Text = null;
                timer1.Enabled = true;
                timer5.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = true;
                timer6.Enabled = true;
                timer7.Enabled = true;
                clock.Enabled = true;

                if (wasEnabled2)
                {
                    timer2.Enabled = true;
                    wasEnabled2 = false;
                }
                
                if (wasEnabled_I)
                {
                    Items1.Enabled = true;
                    wasEnabled_I = false;
                }
                
                if (wasEnabled_J)
                {
                    jumpclock.Enabled = true;
                    wasEnabled_J = false;
                }
            }
        }
        

        private void gameOver_Tick(object sender, EventArgs e)
        {
            gameOver.Enabled = false;
        }
    }
}
