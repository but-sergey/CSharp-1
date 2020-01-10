namespace Task01
{
    partial class frmMain
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStepCaption = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGBegin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTaskCaption = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblMaxStepCaption = new System.Windows.Forms.Label();
            this.lblMaxStep = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(195, 49);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(19, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "1";
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(255, 46);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(97, 23);
            this.btnCommand1.TabIndex = 1;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(255, 75);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(97, 23);
            this.btnCommand2.TabIndex = 2;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущее число:";
            // 
            // lblStepCaption
            // 
            this.lblStepCaption.AutoSize = true;
            this.lblStepCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStepCaption.Location = new System.Drawing.Point(23, 81);
            this.lblStepCaption.Name = "lblStepCaption";
            this.lblStepCaption.Size = new System.Drawing.Size(168, 17);
            this.lblStepCaption.TabIndex = 5;
            this.lblStepCaption.Text = "Использовано шагов:";
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep.Location = new System.Drawing.Point(197, 81);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(17, 17);
            this.lblStep.TabIndex = 6;
            this.lblStep.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuGame,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(48, 20);
            this.mnuFile.Text = "Файл";
            // 
            // mnuFExit
            // 
            this.mnuFExit.Name = "mnuFExit";
            this.mnuFExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFExit.Text = "Выход";
            this.mnuFExit.Click += new System.EventHandler(this.mnuFExit_Click);
            // 
            // mnuGame
            // 
            this.mnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGBegin,
            this.mnuGReset});
            this.mnuGame.Name = "mnuGame";
            this.mnuGame.Size = new System.Drawing.Size(46, 20);
            this.mnuGame.Text = "Игра";
            // 
            // mnuGBegin
            // 
            this.mnuGBegin.Name = "mnuGBegin";
            this.mnuGBegin.Size = new System.Drawing.Size(180, 22);
            this.mnuGBegin.Text = "Начать";
            this.mnuGBegin.Click += new System.EventHandler(this.mnuGBegin_Click);
            // 
            // mnuGReset
            // 
            this.mnuGReset.Name = "mnuGReset";
            this.mnuGReset.Size = new System.Drawing.Size(180, 22);
            this.mnuGReset.Text = "Сброс";
            this.mnuGReset.Click += new System.EventHandler(this.mnuGReset_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(65, 20);
            this.mnuHelp.Text = "Справка";
            // 
            // mnuHAbout
            // 
            this.mnuHAbout.Enabled = false;
            this.mnuHAbout.Name = "mnuHAbout";
            this.mnuHAbout.Size = new System.Drawing.Size(158, 22);
            this.mnuHAbout.Text = "О программе...";
            // 
            // lblTaskCaption
            // 
            this.lblTaskCaption.AutoSize = true;
            this.lblTaskCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskCaption.Location = new System.Drawing.Point(22, 134);
            this.lblTaskCaption.Name = "lblTaskCaption";
            this.lblTaskCaption.Size = new System.Drawing.Size(88, 20);
            this.lblTaskCaption.TabIndex = 9;
            this.lblTaskCaption.Text = "Задание:";
            this.lblTaskCaption.Visible = false;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTask.Location = new System.Drawing.Point(108, 134);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(19, 20);
            this.lblTask.TabIndex = 8;
            this.lblTask.Text = "1";
            this.lblTask.Visible = false;
            // 
            // lblMaxStepCaption
            // 
            this.lblMaxStepCaption.AutoSize = true;
            this.lblMaxStepCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxStepCaption.Location = new System.Drawing.Point(23, 154);
            this.lblMaxStepCaption.Name = "lblMaxStepCaption";
            this.lblMaxStepCaption.Size = new System.Drawing.Size(136, 17);
            this.lblMaxStepCaption.TabIndex = 10;
            this.lblMaxStepCaption.Text = "Максимум шагов:";
            this.lblMaxStepCaption.Visible = false;
            // 
            // lblMaxStep
            // 
            this.lblMaxStep.AutoSize = true;
            this.lblMaxStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxStep.Location = new System.Drawing.Point(165, 154);
            this.lblMaxStep.Name = "lblMaxStep";
            this.lblMaxStep.Size = new System.Drawing.Size(17, 17);
            this.lblMaxStep.TabIndex = 11;
            this.lblMaxStep.Text = "0";
            this.lblMaxStep.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(255, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена хода";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 182);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMaxStep);
            this.Controls.Add(this.lblMaxStepCaption);
            this.Controls.Add(this.lblTaskCaption);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.lblStepCaption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = " Удвоитель";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStepCaption;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFExit;
        private System.Windows.Forms.ToolStripMenuItem mnuGame;
        private System.Windows.Forms.ToolStripMenuItem mnuGBegin;
        private System.Windows.Forms.ToolStripMenuItem mnuGReset;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHAbout;
        private System.Windows.Forms.Label lblTaskCaption;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblMaxStepCaption;
        private System.Windows.Forms.Label lblMaxStep;
        private System.Windows.Forms.Button btnCancel;
    }
}

