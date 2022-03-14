namespace MineSweeper
{
    partial class MineSweeper
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
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.CellPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(57, 3);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(62, 17);
            this.Medium.TabIndex = 0;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Location = new System.Drawing.Point(125, 3);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(48, 17);
            this.Hard.TabIndex = 0;
            this.Hard.TabStop = true;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(282, 0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(96, 34);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Easy);
            this.panel1.Controls.Add(this.Medium);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.Hard);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 34);
            this.panel1.TabIndex = 3;
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Location = new System.Drawing.Point(0, 3);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(48, 17);
            this.Easy.TabIndex = 2;
            this.Easy.TabStop = true;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // CellPanel
            // 
            this.CellPanel.Location = new System.Drawing.Point(0, 40);
            this.CellPanel.Name = "CellPanel";
            this.CellPanel.Size = new System.Drawing.Size(381, 319);
            this.CellPanel.TabIndex = 3;
            // 
            // MineSweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 358);
            this.Controls.Add(this.CellPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MineSweeper";
            this.Text = "MineSweeper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.FlowLayoutPanel CellPanel;
    }
}

