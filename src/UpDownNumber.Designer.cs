namespace Prajire
{
    partial class UpDownNumber
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnCustrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(14, 21);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(45, 44);
            this.btnDown.TabIndex = 0;
            this.btnDown.Text = "-";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(131, 21);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(45, 44);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "+";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblValue
            // 
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(65, 21);
            this.lblValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblValue.Size = new System.Drawing.Size(61, 44);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "9";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCustrom
            // 
            this.btnCustrom.Location = new System.Drawing.Point(14, 71);
            this.btnCustrom.Name = "btnCustrom";
            this.btnCustrom.Size = new System.Drawing.Size(162, 34);
            this.btnCustrom.TabIndex = 4;
            this.btnCustrom.Text = "Manual";
            this.btnCustrom.UseVisualStyleBackColor = true;
            this.btnCustrom.Click += new System.EventHandler(this.btnCustrom_Click);
            // 
            // UpDownNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCustrom);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Name = "UpDownNumber";
            this.Size = new System.Drawing.Size(196, 129);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnCustrom;
    }
}
