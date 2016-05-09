namespace MusicPlayer
{
    partial class MusicPlayer
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
            this.LB_Songs = new System.Windows.Forms.ListBox();
            this.B_Help = new System.Windows.Forms.Button();
            this.B_Play = new System.Windows.Forms.Button();
            this.B_Pause = new System.Windows.Forms.Button();
            this.L_Elapsed = new System.Windows.Forms.Label();
            this.L_Time = new System.Windows.Forms.Label();
            this.T_Time = new System.Windows.Forms.Timer(this.components);
            this.T_Update = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LB_Songs
            // 
            this.LB_Songs.FormattingEnabled = true;
            this.LB_Songs.Location = new System.Drawing.Point(12, 48);
            this.LB_Songs.Name = "LB_Songs";
            this.LB_Songs.Size = new System.Drawing.Size(491, 368);
            this.LB_Songs.TabIndex = 0;
            this.LB_Songs.SelectedIndexChanged += new System.EventHandler(this.LB_Songs_SelectedIndexChanged);
            // 
            // B_Help
            // 
            this.B_Help.Location = new System.Drawing.Point(12, 19);
            this.B_Help.Name = "B_Help";
            this.B_Help.Size = new System.Drawing.Size(75, 23);
            this.B_Help.TabIndex = 1;
            this.B_Help.Text = "Help";
            this.B_Help.UseVisualStyleBackColor = true;
            this.B_Help.Click += new System.EventHandler(this.B_Help_Click);
            // 
            // B_Play
            // 
            this.B_Play.Location = new System.Drawing.Point(347, 19);
            this.B_Play.Name = "B_Play";
            this.B_Play.Size = new System.Drawing.Size(75, 23);
            this.B_Play.TabIndex = 2;
            this.B_Play.Text = "Play";
            this.B_Play.UseVisualStyleBackColor = true;
            this.B_Play.Click += new System.EventHandler(this.B_Play_Click);
            // 
            // B_Pause
            // 
            this.B_Pause.Location = new System.Drawing.Point(428, 19);
            this.B_Pause.Name = "B_Pause";
            this.B_Pause.Size = new System.Drawing.Size(75, 23);
            this.B_Pause.TabIndex = 3;
            this.B_Pause.Text = "Pause";
            this.B_Pause.UseVisualStyleBackColor = true;
            this.B_Pause.Click += new System.EventHandler(this.B_Pause_Click);
            // 
            // L_Elapsed
            // 
            this.L_Elapsed.AutoSize = true;
            this.L_Elapsed.Location = new System.Drawing.Point(105, 24);
            this.L_Elapsed.Name = "L_Elapsed";
            this.L_Elapsed.Size = new System.Drawing.Size(77, 13);
            this.L_Elapsed.TabIndex = 4;
            this.L_Elapsed.Text = "Elapsed Time: ";
            // 
            // L_Time
            // 
            this.L_Time.AutoSize = true;
            this.L_Time.Location = new System.Drawing.Point(188, 24);
            this.L_Time.Name = "L_Time";
            this.L_Time.Size = new System.Drawing.Size(34, 13);
            this.L_Time.TabIndex = 5;
            this.L_Time.Text = "00:00";
            // 
            // T_Time
            // 
            this.T_Time.Interval = 1;
            this.T_Time.Tick += new System.EventHandler(this.T_Time_Tick);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(515, 432);
            this.Controls.Add(this.L_Time);
            this.Controls.Add(this.L_Elapsed);
            this.Controls.Add(this.B_Pause);
            this.Controls.Add(this.B_Play);
            this.Controls.Add(this.B_Help);
            this.Controls.Add(this.LB_Songs);
            this.MaximumSize = new System.Drawing.Size(531, 471);
            this.MinimumSize = new System.Drawing.Size(531, 471);
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Songs;
        private System.Windows.Forms.Button B_Help;
        private System.Windows.Forms.Button B_Play;
        private System.Windows.Forms.Button B_Pause;
        private System.Windows.Forms.Label L_Elapsed;
        private System.Windows.Forms.Label L_Time;
        private System.Windows.Forms.Timer T_Time;
        private System.Windows.Forms.Timer T_Update;
    }
}

