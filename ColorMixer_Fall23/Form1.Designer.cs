namespace ColorMixer_Fall23
{
    partial class ColorMixerForm
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
            this.MixBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.Color1GB = new System.Windows.Forms.GroupBox();
            this.Yellow1RB = new System.Windows.Forms.RadioButton();
            this.Blue1RB = new System.Windows.Forms.RadioButton();
            this.Red1RB = new System.Windows.Forms.RadioButton();
            this.Color2GB = new System.Windows.Forms.GroupBox();
            this.Yellow2RB = new System.Windows.Forms.RadioButton();
            this.Blue2RB = new System.Windows.Forms.RadioButton();
            this.Red2RB = new System.Windows.Forms.RadioButton();
            this.DeselectBtn = new System.Windows.Forms.Button();
            this.Color3GB = new System.Windows.Forms.GroupBox();
            this.RedCB = new System.Windows.Forms.CheckBox();
            this.BlueCB = new System.Windows.Forms.CheckBox();
            this.YellowCB = new System.Windows.Forms.CheckBox();
            this.Color1GB.SuspendLayout();
            this.Color2GB.SuspendLayout();
            this.Color3GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // MixBtn
            // 
            this.MixBtn.Location = new System.Drawing.Point(12, 125);
            this.MixBtn.Name = "MixBtn";
            this.MixBtn.Size = new System.Drawing.Size(75, 23);
            this.MixBtn.TabIndex = 0;
            this.MixBtn.Text = "&Mix";
            this.MixBtn.UseVisualStyleBackColor = true;
            this.MixBtn.Click += new System.EventHandler(this.MixBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(219, 125);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(75, 23);
            this.QuitBtn.TabIndex = 1;
            this.QuitBtn.Text = "&Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // Color1GB
            // 
            this.Color1GB.Controls.Add(this.Yellow1RB);
            this.Color1GB.Controls.Add(this.Blue1RB);
            this.Color1GB.Controls.Add(this.Red1RB);
            this.Color1GB.Location = new System.Drawing.Point(12, 12);
            this.Color1GB.Name = "Color1GB";
            this.Color1GB.Size = new System.Drawing.Size(138, 107);
            this.Color1GB.TabIndex = 2;
            this.Color1GB.TabStop = false;
            this.Color1GB.Text = "Color 1";
            // 
            // Yellow1RB
            // 
            this.Yellow1RB.AutoSize = true;
            this.Yellow1RB.Location = new System.Drawing.Point(35, 73);
            this.Yellow1RB.Name = "Yellow1RB";
            this.Yellow1RB.Size = new System.Drawing.Size(65, 20);
            this.Yellow1RB.TabIndex = 2;
            this.Yellow1RB.TabStop = true;
            this.Yellow1RB.Text = "Yellow";
            this.Yellow1RB.UseVisualStyleBackColor = true;
            this.Yellow1RB.CheckedChanged += new System.EventHandler(this.Yellow1RB_CheckedChanged);
            // 
            // Blue1RB
            // 
            this.Blue1RB.AutoSize = true;
            this.Blue1RB.Location = new System.Drawing.Point(35, 47);
            this.Blue1RB.Name = "Blue1RB";
            this.Blue1RB.Size = new System.Drawing.Size(52, 20);
            this.Blue1RB.TabIndex = 1;
            this.Blue1RB.TabStop = true;
            this.Blue1RB.Text = "Blue";
            this.Blue1RB.UseVisualStyleBackColor = true;
            this.Blue1RB.CheckedChanged += new System.EventHandler(this.Blue1RB_CheckedChanged);
            // 
            // Red1RB
            // 
            this.Red1RB.AutoSize = true;
            this.Red1RB.Location = new System.Drawing.Point(35, 21);
            this.Red1RB.Name = "Red1RB";
            this.Red1RB.Size = new System.Drawing.Size(51, 20);
            this.Red1RB.TabIndex = 0;
            this.Red1RB.TabStop = true;
            this.Red1RB.Text = "Red";
            this.Red1RB.UseVisualStyleBackColor = true;
            this.Red1RB.CheckedChanged += new System.EventHandler(this.Red1RB_CheckedChanged);
            // 
            // Color2GB
            // 
            this.Color2GB.Controls.Add(this.Yellow2RB);
            this.Color2GB.Controls.Add(this.Blue2RB);
            this.Color2GB.Controls.Add(this.Red2RB);
            this.Color2GB.Location = new System.Drawing.Point(156, 12);
            this.Color2GB.Name = "Color2GB";
            this.Color2GB.Size = new System.Drawing.Size(138, 107);
            this.Color2GB.TabIndex = 3;
            this.Color2GB.TabStop = false;
            this.Color2GB.Text = "Color 2";
            // 
            // Yellow2RB
            // 
            this.Yellow2RB.AutoSize = true;
            this.Yellow2RB.Location = new System.Drawing.Point(35, 73);
            this.Yellow2RB.Name = "Yellow2RB";
            this.Yellow2RB.Size = new System.Drawing.Size(65, 20);
            this.Yellow2RB.TabIndex = 2;
            this.Yellow2RB.TabStop = true;
            this.Yellow2RB.Text = "Yellow";
            this.Yellow2RB.UseVisualStyleBackColor = true;
            this.Yellow2RB.CheckedChanged += new System.EventHandler(this.Yellow2RB_CheckedChanged);
            // 
            // Blue2RB
            // 
            this.Blue2RB.AutoSize = true;
            this.Blue2RB.Location = new System.Drawing.Point(35, 47);
            this.Blue2RB.Name = "Blue2RB";
            this.Blue2RB.Size = new System.Drawing.Size(52, 20);
            this.Blue2RB.TabIndex = 1;
            this.Blue2RB.TabStop = true;
            this.Blue2RB.Text = "Blue";
            this.Blue2RB.UseVisualStyleBackColor = true;
            this.Blue2RB.CheckedChanged += new System.EventHandler(this.Blue2RB_CheckedChanged);
            // 
            // Red2RB
            // 
            this.Red2RB.AutoSize = true;
            this.Red2RB.Location = new System.Drawing.Point(35, 21);
            this.Red2RB.Name = "Red2RB";
            this.Red2RB.Size = new System.Drawing.Size(51, 20);
            this.Red2RB.TabIndex = 0;
            this.Red2RB.TabStop = true;
            this.Red2RB.Text = "Red";
            this.Red2RB.UseVisualStyleBackColor = true;
            this.Red2RB.CheckedChanged += new System.EventHandler(this.Red2RB_CheckedChanged);
            // 
            // DeselectBtn
            // 
            this.DeselectBtn.Location = new System.Drawing.Point(111, 125);
            this.DeselectBtn.Name = "DeselectBtn";
            this.DeselectBtn.Size = new System.Drawing.Size(75, 23);
            this.DeselectBtn.TabIndex = 4;
            this.DeselectBtn.Text = "&Deselect";
            this.DeselectBtn.UseVisualStyleBackColor = true;
            this.DeselectBtn.Click += new System.EventHandler(this.DeselectBtn_Click);
            // 
            // Color3GB
            // 
            this.Color3GB.Controls.Add(this.YellowCB);
            this.Color3GB.Controls.Add(this.BlueCB);
            this.Color3GB.Controls.Add(this.RedCB);
            this.Color3GB.Location = new System.Drawing.Point(86, 154);
            this.Color3GB.Name = "Color3GB";
            this.Color3GB.Size = new System.Drawing.Size(139, 107);
            this.Color3GB.TabIndex = 5;
            this.Color3GB.TabStop = false;
            this.Color3GB.Text = "Alternative";
            // 
            // RedCB
            // 
            this.RedCB.AutoSize = true;
            this.RedCB.Location = new System.Drawing.Point(33, 21);
            this.RedCB.Name = "RedCB";
            this.RedCB.Size = new System.Drawing.Size(52, 20);
            this.RedCB.TabIndex = 0;
            this.RedCB.Text = "Red";
            this.RedCB.UseVisualStyleBackColor = true;
            this.RedCB.CheckedChanged += new System.EventHandler(this.RedCB_CheckedChanged);
            // 
            // BlueCB
            // 
            this.BlueCB.AutoSize = true;
            this.BlueCB.Location = new System.Drawing.Point(33, 47);
            this.BlueCB.Name = "BlueCB";
            this.BlueCB.Size = new System.Drawing.Size(53, 20);
            this.BlueCB.TabIndex = 1;
            this.BlueCB.Text = "Blue";
            this.BlueCB.UseVisualStyleBackColor = true;
            this.BlueCB.CheckedChanged += new System.EventHandler(this.BlueCB_CheckedChanged);
            // 
            // YellowCB
            // 
            this.YellowCB.AutoSize = true;
            this.YellowCB.Location = new System.Drawing.Point(33, 73);
            this.YellowCB.Name = "YellowCB";
            this.YellowCB.Size = new System.Drawing.Size(66, 20);
            this.YellowCB.TabIndex = 2;
            this.YellowCB.Text = "Yellow";
            this.YellowCB.UseVisualStyleBackColor = true;
            this.YellowCB.CheckedChanged += new System.EventHandler(this.YellowCB_CheckedChanged);
            // 
            // ColorMixerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 277);
            this.Controls.Add(this.Color3GB);
            this.Controls.Add(this.DeselectBtn);
            this.Controls.Add(this.Color2GB);
            this.Controls.Add(this.Color1GB);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.MixBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ColorMixerForm";
            this.Text = "Color Mixer";
            this.Color1GB.ResumeLayout(false);
            this.Color1GB.PerformLayout();
            this.Color2GB.ResumeLayout(false);
            this.Color2GB.PerformLayout();
            this.Color3GB.ResumeLayout(false);
            this.Color3GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MixBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.GroupBox Color1GB;
        private System.Windows.Forms.RadioButton Red1RB;
        private System.Windows.Forms.RadioButton Yellow1RB;
        private System.Windows.Forms.RadioButton Blue1RB;
        private System.Windows.Forms.GroupBox Color2GB;
        private System.Windows.Forms.RadioButton Yellow2RB;
        private System.Windows.Forms.RadioButton Blue2RB;
        private System.Windows.Forms.RadioButton Red2RB;
        private System.Windows.Forms.Button DeselectBtn;
        private System.Windows.Forms.GroupBox Color3GB;
        private System.Windows.Forms.CheckBox YellowCB;
        private System.Windows.Forms.CheckBox BlueCB;
        private System.Windows.Forms.CheckBox RedCB;
    }
}

