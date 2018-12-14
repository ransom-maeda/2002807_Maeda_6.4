namespace _2002807_Maeda_6._4
{
    partial class summary
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
            this.exit = new System.Windows.Forms.Button();
            this.labelTesters = new System.Windows.Forms.Label();
            this.testerAmount = new System.Windows.Forms.TextBox();
            this.labelWinner = new System.Windows.Forms.Label();
            this.labelAverageA = new System.Windows.Forms.Label();
            this.averageAOutput = new System.Windows.Forms.TextBox();
            this.averagePOutput = new System.Windows.Forms.TextBox();
            this.labelAverageP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 244);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Okay";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // labelTesters
            // 
            this.labelTesters.AutoSize = true;
            this.labelTesters.Location = new System.Drawing.Point(74, 9);
            this.labelTesters.Name = "labelTesters";
            this.labelTesters.Size = new System.Drawing.Size(93, 13);
            this.labelTesters.TabIndex = 1;
            this.labelTesters.Text = "Amount of Testers";
            // 
            // testerAmount
            // 
            this.testerAmount.Location = new System.Drawing.Point(106, 25);
            this.testerAmount.Name = "testerAmount";
            this.testerAmount.Size = new System.Drawing.Size(21, 20);
            this.testerAmount.TabIndex = 2;
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinner.Location = new System.Drawing.Point(51, 95);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(0, 23);
            this.labelWinner.TabIndex = 3;
            // 
            // labelAverageA
            // 
            this.labelAverageA.AutoSize = true;
            this.labelAverageA.Location = new System.Drawing.Point(12, 165);
            this.labelAverageA.Name = "labelAverageA";
            this.labelAverageA.Size = new System.Drawing.Size(108, 13);
            this.labelAverageA.TabIndex = 4;
            this.labelAverageA.Text = "Average Apple Score";
            // 
            // averageAOutput
            // 
            this.averageAOutput.Location = new System.Drawing.Point(126, 162);
            this.averageAOutput.Name = "averageAOutput";
            this.averageAOutput.Size = new System.Drawing.Size(100, 20);
            this.averageAOutput.TabIndex = 5;
            // 
            // averagePOutput
            // 
            this.averagePOutput.Location = new System.Drawing.Point(126, 188);
            this.averagePOutput.Name = "averagePOutput";
            this.averagePOutput.Size = new System.Drawing.Size(100, 20);
            this.averagePOutput.TabIndex = 7;
            // 
            // labelAverageP
            // 
            this.labelAverageP.AutoSize = true;
            this.labelAverageP.Location = new System.Drawing.Point(12, 191);
            this.labelAverageP.Name = "labelAverageP";
            this.labelAverageP.Size = new System.Drawing.Size(109, 13);
            this.labelAverageP.TabIndex = 6;
            this.labelAverageP.Text = "Average Prune Score";
            // 
            // summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 273);
            this.Controls.Add(this.averagePOutput);
            this.Controls.Add(this.labelAverageP);
            this.Controls.Add(this.averageAOutput);
            this.Controls.Add(this.labelAverageA);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.testerAmount);
            this.Controls.Add(this.labelTesters);
            this.Controls.Add(this.exit);
            this.Name = "summary";
            this.Text = "summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label labelTesters;
        private System.Windows.Forms.TextBox testerAmount;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Label labelAverageA;
        private System.Windows.Forms.TextBox averageAOutput;
        private System.Windows.Forms.TextBox averagePOutput;
        private System.Windows.Forms.Label labelAverageP;
    }
}