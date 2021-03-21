using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

//Saving Current Universe *Complete currentrow.cell desktop or Save as 
//Opening a previously saved universe *Completed
//Show Number of Liveing Cells *Status Strip *Completed
//Control Milliseconds between each new generation Option *Completed
//Control The current size of the universe *Completed
//VIEW MENU ITEMS TOGGLE GRIDS ON and OFF *Completed
//VIEW MENU ITEMS TOGGLE neighbor count *Completed 90 percent works
//Infianty 
//Context Sensitive Menu
//TODO: HUD
//Reload and Reset Work better prolly just needs little extra code. 



namespace GameOfLife_Two
{
    public partial class Game_Of_LIfe_Main : Form
    {
        bool finiteStatus = true;
        bool showNeighborsStatus = true;
        int LivingCells = 0;
        // The universe array   //x = accross //y = down    
        bool[,] universe = new bool[Properties.Settings.Default.width, Properties.Settings.Default.height];
        bool[,] scratchPad = new bool[Properties.Settings.Default.width, Properties.Settings.Default.height];
        // Drawing colors
        Color gridColor = Properties.Settings.Default.GridColor; // Lines color for grids
        Color cellColor = Properties.Settings.Default.CellColor; // Background of cell when its alive
        Color numberColor = Color.Green; // Changes Number Color
        string nextDoor = string.Empty;
        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Game_Of_LIfe_Main()
        {

            InitializeComponent();


            //Read Settings ******* Read Settings
            graphicsPanel1.BackColor = Properties.Settings.Default.BackGroundColor; // Background color loaded from settings
            timer.Interval = Properties.Settings.Default.Timer;  // milliseconds loaded from settings
            // Setup the timer
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }



        //______________________________________________________________________________________________________________________________________________________________

        //NEXT GENERATION METHOD()

        //______________________________________________________________________________________________________________________________________________________________



        // Calculate the next generation of cells
        private void NextGeneration()
        {

            // Increment generation count
            generations++;
            LivingCells = 0;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                //MAIN IF STATMENT LOCATION WHERE ALL MAGIC HAPPENS !!!
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (universe[x, y])
                    {

                        LivingCells++;

                    }
                    if (universe[x, y] && finiteStatus == true)
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
                    else if (!universe[x, y] && finiteStatus == true)
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
                    if (universe[x, y] && finiteStatus == false)
                    {

                        if ((CountNeighborsToridal(x, y) == 2) || (CountNeighborsToridal(x, y) == 3))
                        {
                            scratchPad[x, y] = true;
                        }

                        if ((CountNeighborsToridal(x, y) < 2) || (CountNeighborsToridal(x, y) > 3))
                        {
                            scratchPad[x, y] = false;
                        }
                    }
                    else if (!universe[x, y] && finiteStatus == false)
                    {
                        //Bring them back to life if 3 next door exist
                        if (CountNeighborsToridal(x, y) == 3)
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

                // Update status strip generations While *Need to be after for loop to stay current. 
                toolStripStatusLabelGenerations.Text = "Current Generations = " + generations.ToString() + " Cells Alive " + LivingCells.ToString();
            }

            //Swap
            bool[,] temp = universe;
            universe = scratchPad;
            scratchPad = temp;
            graphicsPanel1.Invalidate();
        }







        //______________________________________________________________________________________________________________________________________________________________


        //TIMER >>>>> GRAPHIC PANEL  >>>>>>> MOUSE CLICK


        //______________________________________________________________________________________________________________________________________________________________



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

                        Font font = new Font("Arial", 10f); // Adds Text to the box
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;
                        Rectangle rect = new Rectangle(0, 0, 100, 100);


                        //If Checked neighbors are turned off by empty string, otherwise the numbers show;
 

