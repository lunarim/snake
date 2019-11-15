namespace snake_test_v1
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
            this.bananapaper1 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.actualscore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bananapaper1)).BeginInit();
            this.SuspendLayout();
            // 
            // bananapaper1
            // 
            this.bananapaper1.BackColor = System.Drawing.Color.DimGray;
            this.bananapaper1.Location = new System.Drawing.Point(1, 1);
            this.bananapaper1.Name = "bananapaper1";
            this.bananapaper1.Size = new System.Drawing.Size(511, 554);
            this.bananapaper1.TabIndex = 0;
            this.bananapaper1.TabStop = false;
            this.bananapaper1.Click += new System.EventHandler(this.bananapaper1_Click);
            this.bananapaper1.Paint += new System.Windows.Forms.PaintEventHandler(this.bananapaper1_Paint);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(518, 56);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(130, 45);
            this.Score.TabIndex = 1;
            this.Score.Text = "score: ";
            this.Score.Click += new System.EventHandler(this.score_Click);
            // 
            // actualscore
            // 
            this.actualscore.AutoSize = true;
            this.actualscore.BackColor = System.Drawing.Color.Transparent;
            this.actualscore.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualscore.Location = new System.Drawing.Point(616, 101);
            this.actualscore.Name = "actualscore";
            this.actualscore.Size = new System.Drawing.Size(113, 45);
            this.actualscore.TabIndex = 2;
            this.actualscore.Text = "label1";
            this.actualscore.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(65, 56);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(113, 45);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label1";
            this.lblGameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 559);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.actualscore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.bananapaper1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bananapaper1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bananapaper1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label actualscore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
    }
}

