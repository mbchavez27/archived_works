namespace Flappy_Square
{
    partial class Game
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
            this.Square = new System.Windows.Forms.PictureBox();
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.EnemyMov = new System.Windows.Forms.Timer(this.components);
            this.LoseScoreMech = new System.Windows.Forms.Timer(this.components);
            this.scoretext = new System.Windows.Forms.Label();
            this.ObsTop = new System.Windows.Forms.PictureBox();
            this.ObsBot = new System.Windows.Forms.PictureBox();
            this.Scorer = new System.Windows.Forms.PictureBox();
            this.gameover = new System.Windows.Forms.Panel();
            this.restart = new System.Windows.Forms.PictureBox();
            this.gameovertext = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObsTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObsBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scorer)).BeginInit();
            this.gameover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.Color.Olive;
            this.Square.Location = new System.Drawing.Point(150, 300);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(50, 50);
            this.Square.TabIndex = 0;
            this.Square.TabStop = false;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Movement
            // 
            this.Movement.Interval = 10;
            this.Movement.Tick += new System.EventHandler(this.Movement_Tick);
            // 
            // EnemyMov
            // 
            this.EnemyMov.Interval = 10;
            this.EnemyMov.Tick += new System.EventHandler(this.EnemyMov_Tick);
            // 
            // LoseScoreMech
            // 
            this.LoseScoreMech.Tick += new System.EventHandler(this.LoseMech_Tick);
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.Transparent;
            this.scoretext.Font = new System.Drawing.Font("Bebas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.ForeColor = System.Drawing.Color.Gray;
            this.scoretext.Location = new System.Drawing.Point(223, 52);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(71, 86);
            this.scoretext.TabIndex = 3;
            this.scoretext.Text = "0";
            this.scoretext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ObsTop
            // 
            this.ObsTop.BackColor = System.Drawing.Color.Teal;
            this.ObsTop.Location = new System.Drawing.Point(389, -339);
            this.ObsTop.Name = "ObsTop";
            this.ObsTop.Size = new System.Drawing.Size(100, 477);
            this.ObsTop.TabIndex = 6;
            this.ObsTop.TabStop = false;
            // 
            // ObsBot
            // 
            this.ObsBot.BackColor = System.Drawing.Color.Teal;
            this.ObsBot.Location = new System.Drawing.Point(389, 290);
            this.ObsBot.Name = "ObsBot";
            this.ObsBot.Size = new System.Drawing.Size(100, 470);
            this.ObsBot.TabIndex = 7;
            this.ObsBot.TabStop = false;
            // 
            // Scorer
            // 
            this.Scorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.Scorer.Location = new System.Drawing.Point(478, 0);
            this.Scorer.Name = "Scorer";
            this.Scorer.Size = new System.Drawing.Size(1, 700);
            this.Scorer.TabIndex = 8;
            this.Scorer.TabStop = false;
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.Color.Black;
            this.gameover.Controls.Add(this.exit);
            this.gameover.Controls.Add(this.gameovertext);
            this.gameover.Controls.Add(this.restart);
            this.gameover.Location = new System.Drawing.Point(83, 208);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(415, 239);
            this.gameover.TabIndex = 9;
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Maroon;
            this.restart.Location = new System.Drawing.Point(54, 141);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(100, 50);
            this.restart.TabIndex = 0;
            this.restart.TabStop = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // gameovertext
            // 
            this.gameovertext.AutoSize = true;
            this.gameovertext.BackColor = System.Drawing.Color.Transparent;
            this.gameovertext.Font = new System.Drawing.Font("Bebas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameovertext.ForeColor = System.Drawing.Color.Gray;
            this.gameovertext.Location = new System.Drawing.Point(39, 16);
            this.gameovertext.Name = "gameovertext";
            this.gameovertext.Size = new System.Drawing.Size(350, 86);
            this.gameovertext.TabIndex = 10;
            this.gameovertext.Text = "Game Over!";
            this.gameovertext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Teal;
            this.exit.Location = new System.Drawing.Point(272, 141);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 50);
            this.exit.TabIndex = 11;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.ObsBot);
            this.Controls.Add(this.ObsTop);
            this.Controls.Add(this.Scorer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Square";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jumped);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Released);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseJump);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseRelease);
            ((System.ComponentModel.ISupportInitialize)(this.Square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObsTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObsBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scorer)).EndInit();
            this.gameover.ResumeLayout(false);
            this.gameover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Square;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.Timer EnemyMov;
        private System.Windows.Forms.Timer LoseScoreMech;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.PictureBox ObsTop;
        private System.Windows.Forms.PictureBox ObsBot;
        private System.Windows.Forms.PictureBox Scorer;
        private System.Windows.Forms.Panel gameover;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label gameovertext;
        private System.Windows.Forms.PictureBox restart;
    }
}

