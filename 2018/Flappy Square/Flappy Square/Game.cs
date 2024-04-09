using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Square
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }


        //Variables 
        bool jumped,lost;//jump- to check if you jumped, lost - to check if you lose
        int[] speeds = { 5, 15, 3 }; //first speed - down speed: speed when not clicking, second speed - upspeed: speed when clicking, third speed - leftspeed : enemy speed


        //Finding New Location Variables
        Random randomizer = new Random();
        int[] toploc = {-467,-437, -420,-428,-339, -361,-310, -279,-260,-232,-201,-165,-125,-100,-57,-26,-8,-2};
        int[] botloc = {190, 220, 237,229,295, 296,347, 378,397,425,456,493,532,558,601,632,650,656};
        int arrangement;

        //Scoring
        double score = 0;
        bool inside,outside;


        //Settings
        private void Game_Load(object sender, EventArgs e)
        {
            //True that timers
            EnemyMov.Enabled = true;
            Movement.Enabled = true;
            LoseScoreMech.Enabled = true;
            gameover.Visible = false;

            //Function that calls the location of everything
            ElementLocations();
            NewLocation();
        }

        #region "All bout the character"
        //Move your player man!
        private void Movement_Tick(object sender, EventArgs e)
        {
            if (jumped)
            {
                Square.Top -= speeds[1];
            }
            else
            {
                if (Square.Top <= 0 || Square.Top >= 615)
                {
                    lost = true;
                }
                else
                {
                    Square.Top += speeds[0];
                }
            }




        }


        // if you press this button you jump
        private void Jumped(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                if (!lost)
                {
                    jumped = true;
                }
                else
                {
                    jumped = false;
                }
            }
        }

        //if not clicking anything
        private void Released(object sender, KeyEventArgs e)
        {
            jumped = false;
        }

        //If the player clicked the square
        private void Square_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi...","From Me");
        }

        private void MouseJump(object sender, MouseEventArgs e)
        {
                if (!lost)
                {
                    jumped = true;
                }
                else
                {
                    jumped = false;
                }
        }

        private void MouseRelease(object sender, MouseEventArgs e)
        {
            jumped = false;
        }
        #endregion

        #region "Enemy  man"
        private void EnemyMov_Tick(object sender, EventArgs e)
        {
            scoretext.Text = score.ToString();

            ObsTop.Left -= speeds[2];
            ObsBot.Left -= speeds[2];
            Scorer.Left -= speeds[2];

            if(ObsTop.Left < -100 & ObsBot.Left < -100 && Scorer.Left < -100)
            {
                NewLocation();
                score++;
            }
        }
        #endregion

        #region "Mechanics"
        private void LoseMech_Tick(object sender, EventArgs e)
        {
            scoretext.Text = score.ToString();

            if(ObsTop.Bounds.IntersectsWith(Square.Bounds) || ObsBot.Bounds.IntersectsWith(Square.Bounds))
            {
                lost = true;
            }
            if (lost)
            {
                Square.BackColor = Color.Maroon;
                gameover.Visible = true;
                EnemyMov.Enabled = false;
                Movement.Enabled = false;
                LoseScoreMech.Enabled = false;
                scoretext.Visible = false;

            }
            else
            {
                gameover.Visible = false;
            }
        }


        #endregion

        #region "My own functions"
        private void ElementLocations()
        {
            Square.Location = new Point(150,300); // Location of the square 
            Scorer.Location = new Point(600, 0);
        }


        private void NewLocation()
        {
            Scorer.Location = new Point(600, 0);
            arrangement = 5;

            switch (arrangement)
            {
                case 1:
                    ObsTop.Location = new Point(600, toploc[0]);
                    ObsBot.Location = new Point(600, botloc[0]);
                    break;
                case 2:
                    ObsTop.Location = new Point(600, toploc[1]);
                    ObsBot.Location = new Point(600, botloc[1]);
                    break;
                case 3:
                    ObsTop.Location = new Point(600, toploc[2]);
                    ObsBot.Location = new Point(600, botloc[2]);
                    break;
                case 4:
                    ObsTop.Location = new Point(600, toploc[3]);
                    ObsBot.Location = new Point(600, botloc[3]);
                    break;
                case 5:
                    ObsTop.Location = new Point(600, toploc[4]);
                    ObsBot.Location = new Point(600, botloc[4]);
                    break;
                case 6:
                    ObsTop.Location = new Point(600, toploc[5]);
                    ObsBot.Location = new Point(600, botloc[5]);
                    break;
                case 7:
                    ObsTop.Location = new Point(600, toploc[6]);
                    ObsBot.Location = new Point(600, botloc[6]);
                    break;
                case 8:
                    ObsTop.Location = new Point(600, toploc[7]);
                    ObsBot.Location = new Point(600, botloc[7]);
                    break;
                case 9:
                    ObsTop.Location = new Point(600, toploc[8]);
                    ObsBot.Location = new Point(600, botloc[8]);
                    break;
                case 10:
                    ObsTop.Location = new Point(600, toploc[9]);
                    ObsBot.Location = new Point(600, botloc[9]);
                    break;
                case 11:
                    ObsTop.Location = new Point(600, toploc[10]);
                    ObsBot.Location = new Point(600, botloc[10]);
                    break;
                case 12:
                    ObsTop.Location = new Point(600, toploc[11]);
                    ObsBot.Location = new Point(600, botloc[11]);
                    break;
                case 13:
                    ObsTop.Location = new Point(600, toploc[12]);
                    ObsBot.Location = new Point(600, botloc[12]);
                    break;
                case 14:
                    ObsTop.Location = new Point(600, toploc[13]);
                    ObsBot.Location = new Point(600, botloc[13]);
                    break;
                case 15:
                    ObsTop.Location = new Point(600, toploc[14]);
                    ObsBot.Location = new Point(600, botloc[14]);
                    break;
                case 16:
                    ObsTop.Location = new Point(600, toploc[15]);
                    ObsBot.Location = new Point(600, botloc[15]);
                    break;
                case 17:
                    ObsTop.Location = new Point(600, toploc[16]);
                    ObsBot.Location = new Point(600, botloc[16]);
                    break;
                case 18:
                    ObsTop.Location = new Point(600, toploc[17]);
                    ObsBot.Location = new Point(600, botloc[17]);
                    break;
            }
        }
        #endregion

        #region "Exit"

        private void restart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            Hide();
            game.ShowDialog();
            Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            Hide();
            menu.ShowDialog();
            Close();
        }

        #endregion
    }
}
