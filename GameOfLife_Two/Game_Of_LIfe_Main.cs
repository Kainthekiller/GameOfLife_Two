﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

//TODO: Saving Current Universe
//TODO: Opening a previously saved universe
//TODO: Show Number of Liveing Cells *Status Strip
//TODO: Control Milliseconds between each new generation Option
//TODO: Control The current size of the universe
//TODO: VIEW MENU ITEMS TOGGLE GRIDS ON and OFF
//TODO: VIEW MENU ITEMS TOGGLE neighbor count
//TODO: Advance Features time to check back on to FSU 




namespace GameOfLife_Two
{
    public partial class Game_Of_LIfe_Main : Form
    {
        
        // The universe array   //x = accross //y = down    
        bool[,] universe = new bool[100, 100];
        bool[,] scratchPad = new bool[100, 100];
        // Drawing colors
        Color gridColor = Color.Black; // Lines color for grids
        Color cellColor = Color.DarkGray; // Background of cell when its alive
        Color numberColor = Color.Green; // Changes Number Color
        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Game_Of_LIfe_Main()
        {

            InitializeComponent();


            //Read Settings ******* Read Settings
            graphicsPanel1.BackColor = Properties.Settings.Default.BackGroundColor;


            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }





        //WORK SITE !!!





        // Calculate the next generation of cells
        private void NextGeneration()
        {

            // Increment generation count
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Current Generations = " + generations.ToString();
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                //MAIN IF STATMENT LOCATION WHERE ALL MAGIC HAPPENS !!!
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (universe[x, y])
                    {
                        if ((CountNeighborsFinite(x, y) == 2) || (CountNeighborsFinite(x, y) == 3))
                        {
                            scratchPad[x, y] = true;
                        }

                        if ((CountNeighborsFinite(x, y) < 2) || (CountNeighborsFinite(x, y) > 3))
                        {
                            scratchPad[x, y] = false;
                        }
                    }
                    else
                    {
                        //Bring them back to life if 3 next door exist
                        if (CountNeighborsFinite(x, y) == 3)
                        {
                            scratchPad[x, y] = true;
                        }
                        //Needed to ensure the dead stay dead
                        else
                        {
                            scratchPad[x, y] = false;
                        }
                    }
                }
            }
            //Swap
            bool[,] temp = universe;
            universe = scratchPad;
            scratchPad = temp;
            graphicsPanel1.Invalidate();
        }














        //WORK SITE !!!!
















        // The event called by the timer every Interval milliseconds. *Complete
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();

        }


        //Prolly Needs Some Love *****
        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);
            Brush numBrush = new SolidBrush(numberColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = (int)(x * cellWidth);
                    cellRect.Y = (int)(y * cellHeight);
                    cellRect.Width = (int)cellWidth;
                    cellRect.Height = (int)(cellHeight);

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);

                        Font font = new Font("Arial", 20f); // Adds Text to the box
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;
                        Rectangle rect = new Rectangle(0, 0, 100, 100);
                        int neighbors = 8;
                        neighbors = CountNeighborsFinite(x, y);
                        e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Black, cellRect, stringFormat); // Draws A in the middle of the boxes

                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }


        //Click true = false and false = true; Knows where you clicked *Not Complete
        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {

                // Calculate the width and height of each cell in pixels
                float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
                float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = (int)(e.X / cellWidth);
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = (int)(e.Y / cellHeight);
                // Toggle the cell's state
                universe[x, y] = !universe[x, y];
                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }



















        // COUNT NEXT DOOR PEEPS !!!!!!!!!!



        //Counts Neighbors Alive FINITE !!!! //Easy Milestone *Complete
        private int CountNeighborsFinite(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);

            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;

                    // if xOffset and yOffset are both equal to 0 then continue
                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }
                    // if xCheck is less than 0 then continue
                    if (xCheck < 0)
                    {
                        continue;
                    }
                    // if yCheck is less than 0 then continue
                    if (yCheck < 0)
                    {
                        continue;
                    }
                    // if xCheck is greater than or equal too xLen then continue
                    if (xCheck >= xLen)
                    {
                        continue;
                    }
                    // if yCheck is greater than or equal too yLen then continue
                    if (yCheck >= yLen)
                    {
                        continue;
                    }
                    //Check if neighbor is a alive via true and adds to count checks 8 spots;
                    if (universe[xCheck, yCheck] == true)
                    {
                        count++;
                    }

                }
            }
            return count;
        }



        //Counts Neighbors Toroidal  *Not Complete
        private int CountNeighborsToridal(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);

            for (int yOffset = -1; yOffset < 2; yOffset++)
            {
                for (int xOffset = -1; xOffset < 2; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;


                    // if xOffset and yOffset are both equal to 0 then continue
                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }

                    // if xCheck is less than 0 then set to xLen - 1
                    if (xCheck < 0)
                    {
                        xLen = -1;
                    }

                    // if yCheck is less than 0 then set to yLen - 1
                    if (yCheck < 0)
                    {
                        yLen = -1;
                    }

                    // if xCheck is greater than or equal too xLen then set to 0
                    if (xCheck >= xLen)
                    {
                        xCheck = 0;
                    }
                    // if yCheck is greater than or equal too yLen then set to 0
                    if (yCheck >= yLen)
                    {
                        yCheck = 0;
                    }
                    if (universe[xCheck, yCheck] == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }









        //BUTTONS !!!!!!!!!!!!!




        
        //New Game Button clicked resets all *Complete
        private void NewClicked(object sender, EventArgs e)
        {

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                    scratchPad[x, y] = false;
                }
            }
            generations = 0;
            //updates status strip Generations;
            toolStripStatusLabelGenerations.Text = "Current Generations = " + generations.ToString();
            graphicsPanel1.Invalidate();


        }


        //Start Game of life by pressing start button *Complete
        private void StartBTN_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
            timer.Enabled = true;
            NextBTN.Enabled = false;
            graphicsPanel1.Invalidate();
        }


        //Stop Game of life by pressing stop button *Complete
        private void StopBTN_Click(object sender, EventArgs e)
        {

            timer.Stop();
            NextBTN.Enabled = true;
            graphicsPanel1.Invalidate();
        }

        //Exit BTN Pressed Closes Program *Complete
        private void ExitBTN_Click(object sender, EventArgs e)
        {

            //Simple
            this.Close();
        }


        //Goes to next Generation *Complete
        private void NextBTN_Click(object sender, EventArgs e)
        {
            //Button Disabled inside Start and Enabled when Pause is pressed.
            NextGeneration();
            graphicsPanel1.Invalidate();
        }

      
        //Regular Randomizer *Completed *Crash Proof
        private void RandomNoSeed_Click(object sender, EventArgs e)
        {
            var rando = new Random();
            for (int y = 0; y < universe.GetLength(1); y++)
            {

                for (int x = 0; x < universe.GetLength(0); x++)
                {

                    universe[x, y] = rando.Next(100) % 2 == 0;
                    Console.WriteLine(rando.Next(100));
                    graphicsPanel1.Invalidate();

                }
            }

            
        }


        //Seed Randomizer *Completed *Crash Proof
        public void Random_Seed_Click(object sender, EventArgs e)
        {
            RandomSeedDialog dlg = new RandomSeedDialog();
            if (DialogResult.OK == dlg.ShowDialog())
            {
                dlg.Seed = dlg.Seed;
                
                //User input recorded
                var rando = new Random((int)dlg.Seed);
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {

                        universe[x, y] = rando.Next(0, int.MaxValue) % 2 == 0;
                        graphicsPanel1.Invalidate();

                    }
                }
            }
       
        }

        private void BackGround_Color_BTN_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = graphicsPanel1.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                graphicsPanel1.BackColor = dlg.Color; 

            }
        }

        //Overall Form Closes and this code is executed *Holds Settings*
        private void Game_Of_LIfe_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Saves Settings for Background Color
            Properties.Settings.Default.BackGroundColor = graphicsPanel1.BackColor;
            Properties.Settings.Default.Save();
        }
        
        //Reset BTN 
        private void Reset_BTN_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            //Read Setting agian after reset
            graphicsPanel1.BackColor = Properties.Settings.Default.BackGroundColor;
        }

        //Reload BTN
        private void Reload_BTN_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            //Read Setting Agian after Reload
            graphicsPanel1.BackColor = Properties.Settings.Default.BackGroundColor;
        }
    }
}
    
