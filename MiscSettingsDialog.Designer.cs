namespace uWAVE_Host
{
    partial class MiscSettingsDialog
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.periodMsEdit = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isBatVCxb = new System.Windows.Forms.CheckBox();
            this.isDepthCxb = new System.Windows.Forms.CheckBox();
            this.isTempCxb = new System.Windows.Forms.CheckBox();
            this.isPressureCxb = new System.Windows.Forms.CheckBox();
            this.isSaveInFlashCxb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.periodMsEdit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(241, 270);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(93, 34);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBtn.Location = new System.Drawing.Point(117, 270);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(93, 34);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update period, ms (0 - never)";
            // 
            // periodMsEdit
            // 
            this.periodMsEdit.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.periodMsEdit.Location = new System.Drawing.Point(214, 70);
            this.periodMsEdit.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.periodMsEdit.Name = "periodMsEdit";
            this.periodMsEdit.Size = new System.Drawing.Size(120, 22);
            this.periodMsEdit.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isBatVCxb);
            this.groupBox1.Controls.Add(this.isDepthCxb);
            this.groupBox1.Controls.Add(this.isTempCxb);
            this.groupBox1.Controls.Add(this.isPressureCxb);
            this.groupBox1.Location = new System.Drawing.Point(16, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 166);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items to update";
            // 
            // isBatVCxb
            // 
            this.isBatVCxb.AutoSize = true;
            this.isBatVCxb.Location = new System.Drawing.Point(6, 115);
            this.isBatVCxb.Name = "isBatVCxb";
            this.isBatVCxb.Size = new System.Drawing.Size(164, 21);
            this.isBatVCxb.TabIndex = 11;
            this.isBatVCxb.Text = "Power supply voltage";
            this.isBatVCxb.UseVisualStyleBackColor = true;
            // 
            // isDepthCxb
            // 
            this.isDepthCxb.AutoSize = true;
            this.isDepthCxb.Location = new System.Drawing.Point(6, 88);
            this.isDepthCxb.Name = "isDepthCxb";
            this.isDepthCxb.Size = new System.Drawing.Size(68, 21);
            this.isDepthCxb.TabIndex = 10;
            this.isDepthCxb.Text = "Depth";
            this.isDepthCxb.UseVisualStyleBackColor = true;
            // 
            // isTempCxb
            // 
            this.isTempCxb.AutoSize = true;
            this.isTempCxb.Location = new System.Drawing.Point(6, 61);
            this.isTempCxb.Name = "isTempCxb";
            this.isTempCxb.Size = new System.Drawing.Size(112, 21);
            this.isTempCxb.TabIndex = 9;
            this.isTempCxb.Text = "Temperature";
            this.isTempCxb.UseVisualStyleBackColor = true;
            // 
            // isPressureCxb
            // 
            this.isPressureCxb.AutoSize = true;
            this.isPressureCxb.Location = new System.Drawing.Point(6, 34);
            this.isPressureCxb.Name = "isPressureCxb";
            this.isPressureCxb.Size = new System.Drawing.Size(87, 21);
            this.isPressureCxb.TabIndex = 8;
            this.isPressureCxb.Text = "Pressure";
            this.isPressureCxb.UseVisualStyleBackColor = true;
            // 
            // isSaveInFlashCxb
            // 
            this.isSaveInFlashCxb.AutoSize = true;
            this.isSaveInFlashCxb.Location = new System.Drawing.Point(16, 33);
            this.isSaveInFlashCxb.Name = "isSaveInFlashCxb";
            this.isSaveInFlashCxb.Size = new System.Drawing.Size(164, 21);
            this.isSaveInFlashCxb.TabIndex = 12;
            this.isSaveInFlashCxb.Text = "Save settings in flash";
            this.isSaveInFlashCxb.UseVisualStyleBackColor = true;
            // 
            // MiscSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 316);
            this.Controls.Add(this.isSaveInFlashCxb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.periodMsEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "MiscSettingsDialog";
            this.Text = "MiscSettingsDialog";
            ((System.ComponentModel.ISupportInitialize)(this.periodMsEdit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown periodMsEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox isBatVCxb;
        private System.Windows.Forms.CheckBox isDepthCxb;
        private System.Windows.Forms.CheckBox isTempCxb;
        private System.Windows.Forms.CheckBox isPressureCxb;
        private System.Windows.Forms.CheckBox isSaveInFlashCxb;
    }
}