                            if(finiteStatus == true)
                            {
                            nextDoor = CountNeighborsFinite(x, y).ToString();

                            }
                            else if (finiteStatus == false)
                            {
                                nextDoor = CountNeighborsToridal(x, y).ToString();
                            }
                            if(showNeighborsStatus == true)
                        {
                            e.Graphics.DrawString(nextDoor, font, Brushes.Black, cellRect, stringFormat);
                        }
                            else if (showNeighborsStatus == false)
                        {
                            e.Graphics.DrawString("", font, Brushes.Black, cellRect, stringFormat);
                        }

                           


                               
                            
                           
                        

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




        //______________________________________________________________________________________________________________________________________________________________


        // Count Neighbors Methods()  >>>>>>> FINITE***COMPLETED***  >>>>>>> TOROIDAL ***NOT COMPLETED*** AKA MR INFINANTY STONE

        //______________________________________________________________________________________________________________________________________________________________

        //Counts Neighbors Alive FINITE !!!! //Milestone *Complete
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

        
        
        //Counts Neighbors Toroidal  *Complete
        private int CountNeighborsToridal(int x, int y)
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

                    // if xCheck is less than 0 then set to xLen - 1
                    if (xCheck < 0)
                    {
                        xCheck = xLen - 1;
                    }

                    // if yCheck is less than 0 then set to yLen - 1
                    if (yCheck < 0)
                    {
                        yCheck = yLen - 1;
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





        //______________________________________________________________________________________________________________________________________________________________



        //BUTTONS ********************** BUTTONS ************************ BUTTONS


        //______________________________________________________________________________________________________________________________________________________________



        //New Game Button clicked resets all *Complete
        private void New_BTN_Click(object sender, EventArgs e)
        {
            newBtn();
        }

        private void New_BTN_ToolStrip_Click(object sender, EventArgs e)
        {
            newBtn();
        }
        //Start Game of life by pressing start button *Complete
        private void StartBTN_Click(object sender, EventArgs e)
        {
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


        //Regular Randomizer *Completed
        private void RandomNoSeed_Click(object sender, EventArgs e)
        {

            randomMethod();

        }
        private void RightClick_Random_Click(object sender, EventArgs e)
        {
            randomMethod();
        }

        //Seed Randomizer *Completed
        public void Random_Seed_Click(object sender, EventArgs e)
        {
            randomSeedMethod();
        }
        private void RightClick_Random_Seed_Click(object sender, EventArgs e)
        {
            randomSeedMethod();
        }
        //Change Grid Color Logic *Completed
        private void GridColor_BTN_Click(object sender, EventArgs e)
        {
            gridColorBTN();
        }
        private void RightClick_Grid_Color_Click(object sender, EventArgs e)
        {
            gridColorBTN();
        }
        //Background Color Logic *Completed
        private void BackGround_Color_BTN_Click(object sender, EventArgs e)
        {
            backgroundColorBTN();
        }
        private void rightClick_Background_Color_BTN_Click(object sender, EventArgs e)
        {
            backgroundColorBTN();
        }
        //Overall Form Closes and this code is executed *Holds Settings*
        private void Game_Of_LIfe_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Saves Settings if Form is Closed
            Properties.Settings.Default.BackGroundColor = graphicsPanel1.BackColor;
            Properties.Settings.Default.Timer = timer.Interval;
            Properties.Settings.Default.height = universe.GetLength(0);
            Properties.Settings.Default.width = universe.GetLength(1);
            Properties.Settings.Default.GridColor = gridColor;
            Properties.Settings.Default.CellColor = cellColor;
            Properties.Settings.Default.Save();
        }

        //Reset BTN 
        private void Reset_BTN_Click(object sender, EventArgs e)
        {
            resetMethod();
        }
        private void RightClick_Reset_Click(object sender, EventArgs e)
        {
            resetMethod();
        }
        //Reload BTN
        private void Reload_BTN_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            //Read Setting Agian after Reload
            graphicsPanel1.BackColor = Properties.Settings.Default.BackGroundColor;
            timer.Interval = Properties.Settings.Default.Timer;
            gridColor = Properties.Settings.Default.GridColor;
            cellColor = Properties.Settings.Default.CellColor;
            graphicsPanel1.Invalidate();
        }

