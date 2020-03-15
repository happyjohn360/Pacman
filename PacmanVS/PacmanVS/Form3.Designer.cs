namespace PacmanVS
{
    partial class Form3
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
            this.ResultConfirm = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.showCrown2 = new System.Windows.Forms.PictureBox();
            this.showCrown1 = new System.Windows.Forms.PictureBox();
            this.showLoser1 = new System.Windows.Forms.PictureBox();
            this.showLoser2 = new System.Windows.Forms.PictureBox();
            this.showWinner = new System.Windows.Forms.PictureBox();
            this.High_score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showCrown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCrown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLoser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLoser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultConfirm
            // 
            this.ResultConfirm.AutoSize = true;
            this.ResultConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ResultConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResultConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultConfirm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ResultConfirm.Location = new System.Drawing.Point(389, 528);
            this.ResultConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultConfirm.Name = "ResultConfirm";
            this.ResultConfirm.Size = new System.Drawing.Size(162, 44);
            this.ResultConfirm.TabIndex = 6;
            this.ResultConfirm.Text = "Confirm";
            this.ResultConfirm.Click += new System.EventHandler(this.ResultConfirm_Click);
            this.ResultConfirm.MouseLeave += new System.EventHandler(this.ResultConfirm_MouseLeave);
            this.ResultConfirm.MouseHover += new System.EventHandler(this.ResultConfirm_MouseHover);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.SystemColors.ControlText;
            this.Result.Cursor = System.Windows.Forms.Cursors.Default;
            this.Result.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Result.Location = new System.Drawing.Point(383, 425);
            this.Result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(125, 37);
            this.Result.TabIndex = 7;
            this.Result.Text = "Result";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Result.Visible = false;
            // 
            // showCrown2
            // 
            this.showCrown2.BackColor = System.Drawing.Color.Transparent;
            this.showCrown2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showCrown2.Image = global::PacmanVS.Properties.Resources.queen_crown__2_;
            this.showCrown2.Location = new System.Drawing.Point(580, 42);
            this.showCrown2.Margin = new System.Windows.Forms.Padding(2);
            this.showCrown2.Name = "showCrown2";
            this.showCrown2.Size = new System.Drawing.Size(100, 100);
            this.showCrown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showCrown2.TabIndex = 10;
            this.showCrown2.TabStop = false;
            // 
            // showCrown1
            // 
            this.showCrown1.BackColor = System.Drawing.Color.Transparent;
            this.showCrown1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showCrown1.Image = global::PacmanVS.Properties.Resources.queen_crown;
            this.showCrown1.Location = new System.Drawing.Point(264, 42);
            this.showCrown1.Margin = new System.Windows.Forms.Padding(2);
            this.showCrown1.Name = "showCrown1";
            this.showCrown1.Size = new System.Drawing.Size(100, 100);
            this.showCrown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showCrown1.TabIndex = 9;
            this.showCrown1.TabStop = false;
            // 
            // showLoser1
            // 
            this.showLoser1.Image = global::PacmanVS.Properties.Resources.frame_00_delay_0_01s;
            this.showLoser1.Location = new System.Drawing.Point(165, 259);
            this.showLoser1.Margin = new System.Windows.Forms.Padding(2);
            this.showLoser1.Name = "showLoser1";
            this.showLoser1.Size = new System.Drawing.Size(133, 133);
            this.showLoser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showLoser1.TabIndex = 8;
            this.showLoser1.TabStop = false;
            // 
            // showLoser2
            // 
            this.showLoser2.Image = global::PacmanVS.Properties.Resources.frame_00_delay_0_01s;
            this.showLoser2.Location = new System.Drawing.Point(640, 259);
            this.showLoser2.Margin = new System.Windows.Forms.Padding(2);
            this.showLoser2.Name = "showLoser2";
            this.showLoser2.Size = new System.Drawing.Size(133, 133);
            this.showLoser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showLoser2.TabIndex = 8;
            this.showLoser2.TabStop = false;
            // 
            // showWinner
            // 
            this.showWinner.Image = global::PacmanVS.Properties.Resources.frame_00_delay_0_01s;
            this.showWinner.Location = new System.Drawing.Point(303, 77);
            this.showWinner.Margin = new System.Windows.Forms.Padding(2);
            this.showWinner.Name = "showWinner";
            this.showWinner.Size = new System.Drawing.Size(333, 333);
            this.showWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showWinner.TabIndex = 8;
            this.showWinner.TabStop = false;
            // 
            // High_score
            // 
            this.High_score.AutoSize = true;
            this.High_score.BackColor = System.Drawing.SystemColors.ControlText;
            this.High_score.Cursor = System.Windows.Forms.Cursors.Default;
            this.High_score.Enabled = false;
            this.High_score.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.High_score.ForeColor = System.Drawing.Color.Gold;
            this.High_score.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.High_score.Location = new System.Drawing.Point(334, 22);
            this.High_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.High_score.Name = "High_score";
            this.High_score.Size = new System.Drawing.Size(287, 37);
            this.High_score.TabIndex = 7;
            this.High_score.Text = "!New HighScore!";
            this.High_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.High_score.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(951, 623);
            this.ControlBox = false;
            this.Controls.Add(this.showCrown2);
            this.Controls.Add(this.showCrown1);
            this.Controls.Add(this.showLoser1);
            this.Controls.Add(this.showLoser2);
            this.Controls.Add(this.showWinner);
            this.Controls.Add(this.High_score);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ResultConfirm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Result";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.showCrown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCrown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLoser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLoser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultConfirm;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.PictureBox showWinner;
        private System.Windows.Forms.PictureBox showLoser2;
        private System.Windows.Forms.PictureBox showLoser1;
        private System.Windows.Forms.PictureBox showCrown1;
        private System.Windows.Forms.PictureBox showCrown2;
        private System.Windows.Forms.Label High_score;
    }
}