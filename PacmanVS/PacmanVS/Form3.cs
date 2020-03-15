using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanVS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            GC.Collect();
            BackgroundImage = null;

            Result.Visible = true;

            Result.Text = "You Lose...";
            showWinner.Image = PacmanVS.Properties.Resources.frame_03_delay_0_01s;
            showLoser1.Image = null;
            showLoser2.Image = null;
            showCrown1.Image = null;
            showCrown2.Image = null;
        }

        public Form3(string s)
        {
            InitializeComponent();
            GC.Collect();

            int intTime = 0, intHS = 0 ;

            Int32.TryParse(s, out intTime);

            string path = @"..\HighScore_DO_NOT_EDIT.txt";
            string high;
            if (File.Exists(path))
            {
                high = System.IO.File.ReadAllText(path);
                Int32.TryParse(high, out intHS);

                //ResultConfirm.Text = intHS.ToString();

                if (intTime <= intHS || intHS == 0) 
                {
                    System.IO.File.WriteAllText(path, s);
                    High_score.Enabled = true;
                    High_score.Visible = true;
                }
                else
                {
                    High_score.Enabled = true;
                    High_score.Visible = true;
                    High_score.Text = "HighScore: " + high + " sec" ;
                }

                
            }

            BackgroundImage = null;

            Result.Visible = true;

            Result.Text = "Time Used: \n" + s;
            showWinner.Image = PacmanVS.Properties.Resources.frame_00_delay_0_01s;
            showLoser1.Image = null;
            showLoser2.Image = null;
            showCrown1.Image = null;
            showCrown2.Image = null;

            showCrown1.Visible = false;
            showCrown2.Visible = false;


        }

        public Form3(string s1, string s2)
        {
            InitializeComponent();
            GC.Collect();
            BackgroundImage = null;
            int intScore1 = 0, intScore2 = 0;

            Int32.TryParse(s1, out intScore1);
            Int32.TryParse(s2, out intScore2);
            Result.Visible = true;

            if (intScore1 > intScore2)
            {
                Result.Text = "P1 Wins!!\n" + s1 + " : " + s2;
                showWinner.Image = PacmanVS.Properties.Resources.frame_00_delay_0_01s;
                showLoser1.Image = null;
                showLoser2.Image = PacmanVS.Properties.Resources.frame_03_delay_0_01s1;
                showCrown1.Image = PacmanVS.Properties.Resources.queen_crown;
                showCrown2.Image = null;
            }
            else if (intScore1 < intScore2)
            {
                Result.Text = "P2 Wins!!\n" + s1 + " : " + s2;
                showWinner.Image = PacmanVS.Properties.Resources.frame_00_delay_0_01s1;
                showLoser1.Image = PacmanVS.Properties.Resources.frame_03_delay_0_01s;
                showLoser2.Image = null;
                showCrown1.Image = null;
                showCrown2.Image = PacmanVS.Properties.Resources.queen_crown__2_;
                
            }
            else
            {
                Result.Text = "Draw.\n" + s1 + " : " + s2;
                showWinner.Image = null;
                showLoser1.Image = PacmanVS.Properties.Resources.frame_03_delay_0_01s;
                showLoser2.Image = PacmanVS.Properties.Resources.frame_03_delay_0_01s1;
                showCrown1.Image = null;
                showCrown2.Image = null;
                
            }
                
        }

        private void ResultConfirm_Click(object sender, EventArgs e)
        {
            ResultConfirm.ForeColor = Color.MediumBlue;
            Form1 f1 = new Form1();
            f1.Show();
            High_score.Enabled = false;
            High_score.Visible = false;
            showCrown1.Visible = true;
            showCrown2.Visible = true;
            //this.Hide();
            this.Close();
            
        }

        private void ResultConfirm_MouseHover(object sender, EventArgs e)
        {
            ResultConfirm.ForeColor = Color.DodgerBlue;
        }

        private void ResultConfirm_MouseLeave(object sender, EventArgs e)
        {
            ResultConfirm.ForeColor = Color.RoyalBlue;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            //!!
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                Form1 f1 = new Form1();
                f1.Show();
                High_score.Enabled = false;
                High_score.Visible = false;
                this.Close();
            }
            //!!
        }
    }
}