        //Adjust MillSec speed BTN *Complete
        private void milliseconds_BTN_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            MilliSecondsDialog dlg = new MilliSecondsDialog();

            if (DialogResult.OK == dlg.ShowDialog())
            {
                timer.Interval = (int)dlg.timerMillSec;
            }
            //Saves Current Timer Interval
            Properties.Settings.Default.Timer = timer.Interval;
            Properties.Settings.Default.Save();
            timer.Enabled = true;
        }

        //Save As BTN lets to name and choose where to save the file *Complete
        private void SaveAs_BTN_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2; dlg.DefaultExt = "cells";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                // Write any comments you want to include first.
                // Prefix all comment strings with an exclamation point.
                // Use WriteLine to write the strings to the file. 
                // It appends a CRLF for you.


                // Iterate through the universe one row at a time.
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    // Create a string to represent the current row.
                    System.Text.StringBuilder currentRow = new System.Text.StringBuilder();

                    // Iterate through the current row one cell at a time.
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        // If the universe[x,y] is alive then append 'O' (capital O)

                        if (universe[x, y])
                        {
                            currentRow.Append("O");
                            // If true append capital O
                        }
                        // to the row string.
                        else if (!universe[x, y])
                        {
                            currentRow.Append(".");
                        }
                        // Else if the universe[x,y] is dead then append '.' (period)
                        // to the row string.
                    }

                    writer.WriteLine(currentRow);
                    // Once the current row has been read through and the 
                    // string constructed then write it to the file using WriteLine.
                }
                // After all rows and columns have been written then close the file.
                writer.Close();
                timer.Enabled = true;
            }
        }

        //Save btn gives a default filename currentrow.cell and saves it to the desktop. *Complete
        private void Save_BTN_Click(object sender, EventArgs e)
        {
            saveBtn();
        }

        //Save BTN on tool strip saves default currentrow.cell onto the desktop *Complete
        private void save_ToolStrip_BTN_Click(object sender, EventArgs e)
        {
            saveBtn();
        }

        //*Completed Open Files
        private void open_BTN_Click(object sender, EventArgs e)
        {
            openBtn();
        }

        //*Completed Open Files
        private void Open_BTN_ToolStrip_Click(object sender, EventArgs e)
        {
            openBtn();
        }

        //Show Neighbor BTN
        private void RightClick_ShowNeighbor_Click(object sender, EventArgs e)
        {
            showNeighborsMethod();
        }
        private void ShowNeighbor_BTN_Click(object sender, EventArgs e)
        {
            showNeighborsMethod();
        }
        //SIZE BTN Changes the size of the grid Examples Universe[30,30]; *Complete
        private void SizeofArea_BTN_Click(object sender, EventArgs e)
        {
            sizeOfAreaMethod();
        }
        private void RightClick_Size_Of_Area_Click(object sender, EventArgs e)
        {
            sizeOfAreaMethod();
        }
        //Turns Grid On and Off Stops *Completed
        private void RightClick_Show_Grid_Click(object sender, EventArgs e)
        {
            gridOnOffMethod();
        }
        private void ShowGrid_BTN_Click(object sender, EventArgs e)
        {
            gridOnOffMethod();
        }

        //Change Cell Colors *Completed
        private void CellColor_BTN_Click(object sender, EventArgs e)
        {
            cellColorBTN();

        }
        private void RightClick_cellColor_Click_1(object sender, EventArgs e)
        {
            cellColorBTN();
        }
        private void Finite_BTN_Click(object sender, EventArgs e)
        {
            if (Finite_BTN.Checked == false)
            {
                Finite_BTN.Checked = true;

            }
            if (Finite_BTN.Checked == true)
            {
                finiteStatus = true;
                Toroidal_BTN.Checked = false;
            }
        }

        private void Toroidal_BTN_Click(object sender, EventArgs e)
        {
            if (Toroidal_BTN.Checked == false)
            {
                Toroidal_BTN.Checked = true;
            }
            if (Toroidal_BTN.Checked == true)
            {
                finiteStatus = false;
                Finite_BTN.Checked = false;
            }

        }



        //______________________________________________________________________________________________________________________________________________________________



        //METHODS ********************** METHODS ************************ METHODS


        //______________________________________________________________________________________________________________________________________________________________


        //Open Button Method for Reuse if wanted
        private void openBtn()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);

                // Create a couple variables to calculate the width and height
                // of the data in the file.
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored.
                    if (row.StartsWith("!"))
                    {
                        //Nothing needs to happen
                    }

                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    else if (!row.StartsWith("!"))
                    {
                        maxHeight++;
                    }

                    // Get the length of the current row string
                    int currentRowLength = row.Length;
                    // and adjust the maxWidth variable if necessary.
                    if (maxWidth != currentRowLength && !row.StartsWith("!"))
                    {
                        maxWidth = currentRowLength;
                    }
                }

                // Resize the current universe and scratchPad
                // to the width and height of the file calculated above.
                universe = new bool[maxWidth, maxHeight];
                scratchPad = new bool[maxWidth, maxHeight];



                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                // Iterate through the file again, this time reading in the cells.
                int nextRow = -1;
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();
                    //As line is read next row ++ to make for good irtration to the next row as its one line at a time. 

                    // If the row begins with '!' then
                    // it is a comment and should be ignored.
                    if (row.StartsWith("!"))
                    {
                        //Nothing needs to happen
                    }
                    // If the row is not a comment then 
                    // it is a row of cells and needs to be iterated through.
                    else if (!row.StartsWith("!"))
                    {
                        nextRow++;


                        for (int xPos = 0; xPos < row.Length; xPos++)
                        {




                            // If row[xPos] is a 'O' (capital O) then
                            // set the corresponding cell in the universe to alive.
                            if (row[xPos] == 'O')
                            {

                                universe[xPos, nextRow] = true;

                            }

                            //If row[xPos] is a '.' (period) then
                            //set the corresponding cell in the universe to dead.
                            if (row[xPos] == '.')
                            {
                                universe[xPos, nextRow] = false;
                            }
                        }

                        graphicsPanel1.Invalidate();
                    }
                }

                // Close the file.
                reader.Close();
            }
        }
        //Save Button Method / Default Method
        private void saveBtn()
        {
            timer.Enabled = false;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = path + "\\currentrow.cells";

            //Delete if the default Path Exist keeps things clean in my view alawys just make a new file from scratch
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }

            //Save *Makes a default file on the desktop*
            if (!File.Exists(filepath))
            {
                StreamWriter writer = new StreamWriter(filepath);

                // Write any comments you want to include first.
                // Prefix all comment strings with an exclamation point.
                // Use WriteLine to write the strings to the file. 
                // It appends a CRLF for you.


                // Iterate through the universe one row at a time.
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    // Create a string to represent the current row.
                    System.Text.StringBuilder currentRow = new System.Text.StringBuilder();

                    // Iterate through the current row one cell at a time.
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        // If the universe[x,y] is alive then append 'O' (capital O)

                        if (universe[x, y])
                        {
                            currentRow.Append("O");
                            // If true append capital O
                        }
                        // to the row string.
                        else if (!universe[x, y])
                        {
                            currentRow.Append(".");
                        }
                        // Else if the universe[x,y] is dead then append '.' (period)
                        // to the row string.
                    }

                    writer.WriteLine(currentRow);
                    // Once the current row has been read through and the 
                    // string constructed then write it to the file using WriteLine.
                }
                // After all rows and columns have been written then close the file.
                writer.Close();

                //default message and buttons
                string message = "Your file has been saved to the Desktop as currentrow.cell";
                string caption = "File Saved currentrow.cell";
                MessageBoxButtons buttons = MessageBoxButtons.OK;


                //MessageBox to let user know the file has been saved onto the desktop
                var result = MessageBox.Show(message, caption, buttons);
            }
        }
        //New Button Method 
        private void newBtn()
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
            LivingCells = 0;
            //updates status strip Generations; *NEW CLICKED*
            toolStripStatusLabelGenerations.Text = "Current Generations = " + generations.ToString() + " Cells Alive " + LivingCells.ToString();
            graphicsPanel1.Invalidate();

        }
        //Background Color Changer Method
        private void backgroundColorBTN()
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = graphicsPanel1.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                graphicsPanel1.BackColor = dlg.Color;

            }
            graphicsPanel1.Invalidate();
        }
        //Cell Color Changer Method
        private void cellColorBTN()
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = cellColor;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                cellColor = dlg.Color;
            }

            graphicsPanel1.Invalidate();
        }
        //Grid Color Changer Method
        private void gridColorBTN()
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = gridColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                gridColor = dlg.Color;
            }

            graphicsPanel1.Invalidate();
        }
        //Random No Seed
        private void randomMethod()
        {
            timer.Enabled = false;
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
        //Random Seed
        private void randomSeedMethod()
        {
            timer.Enabled = false;
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
        //Reset Method
        private void resetMethod()
        {
            Properties.Settings.Default.Reset();
            //Read Setting agian after reset
            graphicsPanel1.BackColor = Properties.Settings.Default.BackGroundColor;
            timer.Interval = Properties.Settings.Default.Timer;
            universe = new bool[Properties.Settings.Default.width, Properties.Settings.Default.height];
            gridColor = Properties.Settings.Default.GridColor;
            cellColor = Properties.Settings.Default.CellColor;
            graphicsPanel1.Invalidate();
        }
        //Size of Area Method
        private void sizeOfAreaMethod()
        {
            timer.Enabled = false;
            SizeOfAreaDialog dlg = new SizeOfAreaDialog();
            if (DialogResult.OK == dlg.ShowDialog())
            {
                universe = new bool[(int)dlg.width, (int)dlg.height];
                scratchPad = new bool[(int)dlg.width, (int)dlg.height];
                graphicsPanel1.Invalidate();
            }
            Properties.Settings.Default.height = universe.GetLength(0);
            Properties.Settings.Default.width = universe.GetLength(1);
            Properties.Settings.Default.Save();
        }
        //Grid On and off Method
        private void gridOnOffMethod()
        {
            if (RightClick_Show_Grid.Checked)
            {
                Properties.Settings.Default.GridColor = gridColor;
                gridColor = Color.Empty;
                GridColor_BTN.Enabled = false;
                RightClick_Show_Grid.Checked = false ;
                ShowGrid_BTN.Checked = false;
            }
            else if(!RightClick_Show_Grid.Checked)
            {
                GridColor_BTN.Enabled = true;
                gridColor = Properties.Settings.Default.GridColor;
                Properties.Settings.Default.Save();
                RightClick_Show_Grid.Checked = true;
                ShowGrid_BTN.Checked = true;
            }


            graphicsPanel1.Invalidate();
        }
        //Show Neighbors Method
        private void showNeighborsMethod()
        {
            if (!RightClick_ShowNeighbor.Checked)
            {
                showNeighborsStatus = true;

                RightClick_ShowNeighbor.Checked = true;
                ShowNeighbor_BTN.Checked = true;
                graphicsPanel1.Invalidate();
            }
            
            else if (RightClick_ShowNeighbor.Checked)
            {
                showNeighborsStatus = false;
                RightClick_ShowNeighbor.Checked = false;
                ShowNeighbor_BTN.Checked = false;
                graphicsPanel1.Invalidate();
            }
        }


    }
}

