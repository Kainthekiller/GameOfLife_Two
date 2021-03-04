using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

//// Swap them...
//bool[,] temp = universe;
//universe = scratchPad;
//scratchPad = temp;



namespace GameOfLife_Two
{
    public partial class Form1 : Form
    {

        // The universe array   //x = accross //y = down    
        bool[,] universe = new bool[30, 30];
        bool[,] scratchPad = new bool[30, 30];
        // Drawing colors
        Color gridColor = Color.Black; // Lines color for grids
        Color cellColor = Color.DarkGray; // Background of cell when its alive
        Color numberColor = Color.Green; // Changes Number Color
        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Form1()
        {

            InitializeComponent();

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
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (universe[x, y])
                    {

                        if ((CountNeighborsFinite(x, y) == 2) || (CountNeighborsFinite(x, y) == 3))
                        {

                            scratchPad[x, y] = true;

                            Console.WriteLine("ONE");
                        }
                     
                        if ((CountNeighborsFinite(x, y) < 2) || (CountNeighborsFinite(x, y) > 3))
                        {
                            scratchPad[x, y] = false;

                            Console.WriteLine("Three");
                        

                        }
                    }
                    else
                    {
                        //Bring them back to life if 3 next door exist
                        if (CountNeighborsFinite(x, y) == 3)
                        {
                            scratchPad[x, y] = true;
                            Console.WriteLine("Four");
                           
                        }
                        //Needed to ensure the dead stay dead
                        else
                        {
                            scratchPad[x, y] = false;
                            Console.WriteLine("Five");
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
















// The event called by the timer every Interval milliseconds.
private void Timer_Tick(object sender, EventArgs e)
{
    NextGeneration();

}

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









//TODO: Reset Generation on new
//New Game Button clicked resets all 
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
    graphicsPanel1.Invalidate();
}













//Counts Neighbors Alive FINITE !!!! //Easy Milestone
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



//Counts Neighbors Toroidal
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













//Start Game of life by pressing start button
private void StartBTN_Click(object sender, EventArgs e)
{
            timer.Interval = 100;
    timer.Enabled = true;
    graphicsPanel1.Invalidate();
}
//Stop Game of life by pressing stop button
private void StopBTN_Click(object sender, EventArgs e)
{

    timer.Stop();
    graphicsPanel1.Invalidate();
}

//Exit BTN Pressed Closes Program
private void ExitBTN_Click(object sender, EventArgs e)
{
    //Simple
    this.Close();
}

private void NextBTN_Click(object sender, EventArgs e)
{
    timer.Interval = 1000;
    timer.Start();




    graphicsPanel1.Invalidate();
}
    }
}
