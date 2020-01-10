namespace Task02
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(22, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 43);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Начать игру";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText1.Location = new System.Drawing.Point(182, 32);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(380, 20);
            this.lblText1.TabIndex = 1;
            this.lblText1.Text = "Я загадал число от 1 до 100. Угадай его :-)";
            this.lblText1.Visible = false;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Enabled = false;
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer.Location = new System.Drawing.Point(22, 92);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(133, 43);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Ввести ответ...";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswer.Location = new System.Drawing.Point(182, 67);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(94, 20);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Вы ввели:";
            this.lblAnswer.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(182, 102);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(313, 20);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Это число больше, чем загаданное";
            this.lblResult.Visible = false;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStep.Location = new System.Drawing.Point(182, 150);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(192, 20);
            this.lblStep.TabIndex = 6;
            this.lblStep.Text = "Использовано шагов:";
            this.lblStep.Visible = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAnswer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 220);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадайка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblStep;
    }
}

