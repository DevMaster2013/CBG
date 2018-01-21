namespace Game.InterfaceControllers.UtilityControls
{
    partial class ProductionInfoControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalRunningTime = new System.Windows.Forms.TextBox();
            this.txtProductionRate = new System.Windows.Forms.TextBox();
            this.txtTotalProduction = new System.Windows.Forms.TextBox();
            this.prgProductinoProgress = new System.Windows.Forms.ProgressBar();
            this.btnStopProduction = new System.Windows.Forms.Button();
            this.btnStartProduction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Running Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Production Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Production:";
            // 
            // txtTotalRunningTime
            // 
            this.txtTotalRunningTime.Location = new System.Drawing.Point(104, 0);
            this.txtTotalRunningTime.Name = "txtTotalRunningTime";
            this.txtTotalRunningTime.ReadOnly = true;
            this.txtTotalRunningTime.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRunningTime.TabIndex = 7;
            // 
            // txtProductionRate
            // 
            this.txtProductionRate.Location = new System.Drawing.Point(104, 26);
            this.txtProductionRate.Name = "txtProductionRate";
            this.txtProductionRate.ReadOnly = true;
            this.txtProductionRate.Size = new System.Drawing.Size(100, 20);
            this.txtProductionRate.TabIndex = 9;
            // 
            // txtTotalProduction
            // 
            this.txtTotalProduction.Location = new System.Drawing.Point(104, 52);
            this.txtTotalProduction.Name = "txtTotalProduction";
            this.txtTotalProduction.ReadOnly = true;
            this.txtTotalProduction.Size = new System.Drawing.Size(100, 20);
            this.txtTotalProduction.TabIndex = 10;
            // 
            // prgProductinoProgress
            // 
            this.prgProductinoProgress.Location = new System.Drawing.Point(0, 104);
            this.prgProductinoProgress.Name = "prgProductinoProgress";
            this.prgProductinoProgress.Size = new System.Drawing.Size(204, 23);
            this.prgProductinoProgress.TabIndex = 11;
            // 
            // btnStopProduction
            // 
            this.btnStopProduction.Location = new System.Drawing.Point(105, 77);
            this.btnStopProduction.Name = "btnStopProduction";
            this.btnStopProduction.Size = new System.Drawing.Size(95, 23);
            this.btnStopProduction.TabIndex = 12;
            this.btnStopProduction.Text = "Stop Production";
            this.btnStopProduction.UseVisualStyleBackColor = true;
            this.btnStopProduction.Click += new System.EventHandler(this.btnStopProduction_Click);
            // 
            // btnStartProduction
            // 
            this.btnStartProduction.Location = new System.Drawing.Point(4, 77);
            this.btnStartProduction.Name = "btnStartProduction";
            this.btnStartProduction.Size = new System.Drawing.Size(95, 23);
            this.btnStartProduction.TabIndex = 13;
            this.btnStartProduction.Text = "Start Production";
            this.btnStartProduction.UseVisualStyleBackColor = true;
            this.btnStartProduction.Click += new System.EventHandler(this.btnStartProduction_Click);
            // 
            // ProductionInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStopProduction);
            this.Controls.Add(this.btnStartProduction);
            this.Controls.Add(this.prgProductinoProgress);
            this.Controls.Add(this.txtTotalProduction);
            this.Controls.Add(this.txtProductionRate);
            this.Controls.Add(this.txtTotalRunningTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductionInfoControl";
            this.Size = new System.Drawing.Size(204, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalRunningTime;
        private System.Windows.Forms.TextBox txtProductionRate;
        private System.Windows.Forms.TextBox txtTotalProduction;
        private System.Windows.Forms.ProgressBar prgProductinoProgress;
        private System.Windows.Forms.Button btnStopProduction;
        private System.Windows.Forms.Button btnStartProduction;
    }
}
