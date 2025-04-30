namespace Prajire
{
    partial class PhaseForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTemp
            // 
            this.grpTemp.Controls.Add(this.ctrlTemp);
            this.grpTemp.Location = new System.Drawing.Point(22, 22);
            this.grpTemp.Margin = new System.Windows.Forms.Padding(2);
            this.grpTemp.Name = "grpTemp";
            this.grpTemp.Padding = new System.Windows.Forms.Padding(2);
            this.grpTemp.Size = new System.Drawing.Size(150, 112);
            this.grpTemp.TabIndex = 1;
            this.grpTemp.TabStop = false;
            this.grpTemp.Text = "Temperatura";
            // 
            // ctrlTemp
            // 
            this.ctrlTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlTemp.Location = new System.Drawing.Point(2, 15);
            this.ctrlTemp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlTemp.MaxValue = 0;
            this.ctrlTemp.MinValue = 0;
            this.ctrlTemp.Name = "ctrlTemp";
            this.ctrlTemp.Size = new System.Drawing.Size(146, 95);
            this.ctrlTemp.Step = 0;
            this.ctrlTemp.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(22, 147);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Salveaza";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(22, 196);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Anuleaza";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PhaseForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(202, 246);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PhaseForm";
            this.Text = "Faza";
            this.grpTemp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTemp;
        private UpDownNumber ctrlTemp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}