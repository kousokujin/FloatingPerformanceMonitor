namespace FloatingPerformanceMonitor
{
    partial class seting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seting));
            this.toumeido = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.opa_lv_label = new System.Windows.Forms.Label();
            this.FontChange_button = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.CPU_set = new System.Windows.Forms.Label();
            this.mem_set = new System.Windows.Forms.Label();
            this.Time_set = new System.Windows.Forms.Label();
            this.CPU_enable_chack = new System.Windows.Forms.CheckBox();
            this.mem_enable_ckeck = new System.Windows.Forms.CheckBox();
            this.time_enable_check = new System.Windows.Forms.CheckBox();
            this.back_op_check = new System.Windows.Forms.CheckBox();
            this.Color_button_cpu = new System.Windows.Forms.Button();
            this.Color_button_mem = new System.Windows.Forms.Button();
            this.Color_button_Time = new System.Windows.Forms.Button();
            this.Top_most_check = new System.Windows.Forms.CheckBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.back_color_button = new System.Windows.Forms.Button();
            this.version_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // toumeido
            // 
            this.toumeido.AutoSize = true;
            this.toumeido.Location = new System.Drawing.Point(58, 40);
            this.toumeido.Name = "toumeido";
            this.toumeido.Size = new System.Drawing.Size(41, 12);
            this.toumeido.TabIndex = 0;
            this.toumeido.Text = "透明度";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(101, 29);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.RightToLeftLayout = true;
            this.trackBar1.Size = new System.Drawing.Size(302, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // opa_lv_label
            // 
            this.opa_lv_label.AutoSize = true;
            this.opa_lv_label.Location = new System.Drawing.Point(409, 40);
            this.opa_lv_label.Name = "opa_lv_label";
            this.opa_lv_label.Size = new System.Drawing.Size(35, 12);
            this.opa_lv_label.TabIndex = 101;
            this.opa_lv_label.Text = "label1";
            // 
            // FontChange_button
            // 
            this.FontChange_button.Location = new System.Drawing.Point(37, 80);
            this.FontChange_button.Name = "FontChange_button";
            this.FontChange_button.Size = new System.Drawing.Size(75, 23);
            this.FontChange_button.TabIndex = 102;
            this.FontChange_button.Text = "フォント変更";
            this.FontChange_button.UseVisualStyleBackColor = true;
            this.FontChange_button.Click += new System.EventHandler(this.FontChange_button_Click);
            // 
            // CPU_set
            // 
            this.CPU_set.AutoSize = true;
            this.CPU_set.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CPU_set.Location = new System.Drawing.Point(35, 121);
            this.CPU_set.Name = "CPU_set";
            this.CPU_set.Size = new System.Drawing.Size(64, 12);
            this.CPU_set.TabIndex = 103;
            this.CPU_set.Text = "CPU使用率";
            // 
            // mem_set
            // 
            this.mem_set.AutoSize = true;
            this.mem_set.Location = new System.Drawing.Point(35, 151);
            this.mem_set.Name = "mem_set";
            this.mem_set.Size = new System.Drawing.Size(65, 12);
            this.mem_set.TabIndex = 104;
            this.mem_set.Text = "メモリ使用量";
            // 
            // Time_set
            // 
            this.Time_set.AutoSize = true;
            this.Time_set.Location = new System.Drawing.Point(35, 177);
            this.Time_set.Name = "Time_set";
            this.Time_set.Size = new System.Drawing.Size(29, 12);
            this.Time_set.TabIndex = 105;
            this.Time_set.Text = "時計";
            // 
            // CPU_enable_chack
            // 
            this.CPU_enable_chack.AutoSize = true;
            this.CPU_enable_chack.Location = new System.Drawing.Point(112, 118);
            this.CPU_enable_chack.Name = "CPU_enable_chack";
            this.CPU_enable_chack.Size = new System.Drawing.Size(48, 16);
            this.CPU_enable_chack.TabIndex = 106;
            this.CPU_enable_chack.Text = "有効";
            this.CPU_enable_chack.UseVisualStyleBackColor = true;
            this.CPU_enable_chack.CheckedChanged += new System.EventHandler(this.CPU_enable_chack_CheckedChanged);
            // 
            // mem_enable_ckeck
            // 
            this.mem_enable_ckeck.AutoSize = true;
            this.mem_enable_ckeck.Location = new System.Drawing.Point(112, 147);
            this.mem_enable_ckeck.Name = "mem_enable_ckeck";
            this.mem_enable_ckeck.Size = new System.Drawing.Size(48, 16);
            this.mem_enable_ckeck.TabIndex = 107;
            this.mem_enable_ckeck.Text = "有効";
            this.mem_enable_ckeck.UseVisualStyleBackColor = true;
            this.mem_enable_ckeck.CheckedChanged += new System.EventHandler(this.mem_enable_ckeck_CheckedChanged);
            // 
            // time_enable_check
            // 
            this.time_enable_check.AutoSize = true;
            this.time_enable_check.Location = new System.Drawing.Point(112, 176);
            this.time_enable_check.Name = "time_enable_check";
            this.time_enable_check.Size = new System.Drawing.Size(48, 16);
            this.time_enable_check.TabIndex = 108;
            this.time_enable_check.Text = "有効";
            this.time_enable_check.UseVisualStyleBackColor = true;
            this.time_enable_check.CheckedChanged += new System.EventHandler(this.time_enable_check_CheckedChanged);
            // 
            // back_op_check
            // 
            this.back_op_check.AutoSize = true;
            this.back_op_check.Location = new System.Drawing.Point(294, 117);
            this.back_op_check.Name = "back_op_check";
            this.back_op_check.Size = new System.Drawing.Size(109, 16);
            this.back_op_check.TabIndex = 109;
            this.back_op_check.Text = "背景を無効にする";
            this.back_op_check.UseVisualStyleBackColor = true;
            this.back_op_check.CheckedChanged += new System.EventHandler(this.back_op_check_CheckedChanged);
            // 
            // Color_button_cpu
            // 
            this.Color_button_cpu.Location = new System.Drawing.Point(166, 114);
            this.Color_button_cpu.Name = "Color_button_cpu";
            this.Color_button_cpu.Size = new System.Drawing.Size(75, 23);
            this.Color_button_cpu.TabIndex = 110;
            this.Color_button_cpu.Text = "色の設定";
            this.Color_button_cpu.UseVisualStyleBackColor = true;
            this.Color_button_cpu.Click += new System.EventHandler(this.Color_button_cpu_Click);
            // 
            // Color_button_mem
            // 
            this.Color_button_mem.Location = new System.Drawing.Point(166, 143);
            this.Color_button_mem.Name = "Color_button_mem";
            this.Color_button_mem.Size = new System.Drawing.Size(75, 23);
            this.Color_button_mem.TabIndex = 111;
            this.Color_button_mem.Text = "色の設定";
            this.Color_button_mem.UseVisualStyleBackColor = true;
            this.Color_button_mem.Click += new System.EventHandler(this.Color_button_mem_Click);
            // 
            // Color_button_Time
            // 
            this.Color_button_Time.Location = new System.Drawing.Point(166, 172);
            this.Color_button_Time.Name = "Color_button_Time";
            this.Color_button_Time.Size = new System.Drawing.Size(75, 23);
            this.Color_button_Time.TabIndex = 112;
            this.Color_button_Time.Text = "色の設定";
            this.Color_button_Time.UseVisualStyleBackColor = true;
            this.Color_button_Time.Click += new System.EventHandler(this.Color_button_Time_Click);
            // 
            // Top_most_check
            // 
            this.Top_most_check.AutoSize = true;
            this.Top_most_check.Location = new System.Drawing.Point(294, 140);
            this.Top_most_check.Name = "Top_most_check";
            this.Top_most_check.Size = new System.Drawing.Size(109, 16);
            this.Top_most_check.TabIndex = 113;
            this.Top_most_check.Text = "常に最前面にする";
            this.Top_most_check.UseVisualStyleBackColor = true;
            this.Top_most_check.CheckedChanged += new System.EventHandler(this.Top_most_check_CheckedChanged);
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(397, 226);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 114;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(316, 226);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 115;
            this.Cancel_button.Text = "キャンセル";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // back_color_button
            // 
            this.back_color_button.Location = new System.Drawing.Point(119, 79);
            this.back_color_button.Name = "back_color_button";
            this.back_color_button.Size = new System.Drawing.Size(75, 23);
            this.back_color_button.TabIndex = 116;
            this.back_color_button.Text = "背景色変更";
            this.back_color_button.UseVisualStyleBackColor = true;
            this.back_color_button.Click += new System.EventHandler(this.back_color_button_Click);
            // 
            // version_button
            // 
            this.version_button.Location = new System.Drawing.Point(13, 226);
            this.version_button.Name = "version_button";
            this.version_button.Size = new System.Drawing.Size(99, 23);
            this.version_button.TabIndex = 117;
            this.version_button.Text = "バージョン情報";
            this.version_button.UseVisualStyleBackColor = true;
            this.version_button.Click += new System.EventHandler(this.version_button_Click);
            // 
            // seting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.version_button);
            this.Controls.Add(this.back_color_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Top_most_check);
            this.Controls.Add(this.Color_button_Time);
            this.Controls.Add(this.Color_button_mem);
            this.Controls.Add(this.Color_button_cpu);
            this.Controls.Add(this.back_op_check);
            this.Controls.Add(this.time_enable_check);
            this.Controls.Add(this.mem_enable_ckeck);
            this.Controls.Add(this.CPU_enable_chack);
            this.Controls.Add(this.Time_set);
            this.Controls.Add(this.mem_set);
            this.Controls.Add(this.CPU_set);
            this.Controls.Add(this.FontChange_button);
            this.Controls.Add(this.opa_lv_label);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.toumeido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "seting";
            this.Text = "設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.seting_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toumeido;
        private System.Windows.Forms.Label opa_lv_label;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button FontChange_button;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label CPU_set;
        private System.Windows.Forms.Label mem_set;
        private System.Windows.Forms.Label Time_set;
        private System.Windows.Forms.CheckBox CPU_enable_chack;
        private System.Windows.Forms.CheckBox mem_enable_ckeck;
        private System.Windows.Forms.CheckBox time_enable_check;
        private System.Windows.Forms.CheckBox back_op_check;
        private System.Windows.Forms.Button Color_button_cpu;
        private System.Windows.Forms.Button Color_button_mem;
        private System.Windows.Forms.Button Color_button_Time;
        private System.Windows.Forms.CheckBox Top_most_check;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button back_color_button;
        private System.Windows.Forms.Button version_button;
    }
}