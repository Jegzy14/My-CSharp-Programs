namespace SpaceShooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ReplayBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scorelb1 = new System.Windows.Forms.Label();
            this.levellb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10;
            this.MoveBgTimer.Tick += new System.EventHandler(this.MoveBgTimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(260, 400);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 5;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 5;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 5;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 5;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // MoveMunitionTimer
            // 
            this.MoveMunitionTimer.Enabled = true;
            this.MoveMunitionTimer.Interval = 20;
            this.MoveMunitionTimer.Tick += new System.EventHandler(this.MoveMunitionTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // EnemiesMunitionTimer
            // 
            this.EnemiesMunitionTimer.Enabled = true;
            this.EnemiesMunitionTimer.Interval = 20;
            this.EnemiesMunitionTimer.Tick += new System.EventHandler(this.EnemiesMunitionTimer_Tick);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(175, 265);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(223, 47);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Visible = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReplayBtn
            // 
            this.ReplayBtn.Location = new System.Drawing.Point(175, 200);
            this.ReplayBtn.Name = "ReplayBtn";
            this.ReplayBtn.Size = new System.Drawing.Size(223, 47);
            this.ReplayBtn.TabIndex = 2;
            this.ReplayBtn.Text = "Replay";
            this.ReplayBtn.UseVisualStyleBackColor = true;
            this.ReplayBtn.Visible = false;
            this.ReplayBtn.Click += new System.EventHandler(this.ReplayBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(160, 124);
            this.label1.MaximumSize = new System.Drawing.Size(254, 57);
            this.label1.MinimumSize = new System.Drawing.Size(254, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "PAUSED";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // scorelb1
            // 
            this.scorelb1.AutoSize = true;
            this.scorelb1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scorelb1.Location = new System.Drawing.Point(105, 9);
            this.scorelb1.Name = "scorelb1";
            this.scorelb1.Size = new System.Drawing.Size(39, 30);
            this.scorelb1.TabIndex = 4;
            this.scorelb1.Text = "00";
            // 
            // levellb1
            // 
            this.levellb1.AutoSize = true;
            this.levellb1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.levellb1.Location = new System.Drawing.Point(533, 9);
            this.levellb1.Name = "levellb1";
            this.levellb1.Size = new System.Drawing.Size(39, 30);
            this.levellb1.TabIndex = 5;
            this.levellb1.Text = "01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(441, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "LEVEL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "SCORE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levellb1);
            this.Controls.Add(this.scorelb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplayBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer MoveMunitionTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ReplayBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scorelb1;
        private System.Windows.Forms.Label levellb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

