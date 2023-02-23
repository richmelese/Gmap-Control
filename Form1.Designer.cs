namespace CheekMap
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddPoints = new System.Windows.Forms.ToolStripButton();
            this.DrowRoute = new System.Windows.Forms.ToolStripButton();
            this.RemoveMarker = new System.Windows.Forms.ToolStripButton();
            this.RemoveRoute = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textlat = new System.Windows.Forms.TextBox();
            this.txtlongt = new System.Windows.Forms.TextBox();
            this.btnLoadToMap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPoints,
            this.DrowRoute,
            this.RemoveMarker,
            this.RemoveRoute,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddPoints
            // 
            this.AddPoints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddPoints.Image = ((System.Drawing.Image)(resources.GetObject("AddPoints.Image")));
            this.AddPoints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddPoints.Name = "AddPoints";
            this.AddPoints.Size = new System.Drawing.Size(23, 22);
            this.AddPoints.Text = "ADDMarker";
            this.AddPoints.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // DrowRoute
            // 
            this.DrowRoute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrowRoute.Image = ((System.Drawing.Image)(resources.GetObject("DrowRoute.Image")));
            this.DrowRoute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrowRoute.Name = "DrowRoute";
            this.DrowRoute.Size = new System.Drawing.Size(23, 22);
            this.DrowRoute.Text = "AddRoute";
            this.DrowRoute.Click += new System.EventHandler(this.DrowRoute_Click);
            // 
            // RemoveMarker
            // 
            this.RemoveMarker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveMarker.Image = ((System.Drawing.Image)(resources.GetObject("RemoveMarker.Image")));
            this.RemoveMarker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveMarker.Name = "RemoveMarker";
            this.RemoveMarker.Size = new System.Drawing.Size(23, 22);
            this.RemoveMarker.Text = "RemoveMarker";
            this.RemoveMarker.Click += new System.EventHandler(this.RemoveMarker_Click);
            // 
            // RemoveRoute
            // 
            this.RemoveRoute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveRoute.Image = ((System.Drawing.Image)(resources.GetObject("RemoveRoute.Image")));
            this.RemoveRoute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveRoute.Name = "RemoveRoute";
            this.RemoveRoute.Size = new System.Drawing.Size(23, 22);
            this.RemoveRoute.Text = "RemoveRoute";
            this.RemoveRoute.Click += new System.EventHandler(this.RemoveRoute_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel1.Text = "Mission planner";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.map);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(267, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 398);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(533, 398);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            this.map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude";
            // 
            // textlat
            // 
            this.textlat.Location = new System.Drawing.Point(74, 63);
            this.textlat.Name = "textlat";
            this.textlat.Size = new System.Drawing.Size(100, 20);
            this.textlat.TabIndex = 2;
            this.textlat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtlongt
            // 
            this.txtlongt.Location = new System.Drawing.Point(74, 131);
            this.txtlongt.Name = "txtlongt";
            this.txtlongt.Size = new System.Drawing.Size(100, 20);
            this.txtlongt.TabIndex = 3;
            // 
            // btnLoadToMap
            // 
            this.btnLoadToMap.Location = new System.Drawing.Point(12, 185);
            this.btnLoadToMap.Name = "btnLoadToMap";
            this.btnLoadToMap.Size = new System.Drawing.Size(58, 25);
            this.btnLoadToMap.TabIndex = 4;
            this.btnLoadToMap.Text = "Load";
            this.btnLoadToMap.UseVisualStyleBackColor = true;
            this.btnLoadToMap.Click += new System.EventHandler(this.btnLoadToMap_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btnLoadToMap);
            this.panel2.Controls.Add(this.txtlongt);
            this.panel2.Controls.Add(this.textlat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 398);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddPoints;
        private System.Windows.Forms.ToolStripButton DrowRoute;
        private System.Windows.Forms.ToolStripButton RemoveMarker;
        private System.Windows.Forms.ToolStripButton RemoveRoute;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textlat;
        private System.Windows.Forms.TextBox txtlongt;
        private System.Windows.Forms.Button btnLoadToMap;
        private System.Windows.Forms.Panel panel2;
    }
}

