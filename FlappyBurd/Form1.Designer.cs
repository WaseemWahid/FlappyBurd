namespace FlappyBurd
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
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBurd.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(560, 12);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(110, 225);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // flappybird
            // 
            this.flappybird.Image = global::FlappyBurd.Properties.Resources.bird;
            this.flappybird.Location = new System.Drawing.Point(102, 321);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(68, 58);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 1;
            this.flappybird.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::FlappyBurd.Properties.Resources.pipe;
            this.pipeDown.Location = new System.Drawing.Point(395, 428);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(121, 221);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 2;
            this.pipeDown.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBurd.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-23, 643);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(741, 86);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Khaki;
            this.scoreText.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(184, 670);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(122, 39);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(711, 718);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form1";
            this.Text = "FlappyBurd1.0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

