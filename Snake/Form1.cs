using static Snake.Settings;

namespace Snake
{
    public partial class Form1 : Form
    {
        private int maxBombs = 10;
        private List<Cercle> Bombas = new List<Cercle>();
        private List<Cercle> Snake = new List<Cercle>();
        private Cercle food = new Cercle();
        private Cercle bomb = new Cercle();

        public Form1()
        {
            InitializeComponent();
            //Inicialitzem l'estat inicial
            new Settings();

            //Inicialitzem el timer
            gameTimer.Interval = 1200 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Start new game
            StartGame();

        }
        private void StartGame()
        {
            hardMode.Enabled = false;
            Settings.GameOver = false;
            gameOver.Visible = false;
            restart.Visible = false;
            //Settings a Default
            new Settings();

            //Creem un nou objecte jugador
            Snake.Clear();
            Bombas.Clear();
            Cercle head = new Cercle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            lblPuntos.Text = Settings.Score.ToString();
            GenerateFood();
        }
        private void GenerateFood()
        {
            //Creem menjar a una posició random
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;
            Random r = new Random();
            if (Settings.Score == 0)
            {
                food = new Cercle();
                food.X = r.Next(0, maxXPos);
                food.Y = r.Next(0, maxYPos);
            }
            else
            {
                food.X = r.Next(0, maxXPos);
                food.Y = r.Next(0, maxYPos);
            }
        }

        private void CreateBomb()
        {
            bool correct = false;
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;
            int posX = 0;
            int posY = 0;
            Random r = new Random();
            if (Settings.Score % 2 != 0 && Settings.Score > 5 && Bombas.Count() < maxBombs)
            {
                bomb = new Cercle();
                Bombas.Add(bomb);
                posX = r.Next(0, maxXPos);
                posY = r.Next(0, maxYPos);

                // Comprobar que no colocamos una bomba en la cabeza de la serpiente
                // Tambien comprueba que no coloquemos una bomba encima de la comida
                // Las bombas pueden tocar el cuerpo de la serpiente sin problema

                while (!correct)
                {
                    if (posX == Snake[0].X && posY == Snake[0].Y || posX == food.X && posY == food.Y)
                    {
                        posX = r.Next(0, maxXPos);
                        posY = r.Next(0, maxYPos);
                    }
                    else
                    {
                        bomb.X = posX;
                        bomb.Y = posY;
                        correct = !correct;
                    }
                }
                if (Bombas.Count() == maxBombs && Score % 5 == 0)
                {
                    for (int i = 0; i < Bombas.Count(); i++)
                    {
                        Bombas[i].X = r.Next(0, maxXPos);
                        Bombas[i].Y = r.Next(0, maxYPos);
                    }
                }
            }
        }
        private void UpdateScreen(Object sender, EventArgs e)
        {
            if (Input.KeyPressed(Keys.Escape))
            {
                Settings.GameOver = true;
            }
            //mirem si el joc ha acabat
            if (Settings.GameOver)
            {
                hardMode.Enabled = true;
                //Mirem si apretem l'Enter
                if (Input.KeyPressed(Keys.Enter))
                {
                    //Tornem a jugar
                    StartGame();
                }
            }
            else//Mirem quin moviment fem
            {
                lblPuntos.Text = Settings.Score.ToString();
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }
            pbCanvas.Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                //Pintem la serp
                for (int i = 0; i < Snake.Count; i++)
                {
                    //Assignem el color de la serp
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;
                    else if (i != 0 && Settings.Score < 7)
                        snakeColour = Brushes.Green;
                    else if (i != 0 && Settings.Score >= 7 && Settings.Score < 20)
                        snakeColour = Brushes.Blue;
                    else
                        snakeColour = Brushes.DarkViolet;

                    //Dibuixem cada boleta
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                        Snake[i].Y * Settings.Height,
                                        Settings.Width, Settings.Height));

                    //Dibuixem el menjar
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                                food.Y * Settings.Height, Settings.Width, Settings.Height));

                    // Dibujar todas las bombas
                    for (int j = 0; j < Bombas.Count(); j++)
                    {
                        canvas.FillEllipse(Brushes.Black,
                        new Rectangle(Bombas[j].X * Settings.Width,
                        Bombas[j].Y * Settings.Height, Settings.Width, Settings.Height));
                    }

                }
            }
            else
            {
                gameOver.Visible = true;
                restart.Visible = true;
            }
        }
        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move head
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
                    if (Snake[i].X > (pbCanvas.Size.Width / Settings.Width) || Snake[i].X < 0 || Snake[i].Y > (pbCanvas.Size.Height / Settings.Height) || Snake[i].Y < 0)
                    {
                        Settings.GameOver = true;
                    }
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        GenerateFood();
                        Settings.Score++;
                        CreateBomb();
                        Cercle body = new Cercle();
                        Snake.Add(body);
                    }
                }
                else
                {
                    //Move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            for (int j = 3; j < Snake.Count - 1; j++)
            {
                if (Snake[j].X == Snake[0].X && Snake[j].Y == Snake[0].Y)
                {
                    Settings.GameOver = true;
                }
            }
            for (int j = 0; j < Bombas.Count; j++)
            {
                if (Bombas[j].X == Snake[0].X && Bombas[j].Y == Snake[0].Y)
                {
                    Settings.GameOver = true;
                }
            }
        }
        private void Hard_click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
        private void pbCanvas_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hardMode.Checked)
            {
                gameTimer.Interval = 50;
                maxBombs = 20;
            }
            else
            {
                gameTimer.Interval = 100;
                maxBombs = 10;
            }
            hardMode.Enabled = false;
        }
    }
}
