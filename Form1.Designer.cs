namespace jf_17
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
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(-4, 147);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(849, 152);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // player
            // 
            this.player.Image = global::jf_17.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(373, 436);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 98);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::jf_17.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(426, 342);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(7, 27);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.Image = global::jf_17.Properties.Resources.enemy;
            this.enemyThree.Location = new System.Drawing.Point(730, 32);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(100, 85);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyThree.TabIndex = 2;
            this.enemyThree.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.Image = global::jf_17.Properties.Resources.enemy;
            this.enemyTwo.Location = new System.Drawing.Point(373, 32);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(100, 85);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyTwo.TabIndex = 1;
            this.enemyTwo.TabStop = false;
            // 
            // enemyOne
            // 
            this.enemyOne.Image = global::jf_17.Properties.Resources.enemy;
            this.enemyOne.Location = new System.Drawing.Point(61, 32);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(100, 85);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyOne.TabIndex = 0;
            this.enemyOne.TabStop = false;
            this.enemyOne.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 527);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.txtScore);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "jf_17";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox player;
    }
}

