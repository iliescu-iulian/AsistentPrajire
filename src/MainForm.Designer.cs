namespace Prajire
{
    partial class MainForm
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
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblFan = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lvRoast = new System.Windows.Forms.ListView();
            this.colTemp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTimp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmSamples = new System.Windows.Forms.Timer(this.components);
            this.tmElapsed = new System.Windows.Forms.Timer(this.components);
            this.lblElapsed = new System.Windows.Forms.Label();
            this.btnDryEnd = new System.Windows.Forms.Button();
            this.btnFirstCrack = new System.Windows.Forms.Button();
            this.lblDryEnd = new System.Windows.Forms.Label();
            this.lblFirstCrach = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVArtisanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVArtisanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.btnTurningPoint = new System.Windows.Forms.Button();
            this.lblTurningPoint = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(33, 39);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(80, 29);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "T: 000";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(157, 39);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(80, 29);
            this.lblPower.TabIndex = 1;
            this.lblPower.Text = "P: 000";
            // 
            // lblFan
            // 
            this.lblFan.AutoSize = true;
            this.lblFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFan.Location = new System.Drawing.Point(283, 39);
            this.lblFan.Name = "lblFan";
            this.lblFan.Size = new System.Drawing.Size(79, 29);
            this.lblFan.TabIndex = 2;
            this.lblFan.Text = "F: 000";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelta.Location = new System.Drawing.Point(33, 94);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(95, 29);
            this.lblDelta.TabIndex = 3;
            this.lblDelta.Text = "ΔT: 000";
            // 
            // btnInit
            // 
            this.btnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.Location = new System.Drawing.Point(445, 39);
            this.btnInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(95, 41);
            this.btnInit.TabIndex = 5;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(563, 39);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 41);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(681, 39);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(95, 41);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lvRoast
            // 
            this.lvRoast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTemp,
            this.colPower,
            this.colFan,
            this.colRor,
            this.colTimp,
            this.colEvent});
            this.lvRoast.FullRowSelect = true;
            this.lvRoast.GridLines = true;
            this.lvRoast.HideSelection = false;
            this.lvRoast.Location = new System.Drawing.Point(37, 299);
            this.lvRoast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvRoast.Name = "lvRoast";
            this.lvRoast.Size = new System.Drawing.Size(737, 235);
            this.lvRoast.TabIndex = 8;
            this.lvRoast.UseCompatibleStateImageBehavior = false;
            this.lvRoast.View = System.Windows.Forms.View.Details;
            // 
            // colTemp
            // 
            this.colTemp.Text = "Temp";
            // 
            // colPower
            // 
            this.colPower.Text = "Putere";
            // 
            // colFan
            // 
            this.colFan.Text = "Vent";
            // 
            // colRor
            // 
            this.colRor.Text = "ΔT";
            // 
            // colTimp
            // 
            this.colTimp.Text = "Timp";
            // 
            // colEvent
            // 
            this.colEvent.Text = "Eveniment";
            // 
            // tmSamples
            // 
            this.tmSamples.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmElapsed
            // 
            this.tmElapsed.Interval = 1000;
            this.tmElapsed.Tick += new System.EventHandler(this.tmElapsed_Tick);
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsed.Location = new System.Drawing.Point(440, 178);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(103, 29);
            this.lblElapsed.TabIndex = 9;
            this.lblElapsed.Text = "00.00.00";
            this.lblElapsed.Visible = false;
            // 
            // btnDryEnd
            // 
            this.btnDryEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDryEnd.Location = new System.Drawing.Point(507, 89);
            this.btnDryEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDryEnd.Name = "btnDryEnd";
            this.btnDryEnd.Size = new System.Drawing.Size(81, 41);
            this.btnDryEnd.TabIndex = 10;
            this.btnDryEnd.Text = "DE";
            this.btnDryEnd.UseVisualStyleBackColor = true;
            this.btnDryEnd.Click += new System.EventHandler(this.btnDryEnd_Click);
            // 
            // btnFirstCrack
            // 
            this.btnFirstCrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstCrack.Location = new System.Drawing.Point(629, 89);
            this.btnFirstCrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirstCrack.Name = "btnFirstCrack";
            this.btnFirstCrack.Size = new System.Drawing.Size(81, 41);
            this.btnFirstCrack.TabIndex = 11;
            this.btnFirstCrack.Text = "FC";
            this.btnFirstCrack.UseVisualStyleBackColor = true;
            this.btnFirstCrack.Click += new System.EventHandler(this.btnFirstCrack_Click);
            // 
            // lblDryEnd
            // 
            this.lblDryEnd.AutoSize = true;
            this.lblDryEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDryEnd.Location = new System.Drawing.Point(496, 132);
            this.lblDryEnd.Name = "lblDryEnd";
            this.lblDryEnd.Size = new System.Drawing.Size(103, 29);
            this.lblDryEnd.TabIndex = 12;
            this.lblDryEnd.Text = "00.00.00";
            this.lblDryEnd.Visible = false;
            // 
            // lblFirstCrach
            // 
            this.lblFirstCrach.AutoSize = true;
            this.lblFirstCrach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstCrach.Location = new System.Drawing.Point(617, 132);
            this.lblFirstCrach.Name = "lblFirstCrach";
            this.lblFirstCrach.Size = new System.Drawing.Size(103, 29);
            this.lblFirstCrach.TabIndex = 13;
            this.lblFirstCrach.Text = "00.00.00";
            this.lblFirstCrach.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importDateToolStripMenuItem
            // 
            this.importDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.importDateToolStripMenuItem.Name = "importDateToolStripMenuItem";
            this.importDateToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.importDateToolStripMenuItem.Text = "&Optiuni";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem1,
            this.cSVArtisanToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importToolStripMenuItem.Text = "&Import";
            // 
            // cSVToolStripMenuItem1
            // 
            this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.cSVToolStripMenuItem1.Text = "CSV";
            this.cSVToolStripMenuItem1.Click += new System.EventHandler(this.ImportCsvMenuItem_Click);
            // 
            // cSVArtisanToolStripMenuItem
            // 
            this.cSVArtisanToolStripMenuItem.Name = "cSVArtisanToolStripMenuItem";
            this.cSVArtisanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cSVArtisanToolStripMenuItem.Text = "CSV Artisan";
            this.cSVArtisanToolStripMenuItem.Click += new System.EventHandler(this.cSVArtisanToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem,
            this.cSVArtisanToolStripMenuItem1});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.ExportCsvMenuItem_Click);
            // 
            // cSVArtisanToolStripMenuItem1
            // 
            this.cSVArtisanToolStripMenuItem1.Name = "cSVArtisanToolStripMenuItem1";
            this.cSVArtisanToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.cSVArtisanToolStripMenuItem1.Text = "CSV Artisan";
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "Csv files|*.csv";
            // 
            // dlgSave
            // 
            this.dlgSave.CheckFileExists = true;
            this.dlgSave.DefaultExt = "csv";
            this.dlgSave.Filter = "CSV files|*.csv";
            // 
            // btnTurningPoint
            // 
            this.btnTurningPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurningPoint.Location = new System.Drawing.Point(381, 89);
            this.btnTurningPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTurningPoint.Name = "btnTurningPoint";
            this.btnTurningPoint.Size = new System.Drawing.Size(81, 41);
            this.btnTurningPoint.TabIndex = 15;
            this.btnTurningPoint.Text = "TP";
            this.btnTurningPoint.UseVisualStyleBackColor = true;
            this.btnTurningPoint.Click += new System.EventHandler(this.btnTurningPoint_Click);
            // 
            // lblTurningPoint
            // 
            this.lblTurningPoint.AutoSize = true;
            this.lblTurningPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurningPoint.Location = new System.Drawing.Point(369, 132);
            this.lblTurningPoint.Name = "lblTurningPoint";
            this.lblTurningPoint.Size = new System.Drawing.Size(103, 29);
            this.lblTurningPoint.TabIndex = 16;
            this.lblTurningPoint.Text = "00.00.00";
            this.lblTurningPoint.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.lblTurningPoint);
            this.Controls.Add(this.btnTurningPoint);
            this.Controls.Add(this.lblFirstCrach);
            this.Controls.Add(this.lblDryEnd);
            this.Controls.Add(this.btnFirstCrack);
            this.Controls.Add(this.btnDryEnd);
            this.Controls.Add(this.lblElapsed);
            this.Controls.Add(this.lvRoast);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.lblFan);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Prajire";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblFan;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListView lvRoast;
        private System.Windows.Forms.Timer tmSamples;
        private System.Windows.Forms.ColumnHeader colTemp;
        private System.Windows.Forms.ColumnHeader colPower;
        private System.Windows.Forms.ColumnHeader colFan;
        private System.Windows.Forms.ColumnHeader colRor;
        private System.Windows.Forms.ColumnHeader colTimp;
        private System.Windows.Forms.Timer tmElapsed;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Button btnDryEnd;
        private System.Windows.Forms.Button btnFirstCrack;
        private System.Windows.Forms.Label lblDryEnd;
        private System.Windows.Forms.Label lblFirstCrach;
        private System.Windows.Forms.ColumnHeader colEvent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cSVArtisanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVArtisanToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnTurningPoint;
        private System.Windows.Forms.Label lblTurningPoint;
    }
}

