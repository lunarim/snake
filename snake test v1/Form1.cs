using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace snake_test_v1
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        public Form1()
        {
            InitializeComponent();

            //set settings to default;
            new Settings();

            //set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //start new game
            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false;
            //set settings to default;
            new Settings();


            //create new player
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            actualscore.Text = Settings.Score.ToString();
            GenerateFood();

        }


        //place random food game
        private void GenerateFood()
        {
            int maxXPos = bananapaper1.Size.Width / Settings.Width;
            int maxYPos = bananapaper1.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };

        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //check for gameover
            if(Settings.GameOver)
            {
                //check if enter is pressed
                if(userinput.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (userinput.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (userinput.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (userinput.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;
                else if (userinput.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;

                MovePlayer();
            }

            bananapaper1.Invalidate();

        }

        private void score_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bananapaper1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                //set color of snake
                Brush snakeColour;

                //draw snake
                for(int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColour = Brushes.Black;  //draw head

                    }
                    else
                    {
                        snakeColour = Brushes.Green; // rest of body
                    }

                    //draw snake whole
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //draw food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));



                }
            }
            else
            {
                string gameOver = "Game Over \nYour final score is: " + Settings.Score + "\nPress Enter to try again";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }

        private void MovePlayer()
        {
            for(int i = Snake.Count -1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }

                    //collison - get maximum x and y pos
                    int maxXPos = bananapaper1.Size.Width / Settings.Width;
                    int maxYPos = bananapaper1.Size.Height / Settings.Height;

                    //detect collision with game borders
                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }

                    //detect dollision with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                            Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //detect collision with food
                    if(Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                }
                else
                {
                    //move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].X = Snake[i - 1].Y;

                }
            }
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void Eat()
        {
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);
            // update score
            Settings.Score += Settings.Points;
            actualscore.Text = Settings.Score.ToString();

            GenerateFood();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            userinput.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            userinput.ChangeState(e.KeyCode, false);

        }

        private void bananapaper1_Click(object sender, EventArgs e)
        {

        }
    }
}
