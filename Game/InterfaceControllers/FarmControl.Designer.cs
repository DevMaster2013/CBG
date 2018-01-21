namespace Game.InterfaceControllers
{
    partial class FarmControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentCropName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCrops = new System.Windows.Forms.ComboBox();
            this.btnChangeCrop = new System.Windows.Forms.Button();
            this.blkszFarmSize = new Game.InterfaceControllers.UtilityControls.BlockSizeControl();
            this.productionInfo = new Game.InterfaceControllers.UtilityControls.ProductionInfoControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 0);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Crop:";
            // 
            // txtCurrentCropName
            // 
            this.txtCurrentCropName.Location = new System.Drawing.Point(82, 49);
            this.txtCurrentCropName.Name = "txtCurrentCropName";
            this.txtCurrentCropName.ReadOnly = true;
            this.txtCurrentCropName.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentCropName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Crop:";
            // 
            // cmbCrops
            // 
            this.cmbCrops.FormattingEnabled = true;
            this.cmbCrops.Items.AddRange(new object[] {
            "Wheat"});
            this.cmbCrops.Location = new System.Drawing.Point(82, 75);
            this.cmbCrops.Name = "cmbCrops";
            this.cmbCrops.Size = new System.Drawing.Size(127, 21);
            this.cmbCrops.TabIndex = 7;
            // 
            // btnChangeCrop
            // 
            this.btnChangeCrop.Location = new System.Drawing.Point(215, 73);
            this.btnChangeCrop.Name = "btnChangeCrop";
            this.btnChangeCrop.Size = new System.Drawing.Size(75, 23);
            this.btnChangeCrop.TabIndex = 8;
            this.btnChangeCrop.Text = "Change";
            this.btnChangeCrop.UseVisualStyleBackColor = true;
            this.btnChangeCrop.Click += new System.EventHandler(this.btnChangeCrop_Click);
            // 
            // blkszFarmSize
            // 
            this.blkszFarmSize.Location = new System.Drawing.Point(82, 25);
            this.blkszFarmSize.Name = "blkszFarmSize";
            this.blkszFarmSize.ReadOnly = true;
            this.blkszFarmSize.Size = new System.Drawing.Size(186, 20);
            this.blkszFarmSize.TabIndex = 3;
            // 
            // productionInfo
            // 
            this.productionInfo.Location = new System.Drawing.Point(2, 102);
            this.productionInfo.Name = "productionInfo";
            this.productionInfo.ProductionBuilding = null;
            this.productionInfo.Size = new System.Drawing.Size(204, 103);
            this.productionInfo.TabIndex = 9;
            // 
            // FarmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productionInfo);
            this.Controls.Add(this.btnChangeCrop);
            this.Controls.Add(this.cmbCrops);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCurrentCropName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blkszFarmSize);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FarmControl";
            this.Size = new System.Drawing.Size(292, 205);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private UtilityControls.BlockSizeControl blkszFarmSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentCropName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCrops;
        private System.Windows.Forms.Button btnChangeCrop;
        private UtilityControls.ProductionInfoControl productionInfo;
    }
}
