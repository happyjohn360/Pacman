namespace PacmanVS
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Collect = new System.Windows.Forms.Timer(this.components);
            this.P1_Up = new System.Windows.Forms.ImageList(this.components);
            this.P1_Right = new System.Windows.Forms.ImageList(this.components);
            this.P1_Down = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.P1_Left = new System.Windows.Forms.ImageList(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.P2_Down = new System.Windows.Forms.ImageList(this.components);
            this.P2_Left = new System.Windows.Forms.ImageList(this.components);
            this.P2_Right = new System.Windows.Forms.ImageList(this.components);
            this.P2_Up = new System.Windows.Forms.ImageList(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.item = new System.Windows.Forms.ImageList(this.components);
            this.Items1 = new System.Windows.Forms.Timer(this.components);
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.Items2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.jumpclock = new System.Windows.Forms.Timer(this.components);
            this.jumpclock2 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Timer(this.components);
            this.help = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.ImageList(this.components);
            this.bom2 = new System.Windows.Forms.Timer(this.components);
            this.bom1 = new System.Windows.Forms.Timer(this.components);
            this.P1_Death = new System.Windows.Forms.ImageList(this.components);
            this.P1death = new System.Windows.Forms.Timer(this.components);
            this.P2death = new System.Windows.Forms.Timer(this.components);
            this.P2_Death = new System.Windows.Forms.ImageList(this.components);
            this.Hourglass = new System.Windows.Forms.ImageList(this.components);
            this.CD = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(121, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Collect
            // 
            this.Collect.Enabled = true;
            this.Collect.Interval = 10;
            this.Collect.Tick += new System.EventHandler(this.Collect_Tick);
            // 
            // P1_Up
            // 
            this.P1_Up.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P1_Up.ImageStream")));
            this.P1_Up.TransparentColor = System.Drawing.Color.Transparent;
            this.P1_Up.Images.SetKeyName(0, "frame_00_delay-0.01s.png");
            this.P1_Up.Images.SetKeyName(1, "frame_01_delay-0.01s.png");
            this.P1_Up.Images.SetKeyName(2, "frame_02_delay-0.01s.png");
            this.P1_Up.Images.SetKeyName(3, "frame_03_delay-0.01s.png");
            this.P1_Up.Images.SetKeyName(4, "frame_04_delay-0.01s.png");
            this.P1_Up.Images.SetKeyName(5, "frame_05_delay-0.01s.png");
            this.P1_Up.Images.SetKeyName(6, "frame_06_delay-0.01s.png");
            this.P1_Up.Images.SetKeyName(7, "frame_07_delay-0.01s.png");
            this.P1_Up.Images.SetKeyName(8, "frame_08_delay-0.01s.png");
            this.P1_Up.Images.SetKeyName(9, "frame_09_delay-0.01s.png");
            this.P1_Up.Images.SetKeyName(10, "Blank_Canvas_on_Transparent_Background.png");
            // 
            // P1_Right
            // 
            this.P1_Right.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P1_Right.ImageStream")));
            this.P1_Right.TransparentColor = System.Drawing.Color.Transparent;
            this.P1_Right.Images.SetKeyName(0, "frame_00_delay-0.01s.png");
            this.P1_Right.Images.SetKeyName(1, "frame_01_delay-0.01s.png");
            this.P1_Right.Images.SetKeyName(2, "frame_02_delay-0.01s.png");
            this.P1_Right.Images.SetKeyName(3, "frame_03_delay-0.01s.png");
            this.P1_Right.Images.SetKeyName(4, "frame_04_delay-0.01s.png");
            this.P1_Right.Images.SetKeyName(5, "frame_05_delay-0.01s.png");
            this.P1_Right.Images.SetKeyName(6, "frame_06_delay-0.01s.png");
            this.P1_Right.Images.SetKeyName(7, "frame_07_delay-0.01s.png");
            this.P1_Right.Images.SetKeyName(8, "frame_08_delay-0.01s.png");
            this.P1_Right.Images.SetKeyName(9, "frame_09_delay-0.01s.png");
            this.P1_Right.Images.SetKeyName(10, "Blank_Canvas_on_Transparent_Background.png");
            // 
            // P1_Down
            // 
            this.P1_Down.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P1_Down.ImageStream")));
            this.P1_Down.TransparentColor = System.Drawing.Color.Transparent;
            this.P1_Down.Images.SetKeyName(0, "frame_00_delay-0.01s.png");
            this.P1_Down.Images.SetKeyName(1, "frame_01_delay-0.01s.png");
            this.P1_Down.Images.SetKeyName(2, "frame_02_delay-0.01s.png");
            this.P1_Down.Images.SetKeyName(3, "frame_03_delay-0.01s.png");
            this.P1_Down.Images.SetKeyName(4, "frame_04_delay-0.01s.png");
            this.P1_Down.Images.SetKeyName(5, "frame_05_delay-0.01s.png");
            this.P1_Down.Images.SetKeyName(6, "frame_06_delay-0.01s.png");
            this.P1_Down.Images.SetKeyName(7, "frame_07_delay-0.01s.png");
            this.P1_Down.Images.SetKeyName(8, "frame_08_delay-0.01s.png");
            this.P1_Down.Images.SetKeyName(9, "frame_09_delay-0.01s.png");
            this.P1_Down.Images.SetKeyName(10, "Blank_Canvas_on_Transparent_Background.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // P1_Left
            // 
            this.P1_Left.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P1_Left.ImageStream")));
            this.P1_Left.TransparentColor = System.Drawing.Color.Transparent;
            this.P1_Left.Images.SetKeyName(0, "frame_00_delay-0.01s.png");
            this.P1_Left.Images.SetKeyName(1, "frame_01_delay-0.01s.png");
            this.P1_Left.Images.SetKeyName(2, "frame_02_delay-0.01s.png");
            this.P1_Left.Images.SetKeyName(3, "frame_03_delay-0.01s.png");
            this.P1_Left.Images.SetKeyName(4, "frame_04_delay-0.01s.png");
            this.P1_Left.Images.SetKeyName(5, "frame_05_delay-0.01s.png");
            this.P1_Left.Images.SetKeyName(6, "frame_06_delay-0.01s.png");
            this.P1_Left.Images.SetKeyName(7, "frame_07_delay-0.01s.png");
            this.P1_Left.Images.SetKeyName(8, "frame_08_delay-0.01s.png");
            this.P1_Left.Images.SetKeyName(9, "frame_09_delay-0.01s.png");
            this.P1_Left.Images.SetKeyName(10, "Blank_Canvas_on_Transparent_Background.png");
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // P2_Down
            // 
            this.P2_Down.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P2_Down.ImageStream")));
            this.P2_Down.TransparentColor = System.Drawing.Color.Transparent;
            this.P2_Down.Images.SetKeyName(0, "frame_00_delay-0.01s.png");
            this.P2_Down.Images.SetKeyName(1, "frame_01_delay-0.01s.png");
            this.P2_Down.Images.SetKeyName(2, "frame_02_delay-0.01s.png");
            this.P2_Down.Images.SetKeyName(3, "frame_03_delay-0.01s.png");
            this.P2_Down.Images.SetKeyName(4, "frame_04_delay-0.01s.png");
            this.P2_Down.Images.SetKeyName(5, "frame_05_delay-0.01s.png");
            this.P2_Down.Images.SetKeyName(6, "frame_06_delay-0.01s.png");
            this.P2_Down.Images.SetKeyName(7, "frame_07_delay-0.01s.png");
            this.P2_Down.Images.SetKeyName(8, "frame_08_delay-0.01s.png");
            this.P2_Down.Images.SetKeyName(9, "frame_09_delay-0.01s.png");
            this.P2_Down.Images.SetKeyName(10, "Blank_Canvas_on_Transparent_Background.png");
            // 
            // P2_Left
            // 
            this.P2_Left.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P2_Left.ImageStream")));
            this.P2_Left.TransparentColor = System.Drawing.Color.Transparent;
            this.P2_Left.Images.SetKeyName(0, "frame_00_delay-0.01s.png");
            this.P2_Left.Images.SetKeyName(1, "frame_01_delay-0.01s.png");
            this.P2_Left.Images.SetKeyName(2, "frame_02_delay-0.01s.png");
            this.P2_Left.Images.SetKeyName(3, "frame_03_delay-0.01s.png");
            this.P2_Left.Images.SetKeyName(4, "frame_04_delay-0.01s.png");
            this.P2_Left.Images.SetKeyName(5, "frame_05_delay-0.01s.png");
            this.P2_Left.Images.SetKeyName(6, "frame_06_delay-0.01s.png");
            this.P2_Left.Images.SetKeyName(7, "frame_07_delay-0.01s.png");
            this.P2_Left.Images.SetKeyName(8, "frame_08_delay-0.01s.png");
            this.P2_Left.Images.SetKeyName(9, "frame_09_delay-0.01s.png");
            this.P2_Left.Images.SetKeyName(10, "Blank_Canvas_on_Transparent_Background.png");
            // 
            // P2_Right
            // 
            this.P2_Right.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P2_Right.ImageStream")));
            this.P2_Right.TransparentColor = System.Drawing.Color.Transparent;
            this.P2_Right.Images.SetKeyName(0, "frame_00_delay-0.01s.png");
            this.P2_Right.Images.SetKeyName(1, "frame_01_delay-0.01s.png");
            this.P2_Right.Images.SetKeyName(2, "frame_02_delay-0.01s.png");
            this.P2_Right.Images.SetKeyName(3, "frame_03_delay-0.01s.png");
            this.P2_Right.Images.SetKeyName(4, "frame_04_delay-0.01s.png");
            this.P2_Right.Images.SetKeyName(5, "frame_05_delay-0.01s.png");
            this.P2_Right.Images.SetKeyName(6, "frame_06_delay-0.01s.png");
            this.P2_Right.Images.SetKeyName(7, "frame_07_delay-0.01s.png");
            this.P2_Right.Images.SetKeyName(8, "frame_08_delay-0.01s.png");
            this.P2_Right.Images.SetKeyName(9, "frame_09_delay-0.01s.png");
            this.P2_Right.Images.SetKeyName(10, "Blank_Canvas_on_Transparent_Background.png");
            // 
            // P2_Up
            // 
            this.P2_Up.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P2_Up.ImageStream")));
            this.P2_Up.TransparentColor = System.Drawing.Color.Transparent;
            this.P2_Up.Images.SetKeyName(0, "frame_00_delay-0.01s.png");
            this.P2_Up.Images.SetKeyName(1, "frame_01_delay-0.01s.png");
            this.P2_Up.Images.SetKeyName(2, "frame_02_delay-0.01s.png");
            this.P2_Up.Images.SetKeyName(3, "frame_03_delay-0.01s.png");
            this.P2_Up.Images.SetKeyName(4, "frame_04_delay-0.01s.png");
            this.P2_Up.Images.SetKeyName(5, "frame_05_delay-0.01s.png");
            this.P2_Up.Images.SetKeyName(6, "frame_06_delay-0.01s.png");
            this.P2_Up.Images.SetKeyName(7, "frame_07_delay-0.01s.png");
            this.P2_Up.Images.SetKeyName(8, "frame_08_delay-0.01s.png");
            this.P2_Up.Images.SetKeyName(9, "frame_09_delay-0.01s.png");
            this.P2_Up.Images.SetKeyName(10, "Blank_Canvas_on_Transparent_Background.png");
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 5000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // item
            // 
            this.item.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("item.ImageStream")));
            this.item.TransparentColor = System.Drawing.Color.Transparent;
            this.item.Images.SetKeyName(0, "card-exchange.png");
            this.item.Images.SetKeyName(1, "fast-arrow.png");
            this.item.Images.SetKeyName(2, "invisible.png");
            this.item.Images.SetKeyName(3, "plain-circle.png");
            this.item.Images.SetKeyName(4, "sparky-bomb.png");
            // 
            // Items1
            // 
            this.Items1.Tick += new System.EventHandler(this.Items1_Tick_1);
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.SystemColors.ControlText;
            this.score1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score1.Location = new System.Drawing.Point(525, 365);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(94, 24);
            this.score1.TabIndex = 3;
            this.score1.Text = "Score 1";
            this.score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.SystemColors.ControlText;
            this.score2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score2.Location = new System.Drawing.Point(12, 365);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(94, 24);
            this.score2.TabIndex = 4;
            this.score2.Text = "Score 2";
            this.score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.BackColor = System.Drawing.SystemColors.ControlText;
            this.second.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.second.Location = new System.Drawing.Point(261, 15);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(61, 27);
            this.second.TabIndex = 5;
            this.second.Text = "TIME";
            this.second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Items2
            // 
            this.Items2.Tick += new System.EventHandler(this.Items2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(527, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "P1 Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Turquoise;
            this.label4.Location = new System.Drawing.Point(9, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "P2 Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(528, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "P1 Items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Turquoise;
            this.label6.Location = new System.Drawing.Point(4, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "P2 Items";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(271, 573);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Press P to Pause.";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // jumpclock
            // 
            this.jumpclock.Interval = 35;
            this.jumpclock.Tick += new System.EventHandler(this.jumpclock_Tick);
            // 
            // jumpclock2
            // 
            this.jumpclock2.Interval = 35;
            this.jumpclock2.Tick += new System.EventHandler(this.jumpclock2_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Pause.Location = new System.Drawing.Point(105, 263);
            this.Pause.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(417, 112);
            this.Pause.TabIndex = 12;
            this.Pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pause.Visible = false;
            // 
            // gameOver
            // 
            this.gameOver.Interval = 5000;
            this.gameOver.Tick += new System.EventHandler(this.gameOver_Tick);
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.help.Location = new System.Drawing.Point(184, 386);
            this.help.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(0, 29);
            this.help.TabIndex = 13;
            this.help.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.help.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(8, 115);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(8, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(544, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(544, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bomb
            // 
            this.bomb.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bomb.ImageStream")));
            this.bomb.TransparentColor = System.Drawing.Color.Transparent;
            this.bomb.Images.SetKeyName(0, "frame_00_delay-0.1s.png");
            this.bomb.Images.SetKeyName(1, "frame_01_delay-0.1s.png");
            this.bomb.Images.SetKeyName(2, "frame_04_delay-0.1s.png");
            this.bomb.Images.SetKeyName(3, "frame_06_delay-0.1s.png");
            this.bomb.Images.SetKeyName(4, "frame_07_delay-0.1s.png");
            this.bomb.Images.SetKeyName(5, "frame_08_delay-0.1s.png");
            this.bomb.Images.SetKeyName(6, "frame_09_delay-0.1s.png");
            this.bomb.Images.SetKeyName(7, "frame_10_delay-0.1s.png");
            this.bomb.Images.SetKeyName(8, "frame_11_delay-0.1s.png");
            this.bomb.Images.SetKeyName(9, "frame_12_delay-0.1s.png");
            // 
            // bom2
            // 
            this.bom2.Interval = 15;
            this.bom2.Tick += new System.EventHandler(this.bom_Tick);
            // 
            // bom1
            // 
            this.bom1.Interval = 15;
            this.bom1.Tick += new System.EventHandler(this.bom1_Tick);
            // 
            // P1_Death
            // 
            this.P1_Death.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P1_Death.ImageStream")));
            this.P1_Death.TransparentColor = System.Drawing.Color.Transparent;
            this.P1_Death.Images.SetKeyName(0, "frame_00_delay-0.01s.png");
            this.P1_Death.Images.SetKeyName(1, "frame_01_delay-0.01s.png");
            this.P1_Death.Images.SetKeyName(2, "frame_02_delay-0.01s.png");
            this.P1_Death.Images.SetKeyName(3, "frame_03_delay-0.01s.png");
            this.P1_Death.Images.SetKeyName(4, "frame_04_delay-0.01s.png");
            this.P1_Death.Images.SetKeyName(5, "frame_05_delay-0.01s.png");
            this.P1_Death.Images.SetKeyName(6, "frame_06_delay-0.01s.png");
            this.P1_Death.Images.SetKeyName(7, "frame_07_delay-0.01s.png");
            this.P1_Death.Images.SetKeyName(8, "frame_08_delay-0.01s.png");
            this.P1_Death.Images.SetKeyName(9, "frame_09_delay-0.01s.png");
            // 
            // P1death
            // 
            this.P1death.Interval = 200;
            this.P1death.Tick += new System.EventHandler(this.P1death_Tick);
            // 
            // P2death
            // 
            this.P2death.Interval = 200;
            this.P2death.Tick += new System.EventHandler(this.P2death_Tick);
            // 
            // P2_Death
            // 
            this.P2_Death.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P2_Death.ImageStream")));
            this.P2_Death.TransparentColor = System.Drawing.Color.Transparent;
            this.P2_Death.Images.SetKeyName(0, "frame_00_delay-0.01s.png");
            this.P2_Death.Images.SetKeyName(1, "frame_01_delay-0.01s.png");
            this.P2_Death.Images.SetKeyName(2, "frame_02_delay-0.01s.png");
            this.P2_Death.Images.SetKeyName(3, "frame_03_delay-0.01s.png");
            this.P2_Death.Images.SetKeyName(4, "frame_04_delay-0.01s.png");
            this.P2_Death.Images.SetKeyName(5, "frame_05_delay-0.01s.png");
            this.P2_Death.Images.SetKeyName(6, "frame_06_delay-0.01s.png");
            this.P2_Death.Images.SetKeyName(7, "frame_07_delay-0.01s.png");
            this.P2_Death.Images.SetKeyName(8, "frame_08_delay-0.01s.png");
            this.P2_Death.Images.SetKeyName(9, "frame_09_delay-0.01s.png");
            // 
            // Hourglass
            // 
            this.Hourglass.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Hourglass.ImageStream")));
            this.Hourglass.TransparentColor = System.Drawing.Color.Transparent;
            this.Hourglass.Images.SetKeyName(0, "frame_00_delay-0.1s.png");
            this.Hourglass.Images.SetKeyName(1, "frame_01_delay-0.1s.png");
            this.Hourglass.Images.SetKeyName(2, "frame_02_delay-0.1s.png");
            this.Hourglass.Images.SetKeyName(3, "frame_03_delay-0.1s.png");
            this.Hourglass.Images.SetKeyName(4, "frame_04_delay-0.1s.png");
            this.Hourglass.Images.SetKeyName(5, "frame_05_delay-0.1s.png");
            this.Hourglass.Images.SetKeyName(6, "frame_06_delay-0.1s.png");
            this.Hourglass.Images.SetKeyName(7, "frame_07_delay-0.1s.png");
            this.Hourglass.Images.SetKeyName(8, "frame_08_delay-0.1s.png");
            this.Hourglass.Images.SetKeyName(9, "frame_09_delay-0.1s.png");
            // 
            // CD
            // 
            this.CD.Enabled = true;
            this.CD.Tick += new System.EventHandler(this.CD_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(627, 618);
            this.ControlBox = false;
            this.Controls.Add(this.help);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.second);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "PvP";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Collect;
        private System.Windows.Forms.ImageList P1_Up;
        private System.Windows.Forms.ImageList P1_Right;
        private System.Windows.Forms.ImageList P1_Down;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ImageList P1_Left;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ImageList P2_Down;
        private System.Windows.Forms.ImageList P2_Left;
        private System.Windows.Forms.ImageList P2_Right;
        private System.Windows.Forms.ImageList P2_Up;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer Items1;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Timer Items2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Timer jumpclock;
        private System.Windows.Forms.Timer jumpclock2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Pause;
        private System.Windows.Forms.Timer gameOver;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.ImageList item;
        private System.Windows.Forms.ImageList bomb;
        private System.Windows.Forms.Timer bom2;
        private System.Windows.Forms.Timer bom1;
        private System.Windows.Forms.ImageList P1_Death;
        private System.Windows.Forms.Timer P1death;
        private System.Windows.Forms.Timer P2death;
        private System.Windows.Forms.ImageList P2_Death;
        private System.Windows.Forms.ImageList Hourglass;
        private System.Windows.Forms.Timer CD;
    }
}