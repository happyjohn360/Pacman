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
    public partial class Form5 : Form
    {
        int Mode = 1;

        public Form5()
        {
            InitializeComponent();
            Mode = 1;
            ChangePage(Mode);
            
        }
        

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData.Equals(Keys.Left) && Mode!=1)
            {
                Mode--;
                ChangePage(Mode);
            }
            if (keyData.Equals(Keys.Right) && Mode != 5)
            {
                Mode++;
                ChangePage(Mode);
            }
            if (keyData.Equals(Keys.B) || keyData.Equals(Keys.Escape))
            {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        void ChangePage(int mode)
        {
            switch (mode)
            {
                case 1:
                    button1.Enabled = false;
                    button1.Visible = false;
                    label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = true;
                    label6.Visible = label7.Visible = label8.Visible = label9.Visible = label10.Visible = true;
                    label11.Visible = label12.Visible = true;

                    label16.Visible = label17.Visible = label18.Visible = label19.Visible = label20.Visible = false;
                    label21.Visible = label22.Visible = false;
                    pictureBox17.Visible = pictureBox18.Visible = pictureBox19.Visible = pictureBox20.Visible = pictureBox21.Visible = false;

                    label11.Text = "遊戲中按下：";
                    label10.Text = "再按下：";

                    pictureBox17.Image = null;
                    pictureBox18.Image = null;
                    pictureBox19.Image = null;
                    pictureBox20.Image = null;
                    pictureBox21.Image = null;
                    
                    pictureBox1.Visible = pictureBox2.Visible = pictureBox3.Visible = pictureBox4.Visible = pictureBox5.Visible = true;
                    pictureBox6.Visible = pictureBox7.Visible = pictureBox8.Visible = pictureBox9.Visible = pictureBox10.Visible = true;
                    pictureBox11.Visible = pictureBox12.Visible = pictureBox13.Visible = pictureBox14.Visible = pictureBox15.Visible = true;
                    
                    pictureBox1.Image = KBKeys.Images[7];
                    pictureBox2.Image = KBKeys.Images[6];
                    pictureBox3.Image = KBKeys.Images[11];
                    pictureBox4.Image = KBKeys.Images[13];

                    pictureBox5.Image = KBKeys.Images[0];
                    pictureBox6.Image = KBKeys.Images[2];
                    pictureBox7.Image = KBKeys.Images[1];
                    pictureBox8.Image = KBKeys.Images[3];

                    pictureBox9.Image = KBKeys.Images[8];
                    pictureBox10.Image = KBKeys.Images[12];
                    pictureBox11.Image = KBKeys.Images[10];
                    pictureBox12.Image = KBKeys.Images[9];

                    pictureBox13.Image = KBKeys.Images[4];
                    pictureBox14.Image = KBKeys.Images[5];
                    pictureBox15.Image = KBKeys.Images[4];
                    break;

                case 2:
                    button1.Enabled = true;
                    button1.Visible = true;
                    label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = false;
                    label6.Visible = label7.Visible = label8.Visible = label9.Visible = label10.Visible = false;
                    label11.Visible = label12.Visible = false;

                    label16.Visible = label17.Visible = label18.Visible = label19.Visible = label20.Visible = true;
                    label21.Visible = label22.Visible = true;
                    pictureBox17.Visible = pictureBox18.Visible = pictureBox19.Visible = pictureBox20.Visible = pictureBox21.Visible = true;

                    pictureBox17.Image = Items.Images[0];
                    pictureBox18.Image = Items.Images[1];
                    pictureBox19.Image = Items.Images[3];
                    pictureBox20.Image = Items.Images[2];
                    pictureBox21.Image = Items.Images[5];

                    label17.Text = "交換：釋放後立即與對手交換位置";
                    label18.Text = "衝刺：釋放後5秒之間，自身速度提升";
                    label19.Text = "分數加倍：釋放後5秒之間，獲得分數提升2倍";
                    label20.Text = "隱形：釋放後5秒之間，對手位置消失";
                    label21.Text = "炸彈：釋放後以十字形爆炸，範圍至觸及牆壁為止，\n　　　受波及的對手將死亡，並回到重生點";
                    label22.Text = "Duel 對戰模式";

                    pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = null;
                    pictureBox6.Image = pictureBox7.Image = pictureBox8.Image = pictureBox9.Image = pictureBox10.Image = null;
                    pictureBox11.Image = pictureBox12.Image = pictureBox13.Image = pictureBox14.Image = pictureBox15.Image = null;
                    
                    pictureBox1.Visible = pictureBox2.Visible = pictureBox3.Visible = pictureBox4.Visible = pictureBox5.Visible = false;
                    pictureBox6.Visible = pictureBox7.Visible = pictureBox8.Visible = pictureBox9.Visible = pictureBox10.Visible = false;
                    pictureBox11.Visible = pictureBox12.Visible = pictureBox13.Visible = pictureBox14.Visible = pictureBox15.Visible = false;
                    
                    break;

                case 3:
                    label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = false;
                    label6.Visible = label7.Visible = label8.Visible = label9.Visible = label10.Visible = false;
                    label11.Visible = label12.Visible = false;

                    label16.Visible = label17.Visible = label18.Visible = label19.Visible = label22.Visible = true;
                    label20.Visible = label21.Visible = false;
                    label23.Visible = label24.Visible = false;
                    pictureBox17.Visible = pictureBox18.Visible = pictureBox19.Visible = true;
                    pictureBox20.Visible = pictureBox21.Visible = false;

                    pictureBox17.Image = Items.Images[1];
                    pictureBox18.Image = Items.Images[5];
                    pictureBox19.Image = Items.Images[4];
                    pictureBox20.Image = null;
                    pictureBox21.Image = null;

                    label16.Text = "道具介紹";
                    label17.Text = "衝刺：釋放後5秒之間，自身速度提升";
                    label18.Text = "炸彈：釋放後以十字形爆炸，範圍至觸及牆壁為止，\n　　　受波及的怪物將回到重生點，待5秒後恢復動作";
                    label19.Text = "敵人緩速：釋放後7秒之間，怪物移動速度變慢";
                    //label20.Text = "隱形：釋放後5秒之間，對手位置消失";
                    //label21.Text = "炸彈：釋放後以十字形爆炸，範圍至觸及牆壁為止，\n　　　受波及的怪物將回到重生點，待5秒後恢復動作";
                    label22.Text = "Single 單人模式";

                    pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = null;
                    pictureBox6.Image = pictureBox7.Image = pictureBox8.Image = pictureBox9.Image = pictureBox10.Image = null;
                    pictureBox11.Image = pictureBox12.Image = pictureBox13.Image = pictureBox14.Image = pictureBox15.Image = null;

                    pictureBox1.Visible = pictureBox2.Visible = pictureBox3.Visible = pictureBox4.Visible = pictureBox5.Visible = false;
                    pictureBox6.Visible = pictureBox7.Visible = pictureBox8.Visible = pictureBox9.Visible = pictureBox10.Visible = false;
                    pictureBox11.Visible = pictureBox12.Visible = pictureBox13.Visible = pictureBox14.Visible = pictureBox15.Visible = false;
                    break;
                case 4:
                    button2.Enabled = true;
                    button2.Visible = true;
                    label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = false;
                    label6.Visible = label7.Visible = label8.Visible = label9.Visible = label12.Visible = false;
                    label10.Visible = label11.Visible = false;

                    label17.Visible = label18.Visible = label19.Visible = label22.Visible = false;
                    label20.Visible = label21.Visible = false;
                    pictureBox17.Visible = pictureBox18.Visible = pictureBox19.Visible = false;
                    pictureBox20.Visible = pictureBox21.Visible = false;

                    pictureBox17.Image = null;
                    pictureBox18.Image = null;
                    pictureBox19.Image = null;
                    pictureBox20.Image = null;
                    pictureBox21.Image = null;

                    label23.Visible = label24.Visible = true;
                    
                    label23.Text = "Duel 對戰模式：\n\n　　　•玩家每吃到1顆白色圓點，將紀錄其當下的讀秒作為採計分數。\n" +
                        "　　　•玩家死亡時將失去約3成的積分，\n　　　　並在地圖上隨機增加相應數量的白色圓點。\n" +
                        "　　　•成功消滅對手的玩家可獲得額外分數獎勵。\n"+
                        "　　　•遊戲目標：將場上所有白色圓點吃光，得分較高的一方獲勝！";

                    label24.Text = "Single 單人模式：\n\n　　　•開場時，玩家將被賦予4顆❤。\n" +
                        "　　　•被鬼抓到的時候，會丟掉1顆❤。\n" +
                        "　　　•當❤數歸零，遊戲失敗。\n" +
                        "　　　•遊戲目標：儘快把場上所有白色圓點吃光！";

                    label16.Text = "遊戲規則";
                    break;
                case 5:
                    button2.Enabled = false;
                    button2.Visible = false;
                    label24.Visible = false;
                    label23.Text = "其他規則：\n\n　　　•玩家按下 [?] 或 [Ctrl] 跳躍時，最多只能越過2方格厚的牆壁。\n" +
                        "　　　•道具在作用的期間時，不可連放第二枚道具。\n" +
                        "　　　•道具可以持有2枚，最多也只能持有2枚。\n";

                    break;


            }
            label15.Text = Mode.ToString();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            pictureBox16.BackgroundImage = Properties.Resources.logout_rounded_filled_GRY;
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.BackgroundImage = Properties.Resources.logout_rounded_filled_W;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mode--;
            ChangePage(Mode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mode++;
            ChangePage(Mode);
        }
    }
}
