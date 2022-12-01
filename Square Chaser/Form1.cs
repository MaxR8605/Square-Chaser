using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Square_Chaser
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(20, 0, 30, 30);
        Rectangle player2 = new Rectangle(20, 0, 30, 30);
        Rectangle pointsquare = new Rectangle(0, 0, 20, 20);
        Rectangle speedsquare = new Rectangle(0, 0, 20, 20);
        Rectangle sizesquare = new Rectangle(0, 0, 20, 20);
        Rectangle strengthsquare = new Rectangle(0, 0, 20, 20);

        int player1Score = 0;
        int player2Score = 0;
        int maxScore;

        int p1XSpeed = 0;
        int p1YSpeed = 0;
        int p2XSpeed = 0;
        int p2YSpeed = 0;
        int p1MaxSpeed = 4;
        int p2MaxSpeed = 4;

        int p1Strength = 2;
        int p2Strength = 2;

        int helpTimer = 0;

        int wallCollision = 1;

        Random random = new Random();

        bool aDown = false;
        bool dDown = false;
        bool wDown = false;
        bool sDown = false;
        bool leftDown = false;
        bool rightDown = false;
        bool upDown = false;
        bool downDown = false;

        bool help = false;

        Pen p1pen = new Pen(Color.DarkMagenta, 3);
        Pen p2pen = new Pen(Color.Teal, 3);
        SolidBrush p1brush = new SolidBrush(Color.Magenta);
        SolidBrush p2brush = new SolidBrush(Color.Aqua);
        SolidBrush point = new SolidBrush(Color.White);
        SolidBrush speed = new SolidBrush(Color.Orange);
        SolidBrush size = new SolidBrush(Color.Blue);
        SolidBrush strength = new SolidBrush(Color.LimeGreen);

        SoundPlayer pointSound = new SoundPlayer(Properties.Resources.points);
        SoundPlayer speedSound = new SoundPlayer(Properties.Resources.speed);
        SoundPlayer sizeSound = new SoundPlayer(Properties.Resources.size);
        SoundPlayer strengthSound = new SoundPlayer(Properties.Resources.strength);

        public Form1()
        {
            InitializeComponent();

            // Set locations

            player1.X = 20;
            player1.Y = (this.Height / 2) - player1.Height / 2;

            player2.X = this.Width - 20 - player1.Width;
            player2.Y = (this.Height / 2) - player2.Height / 2;

            pointsquare.X = this.Width / 2 - 15;
            pointsquare.Y = random.Next(0, this.Height);

            speedsquare.X = this.Width / 2 - 15;
            speedsquare.Y = random.Next(0, this.Height);

            sizesquare.X = this.Width / 2 - 15;
            sizesquare.Y = random.Next(0, this.Height);

            strengthsquare.X = this.Width / 2 - 15;
            strengthsquare.Y = random.Next(0, this.Height);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Up:
                    upDown = true;
                    break;
                case Keys.Down:
                    downDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Up:
                    upDown = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(size, sizesquare);
            e.Graphics.FillRectangle(speed, speedsquare);
            e.Graphics.FillRectangle(point, pointsquare);
            e.Graphics.FillRectangle(strength, strengthsquare);
            
            e.Graphics.FillRectangle(p1brush, player1);
            e.Graphics.DrawRectangle(p1pen, player1);

            e.Graphics.FillRectangle(p2brush, player2);
            e.Graphics.DrawRectangle(p2pen, player2);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (player1Score < maxScore && player2Score < maxScore)
            {
                // Move P1

                if (aDown == true)
                {
                    if (p1XSpeed > -p1MaxSpeed)
                    {
                        p1XSpeed--;
                    }
                }
                else if (p1XSpeed < 0 && dDown == false)
                {
                    p1XSpeed++;
                }

                if (dDown == true)
                {
                    if (p1XSpeed < p1MaxSpeed)
                    {
                        p1XSpeed++;
                    }
                }
                else if (p1XSpeed > 0 && aDown == false)
                {
                    p1XSpeed--;
                }

                if (wDown == true)
                {
                    if (p1YSpeed > -p1MaxSpeed)
                    {
                        p1YSpeed--;
                    }
                }
                else if (p1YSpeed < 0 && sDown == false)
                {
                    p1YSpeed++;
                }

                if (sDown == true)
                {
                    if (p1YSpeed < p1MaxSpeed)
                    {
                        p1YSpeed++;
                    }
                }
                else if (p1YSpeed > 0 && wDown == false)
                {
                    p1YSpeed--;
                }

                // P1 moves. It is coded to move a step at a time to prevent glitchy collisions.

                if (p1XSpeed > 0)
                {
                    for (int i = 0; i < p1XSpeed; i++)
                    {
                        player1.X += 1;
                        CheckCollisions();
                    }
                }
                else if (p1XSpeed < 0)
                {
                    for (int i = 0; i < -p1XSpeed; i++)
                    {
                        player1.X -= 1;
                        CheckCollisions();
                    }
                }

                if (p1YSpeed > 0)
                {
                    for (int i = 0; i < p1YSpeed; i++)
                    {
                        player1.Y += 1;
                        CheckCollisions();
                    }
                }
                else if (p1YSpeed < 0)
                {
                    for (int i = 0; i < -p1YSpeed; i++)
                    {
                        player1.Y -= 1;
                        CheckCollisions();
                    }
                }

                // Check P1 collision with wall

                if (player1.X > this.Width - player1.Width)
                {
                    if (wallCollision != 3)
                    {
                        player1.X = this.Width - player1.Width;

                        if (wallCollision == 2)
                        {
                            p1XSpeed = -p1XSpeed;
                        }
                        else
                        {
                            p1XSpeed = 0;
                        }
                    }
                    else
                    {
                        player1.X = 0;
                    }
                }
                else if (player1.X < 0)
                {
                    if (wallCollision != 3)
                    {
                        player1.X = 0;

                        if (wallCollision == 2)
                        {
                            p1XSpeed = -p1XSpeed;
                        }
                        else
                        {
                            p1XSpeed = 0;
                        }
                    }
                    else
                    {
                        player1.X = this.Width - player1.Width;
                    }
                }

                if (player1.Y > this.Height - player1.Height)
                {
                    if (wallCollision != 3)
                    {
                        player1.Y = this.Height - player1.Height;

                        if (wallCollision == 2)
                        {
                            p1YSpeed = -p1YSpeed;
                        }
                        else
                        {
                            p1YSpeed = 0;
                        }
                    }
                    else
                    {
                        player1.Y = 0;
                    }
                }
                else if (player1.Y < 0)
                {
                    if (wallCollision != 3)
                    {
                        player1.Y = 0;

                        if (wallCollision == 2)
                        {
                            p1YSpeed = -p1YSpeed;
                        }
                        else
                        {
                            p1YSpeed = 0;
                        }
                    }
                    else
                    {
                        player1.Y = this.Height - player1.Height;
                    }
                }

                // Move P2

                if (leftDown == true)
                {
                    if (p2XSpeed > -p2MaxSpeed)
                    {
                        p2XSpeed--;
                    }
                }
                else if (p2XSpeed < 0 && rightDown == false)
                {
                    p2XSpeed++;
                }

                if (rightDown == true)
                {
                    if (p2XSpeed < p2MaxSpeed)
                    {
                        p2XSpeed++;
                    }
                }
                else if (p2XSpeed > 0 && leftDown == false)
                {
                    p2XSpeed--;
                }

                if (upDown == true)
                {
                    if (p2YSpeed > -p2MaxSpeed)
                    {
                        p2YSpeed--;
                    }
                }
                else if (p2YSpeed < 0 && downDown == false)
                {
                    p2YSpeed++;
                }

                if (downDown == true)
                {
                    if (p2YSpeed < p2MaxSpeed)
                    {
                        p2YSpeed++;
                    }
                }
                else if (p2YSpeed > 0 && upDown == false)
                {
                    p2YSpeed--;
                }
                
                // P2 moves. It is coded to move a step at a time to prevent glitchy collisions.

                if (p2XSpeed > 0)
                {
                    for (int i = 0; i < p2XSpeed; i++)
                    {
                        player2.X += 1;
                        CheckCollisions();
                    }
                }
                else if (p2XSpeed < 0)
                {
                    for (int i = 0; i < -p2XSpeed; i++)
                    {
                        player2.X -= 1;
                        CheckCollisions();
                    }
                }

                if (p2YSpeed > 0)
                {
                    for (int i = 0; i < p2YSpeed; i++)
                    {
                        player2.Y += 1;
                        CheckCollisions();
                    }
                }
                else if (p2YSpeed < 0)
                {
                    for (int i = 0; i < -p2YSpeed; i++)
                    {
                        player2.Y -= 1;
                        CheckCollisions();
                    }
                }

                // Check P2 collision with wall

                if (player2.X > this.Width - player2.Width)
                {
                    if (wallCollision != 3)
                    {
                        player2.X = this.Width - player2.Width;

                        if (wallCollision == 2)
                        {
                            p2XSpeed = -p2XSpeed;
                        }
                        else
                        {
                            p2XSpeed = 0;
                        }
                    }
                    else
                    {
                        player2.X = 0;
                    }
                }
                else if (player2.X < 0)
                {
                    if (wallCollision != 3)
                    {
                        player2.X = 0;

                        if (wallCollision == 2)
                        {
                            p2XSpeed = -p2XSpeed;
                        }
                        else
                        {
                            p2XSpeed = 0;
                        }
                    }
                    else
                    {
                        player2.X = this.Width - player2.Width;
                    }
                }

                if (player2.Y > this.Height - player2.Height)
                {
                    if (wallCollision != 3)
                    {
                        player2.Y = this.Height - player2.Height;

                        if (wallCollision == 2)
                        {
                            p2YSpeed = -p2YSpeed;
                        }
                        else
                        {
                            p2YSpeed = 0;
                        }
                    }
                    else
                    {
                        player2.Y = 0;
                    }
                }
                else if (player2.Y < 0)
                {
                    if (wallCollision != 3)
                    {
                        player2.Y = 0;

                        if (wallCollision == 2)
                        {
                            p2YSpeed = -p2YSpeed;
                        }
                        else
                        {
                            p2YSpeed = 0;
                        }
                    }
                    else
                    {
                        player2.Y = this.Height - player2.Height;
                    }
                }

                // Check if either player collects the squares

                /// Point square

                if (player1.IntersectsWith(pointsquare))
                {
                    pointsquare.X = random.Next(0, this.Width - 30);
                    pointsquare.Y = random.Next(0, this.Height - 30);

                    player1Score++;
                    p1ScoreLabel.Text = player1Score.ToString();

                    pointSound.Play();
                }
                else if (player2.IntersectsWith(pointsquare))
                {
                    pointsquare.X = random.Next(0, this.Width - 30);
                    pointsquare.Y = random.Next(0, this.Height - 30);

                    player2Score++;
                    p2ScoreLabel.Text = player2Score.ToString();

                    pointSound.Play();
                }

                /// Speed square

                if (player1.IntersectsWith(speedsquare))
                {
                    speedsquare.X = random.Next(0, this.Width - 30);
                    speedsquare.Y = random.Next(0, this.Height - 30);

                    p1MaxSpeed++;

                    speedSound.Play();
                }
                else if (player2.IntersectsWith(speedsquare))
                {
                    speedsquare.X = random.Next(0, this.Width - 30);
                    speedsquare.Y = random.Next(0, this.Height - 30);

                    p2MaxSpeed++;

                    speedSound.Play();
                }

                /// Size square

                if (player1.IntersectsWith(sizesquare))
                {
                    sizesquare.X = random.Next(0, this.Width - 30);
                    sizesquare.Y = random.Next(0, this.Height - 30);

                    player1.Width += 3;
                    player1.Height += 3;

                    sizeSound.Play();
                }
                else if (player2.IntersectsWith(sizesquare))
                {
                    sizesquare.X = random.Next(0, this.Width - 30);
                    sizesquare.Y = random.Next(0, this.Height - 30);

                    player2.Width += 3;
                    player2.Height += 3;

                    sizeSound.Play();
                }

                /// Strength square

                if (player1.IntersectsWith(strengthsquare))
                {
                    strengthsquare.X = random.Next(0, this.Width - 30);
                    strengthsquare.Y = random.Next(0, this.Height - 30);

                    p1Strength++;

                    strengthSound.Play();
                }
                else if (player2.IntersectsWith(strengthsquare))
                {
                    strengthsquare.X = random.Next(0, this.Width - 30);
                    strengthsquare.Y = random.Next(0, this.Height - 30);

                    p2Strength++;

                    strengthSound.Play();
                }
            }
            else if (player1Score >= maxScore)
            {
                winLabel.ForeColor = Color.Magenta;
                winLabel.Visible = true;
                winLabel.Text = "Player One wins!";
            }
            else if (player2Score >= maxScore)
            {
                winLabel.ForeColor = Color.Aqua;
                winLabel.Visible = true;
                winLabel.Text = "Player Two wins!";
            }

            if (helpTimer > 0)
            {
                helpTimer++;
                
                switch (helpTimer)
                {
                    case 2:
                        helpLabel1.Visible = true;
                        break;
                    case 4:
                        helpLabel2.Visible = true;
                        break;
                    case 6:
                        helpLabel3.Visible = true;
                        break;
                    case 8:
                        helpLabel4.Visible = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                helpLabel1.Visible = false;
                helpLabel2.Visible = false;
                helpLabel3.Visible = false;
                helpLabel4.Visible = false;
            }

            Refresh();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(maxPointsInput.Text) > 0)
                {
                    maxScore = Convert.ToInt16(maxPointsInput.Text);
                    startLabel.Visible = false;
                    maxPointsInput.Visible = false;
                    maxPointsInput.Enabled = false;
                    startButton.Visible = false;
                    helpButton.Visible = true;
                    wallCollisionLabel.Visible = false;
                    wallCollisionInput.Visible = false;
                    wallCollisionInput.Enabled = false;

                    if (wallCollisionInput.Text == "1" || wallCollisionInput.Text == "2" || wallCollisionInput.Text == "3")
                    {
                        wallCollision = Convert.ToInt16(wallCollisionInput.Text);
                    }
                    else
                    {
                        wallCollisionInput.Text = "1";
                        wallCollision = 1;
                    }

                    gameTimer.Enabled = true;
                }
                else
                {
                    maxPointsInput.Text = null;
                    for (int i = 0; i < 5; i++)
                    {
                        maxPointsInput.BackColor = Color.Tomato;
                        Refresh();
                        Thread.Sleep(50);
                        maxPointsInput.BackColor = Color.White;
                        Refresh();
                        Thread.Sleep(50);
                    }
                }
            }
            catch
            {
                maxPointsInput.Text = null;
                for (int i = 0; i < 5; i++)
                {
                    maxPointsInput.BackColor = Color.Tomato;
                    Refresh();
                    Thread.Sleep(50);
                    maxPointsInput.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(50);
                }
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            winLabel.Text = null;
            winLabel.Visible = false;
            startLabel.Visible = true;
            maxPointsInput.Visible = true;
            maxPointsInput.Enabled = true;
            startButton.Visible = true;
            wallCollisionLabel.Visible = true;
            wallCollisionInput.Visible = true;
            wallCollisionInput.Enabled = true;
            helpButton.Visible = false;
            help = false;
            helpTimer = 0;
            helpButton.BackColor = Color.White;

            helpLabel1.Visible = false;
            helpLabel2.Visible = false;
            helpLabel3.Visible = false;
            helpLabel4.Visible = false;

            player1Score = 0;
            player2Score = 0;

            p1ScoreLabel.Text = "0";
            p2ScoreLabel.Text = "0";

            gameTimer.Enabled = false;

            p1XSpeed = 0;
            p1YSpeed = 0;
            p2XSpeed = 0;
            p2YSpeed = 0;
            p1MaxSpeed = 4;
            p2MaxSpeed = 4;

            p1Strength = 2;
            p2Strength = 2;

            player1.X = 20;
            player1.Y = (this.Height / 2) - player1.Height / 2;

            player2.X = this.Width - 20 - player1.Width;
            player2.Y = (this.Height / 2) - player2.Height / 2;

            pointsquare.X = this.Width / 2 - 15;
            pointsquare.Y = random.Next(0, this.Height);

            speedsquare.X = this.Width / 2 - 15;
            speedsquare.Y = random.Next(0, this.Height);

            sizesquare.X = this.Width / 2 - 15;
            sizesquare.Y = random.Next(0, this.Height);

            strengthsquare.X = this.Width / 2 - 15;
            strengthsquare.Y = random.Next(0, this.Height);

            player1.Width = 30;
            player1.Height = 30;
            player2.Width = 30;
            player2.Height = 30;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CheckCollisions()
        {
            // Check if players run into each other

            /// Option 1

            if (player1.IntersectsWith(player2))
            {
                if (player1.X > (player2.X + player2.Width - 10))
                {
                    p1XSpeed = p2Strength;
                    p2XSpeed = -p1Strength;
                }
                else if (player2.X > (player1.X + player1.Width - 10))
                {
                    p1XSpeed = -p2Strength;
                    p2XSpeed = p1Strength;
                }
                if (player1.Y > (player2.Y + player2.Height - 10))
                {
                    p1YSpeed = p2Strength;
                    p2YSpeed = -p1Strength;
                }
                else if (player2.Y > (player1.Y + player1.Height - 10))
                {
                    p1YSpeed = -p2Strength;
                    p2YSpeed = p1Strength;
                }
            }

            /// Option 2

            //if (player1.IntersectsWith(player2))
            //{
            //    if (player1.X > (player2.X + player2.Width - 10))
            //    {
            //        player1.X += p2Strength;
            //        player2.X -= p1Strength;
            //    }
            //    else if (player2.X > (player1.X + player1.Width - 10))
            //    {
            //        player1.X -= p2Strength;
            //        player2.X += p1Strength;
            //    }
            //    if (player1.Y > (player2.Y + player2.Height - 10))
            //    {
            //        player1.Y += p2Strength;
            //        player2.Y -= p1Strength;
            //    }
            //    else if (player2.Y > (player1.Y + player1.Height - 10))
            //    {
            //        player1.Y -= p2Strength;
            //        player2.Y += p1Strength;
            //    }
            //}
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            if (help == false)
            {
                help = true;
                helpButton.BackColor = Color.Silver;
                helpTimer = 1;
            }
            else
            {
                help = false;
                helpButton.BackColor = Color.White;
                helpTimer = 0;
            }
        }
    }
}
