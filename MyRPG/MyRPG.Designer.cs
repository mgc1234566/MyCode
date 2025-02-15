namespace MyRPG
{
    partial class MyRPG
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblHitPoints = new Label();
            lblGold = new Label();
            lblExperience = new Label();
            lblLevel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Hit Points:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 55);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Gold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 90);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 2;
            label3.Text = "Experience:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 125);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 3;
            label4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            lblHitPoints.AutoSize = true;
            lblHitPoints.Location = new Point(270, 20);
            lblHitPoints.Name = "lblHitPoints";
            lblHitPoints.Size = new Size(16, 25);
            lblHitPoints.TabIndex = 4;
            lblHitPoints.Text = ".";
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(270, 55);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(16, 25);
            lblGold.TabIndex = 5;
            lblGold.Text = ".";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(270, 90);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(16, 25);
            lblExperience.TabIndex = 6;
            lblExperience.Text = ".";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(270, 125);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(16, 25);
            lblLevel.TabIndex = 7;
            lblLevel.Text = ".";
            // 
            // MyRPG
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 1044);
            Controls.Add(lblLevel);
            Controls.Add(lblExperience);
            Controls.Add(lblGold);
            Controls.Add(lblHitPoints);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MyRPG";
            Text = "MyRPG";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblHitPoints;
        private Label lblGold;
        private Label lblExperience;
        private Label lblLevel;
    }
}
