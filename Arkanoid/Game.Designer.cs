namespace Arkanoid
{
    partial class Game
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
            this.labelUp = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.Raketka = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.RadioButton();
            this.brick1 = new System.Windows.Forms.Label();
            this.brick2 = new System.Windows.Forms.Label();
            this.brick3 = new System.Windows.Forms.Label();
            this.brick4 = new System.Windows.Forms.Label();
            this.brick5 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_bricks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUp
            // 
            this.labelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelUp.Location = new System.Drawing.Point(0, -8);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(816, 10);
            this.labelUp.TabIndex = 0;
            // 
            // labelLeft
            // 
            this.labelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelLeft.Location = new System.Drawing.Point(-8, 0);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(10, 512);
            this.labelLeft.TabIndex = 1;
            // 
            // labelRight
            // 
            this.labelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelRight.Location = new System.Drawing.Point(810, 1);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(10, 511);
            this.labelRight.TabIndex = 2;
            // 
            // Raketka
            // 
            this.Raketka.BackColor = System.Drawing.Color.Blue;
            this.Raketka.Enabled = false;
            this.Raketka.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raketka.Location = new System.Drawing.Point(330, 484);
            this.Raketka.Name = "Raketka";
            this.Raketka.Size = new System.Drawing.Size(104, 19);
            this.Raketka.TabIndex = 3;
            this.Raketka.Text = "---------";
            this.Raketka.UseVisualStyleBackColor = false;
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Checked = true;
            this.ball.Enabled = false;
            this.ball.Location = new System.Drawing.Point(378, 465);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 13);
            this.ball.TabIndex = 4;
            this.ball.TabStop = true;
            this.ball.UseVisualStyleBackColor = false;
            // 
            // brick1
            // 
            this.brick1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.brick1.ForeColor = System.Drawing.Color.Blue;
            this.brick1.Location = new System.Drawing.Point(53, 153);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(69, 15);
            this.brick1.TabIndex = 5;
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.brick2.ForeColor = System.Drawing.Color.Blue;
            this.brick2.Location = new System.Drawing.Point(223, 195);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(69, 15);
            this.brick2.TabIndex = 6;
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.brick3.ForeColor = System.Drawing.Color.Blue;
            this.brick3.Location = new System.Drawing.Point(386, 153);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(69, 15);
            this.brick3.TabIndex = 7;
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.brick4.ForeColor = System.Drawing.Color.Blue;
            this.brick4.Location = new System.Drawing.Point(540, 195);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(69, 15);
            this.brick4.TabIndex = 8;
            // 
            // brick5
            // 
            this.brick5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.brick5.ForeColor = System.Drawing.Color.Blue;
            this.brick5.Location = new System.Drawing.Point(702, 153);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(69, 15);
            this.brick5.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_bricks
            // 
            this.label_bricks.BackColor = System.Drawing.Color.Transparent;
            this.label_bricks.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bricks.Location = new System.Drawing.Point(9, 6);
            this.label_bricks.Name = "label_bricks";
            this.label_bricks.Size = new System.Drawing.Size(100, 23);
            this.label_bricks.TabIndex = 10;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.Level_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 504);
            this.Controls.Add(this.label_bricks);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Raketka);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.labelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game";
            this.Shown += new System.EventHandler(this.Game_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUp;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Button Raketka;
        private System.Windows.Forms.RadioButton ball;
        private System.Windows.Forms.Label brick1;
        private System.Windows.Forms.Label brick2;
        private System.Windows.Forms.Label brick3;
        private System.Windows.Forms.Label brick4;
        private System.Windows.Forms.Label brick5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_bricks;
    }
}