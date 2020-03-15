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

// Multi Form, Struct, Class
namespace PacmanVS
{
    
       

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            BackgroundImage = PacmanVS.Properties.Resources.COVER;
            string path = @"..\HighScore_DO_NOT_EDIT.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            
        }

        int mode = 0;



        private void Start_Click(object sender, EventArgs e)
        {
            Start.ForeColor = Color.MediumBlue;

            switch (mode)
            {
                case 1:
                    Form4 f4 = new Form4();
                    f4.Show();
                    this.Hide();
                    break;
                case 2:
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                    break;

                default:
                    break;
            }
            
            //this.Close();
        }
        
        private void Start_MouseHover(object sender, EventArgs e)
        {
            Start.ForeColor = Color.DodgerBlue;
        }

        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.ForeColor = Color.RoyalBlue;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Environment.Exit(1);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.logout_rounded_filled_GRY;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.logout_rounded_filled_W;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //!!
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Q) 
            {
                Environment.Exit(1);
            }
            if (e.KeyCode == Keys.H)
            {
                Form f5 = new Form5();
                f5.Show();
            }
            if (e.KeyCode == Keys.R)
            {
                string path = @"..\HighScore_DO_NOT_EDIT.txt";
                if (File.Exists(path))
                {
                    System.IO.File.WriteAllText(path, "0");
                    MessageBox.Show("HighScore Reset!");
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                Single.ForeColor = Color.Yellow;
                Single.Text = "Single•";
                Duel.ForeColor = Color.MediumAquamarine;
                Duel.Text = "Duel";
                mode = 1;
            }

            if (e.KeyCode == Keys.Right)
            {
                Duel.ForeColor = Color.MediumSpringGreen;
                Duel.Text = "Duel•";
                Single.ForeColor = Color.Goldenrod;
                Single.Text = "Single";
                mode = 2;
            }

            if (e.KeyCode == Keys.Enter)
            {
                Start.ForeColor = Color.MediumBlue;

                switch (mode)
                {
                    case 1:
                        Form4 f4 = new Form4();
                        f4.Show();
                        this.Hide();
                        break;
                    case 2:
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                        break;
                    default:
                        break;

                }
            }
            //!!
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Start.ForeColor = Color.RoyalBlue;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Environment.Exit(1);
        }

        private void Single_Click(object sender, EventArgs e)
        {
            if (mode != 1)
            {
                Single.ForeColor = Color.Yellow;
                Single.Text = "Single•";
                Duel.ForeColor = Color.MediumAquamarine;
                Duel.Text = "Duel";
                mode = 1;
            }
            else
            {
                mode = 0;
                Single.Text = "Single";
            }
                
            
        }
        private void Single_MouseHover(object sender, EventArgs e)
        {
            Single.ForeColor = Color.Yellow;
        }
        private void Single_MouseLeave(object sender, EventArgs e)
        {
            if(mode !=1)
                Single.ForeColor = Color.Goldenrod;
            else
                Single.ForeColor = Color.Yellow;
        }

        private void Duel_Click(object sender, EventArgs e)
        {
            if (mode != 2)
            {
                Duel.ForeColor = Color.MediumSpringGreen;
                Duel.Text = "Duel•";
                Single.ForeColor = Color.Goldenrod;
                Single.Text = "Single";
                mode = 2;
            }
            else
            {
                mode = 0;
                Duel.Text = "Duel";
            }
                
        }
        private void Duel_MouseHover(object sender, EventArgs e)
        {
            Duel.ForeColor = Color.MediumSpringGreen;
        }

        private void Duel_MouseLeave(object sender, EventArgs e)
        {
            if (mode != 2)
                Duel.ForeColor = Color.MediumAquamarine;
            else
                Duel.ForeColor = Color.MediumSpringGreen;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.Show();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.info_GRY;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.info_W;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string path = @"..\HighScore_DO_NOT_EDIT.txt";
            if (File.Exists(path))
            {
                System.IO.File.WriteAllText(path, "999999");
                MessageBox.Show("HighScore Reset!");
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.refresh_GRY;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.refresh_W;
        }
    }

    
}
