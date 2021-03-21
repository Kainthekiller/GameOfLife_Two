
namespace GameOfLife_Two
{
    partial class Game_Of_LIfe_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Of_LIfe_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.open_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Save_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomNoSeed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.Random_Seed = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackGround_Color_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.CellColor_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.GridColor_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.Reset_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.Reload_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.milliseconds_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeofArea_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.universeBehaviorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Finite_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.Toroidal_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New_BTN_ToolStrip = new System.Windows.Forms.ToolStripButton();
            this.Open_BTN_ToolStrip = new System.Windows.Forms.ToolStripButton();
            this.save_ToolStrip_BTN = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.StartBTN = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.NextBTN = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.rightClick_BTN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rightClick_Background_Color_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClick_cellColor = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClick_Grid_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClick_Size_Of_Area = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClick_Random = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClick_Random_Seed = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClick_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClick_ShowNeighbor = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClick_Show_Grid = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowGrid_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowNeighbor_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.graphicsPanel1 = new GameOfLife_Two.GraphicsPanel();
            this.HUD = new GameOfLife_Two.GraphicsPanel();
            this.RightClick_ShowHud = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHud_BTN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.rightClick_BTN.SuspendLayout();
            this.graphicsPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.randomToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.SizeofArea_BTN,
            this.universeBehaviorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2613, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_BTN,
            this.open_BTN,
            this.toolStripSeparator,
            this.Save_BTN,
            this.SaveAs_BTN,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.ExitBTN});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // New_BTN
            // 
            this.New_BTN.Image = ((System.Drawing.Image)(resources.GetObject("New_BTN.Image")));
            this.New_BTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_BTN.Name = "New_BTN";
            this.New_BTN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.New_BTN.Size = new System.Drawing.Size(223, 34);
            this.New_BTN.Text = "&New";
            this.New_BTN.Click += new System.EventHandler(this.New_BTN_Click);
            // 
            // open_BTN
            // 
            this.open_BTN.Image = ((System.Drawing.Image)(resources.GetObject("open_BTN.Image")));
            this.open_BTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open_BTN.Name = "open_BTN";
            this.open_BTN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open_BTN.Size = new System.Drawing.Size(223, 34);
            this.open_BTN.Text = "&Open";
            this.open_BTN.Click += new System.EventHandler(this.open_BTN_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(220, 6);
            // 
            // Save_BTN
            // 
            this.Save_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Save_BTN.Image")));
            this.Save_BTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save_BTN.Size = new System.Drawing.Size(223, 34);
            this.Save_BTN.Text = "&Save";
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // SaveAs_BTN
            // 
            this.SaveAs_BTN.Name = "SaveAs_BTN";
            this.SaveAs_BTN.Size = new System.Drawing.Size(223, 34);
            this.SaveAs_BTN.Text = "Save &As";
            this.SaveAs_BTN.Click += new System.EventHandler(this.SaveAs_BTN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(223, 34);
            this.ExitBTN.Text = "E&xit";
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandomNoSeed,
            this.toolStripSeparator12,
            this.Random_Seed});
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.randomToolStripMenuItem.Text = "Randomizer";
            // 
            // RandomNoSeed
            // 
            this.RandomNoSeed.Name = "RandomNoSeed";
            this.RandomNoSeed.Size = new System.Drawing.Size(226, 34);
            this.RandomNoSeed.Text = "Random";
            this.RandomNoSeed.Click += new System.EventHandler(this.RandomNoSeed_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(223, 6);
            // 
            // Random_Seed
            // 
            this.Random_Seed.Name = "Random_Seed";
            this.Random_Seed.Size = new System.Drawing.Size(226, 34);
            this.Random_Seed.Text = "Seed Random";
            this.Random_Seed.Click += new System.EventHandler(this.Random_Seed_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackGround_Color_BTN,
            this.CellColor_BTN,
            this.GridColor_BTN,
            this.optionsToolStripMenuItem1,
            this.toolStripSeparator9,
            this.Reset_BTN,
            this.Reload_BTN,
            this.toolStripSeparator15,
            this.milliseconds_BTN});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // BackGround_Color_BTN
            // 
            this.BackGround_Color_BTN.Name = "BackGround_Color_BTN";
            this.BackGround_Color_BTN.Size = new System.Drawing.Size(270, 34);
            this.BackGround_Color_BTN.Text = "&BackGround Color";
            this.BackGround_Color_BTN.Click += new System.EventHandler(this.BackGround_Color_BTN_Click);
            // 
            // CellColor_BTN
            // 
            this.CellColor_BTN.Name = "CellColor_BTN";
            this.CellColor_BTN.Size = new System.Drawing.Size(270, 34);
            this.CellColor_BTN.Text = "&Cell Color";
            this.CellColor_BTN.Click += new System.EventHandler(this.CellColor_BTN_Click);
            // 
            // GridColor_BTN
            // 
            this.GridColor_BTN.Name = "GridColor_BTN";
            this.GridColor_BTN.Size = new System.Drawing.Size(270, 34);
            this.GridColor_BTN.Text = "Grid Color";
            this.GridColor_BTN.Click += new System.EventHandler(this.GridColor_BTN_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowGrid_BTN,
            this.ShowNeighbor_BTN,
            this.ShowHud_BTN});
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(267, 6);
            // 
            // Reset_BTN
            // 
            this.Reset_BTN.Name = "Reset_BTN";
            this.Reset_BTN.Size = new System.Drawing.Size(270, 34);
            this.Reset_BTN.Text = "Reset";
            this.Reset_BTN.Click += new System.EventHandler(this.Reset_BTN_Click);
            // 
            // Reload_BTN
            // 
            this.Reload_BTN.Name = "Reload_BTN";
            this.Reload_BTN.Size = new System.Drawing.Size(270, 34);
            this.Reload_BTN.Text = "Reload";
            this.Reload_BTN.Click += new System.EventHandler(this.Reload_BTN_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(267, 6);
            // 
            // milliseconds_BTN
            // 
            this.milliseconds_BTN.Name = "milliseconds_BTN";
            this.milliseconds_BTN.Size = new System.Drawing.Size(270, 34);
            this.milliseconds_BTN.Text = "Time Adjustment";
            this.milliseconds_BTN.Click += new System.EventHandler(this.milliseconds_BTN_Click);
            // 
            // SizeofArea_BTN
            // 
            this.SizeofArea_BTN.Name = "SizeofArea_BTN";
            this.SizeofArea_BTN.Size = new System.Drawing.Size(122, 29);
            this.SizeofArea_BTN.Text = "Size of Area";
            this.SizeofArea_BTN.Click += new System.EventHandler(this.SizeofArea_BTN_Click);
            // 
            // universeBehaviorToolStripMenuItem
            // 
            this.universeBehaviorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Finite_BTN,
            this.Toroidal_BTN});
            this.universeBehaviorToolStripMenuItem.Name = "universeBehaviorToolStripMenuItem";
            this.universeBehaviorToolStripMenuItem.Size = new System.Drawing.Size(168, 29);
            this.universeBehaviorToolStripMenuItem.Text = "Universe Behavior";
            // 
            // Finite_BTN
            // 
            this.Finite_BTN.Checked = true;
            this.Finite_BTN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Finite_BTN.Name = "Finite_BTN";
            this.Finite_BTN.Size = new System.Drawing.Size(177, 34);
            this.Finite_BTN.Text = "Finite";
            this.Finite_BTN.Click += new System.EventHandler(this.Finite_BTN_Click);
            // 
            // Toroidal_BTN
            // 
            this.Toroidal_BTN.Name = "Toroidal_BTN";
            this.Toroidal_BTN.Size = new System.Drawing.Size(177, 34);
            this.Toroidal_BTN.Text = "Toroidal";
            this.Toroidal_BTN.Click += new System.EventHandler(this.Toroidal_BTN_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_BTN_ToolStrip,
            this.Open_BTN_ToolStrip,
            this.save_ToolStrip_BTN,
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.StartBTN,
            this.toolStripSeparator14,
            this.toolStripButton2,
            this.toolStripSeparator13,
            this.NextBTN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(2613, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // New_BTN_ToolStrip
            // 
            this.New_BTN_ToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.New_BTN_ToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("New_BTN_ToolStrip.Image")));
            this.New_BTN_ToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_BTN_ToolStrip.Name = "New_BTN_ToolStrip";
            this.New_BTN_ToolStrip.Size = new System.Drawing.Size(34, 28);
            this.New_BTN_ToolStrip.Text = "&New";
            this.New_BTN_ToolStrip.Click += new System.EventHandler(this.New_BTN_ToolStrip_Click);
            // 
            // Open_BTN_ToolStrip
            // 
            this.Open_BTN_ToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open_BTN_ToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("Open_BTN_ToolStrip.Image")));
            this.Open_BTN_ToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open_BTN_ToolStrip.Name = "Open_BTN_ToolStrip";
            this.Open_BTN_ToolStrip.Size = new System.Drawing.Size(34, 28);
            this.Open_BTN_ToolStrip.Text = "&Open";
            this.Open_BTN_ToolStrip.Click += new System.EventHandler(this.Open_BTN_ToolStrip_Click);
            // 
            // save_ToolStrip_BTN
            // 
            this.save_ToolStrip_BTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save_ToolStrip_BTN.Image = ((System.Drawing.Image)(resources.GetObject("save_ToolStrip_BTN.Image")));
            this.save_ToolStrip_BTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_ToolStrip_BTN.Name = "save_ToolStrip_BTN";
            this.save_ToolStrip_BTN.Size = new System.Drawing.Size(34, 28);
            this.save_ToolStrip_BTN.Text = "&Save";
            this.save_ToolStrip_BTN.Click += new System.EventHandler(this.save_ToolStrip_BTN_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 33);
            // 
            // StartBTN
            // 
            this.StartBTN.BackColor = System.Drawing.Color.LimeGreen;
            this.StartBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartBTN.Image = ((System.Drawing.Image)(resources.GetObject("StartBTN.Image")));
            this.StartBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.StartBTN.Size = new System.Drawing.Size(128, 28);
            this.StartBTN.Text = "Start";
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.Yellow;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.toolStripButton2.Size = new System.Drawing.Size(128, 28);
            this.toolStripButton2.Text = "Pause";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 33);
            // 
            // NextBTN
            // 
            this.NextBTN.BackColor = System.Drawing.Color.Violet;
            this.NextBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextBTN.Enabled = false;
            this.NextBTN.Image = ((System.Drawing.Image)(resources.GetObject("NextBTN.Image")));
            this.NextBTN.ImageTransparentColor = System.Drawing.Color.Gold;
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.NextBTN.Size = new System.Drawing.Size(128, 28);
            this.NextBTN.Text = "Stop";
            this.NextBTN.ToolTipText = "Next";
            this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2613, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(305, 25);
            this.toolStripStatusLabelGenerations.Text = "Current Generations = 0 Cells Alive 0 ";
            // 
            // rightClick_BTN
            // 
            this.rightClick_BTN.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.rightClick_BTN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightClick_Background_Color_BTN,
            this.RightClick_cellColor,
            this.RightClick_Grid_Color,
            this.RightClick_Size_Of_Area,
            this.randomizerToolStripMenuItem,
            this.RightClick_Reset,
            this.RightClick_ShowNeighbor,
            this.RightClick_Show_Grid,
            this.RightClick_ShowHud});
            this.rightClick_BTN.Name = "rightClick_BTN";
            this.rightClick_BTN.Size = new System.Drawing.Size(228, 292);
            // 
            // rightClick_Background_Color_BTN
            // 
            this.rightClick_Background_Color_BTN.Name = "rightClick_Background_Color_BTN";
            this.rightClick_Background_Color_BTN.Size = new System.Drawing.Size(227, 32);
            this.rightClick_Background_Color_BTN.Text = "Background Color";
            this.rightClick_Background_Color_BTN.Click += new System.EventHandler(this.rightClick_Background_Color_BTN_Click);
            // 
            // RightClick_cellColor
            // 
            this.RightClick_cellColor.Name = "RightClick_cellColor";
            this.RightClick_cellColor.Size = new System.Drawing.Size(227, 32);
            this.RightClick_cellColor.Text = "Cell Color";
            this.RightClick_cellColor.Click += new System.EventHandler(this.RightClick_cellColor_Click_1);
            // 
            // RightClick_Grid_Color
            // 
            this.RightClick_Grid_Color.Name = "RightClick_Grid_Color";
            this.RightClick_Grid_Color.Size = new System.Drawing.Size(227, 32);
            this.RightClick_Grid_Color.Text = "Grid Color";
            this.RightClick_Grid_Color.Click += new System.EventHandler(this.RightClick_Grid_Color_Click);
            // 
            // RightClick_Size_Of_Area
            // 
            this.RightClick_Size_Of_Area.Name = "RightClick_Size_Of_Area";
            this.RightClick_Size_Of_Area.Size = new System.Drawing.Size(227, 32);
            this.RightClick_Size_Of_Area.Text = "Size of Area";
            this.RightClick_Size_Of_Area.Click += new System.EventHandler(this.RightClick_Size_Of_Area_Click);
            // 
            // randomizerToolStripMenuItem
            // 
            this.randomizerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightClick_Random,
            this.RightClick_Random_Seed});
            this.randomizerToolStripMenuItem.Name = "randomizerToolStripMenuItem";
            this.randomizerToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.randomizerToolStripMenuItem.Text = "Randomizer";
            // 
            // RightClick_Random
            // 
            this.RightClick_Random.Name = "RightClick_Random";
            this.RightClick_Random.Size = new System.Drawing.Size(226, 34);
            this.RightClick_Random.Text = "Random";
            this.RightClick_Random.Click += new System.EventHandler(this.RightClick_Random_Click);
            // 
            // RightClick_Random_Seed
            // 
            this.RightClick_Random_Seed.Name = "RightClick_Random_Seed";
            this.RightClick_Random_Seed.Size = new System.Drawing.Size(226, 34);
            this.RightClick_Random_Seed.Text = "Seed Random";
            this.RightClick_Random_Seed.Click += new System.EventHandler(this.RightClick_Random_Seed_Click);
            // 
            // RightClick_Reset
            // 
            this.RightClick_Reset.Name = "RightClick_Reset";
            this.RightClick_Reset.Size = new System.Drawing.Size(227, 32);
            this.RightClick_Reset.Text = "Reset";
            this.RightClick_Reset.Click += new System.EventHandler(this.RightClick_Reset_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // RightClick_ShowNeighbor
            // 
            this.RightClick_ShowNeighbor.Checked = true;
            this.RightClick_ShowNeighbor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RightClick_ShowNeighbor.Name = "RightClick_ShowNeighbor";
            this.RightClick_ShowNeighbor.Size = new System.Drawing.Size(227, 32);
            this.RightClick_ShowNeighbor.Text = "Show Neighbor";
            this.RightClick_ShowNeighbor.Click += new System.EventHandler(this.RightClick_ShowNeighbor_Click);
            // 
            // RightClick_Show_Grid
            // 
            this.RightClick_Show_Grid.Checked = true;
            this.RightClick_Show_Grid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RightClick_Show_Grid.Name = "RightClick_Show_Grid";
            this.RightClick_Show_Grid.Size = new System.Drawing.Size(227, 32);
            this.RightClick_Show_Grid.Text = "Show Grid";
            this.RightClick_Show_Grid.Click += new System.EventHandler(this.RightClick_Show_Grid_Click);
            // 
            // ShowGrid_BTN
            // 
            this.ShowGrid_BTN.Checked = true;
            this.ShowGrid_BTN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowGrid_BTN.Name = "ShowGrid_BTN";
            this.ShowGrid_BTN.Size = new System.Drawing.Size(270, 34);
            this.ShowGrid_BTN.Text = "Show Grid";
            this.ShowGrid_BTN.Click += new System.EventHandler(this.ShowGrid_BTN_Click);
            // 
            // ShowNeighbor_BTN
            // 
            this.ShowNeighbor_BTN.Checked = true;
            this.ShowNeighbor_BTN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowNeighbor_BTN.Name = "ShowNeighbor_BTN";
            this.ShowNeighbor_BTN.Size = new System.Drawing.Size(270, 34);
            this.ShowNeighbor_BTN.Text = "Show Neighbor";
            this.ShowNeighbor_BTN.Click += new System.EventHandler(this.ShowNeighbor_BTN_Click);
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.ContextMenuStrip = this.rightClick_BTN;
            this.graphicsPanel1.Controls.Add(this.HUD);
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 66);
            this.graphicsPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(2613, 1318);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // HUD
            // 
            this.HUD.BackColor = System.Drawing.Color.Transparent;
            this.HUD.Location = new System.Drawing.Point(1286, 500);
            this.HUD.Name = "HUD";
            this.HUD.Size = new System.Drawing.Size(980, 410);
            this.HUD.TabIndex = 0;
            this.HUD.Paint += new System.Windows.Forms.PaintEventHandler(this.HUD_Paint);
            // 
            // RightClick_ShowHud
            // 
            this.RightClick_ShowHud.Checked = true;
            this.RightClick_ShowHud.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RightClick_ShowHud.Name = "RightClick_ShowHud";
            this.RightClick_ShowHud.Size = new System.Drawing.Size(227, 32);
            this.RightClick_ShowHud.Text = "Show Hud";
            this.RightClick_ShowHud.Click += new System.EventHandler(this.RightClick_ShowHud_Click);
            // 
            // ShowHud_BTN
            // 
            this.ShowHud_BTN.Checked = true;
            this.ShowHud_BTN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowHud_BTN.Name = "ShowHud_BTN";
            this.ShowHud_BTN.Size = new System.Drawing.Size(270, 34);
            this.ShowHud_BTN.Text = "Show Hud";
            this.ShowHud_BTN.Click += new System.EventHandler(this.ShowHud_BTN_Click);
            // 
            // Game_Of_LIfe_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2613, 1416);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Game_Of_LIfe_Main";
            this.Text = "Game Of Life";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_Of_LIfe_Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.rightClick_BTN.ResumeLayout(false);
            this.graphicsPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem New_BTN;
        private System.Windows.Forms.ToolStripMenuItem open_BTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem Save_BTN;
        private System.Windows.Forms.ToolStripMenuItem SaveAs_BTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitBTN;
        private System.Windows.Forms.ToolStripButton New_BTN_ToolStrip;
        private System.Windows.Forms.ToolStripButton Open_BTN_ToolStrip;
        private System.Windows.Forms.ToolStripButton save_ToolStrip_BTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton NextBTN;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripButton StartBTN;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandomNoSeed;
        private System.Windows.Forms.ToolStripMenuItem Random_Seed;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackGround_Color_BTN;
        private System.Windows.Forms.ToolStripMenuItem CellColor_BTN;
        private System.Windows.Forms.ToolStripMenuItem GridColor_BTN;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Reset_BTN;
        private System.Windows.Forms.ToolStripMenuItem Reload_BTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem milliseconds_BTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem SizeofArea_BTN;
        private System.Windows.Forms.ToolStripMenuItem universeBehaviorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Finite_BTN;
        private System.Windows.Forms.ToolStripMenuItem Toroidal_BTN;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip rightClick_BTN;
        private System.Windows.Forms.ToolStripMenuItem rightClick_Background_Color_BTN;
        private System.Windows.Forms.ToolStripMenuItem RightClick_cellColor;
        private System.Windows.Forms.ToolStripMenuItem RightClick_Grid_Color;
        private System.Windows.Forms.ToolStripMenuItem RightClick_Size_Of_Area;
        private System.Windows.Forms.ToolStripMenuItem randomizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RightClick_Random;
        private System.Windows.Forms.ToolStripMenuItem RightClick_Random_Seed;
        private System.Windows.Forms.ToolStripMenuItem RightClick_Reset;
        private System.Windows.Forms.ToolStripMenuItem RightClick_ShowNeighbor;
        private System.Windows.Forms.ToolStripMenuItem RightClick_Show_Grid;
        private System.Windows.Forms.ToolStripMenuItem ShowGrid_BTN;
        private System.Windows.Forms.ToolStripMenuItem ShowNeighbor_BTN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GraphicsPanel HUD;
        private System.Windows.Forms.ToolStripMenuItem RightClick_ShowHud;
        private System.Windows.Forms.ToolStripMenuItem ShowHud_BTN;
    }
}

