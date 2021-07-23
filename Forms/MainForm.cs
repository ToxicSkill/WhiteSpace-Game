using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WhiteSpaceNsp
{
    public partial class WhiteSpace : Form
    {
        SecondWindow secondWindow;
        Summary summary;

        //dimensions of window game
        public int windowHeight = 0,
            windowWidth = 0;

        //rocket picture dimensions
        public int rocketPictureHeight = 0, rocketPictureWidth = 0;

        //player (hit)points and rocket coordinates
        public int points = 0,
            shotsCount = 0,
            hitPoints = 0,
            rocketX = 0,
            rocketY = 0;

        //fuel supply
        public double fuel = 1e3;

        //table for stars
        public int[] tabStars = new int[6];

        //pictures of all stars and particles
        public List<PictureBox> allStars = new List<PictureBox>(),
            allParticles = new List<PictureBox>();

        //random machine
        public Random rnd;

        //discrete coordinates
        public List<Coordinates> coords = new List<Coordinates>();

        public WhiteSpace()
        {
            InitializeComponent();

            //start a game
            InitializeGame();
        }

        /// <summary>
        /// Game initialization
        /// </summary>
        private void InitializeGame()
        {
            //Initialization - pictur lists
            InitPictureLists();

            //initialization - random machine
            rnd = new Random();

            timerRocketMove.Tick += new EventHandler(Timer_Tick);

            //initialization - window dimensions
            windowHeight = Screen.PrimaryScreen.Bounds.Height;
            windowWidth = Screen.PrimaryScreen.Bounds.Width;

            //initialization - rocket dimensions
            rocketPictureHeight = rocketImage.Height;
            rocketPictureWidth = rocketImage.Width;


            //start value for progress bar
            progressBar1.Value = 10;

            //setting progress bar maximum value for better incrementation
            progressBar1.Maximum = progressBar1.Width;

            //settings parent dependency for transparent images
            rocketProgress.Parent = progressBar1;
        }


        /// <summary>
        /// Discrete values for particles coordinates 
        /// </summary>
        public struct Coordinates
        {
            //x and y of window
            public int X, Y;
        }

        /// <summary>
        /// Filling lists of pictureBox s
        /// </summary>
        private void InitPictureLists()
        {
            //adding all pictures of particles to the list
            allParticles.Add(particle1);
            allParticles.Add(particle2);
            allParticles.Add(particle3);
            allParticles.Add(particle4);
            allParticles.Add(particle5);
            allParticles.Add(particle6);
            allParticles.Add(particle7);


            //adding all pictures of stars to the list
            allStars.Add(pictureStar1);
            allStars.Add(pictureStar2);
            allStars.Add(pictureStar3);
            allStars.Add(pictureStar4);
            allStars.Add(pictureStar5);
            allStars.Add(pictureStar6);
        }


        /// <summary>
        /// filling list of discrete coordinates values 
        /// </summary>
        public void InitCoordinates()
        {
            //new single struct
            Coordinates singleCoords = new Coordinates();

            //two loops - generating coordinates values
            for (int i = 1; i < windowHeight / 100; ++i) // 1 -> 100 to not cover progress bar
            {
                for (int j = 2; j < BackgroundPicture.Width / 100; ++j) // 2 -> 200 to not cover rocket (to close)
                {
                    singleCoords.X = j * 100;
                    singleCoords.Y = i * 100;
                    coords.Add(singleCoords); // adding to list signle struct
                }
            }
        }

        /// <summary>
        /// Initializing particles properties
        /// </summary>
        public void InitParticles()
        {
            //setting timer interval and enabling it
            timerParticles.Interval = 10;
            timerParticles.Enabled = true;

            for (int i = 0; i < allParticles.Count; ++i)
            {
                //bringing to front for all particles
                allParticles[i].BringToFront();
                //setting parent for all particles
                allParticles[i].Parent = BackgroundPicture;
            }
        }

        /// <summary>
        /// Initializing stars properties
        /// </summary>
        public void InitStars()
        {
            //constant size converter
            double multiplyStar = 2;

            //object which are closer are bigger for us. That`s why changing size of stars
            for (int i = 0; i < allStars.Count; ++i)
            {
                //random value for speed of star
                tabStars[i] = rnd.Next(1, 10);
                //changing size of star in according to speed
                allStars[i].Height += (int)(tabStars[i] * multiplyStar);
                allStars[i].Width += (int)(tabStars[i] * multiplyStar);
                //setting parent...
                allStars[i].Parent = BackgroundPicture;
            }
        }

        /// <summary>
        /// Rocket move timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Timer_Tick(object sender, EventArgs e)
        {
            //Setting neutral position image for rocket (straight)
            rocketImage.Image = rocketNeutral.Image;
            //stopping timer
            timerRocketMove.Stop();
        }

        /// <summary>
        /// Laser shot timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerShot_Tick(object sender, EventArgs e)
        {
            //setting laser beam visible
            laserBeam.Visible = false;
            //stopping timer
            timerShot.Stop();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //changing active focus
            this.ActiveControl = null;

            if (buttonStart.Text == "START")
            {
                //initialization functions
                InitCoordinates();
                InitStars();
                InitParticles();

                //new tick for rocket move and start for all others tiemers
                timerStarsFlow.Start();
                time.Start();
                timerParticles.Start();

                //changing button text
                buttonStart.Text = "PAUSE";
            }
            else
            {
                //changing button text
                buttonStart.Text = "START";
                //Stop function
                Stop();
            }
        }

        /// <summary>
        /// Showing About window when button "ABOUT" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            //new window
            secondWindow = new SecondWindow();
            //showing it
            secondWindow.Show();
        }


        /// <summary>
        /// Stop function (timers freeze)
        /// </summary>
        /// <param name="reset"></param>
        private void Stop(bool reset = false) // default as false
        {
            //stopping all timers
            timerStarsFlow.Stop();
            time.Stop();
            timerParticles.Stop();


            //if reset argument is logical true
            if (reset)
            {
                //clear all values to default
                progressBar1.Value = 10;
                hitPoints = 0;
                shotsCount = 0;
                rocketProgress.Location = new Point(0, 0);//setting progres image to start possition
                points = 0;
                fuel = 1e3; // need 100%

                //labels-updating functions
                valueHit.Text = hitPoints.ToString();
                valueShots.Text = shotsCount.ToString();
                CheckSetPoints();
                CheckSetFuel();

                //change button text (now is stopped)
                buttonStart.Text = "START";

                //hide all particles
                for (int i = 0; i < allParticles.Count; ++i)
                    allParticles[i].Visible = false;
            }
        }


        /// <summary>
        /// Particle timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerParticle_Tick(object sender, EventArgs e)
        {
            //random choose for discrete particle location
            var indexCoords = rnd.Next(0, coords.Count);
            //random choose type of particle
            var indexParticle = rnd.Next(0, allParticles.Count);

            //setting choosen particle location
            allParticles[indexParticle].Location = new Point(coords[indexCoords].X, coords[indexCoords].Y);
            //setting visibility of  choosen particle
            allParticles[indexParticle].Visible = true;
            allParticles[indexParticle].BringToFront();
        }


        /// <summary>
        /// Checking keys pressed
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                //arrows and space (shot)
                case Keys.Up:
                case Keys.Down:
                case Keys.Space:
                    return true;
            }
            return base.IsInputKey(keyData);
        }


        /// <summary>
        /// Timer for setting stars flow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerStarsFlow_Tick(object sender, EventArgs e)
        {
            //loop for all stars
            for (int i = 0; i < allStars.Count; ++i)
            {
                //setting new loaction for each star
                allStars[i].Location = new Point(allStars[i].Location.X - tabStars[i], allStars[i].Location.Y);
                //sending star to start location after reaching -100 point on X axis
                if (allStars[i].Location.X < -100)
                    allStars[i].Location = new Point(BackgroundPicture.Width, allStars[i].Location.Y + rnd.Next(-200,200));//changing Y position
            }
        }


        /// <summary>
        /// Resources and rocket progress timer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Time_Tick(object sender, EventArgs e)
        {
            //setting rocket location (with progress bar)
            rocketProgress.Location = new Point(rocketProgress.Location.X + 3, rocketProgress.Location.Y);

            points--; // one less point - can`t win while doing nothing
            fuel -= 2; // less fuel

            //setting resources text informations
            CheckSetPoints();
            //setting and checking fuel
            CheckSetFuel();

            //increasing progress bar value till max
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value += 3; // by one
            //player won (more points than 0)
            else if (points > 0)
                ShowSummary(true);//show summary window
            else // player lose (less than 0 points)
                ShowSummary(false); // show summary window
        }

        /// <summary>
        /// Setting summary window values to pass
        /// </summary>
        /// <param name="win"></param>
        private void ShowSummary(bool win)
        {
            //computing hit ratio
            double hitRatio = (double)hitPoints / (double)shotsCount;
            hitRatio *= 100;//to percent
            //rounding hit ratio and setting precision to 2 after coma
            hitRatio = Math.Round(hitRatio, 2);
            summary = new Summary(win, points.ToString(), hitRatio.ToString()); // initialize new window         
            summary.Show();//show new window
            Stop(true);//stop the game and RESET
        }


        /// <summary>
        /// Setting and checking fuel
        /// </summary>
        private void CheckSetFuel()
        {
            //getting % value from fuel
            var percentFuel = (fuel / 1e3) * 100;
            //no way, cant be more than 100%
            if (percentFuel >= 100)
                percentFuel = 1e2;
            //setting label text
            valueFuel.Text = percentFuel.ToString() + " %";
            //checking if fuel is lower than 20 %
            if (percentFuel <= 20)
                valueFuel.ForeColor = Color.Red;//changing color
            else
                valueFuel.ForeColor = Color.LimeGreen;//changing color

            //player lose if no fuel left
            if (percentFuel <= 0)
                ShowSummary(false);//show window 
        }

        /// <summary>
        /// Setting and checking points
        /// </summary>
        private void CheckSetPoints()
        {
            //Setting label text
            valuePoints.Text = points.ToString();
            //checking if player has less than 0 points
            if (points < 0)
                valuePoints.ForeColor = Color.Red;
            //maybe more than 0
            else if (points > 0)
                valuePoints.ForeColor = Color.Brown;
        }


        /// <summary>
        /// When wanted keys are pressed
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            //get rocket coordinates
            rocketX = rocketImage.Location.X;
            rocketY = rocketImage.Location.Y;

            base.OnKeyDown(e);

            switch (e.KeyCode)
            {
                //when up key pressed
                case Keys.Up:
                    //setting rocket up image
                    rocketImage.Image = rocketUp.Image;
                    //moving rocket up
                    rocketImage.Location = new Point(rocketX, rocketY - 10);
                    //checking boundaries
                    if (rocketY > windowHeight)
                        //new location when Y more than height of window
                        rocketImage.Location = new Point(rocketX, 0 - rocketPictureHeight);
                    if (rocketY < 0 - rocketPictureHeight)
                        //new location when Y less than height of window
                        rocketImage.Location = new Point(rocketX, windowHeight);
                    //stopping timer
                    timerRocketMove.Stop();
                    break;
                //when down key pressed
                case Keys.Down:
                    //setting rocket down image
                    rocketImage.Image = rocketDown.Image;
                    //moving rocket down
                    rocketImage.Location = new Point(rocketX, rocketY + 10);
                    //checking boundaries
                    if (rocketY < 0 - rocketPictureHeight)
                        rocketImage.Location = new Point(rocketX, windowHeight);
                    if (rocketY > windowHeight)
                        rocketImage.Location = new Point(rocketX, 0 - rocketPictureHeight);
                    timerRocketMove.Stop();
                    break;
                //when space pressed
                case Keys.Space:
                    //new var for shot precision check
                    var checkShotLocationY = rocketImage.Location.Y + rocketImage.Height / 2 - laserBeam.Height / 2;
                    //setting new loaction of laser beam
                    laserBeam.Location = new Point(laserBeam.Location.X, checkShotLocationY);
                    //and displaying it
                    laserBeam.Visible = true;

                    for (int i = 0; i < allParticles.Count; ++i)
                    {
                        //checking if any particle was hit
                        if (checkShotLocationY < allParticles[i].Location.Y + 50 + 10 && checkShotLocationY > allParticles[i].Location.Y + 50 - 10)
                        {
                            if (i == 4 || i == 5) // if hit particles are red
                            {
                                //red particle is hit -> fuel lost
                                fuel--;
                                points -= 500; // and points also are lost
                            }
                            else // if not red
                                points += 200; // black or green -> new points for player
                            if (i == 6) //if green
                                fuel += 2;// add some fuel

                            hitPoints++;//hit(s) was made

                            //update hit label 
                            valueHit.Text = hitPoints.ToString();

                            //check if fuel is enough
                            CheckSetFuel();
                        }
                        //set points
                        CheckSetPoints();
                    }
                    //counting shots
                    shotsCount++;
                    //updating shots label
                    valueShots.Text = shotsCount.ToString();
                    //shot costs fuel
                    fuel--;
                    //update fuel
                    CheckSetFuel();
                    //sarting timer for laser beam
                    timerShot.Start();
                    break;
            }
            //starting rocket timer to start
            timerRocketMove.Start();
        }
    }
}
