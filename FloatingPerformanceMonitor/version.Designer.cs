namespace FloatingPerformanceMonitor
{
    partial class version
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(version));
            this.App_name = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.Version_number = new System.Windows.Forms.Label();
            this.copywrite = new System.Windows.Forms.Label();
            this.my_twitter_label = new System.Windows.Forms.Label();
            this.my_twitter_URL = new System.Windows.Forms.LinkLabel();
            this.MITLicence = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // App_name
            // 
            this.App_name.AutoSize = true;
            this.App_name.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.App_name.Location = new System.Drawing.Point(103, 56);
            this.App_name.Name = "App_name";
            this.App_name.Size = new System.Drawing.Size(279, 19);
            this.App_name.TabIndex = 0;
            this.App_name.Text = "Floating Performance Monitor";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.version_label.Location = new System.Drawing.Point(105, 91);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(57, 13);
            this.version_label.TabIndex = 1;
            this.version_label.Text = "バージョン";
            // 
            // Version_number
            // 
            this.Version_number.AutoSize = true;
            this.Version_number.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Version_number.Location = new System.Drawing.Point(162, 91);
            this.Version_number.Name = "Version_number";
            this.Version_number.Size = new System.Drawing.Size(34, 13);
            this.Version_number.TabIndex = 2;
            this.Version_number.Text = "1.0.0";
            // 
            // copywrite
            // 
            this.copywrite.AutoSize = true;
            this.copywrite.Location = new System.Drawing.Point(105, 117);
            this.copywrite.Name = "copywrite";
            this.copywrite.Size = new System.Drawing.Size(160, 12);
            this.copywrite.TabIndex = 3;
            this.copywrite.Text = "Copyright (C) 2015 kousokujin";
            // 
            // my_twitter_label
            // 
            this.my_twitter_label.AutoSize = true;
            this.my_twitter_label.Location = new System.Drawing.Point(106, 175);
            this.my_twitter_label.Name = "my_twitter_label";
            this.my_twitter_label.Size = new System.Drawing.Size(123, 12);
            this.my_twitter_label.TabIndex = 4;
            this.my_twitter_label.Text = "開発者Twitterアカウント:";
            // 
            // my_twitter_URL
            // 
            this.my_twitter_URL.Location = new System.Drawing.Point(235, 175);
            this.my_twitter_URL.Name = "my_twitter_URL";
            this.my_twitter_URL.Size = new System.Drawing.Size(73, 12);
            this.my_twitter_URL.TabIndex = 5;
            this.my_twitter_URL.TabStop = true;
            this.my_twitter_URL.Text = "@highsokujin";
            this.my_twitter_URL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.my_twitter_URL_LinkClicked);
            // 
            // MITLicence
            // 
            this.MITLicence.AutoSize = true;
            this.MITLicence.Location = new System.Drawing.Point(11, 248);
            this.MITLicence.Name = "MITLicence";
            this.MITLicence.Size = new System.Drawing.Size(254, 12);
            this.MITLicence.TabIndex = 6;
            this.MITLicence.Text = "This software is licensed under the MIT License.";
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(367, 237);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 7;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FloatingPerformanceMonitor.Properties.Resources.Icon2;
            this.pictureBox1.Location = new System.Drawing.Point(53, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 269);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.MITLicence);
            this.Controls.Add(this.my_twitter_URL);
            this.Controls.Add(this.my_twitter_label);
            this.Controls.Add(this.copywrite);
            this.Controls.Add(this.Version_number);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.App_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "version";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "バージョン情報";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label App_name;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label Version_number;
        private System.Windows.Forms.Label copywrite;
        private System.Windows.Forms.Label my_twitter_label;
        private System.Windows.Forms.LinkLabel my_twitter_URL;
        private System.Windows.Forms.Label MITLicence;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}