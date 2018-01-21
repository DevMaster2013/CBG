namespace Game
{
    partial class frmMainGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBuildings = new System.Windows.Forms.ComboBox();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blkszBuildingSize = new Game.InterfaceControllers.UtilityControls.BlockSizeControl();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBuildings = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.farmControl = new Game.InterfaceControllers.FarmControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentGameTime = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building:";
            // 
            // cmdBuildings
            // 
            this.cmdBuildings.FormattingEnabled = true;
            this.cmdBuildings.Items.AddRange(new object[] {
            "Farm"});
            this.cmdBuildings.Location = new System.Drawing.Point(66, 10);
            this.cmdBuildings.Name = "cmdBuildings";
            this.cmdBuildings.Size = new System.Drawing.Size(157, 21);
            this.cmdBuildings.TabIndex = 1;
            this.cmdBuildings.SelectedIndexChanged += new System.EventHandler(this.cmdBuildings_SelectedIndexChanged);
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.Location = new System.Drawing.Point(229, 8);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(75, 23);
            this.btnAddBuilding.TabIndex = 2;
            this.btnAddBuilding.Text = "Add Building";
            this.btnAddBuilding.UseVisualStyleBackColor = true;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blkszBuildingSize);
            this.groupBox1.Controls.Add(this.txtBuildingName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Building Info";
            // 
            // blkszBuildingSize
            // 
            this.blkszBuildingSize.Location = new System.Drawing.Point(51, 42);
            this.blkszBuildingSize.Name = "blkszBuildingSize";
            this.blkszBuildingSize.ReadOnly = true;
            this.blkszBuildingSize.Size = new System.Drawing.Size(186, 20);
            this.blkszBuildingSize.TabIndex = 3;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(51, 17);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.ReadOnly = true;
            this.txtBuildingName.Size = new System.Drawing.Size(231, 20);
            this.txtBuildingName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // lstBuildings
            // 
            this.lstBuildings.DisplayMember = "Name";
            this.lstBuildings.FormattingEnabled = true;
            this.lstBuildings.Location = new System.Drawing.Point(16, 111);
            this.lstBuildings.Name = "lstBuildings";
            this.lstBuildings.Size = new System.Drawing.Size(288, 368);
            this.lstBuildings.TabIndex = 4;
            this.lstBuildings.SelectedIndexChanged += new System.EventHandler(this.lstBuildings_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.farmControl);
            this.groupBox2.Location = new System.Drawing.Point(311, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 368);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Building Controller";
            // 
            // farmControl
            // 
            this.farmControl.Farm = null;
            this.farmControl.Location = new System.Drawing.Point(6, 19);
            this.farmControl.Name = "farmControl";
            this.farmControl.Size = new System.Drawing.Size(293, 205);
            this.farmControl.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCurrentGameTime);
            this.groupBox3.Location = new System.Drawing.Point(317, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 96);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Current Time:";
            // 
            // txtCurrentGameTime
            // 
            this.txtCurrentGameTime.Location = new System.Drawing.Point(86, 17);
            this.txtCurrentGameTime.Name = "txtCurrentGameTime";
            this.txtCurrentGameTime.ReadOnly = true;
            this.txtCurrentGameTime.Size = new System.Drawing.Size(207, 20);
            this.txtCurrentGameTime.TabIndex = 0;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstBuildings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddBuilding);
            this.Controls.Add(this.cmdBuildings);
            this.Controls.Add(this.label1);
            this.Name = "frmMainGame";
            this.Text = "City Building Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdBuildings;
        private System.Windows.Forms.Button btnAddBuilding;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.ListBox lstBuildings;
        private InterfaceControllers.UtilityControls.BlockSizeControl blkszBuildingSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private InterfaceControllers.FarmControl farmControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentGameTime;
        private System.Windows.Forms.Timer gameTimer;
    }
}

