namespace _2002807_Maeda_6._4
{
    partial class Form1
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addYourScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruneInput = new System.Windows.Forms.TextBox();
            this.appleInput = new System.Windows.Forms.TextBox();
            this.labelPrune = new System.Windows.Forms.Label();
            this.labelApple = new System.Windows.Forms.Label();
            this.boxTotal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPruneTotal = new System.Windows.Forms.Label();
            this.appleTotal = new System.Windows.Forms.TextBox();
            this.pruneTotal = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.boxTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(235, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addYourScoresToolStripMenuItem,
            this.toolStripSeparator1,
            this.summaryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addYourScoresToolStripMenuItem
            // 
            this.addYourScoresToolStripMenuItem.Name = "addYourScoresToolStripMenuItem";
            this.addYourScoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addYourScoresToolStripMenuItem.Text = "&Add Your Scores";
            this.addYourScoresToolStripMenuItem.Click += new System.EventHandler(this.addYourScoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // pruneInput
            // 
            this.pruneInput.Location = new System.Drawing.Point(42, 71);
            this.pruneInput.Name = "pruneInput";
            this.pruneInput.Size = new System.Drawing.Size(21, 20);
            this.pruneInput.TabIndex = 1;
            // 
            // appleInput
            // 
            this.appleInput.Location = new System.Drawing.Point(157, 71);
            this.appleInput.Name = "appleInput";
            this.appleInput.Size = new System.Drawing.Size(21, 20);
            this.appleInput.TabIndex = 2;
            // 
            // labelPrune
            // 
            this.labelPrune.AutoSize = true;
            this.labelPrune.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrune.Location = new System.Drawing.Point(16, 51);
            this.labelPrune.Name = "labelPrune";
            this.labelPrune.Size = new System.Drawing.Size(78, 17);
            this.labelPrune.TabIndex = 3;
            this.labelPrune.Text = "Prune Punch";
            // 
            // labelApple
            // 
            this.labelApple.AutoSize = true;
            this.labelApple.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApple.Location = new System.Drawing.Point(135, 47);
            this.labelApple.Name = "labelApple";
            this.labelApple.Size = new System.Drawing.Size(62, 21);
            this.labelApple.TabIndex = 4;
            this.labelApple.Text = "Apple Ade";
            // 
            // boxTotal
            // 
            this.boxTotal.Controls.Add(this.label1);
            this.boxTotal.Controls.Add(this.labelPruneTotal);
            this.boxTotal.Controls.Add(this.pruneTotal);
            this.boxTotal.Controls.Add(this.appleTotal);
            this.boxTotal.Location = new System.Drawing.Point(12, 127);
            this.boxTotal.Name = "boxTotal";
            this.boxTotal.Size = new System.Drawing.Size(199, 74);
            this.boxTotal.TabIndex = 7;
            this.boxTotal.TabStop = false;
            this.boxTotal.Text = "Total Scores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Apple Ade";
            // 
            // labelPruneTotal
            // 
            this.labelPruneTotal.AutoSize = true;
            this.labelPruneTotal.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPruneTotal.Location = new System.Drawing.Point(13, 20);
            this.labelPruneTotal.Name = "labelPruneTotal";
            this.labelPruneTotal.Size = new System.Drawing.Size(78, 17);
            this.labelPruneTotal.TabIndex = 10;
            this.labelPruneTotal.Text = "Prune Punch";
            // 
            // appleTotal
            // 
            this.appleTotal.Location = new System.Drawing.Point(145, 40);
            this.appleTotal.Name = "appleTotal";
            this.appleTotal.Size = new System.Drawing.Size(21, 20);
            this.appleTotal.TabIndex = 9;
            // 
            // pruneTotal
            // 
            this.pruneTotal.Location = new System.Drawing.Point(39, 40);
            this.pruneTotal.Name = "pruneTotal";
            this.pruneTotal.Size = new System.Drawing.Size(21, 20);
            this.pruneTotal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 213);
            this.Controls.Add(this.boxTotal);
            this.Controls.Add(this.labelApple);
            this.Controls.Add(this.labelPrune);
            this.Controls.Add(this.appleInput);
            this.Controls.Add(this.pruneInput);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "6.4";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.boxTotal.ResumeLayout(false);
            this.boxTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addYourScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox pruneInput;
        private System.Windows.Forms.TextBox appleInput;
        private System.Windows.Forms.Label labelPrune;
        private System.Windows.Forms.Label labelApple;
        private System.Windows.Forms.GroupBox boxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPruneTotal;
        private System.Windows.Forms.TextBox pruneTotal;
        private System.Windows.Forms.TextBox appleTotal;
    }
}

