namespace MusicPlayer
{
    partial class Help
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
            this.L_Directory = new System.Windows.Forms.Label();
            this.L_Creator = new System.Windows.Forms.Label();
            this.L_Folder = new System.Windows.Forms.Label();
            this.L_Directions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_Directory
            // 
            this.L_Directory.AutoSize = true;
            this.L_Directory.Location = new System.Drawing.Point(64, 135);
            this.L_Directory.Name = "L_Directory";
            this.L_Directory.Size = new System.Drawing.Size(157, 13);
            this.L_Directory.TabIndex = 0;
            this.L_Directory.Text = "The directory is in your desktop.";
            // 
            // L_Creator
            // 
            this.L_Creator.AutoSize = true;
            this.L_Creator.Location = new System.Drawing.Point(77, 239);
            this.L_Creator.Name = "L_Creator";
            this.L_Creator.Size = new System.Drawing.Size(121, 13);
            this.L_Creator.TabIndex = 1;
            this.L_Creator.Text = "Created by Patrick Nulla";
            // 
            // L_Folder
            // 
            this.L_Folder.AutoSize = true;
            this.L_Folder.Location = new System.Drawing.Point(96, 148);
            this.L_Folder.Name = "L_Folder";
            this.L_Folder.Size = new System.Drawing.Size(102, 13);
            this.L_Folder.TabIndex = 2;
            this.L_Folder.Text = "named MusicFolder.";
            // 
            // L_Directions
            // 
            this.L_Directions.AutoSize = true;
            this.L_Directions.Location = new System.Drawing.Point(77, 89);
            this.L_Directions.Name = "L_Directions";
            this.L_Directions.Size = new System.Drawing.Size(141, 13);
            this.L_Directions.TabIndex = 3;
            this.L_Directions.Text = "Add your songs in the folder.";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.L_Directions);
            this.Controls.Add(this.L_Folder);
            this.Controls.Add(this.L_Creator);
            this.Controls.Add(this.L_Directory);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Directory;
        private System.Windows.Forms.Label L_Creator;
        private System.Windows.Forms.Label L_Folder;
        private System.Windows.Forms.Label L_Directions;
    }
}