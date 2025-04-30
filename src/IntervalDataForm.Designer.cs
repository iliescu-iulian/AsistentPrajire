namespace Prajire
{
    partial class IntervalDataForm
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
            this.grpTemp = new System.Windows.Forms.GroupBox();
            this.ctrlTemp = new Prajire.UpDownNumber();
            this.grpPower = new System.Windows.Forms.GroupBox();
            this.ctrlPower = new Prajire.UpDownNumber();
            this.grpVent = new System.Windows.Forms.GroupBox();
            this.ctrlVent = new Prajire.UpDownNumber();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpTemp.SuspendLayout();
            this.grpPower.SuspendLayout();
            this.grpVent.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTemp
            // 
            this.grpTemp.Controls.Add(this.ctrlTemp);
            this.grpTemp.Location = new System.Drawing.Point(28, 28);
            this.grpTemp.Name = "grpTemp";
            this.grpTemp.Size = new System.Drawing.Size(200, 138);
            this.grpTemp.TabIndex = 0;
            this.grpTemp.TabStop = false;
            this.grpTemp.Text = "Temperatura";
            // 
            // ctrlTemp
            // 
            this.ctrlTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlTemp.Location = new System.Drawing.Point(3, 18);
            this.ctrlTemp.MaxValue = 0;
            this.ctrlTemp.MinValue = 0;
            this.ctrlTemp.Name = "ctrlTemp";
            this.ctrlTemp.Size = new System.Drawing.Size(194, 117);
            this.ctrlTemp.Step = 0;
            this.ctrlTemp.TabIndex = 0;
            // 
            // grpPower
            // 
            this.grpPower.Controls.Add(this.ctrlPower);
            this.grpPower.Location = new System.Drawing.Point(249, 29);
            this.grpPower.Name = "grpPower";
            this.grpPower.Size = new System.Drawing.Size(200, 137);
            this.grpPower.TabIndex = 2;
            this.grpPower.TabStop = false;
            this.grpPower.Text = "Putere";
            // 
            // ctrlPower
            // 
            this.ctrlPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPower.Location = new System.Drawing.Point(3, 18);
            this.ctrlPower.MaxValue = 0;
            this.ctrlPower.MinValue = 0;
            this.ctrlPower.Name = "ctrlPower";
            this.ctrlPower.Size = new System.Drawing.Size(194, 116);
            this.ctrlPower.Step = 0;
            this.ctrlPower.TabIndex = 0;
            // 
            // grpVent
            // 
            this.grpVent.Controls.Add(this.ctrlVent);
            this.grpVent.Location = new System.Drawing.Point(472, 29);
            this.grpVent.Name = "grpVent";
            this.grpVent.Size = new System.Drawing.Size(200, 137);
            this.grpVent.TabIndex = 3;
            this.grpVent.TabStop = false;
            this.grpVent.Text = "Ventilatie";
            // 
            // ctrlVent
            // 
            this.ctrlVent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlVent.Location = new System.Drawing.Point(3, 18);
            this.ctrlVent.MaxValue = 0;
            this.ctrlVent.MinValue = 0;
            this.ctrlVent.Name = "ctrlVent";
            this.ctrlVent.Size = new System.Drawing.Size(194, 116);
            this.ctrlVent.Step = 0;
            this.ctrlVent.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(28, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Salveaza";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(481, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(191, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Anuleaza";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // IntervalDataForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(702, 264);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpVent);
            this.Controls.Add(this.grpPower);
            this.Controls.Add(this.grpTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IntervalDataForm";
            this.Text = "Data";
            this.grpTemp.ResumeLayout(false);
            this.grpPower.ResumeLayout(false);
            this.grpVent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTemp;
        private UpDownNumber ctrlTemp;
        private System.Windows.Forms.GroupBox grpPower;
        private UpDownNumber ctrlPower;
        private System.Windows.Forms.GroupBox grpVent;
        private UpDownNumber ctrlVent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}