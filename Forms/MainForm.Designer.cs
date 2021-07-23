
namespace WhiteSpaceNsp
{
    partial class WhiteSpace
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
            this.timerRocketMove = new System.Windows.Forms.Timer(this.components);
            this.timerStarsFlow = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.valueShots = new System.Windows.Forms.Label();
            this.labelShots = new System.Windows.Forms.Label();
            this.valueHit = new System.Windows.Forms.Label();
            this.labelHit = new System.Windows.Forms.Label();
            this.valuePoints = new System.Windows.Forms.Label();
            this.valueFuel = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.timerParticles = new System.Windows.Forms.Timer(this.components);
            this.timerShot = new System.Windows.Forms.Timer(this.components);
            this.particle7 = new System.Windows.Forms.PictureBox();
            this.particle6 = new System.Windows.Forms.PictureBox();
            this.particle5 = new System.Windows.Forms.PictureBox();
            this.particle4 = new System.Windows.Forms.PictureBox();
            this.particle3 = new System.Windows.Forms.PictureBox();
            this.particle2 = new System.Windows.Forms.PictureBox();
            this.particle1 = new System.Windows.Forms.PictureBox();
            this.laserBeam = new System.Windows.Forms.PictureBox();
            this.rocketImage = new System.Windows.Forms.PictureBox();
            this.pictureStar6 = new System.Windows.Forms.PictureBox();
            this.pictureStar5 = new System.Windows.Forms.PictureBox();
            this.rocketProgress = new System.Windows.Forms.PictureBox();
            this.pictureStar4 = new System.Windows.Forms.PictureBox();
            this.pictureStar3 = new System.Windows.Forms.PictureBox();
            this.pictureStar2 = new System.Windows.Forms.PictureBox();
            this.pictureStar1 = new System.Windows.Forms.PictureBox();
            this.rocketNeutral = new System.Windows.Forms.PictureBox();
            this.rocketDown = new System.Windows.Forms.PictureBox();
            this.rocketUp = new System.Windows.Forms.PictureBox();
            this.BackgroundPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.particle7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserBeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketNeutral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRocketMove
            // 
            this.timerRocketMove.Interval = 20;
            // 
            // timerStarsFlow
            // 
            this.timerStarsFlow.Tick += new System.EventHandler(this.TimerStarsFlow_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.buttonAbout);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.valueShots);
            this.panel1.Controls.Add(this.labelShots);
            this.panel1.Controls.Add(this.valueHit);
            this.panel1.Controls.Add(this.labelHit);
            this.panel1.Controls.Add(this.valuePoints);
            this.panel1.Controls.Add(this.valueFuel);
            this.panel1.Controls.Add(this.labelFuel);
            this.panel1.Controls.Add(this.labelPoints);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 1017);
            this.panel1.TabIndex = 9;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(0, 953);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(148, 64);
            this.buttonAbout.TabIndex = 20;
            this.buttonAbout.TabStop = false;
            this.buttonAbout.Text = "ABOUT";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(0, 867);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(148, 64);
            this.buttonStart.TabIndex = 19;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // valueShots
            // 
            this.valueShots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueShots.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueShots.ForeColor = System.Drawing.Color.Brown;
            this.valueShots.Location = new System.Drawing.Point(15, 742);
            this.valueShots.Name = "valueShots";
            this.valueShots.Size = new System.Drawing.Size(123, 35);
            this.valueShots.TabIndex = 18;
            this.valueShots.Text = "0";
            this.valueShots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShots
            // 
            this.labelShots.AutoSize = true;
            this.labelShots.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShots.Location = new System.Drawing.Point(15, 707);
            this.labelShots.Name = "labelShots";
            this.labelShots.Size = new System.Drawing.Size(110, 35);
            this.labelShots.TabIndex = 17;
            this.labelShots.Text = "Shots";
            // 
            // valueHit
            // 
            this.valueHit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueHit.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueHit.ForeColor = System.Drawing.Color.Brown;
            this.valueHit.Location = new System.Drawing.Point(15, 584);
            this.valueHit.Name = "valueHit";
            this.valueHit.Size = new System.Drawing.Size(123, 35);
            this.valueHit.TabIndex = 16;
            this.valueHit.Text = "0";
            this.valueHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHit
            // 
            this.labelHit.AutoSize = true;
            this.labelHit.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHit.Location = new System.Drawing.Point(29, 549);
            this.labelHit.Name = "labelHit";
            this.labelHit.Size = new System.Drawing.Size(91, 35);
            this.labelHit.TabIndex = 15;
            this.labelHit.Text = "Hits";
            // 
            // valuePoints
            // 
            this.valuePoints.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuePoints.ForeColor = System.Drawing.Color.Brown;
            this.valuePoints.Location = new System.Drawing.Point(15, 219);
            this.valuePoints.Name = "valuePoints";
            this.valuePoints.Size = new System.Drawing.Size(123, 30);
            this.valuePoints.TabIndex = 14;
            this.valuePoints.Text = "0";
            this.valuePoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueFuel
            // 
            this.valueFuel.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueFuel.ForeColor = System.Drawing.Color.LimeGreen;
            this.valueFuel.Location = new System.Drawing.Point(15, 396);
            this.valueFuel.Name = "valueFuel";
            this.valueFuel.Size = new System.Drawing.Size(123, 42);
            this.valueFuel.TabIndex = 13;
            this.valueFuel.Text = "100 %";
            this.valueFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuel.Location = new System.Drawing.Point(29, 361);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(91, 35);
            this.labelFuel.TabIndex = 12;
            this.labelFuel.Text = "Fuel";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(9, 184);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(129, 35);
            this.labelPoints.TabIndex = 10;
            this.labelPoints.Text = "Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.Location = new System.Drawing.Point(649, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1120, 24);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 1;
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // timerParticles
            // 
            this.timerParticles.Interval = 500;
            this.timerParticles.Tick += new System.EventHandler(this.TimerParticle_Tick);
            // 
            // timerShot
            // 
            this.timerShot.Interval = 20;
            this.timerShot.Tick += new System.EventHandler(this.TimerShot_Tick);
            // 
            // particle7
            // 
            this.particle7.BackColor = System.Drawing.Color.Transparent;
            this.particle7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.particle7.Image = global::WhiteSpaceNsp.Properties.Resources.Particle7;
            this.particle7.Location = new System.Drawing.Point(1574, 161);
            this.particle7.Name = "particle7";
            this.particle7.Size = new System.Drawing.Size(100, 100);
            this.particle7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.particle7.TabIndex = 21;
            this.particle7.TabStop = false;
            this.particle7.Visible = false;
            // 
            // particle6
            // 
            this.particle6.BackColor = System.Drawing.Color.Transparent;
            this.particle6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.particle6.Image = global::WhiteSpaceNsp.Properties.Resources.Particle6;
            this.particle6.Location = new System.Drawing.Point(1574, 373);
            this.particle6.Name = "particle6";
            this.particle6.Size = new System.Drawing.Size(100, 100);
            this.particle6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.particle6.TabIndex = 20;
            this.particle6.TabStop = false;
            this.particle6.Visible = false;
            // 
            // particle5
            // 
            this.particle5.BackColor = System.Drawing.Color.Transparent;
            this.particle5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.particle5.Image = global::WhiteSpaceNsp.Properties.Resources.Particle5;
            this.particle5.Location = new System.Drawing.Point(1574, 267);
            this.particle5.Name = "particle5";
            this.particle5.Size = new System.Drawing.Size(100, 100);
            this.particle5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.particle5.TabIndex = 19;
            this.particle5.TabStop = false;
            this.particle5.Visible = false;
            // 
            // particle4
            // 
            this.particle4.BackColor = System.Drawing.Color.Transparent;
            this.particle4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.particle4.Image = global::WhiteSpaceNsp.Properties.Resources.Particle4;
            this.particle4.Location = new System.Drawing.Point(1792, 373);
            this.particle4.Name = "particle4";
            this.particle4.Size = new System.Drawing.Size(100, 100);
            this.particle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.particle4.TabIndex = 18;
            this.particle4.TabStop = false;
            this.particle4.Visible = false;
            // 
            // particle3
            // 
            this.particle3.BackColor = System.Drawing.Color.Transparent;
            this.particle3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.particle3.Image = global::WhiteSpaceNsp.Properties.Resources.Particle3;
            this.particle3.Location = new System.Drawing.Point(1786, 267);
            this.particle3.Name = "particle3";
            this.particle3.Size = new System.Drawing.Size(100, 100);
            this.particle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.particle3.TabIndex = 17;
            this.particle3.TabStop = false;
            this.particle3.Visible = false;
            // 
            // particle2
            // 
            this.particle2.BackColor = System.Drawing.Color.Transparent;
            this.particle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.particle2.Image = global::WhiteSpaceNsp.Properties.Resources.Particle2;
            this.particle2.Location = new System.Drawing.Point(1680, 373);
            this.particle2.Name = "particle2";
            this.particle2.Size = new System.Drawing.Size(100, 100);
            this.particle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.particle2.TabIndex = 16;
            this.particle2.TabStop = false;
            this.particle2.Visible = false;
            // 
            // particle1
            // 
            this.particle1.BackColor = System.Drawing.Color.Transparent;
            this.particle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.particle1.Image = global::WhiteSpaceNsp.Properties.Resources.Particle1;
            this.particle1.Location = new System.Drawing.Point(1680, 267);
            this.particle1.Name = "particle1";
            this.particle1.Size = new System.Drawing.Size(100, 100);
            this.particle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.particle1.TabIndex = 15;
            this.particle1.TabStop = false;
            this.particle1.Visible = false;
            // 
            // laserBeam
            // 
            this.laserBeam.BackColor = System.Drawing.Color.Transparent;
            this.laserBeam.Image = global::WhiteSpaceNsp.Properties.Resources.LaserBeam;
            this.laserBeam.Location = new System.Drawing.Point(560, 89);
            this.laserBeam.Name = "laserBeam";
            this.laserBeam.Size = new System.Drawing.Size(1930, 20);
            this.laserBeam.TabIndex = 14;
            this.laserBeam.TabStop = false;
            this.laserBeam.Visible = false;
            // 
            // rocketImage
            // 
            this.rocketImage.Image = global::WhiteSpaceNsp.Properties.Resources.Rocket;
            this.rocketImage.Location = new System.Drawing.Point(166, 12);
            this.rocketImage.Name = "rocketImage";
            this.rocketImage.Size = new System.Drawing.Size(418, 176);
            this.rocketImage.TabIndex = 0;
            this.rocketImage.TabStop = false;
            // 
            // pictureStar6
            // 
            this.pictureStar6.BackColor = System.Drawing.Color.Transparent;
            this.pictureStar6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureStar6.Image = global::WhiteSpaceNsp.Properties.Resources.Star;
            this.pictureStar6.Location = new System.Drawing.Point(1779, 536);
            this.pictureStar6.Name = "pictureStar6";
            this.pictureStar6.Size = new System.Drawing.Size(50, 50);
            this.pictureStar6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStar6.TabIndex = 13;
            this.pictureStar6.TabStop = false;
            // 
            // pictureStar5
            // 
            this.pictureStar5.BackColor = System.Drawing.Color.Transparent;
            this.pictureStar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureStar5.Image = global::WhiteSpaceNsp.Properties.Resources.Star;
            this.pictureStar5.Location = new System.Drawing.Point(1253, 400);
            this.pictureStar5.Name = "pictureStar5";
            this.pictureStar5.Size = new System.Drawing.Size(50, 50);
            this.pictureStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStar5.TabIndex = 12;
            this.pictureStar5.TabStop = false;
            // 
            // rocketProgress
            // 
            this.rocketProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rocketProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rocketProgress.Image = global::WhiteSpaceNsp.Properties.Resources.Rocket;
            this.rocketProgress.Location = new System.Drawing.Point(0, 0);
            this.rocketProgress.Name = "rocketProgress";
            this.rocketProgress.Size = new System.Drawing.Size(61, 25);
            this.rocketProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocketProgress.TabIndex = 11;
            this.rocketProgress.TabStop = false;
            // 
            // pictureStar4
            // 
            this.pictureStar4.BackColor = System.Drawing.Color.Transparent;
            this.pictureStar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureStar4.Image = global::WhiteSpaceNsp.Properties.Resources.Star;
            this.pictureStar4.Location = new System.Drawing.Point(1347, 879);
            this.pictureStar4.Name = "pictureStar4";
            this.pictureStar4.Size = new System.Drawing.Size(50, 50);
            this.pictureStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStar4.TabIndex = 8;
            this.pictureStar4.TabStop = false;
            // 
            // pictureStar3
            // 
            this.pictureStar3.BackColor = System.Drawing.Color.Transparent;
            this.pictureStar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureStar3.Image = global::WhiteSpaceNsp.Properties.Resources.Star;
            this.pictureStar3.InitialImage = global::WhiteSpaceNsp.Properties.Resources.Star;
            this.pictureStar3.Location = new System.Drawing.Point(1825, 172);
            this.pictureStar3.Name = "pictureStar3";
            this.pictureStar3.Size = new System.Drawing.Size(50, 50);
            this.pictureStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStar3.TabIndex = 7;
            this.pictureStar3.TabStop = false;
            // 
            // pictureStar2
            // 
            this.pictureStar2.BackColor = System.Drawing.Color.Transparent;
            this.pictureStar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureStar2.Image = global::WhiteSpaceNsp.Properties.Resources.Star;
            this.pictureStar2.Location = new System.Drawing.Point(974, 624);
            this.pictureStar2.Name = "pictureStar2";
            this.pictureStar2.Size = new System.Drawing.Size(50, 50);
            this.pictureStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStar2.TabIndex = 6;
            this.pictureStar2.TabStop = false;
            // 
            // pictureStar1
            // 
            this.pictureStar1.BackColor = System.Drawing.Color.Transparent;
            this.pictureStar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureStar1.Image = global::WhiteSpaceNsp.Properties.Resources.Star;
            this.pictureStar1.Location = new System.Drawing.Point(938, 267);
            this.pictureStar1.Name = "pictureStar1";
            this.pictureStar1.Size = new System.Drawing.Size(50, 50);
            this.pictureStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStar1.TabIndex = 5;
            this.pictureStar1.TabStop = false;
            // 
            // rocketNeutral
            // 
            this.rocketNeutral.Image = global::WhiteSpaceNsp.Properties.Resources.Rocket;
            this.rocketNeutral.Location = new System.Drawing.Point(470, 486);
            this.rocketNeutral.Name = "rocketNeutral";
            this.rocketNeutral.Size = new System.Drawing.Size(418, 176);
            this.rocketNeutral.TabIndex = 4;
            this.rocketNeutral.TabStop = false;
            this.rocketNeutral.Visible = false;
            // 
            // rocketDown
            // 
            this.rocketDown.Image = global::WhiteSpaceNsp.Properties.Resources.RocketDown;
            this.rocketDown.Location = new System.Drawing.Point(470, 731);
            this.rocketDown.Name = "rocketDown";
            this.rocketDown.Size = new System.Drawing.Size(418, 176);
            this.rocketDown.TabIndex = 3;
            this.rocketDown.TabStop = false;
            this.rocketDown.Visible = false;
            // 
            // rocketUp
            // 
            this.rocketUp.Image = global::WhiteSpaceNsp.Properties.Resources.RocketUp;
            this.rocketUp.Location = new System.Drawing.Point(481, 668);
            this.rocketUp.Name = "rocketUp";
            this.rocketUp.Size = new System.Drawing.Size(418, 176);
            this.rocketUp.TabIndex = 2;
            this.rocketUp.TabStop = false;
            this.rocketUp.Visible = false;
            // 
            // BackgroundPicture
            // 
            this.BackgroundPicture.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundPicture.BackgroundImage = global::WhiteSpaceNsp.Properties.Resources.Universe;
            this.BackgroundPicture.Location = new System.Drawing.Point(405, 12);
            this.BackgroundPicture.Name = "BackgroundPicture";
            this.BackgroundPicture.Size = new System.Drawing.Size(1508, 1080);
            this.BackgroundPicture.TabIndex = 1;
            this.BackgroundPicture.TabStop = false;
            // 
            // WhiteSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.particle7);
            this.Controls.Add(this.particle6);
            this.Controls.Add(this.particle5);
            this.Controls.Add(this.particle4);
            this.Controls.Add(this.particle3);
            this.Controls.Add(this.particle2);
            this.Controls.Add(this.particle1);
            this.Controls.Add(this.laserBeam);
            this.Controls.Add(this.rocketImage);
            this.Controls.Add(this.pictureStar6);
            this.Controls.Add(this.pictureStar5);
            this.Controls.Add(this.rocketProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureStar4);
            this.Controls.Add(this.pictureStar3);
            this.Controls.Add(this.pictureStar2);
            this.Controls.Add(this.pictureStar1);
            this.Controls.Add(this.rocketNeutral);
            this.Controls.Add(this.rocketDown);
            this.Controls.Add(this.rocketUp);
            this.Controls.Add(this.BackgroundPicture);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WhiteSpace";
            this.Text = "WhiteSpace";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.particle7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserBeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketNeutral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerRocketMove;
        private System.Windows.Forms.Timer timerStarsFlow;
        private System.Windows.Forms.PictureBox BackgroundPicture;
        private System.Windows.Forms.PictureBox rocketImage;
        private System.Windows.Forms.PictureBox rocketUp;
        private System.Windows.Forms.PictureBox rocketDown;
        private System.Windows.Forms.PictureBox rocketNeutral;
        private System.Windows.Forms.PictureBox pictureStar1;
        private System.Windows.Forms.PictureBox pictureStar2;
        private System.Windows.Forms.PictureBox pictureStar3;
        private System.Windows.Forms.PictureBox pictureStar4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox rocketProgress;
        private System.Windows.Forms.Timer time;
        public System.Windows.Forms.Label valuePoints;
        private System.Windows.Forms.Label valueFuel;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.PictureBox pictureStar5;
        private System.Windows.Forms.PictureBox pictureStar6;
        private System.Windows.Forms.Timer timerParticles;
        private System.Windows.Forms.PictureBox laserBeam;
        private System.Windows.Forms.PictureBox particle1;
        private System.Windows.Forms.PictureBox particle2;
        private System.Windows.Forms.PictureBox particle3;
        private System.Windows.Forms.PictureBox particle4;
        private System.Windows.Forms.PictureBox particle5;
        private System.Windows.Forms.PictureBox particle6;
        private System.Windows.Forms.PictureBox particle7;
        private System.Windows.Forms.Timer timerShot;
        private System.Windows.Forms.Label valueHit;
        private System.Windows.Forms.Label labelHit;
        private System.Windows.Forms.Label valueShots;
        private System.Windows.Forms.Label labelShots;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonStart;
    }
}

