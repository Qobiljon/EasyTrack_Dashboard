namespace EasyTrack_Dashboard
{
    partial class ExperimenterProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usersAvatarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersAvatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLabel.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.typeLabel.Location = new System.Drawing.Point(68, 18);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(104, 18);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Experimenter";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameLabel.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.usernameLabel.Location = new System.Drawing.Point(68, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(48, 18);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Kevin";
            // 
            // usersAvatarPictureBox
            // 
            this.usersAvatarPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.usersAvatarPictureBox.Image = global::EasyTrack_Dashboard.Properties.Resources.avatar_64;
            this.usersAvatarPictureBox.ImageLocation = "";
            this.usersAvatarPictureBox.Location = new System.Drawing.Point(0, 0);
            this.usersAvatarPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.usersAvatarPictureBox.Name = "usersAvatarPictureBox";
            this.usersAvatarPictureBox.Size = new System.Drawing.Size(68, 68);
            this.usersAvatarPictureBox.TabIndex = 3;
            this.usersAvatarPictureBox.TabStop = false;
            // 
            // ExperimenterProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usersAvatarPictureBox);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ExperimenterProfile";
            this.Size = new System.Drawing.Size(330, 68);
            ((System.ComponentModel.ISupportInitialize)(this.usersAvatarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox usersAvatarPictureBox;
    }
}
