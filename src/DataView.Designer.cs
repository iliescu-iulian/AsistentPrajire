namespace Prajire
{
    partial class DataView
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
            this.lvRoast = new System.Windows.Forms.ListView();
            this.colTemp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDelta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTimp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvRoast
            // 
            this.lvRoast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTemp,
            this.colDelta,
            this.colPower,
            this.colFan,
            this.colTimp,
            this.colEvent});
            this.lvRoast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRoast.FullRowSelect = true;
            this.lvRoast.GridLines = true;
            this.lvRoast.HideSelection = false;
            this.lvRoast.Location = new System.Drawing.Point(0, 0);
            this.lvRoast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvRoast.Name = "lvRoast";
            this.lvRoast.Size = new System.Drawing.Size(800, 450);
            this.lvRoast.TabIndex = 9;
            this.lvRoast.UseCompatibleStateImageBehavior = false;
            this.lvRoast.View = System.Windows.Forms.View.Details;
            // 
            // colTemp
            // 
            this.colTemp.Text = "Temp";
            // 
            // colDelta
            // 
            this.colDelta.Text = "ΔT";
            this.colDelta.Width = 40;
            // 
            // colPower
            // 
            this.colPower.Text = "Putere";
            // 
            // colFan
            // 
            this.colFan.Text = "Vent";
            // 
            // colTimp
            // 
            this.colTimp.Text = "Timp";
            // 
            // colEvent
            // 
            this.colEvent.Text = "Eveniment";
            this.colEvent.Width = 80;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvRoast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataView";
            this.Text = "DataView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRoast;
        private System.Windows.Forms.ColumnHeader colTemp;
        private System.Windows.Forms.ColumnHeader colPower;
        private System.Windows.Forms.ColumnHeader colFan;
        private System.Windows.Forms.ColumnHeader colTimp;
        private System.Windows.Forms.ColumnHeader colEvent;
        private System.Windows.Forms.ColumnHeader colDelta;
    }
}