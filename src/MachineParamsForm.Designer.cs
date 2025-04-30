namespace Prajire
{
    partial class MachineParamsForm
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
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblVent = new System.Windows.Forms.Label();
            this.numTemp = new System.Windows.Forms.NumericUpDown();
            this.numPower = new System.Windows.Forms.NumericUpDown();
            this.numVent = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(24, 32);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(88, 16);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Temperatura:";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(184, 32);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(49, 16);
            this.lblPower.TabIndex = 1;
            this.lblPower.Text = "Putere:";
            // 
            // lblVent
            // 
            this.lblVent.AutoSize = true;
            this.lblVent.Location = new System.Drawing.Point(346, 32);
            this.lblVent.Name = "lblVent";
            this.lblVent.Size = new System.Drawing.Size(65, 16);
            this.lblVent.TabIndex = 2;
            this.lblVent.Text = "Ventilatie:";
            // 
            // numTemp
            // 
            this.numTemp.Location = new System.Drawing.Point(27, 55);
            this.numTemp.Maximum = new decimal(new int[] {
            230,
            0,
            0,
            0});
            this.numTemp.Name = "numTemp";
            this.numTemp.Size = new System.Drawing.Size(120, 22);
            this.numTemp.TabIndex = 3;
            // 
            // numPower
            // 
            this.numPower.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPower.Location = new System.Drawing.Point(187, 55);
            this.numPower.Name = "numPower";
            this.numPower.Size = new System.Drawing.Size(120, 22);
            this.numPower.TabIndex = 4;
            // 
            // numVent
            // 
            this.numVent.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numVent.Location = new System.Drawing.Point(349, 55);
            this.numVent.Name = "numVent";
            this.numVent.Size = new System.Drawing.Size(120, 22);
            this.numVent.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(27, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Salveaza";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(349, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Anuleaza";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // numInterval
            // 
            this.numInterval.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numInterval.Location = new System.Drawing.Point(187, 113);
            this.numInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 22);
            this.numInterval.TabIndex = 9;
            this.numInterval.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(184, 94);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(71, 16);
            this.lblInterval.TabIndex = 8;
            this.lblInterval.Text = "Interval (s):";
            // 
            // MachineParamsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(506, 214);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numVent);
            this.Controls.Add(this.numPower);
            this.Controls.Add(this.numTemp);
            this.Controls.Add(this.lblVent);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MachineParamsForm";
            this.Text = "Parametrii";
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblVent;
        private System.Windows.Forms.NumericUpDown numTemp;
        private System.Windows.Forms.NumericUpDown numPower;
        private System.Windows.Forms.NumericUpDown numVent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label lblInterval;
    }
}