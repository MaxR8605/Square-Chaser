namespace Square_Chaser
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.maxPointsInput = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Label();
            this.helpLabel1 = new System.Windows.Forms.Label();
            this.helpLabel2 = new System.Windows.Forms.Label();
            this.helpLabel3 = new System.Windows.Forms.Label();
            this.helpLabel4 = new System.Windows.Forms.Label();
            this.wallCollisionInput = new System.Windows.Forms.TextBox();
            this.wallCollisionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.BackColor = System.Drawing.Color.Magenta;
            this.p1ScoreLabel.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.p1ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(49, 43);
            this.p1ScoreLabel.TabIndex = 0;
            this.p1ScoreLabel.Text = "0";
            this.p1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.BackColor = System.Drawing.Color.Aqua;
            this.p2ScoreLabel.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.p2ScoreLabel.Location = new System.Drawing.Point(639, 9);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(49, 43);
            this.p2ScoreLabel.TabIndex = 1;
            this.p2ScoreLabel.Text = "0";
            this.p2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxPointsInput
            // 
            this.maxPointsInput.Location = new System.Drawing.Point(278, 238);
            this.maxPointsInput.Name = "maxPointsInput";
            this.maxPointsInput.Size = new System.Drawing.Size(100, 35);
            this.maxPointsInput.TabIndex = 2;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.startLabel.Location = new System.Drawing.Point(115, 209);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(442, 23);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Enter the maximum points to start...";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(278, 282);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 35);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Location = new System.Drawing.Point(12, 232);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(676, 41);
            this.winLabel.TabIndex = 5;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.White;
            this.newGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGameButton.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.ForeColor = System.Drawing.Color.Black;
            this.newGameButton.Location = new System.Drawing.Point(275, 9);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(103, 21);
            this.newGameButton.TabIndex = 6;
            this.newGameButton.Text = "New Game";
            this.newGameButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Wingdings 2", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(422, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 21);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "T";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.White;
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.helpButton.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.Black;
            this.helpButton.Location = new System.Drawing.Point(394, 9);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(22, 21);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "?";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helpButton.Visible = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // helpLabel1
            // 
            this.helpLabel1.AutoSize = true;
            this.helpLabel1.BackColor = System.Drawing.Color.Transparent;
            this.helpLabel1.Font = new System.Drawing.Font("OCR A Extended", 10.25F);
            this.helpLabel1.Location = new System.Drawing.Point(380, 35);
            this.helpLabel1.Name = "helpLabel1";
            this.helpLabel1.Size = new System.Drawing.Size(55, 15);
            this.helpLabel1.TabIndex = 9;
            this.helpLabel1.Text = "Points";
            this.helpLabel1.Visible = false;
            // 
            // helpLabel2
            // 
            this.helpLabel2.AutoSize = true;
            this.helpLabel2.BackColor = System.Drawing.Color.Transparent;
            this.helpLabel2.Font = new System.Drawing.Font("OCR A Extended", 10.25F);
            this.helpLabel2.ForeColor = System.Drawing.Color.Orange;
            this.helpLabel2.Location = new System.Drawing.Point(380, 55);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(47, 15);
            this.helpLabel2.TabIndex = 10;
            this.helpLabel2.Text = "Speed";
            this.helpLabel2.Visible = false;
            // 
            // helpLabel3
            // 
            this.helpLabel3.AutoSize = true;
            this.helpLabel3.BackColor = System.Drawing.Color.Transparent;
            this.helpLabel3.Font = new System.Drawing.Font("OCR A Extended", 10.25F);
            this.helpLabel3.ForeColor = System.Drawing.Color.Blue;
            this.helpLabel3.Location = new System.Drawing.Point(380, 75);
            this.helpLabel3.Name = "helpLabel3";
            this.helpLabel3.Size = new System.Drawing.Size(39, 15);
            this.helpLabel3.TabIndex = 11;
            this.helpLabel3.Text = "Size";
            this.helpLabel3.Visible = false;
            // 
            // helpLabel4
            // 
            this.helpLabel4.AutoSize = true;
            this.helpLabel4.BackColor = System.Drawing.Color.Transparent;
            this.helpLabel4.Font = new System.Drawing.Font("OCR A Extended", 10.25F);
            this.helpLabel4.ForeColor = System.Drawing.Color.LimeGreen;
            this.helpLabel4.Location = new System.Drawing.Point(380, 95);
            this.helpLabel4.Name = "helpLabel4";
            this.helpLabel4.Size = new System.Drawing.Size(71, 15);
            this.helpLabel4.TabIndex = 12;
            this.helpLabel4.Text = "Strength";
            this.helpLabel4.Visible = false;
            // 
            // wallCollisionInput
            // 
            this.wallCollisionInput.Location = new System.Drawing.Point(383, 387);
            this.wallCollisionInput.Name = "wallCollisionInput";
            this.wallCollisionInput.Size = new System.Drawing.Size(26, 35);
            this.wallCollisionInput.TabIndex = 13;
            this.wallCollisionInput.Text = "1";
            // 
            // wallCollisionLabel
            // 
            this.wallCollisionLabel.AutoSize = true;
            this.wallCollisionLabel.BackColor = System.Drawing.Color.Transparent;
            this.wallCollisionLabel.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallCollisionLabel.Location = new System.Drawing.Point(171, 397);
            this.wallCollisionLabel.Name = "wallCollisionLabel";
            this.wallCollisionLabel.Size = new System.Drawing.Size(208, 68);
            this.wallCollisionLabel.TabIndex = 14;
            this.wallCollisionLabel.Text = "Wall collision type:\r\n    1 - Regular\r\n    2 - Bouncy\r\n    3 - Warped";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.wallCollisionLabel);
            this.Controls.Add(this.wallCollisionInput);
            this.Controls.Add(this.helpLabel4);
            this.Controls.Add(this.helpLabel3);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.helpLabel1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.maxPointsInput);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "Form1";
            this.Text = "Square Chaser";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.TextBox maxPointsInput;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label startButton;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label newGameButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label helpButton;
        private System.Windows.Forms.Label helpLabel1;
        private System.Windows.Forms.Label helpLabel2;
        private System.Windows.Forms.Label helpLabel3;
        private System.Windows.Forms.Label helpLabel4;
        private System.Windows.Forms.TextBox wallCollisionInput;
        private System.Windows.Forms.Label wallCollisionLabel;
    }
}

