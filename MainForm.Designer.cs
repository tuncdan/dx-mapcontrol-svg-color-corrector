namespace SvgColorCorrector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_progressBar = new System.Windows.Forms.ProgressBar();
            this.m_labelHeader = new System.Windows.Forms.Label();
            this.m_pictureBox = new System.Windows.Forms.PictureBox();
            this.m_buttonExit = new System.Windows.Forms.Button();
            this.m_textBoxPath = new System.Windows.Forms.TextBox();
            this.m_labelPath = new System.Windows.Forms.Label();
            this.m_buttonStart = new System.Windows.Forms.Button();
            this.m_labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_progressBar
            // 
            this.m_progressBar.Location = new System.Drawing.Point(23, 163);
            this.m_progressBar.Name = "m_progressBar";
            this.m_progressBar.Size = new System.Drawing.Size(419, 14);
            this.m_progressBar.TabIndex = 0;
            // 
            // m_labelHeader
            // 
            this.m_labelHeader.AutoSize = true;
            this.m_labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.m_labelHeader.Location = new System.Drawing.Point(59, 22);
            this.m_labelHeader.Name = "m_labelHeader";
            this.m_labelHeader.Size = new System.Drawing.Size(281, 13);
            this.m_labelHeader.TabIndex = 3;
            this.m_labelHeader.Text = "SVG Color Corrector For Devexpress MapControl";
            this.m_labelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.m_labelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.m_labelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // m_pictureBox
            // 
            this.m_pictureBox.Image = global::SvgColorCorrector.Properties.Resources.color;
            this.m_pictureBox.Location = new System.Drawing.Point(23, 12);
            this.m_pictureBox.Name = "m_pictureBox";
            this.m_pictureBox.Size = new System.Drawing.Size(30, 30);
            this.m_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.m_pictureBox.TabIndex = 2;
            this.m_pictureBox.TabStop = false;
            // 
            // m_buttonExit
            // 
            this.m_buttonExit.BackColor = System.Drawing.Color.Coral;
            this.m_buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_buttonExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.m_buttonExit.Location = new System.Drawing.Point(418, 15);
            this.m_buttonExit.Name = "m_buttonExit";
            this.m_buttonExit.Size = new System.Drawing.Size(24, 24);
            this.m_buttonExit.TabIndex = 1;
            this.m_buttonExit.Text = "X";
            this.m_buttonExit.UseVisualStyleBackColor = false;
            this.m_buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // m_textBoxPath
            // 
            this.m_textBoxPath.Location = new System.Drawing.Point(23, 94);
            this.m_textBoxPath.Name = "m_textBoxPath";
            this.m_textBoxPath.ReadOnly = true;
            this.m_textBoxPath.Size = new System.Drawing.Size(419, 20);
            this.m_textBoxPath.TabIndex = 5;
            // 
            // m_labelPath
            // 
            this.m_labelPath.AutoSize = true;
            this.m_labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.m_labelPath.Location = new System.Drawing.Point(20, 73);
            this.m_labelPath.Name = "m_labelPath";
            this.m_labelPath.Size = new System.Drawing.Size(33, 13);
            this.m_labelPath.TabIndex = 6;
            this.m_labelPath.Text = "Path";
            // 
            // m_buttonStart
            // 
            this.m_buttonStart.BackColor = System.Drawing.Color.DarkOrange;
            this.m_buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_buttonStart.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.m_buttonStart.Location = new System.Drawing.Point(374, 120);
            this.m_buttonStart.Name = "m_buttonStart";
            this.m_buttonStart.Size = new System.Drawing.Size(68, 26);
            this.m_buttonStart.TabIndex = 7;
            this.m_buttonStart.Text = "Start";
            this.m_buttonStart.UseVisualStyleBackColor = false;
            this.m_buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // m_labelStatus
            // 
            this.m_labelStatus.AutoSize = true;
            this.m_labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.m_labelStatus.Location = new System.Drawing.Point(20, 142);
            this.m_labelStatus.Name = "m_labelStatus";
            this.m_labelStatus.Size = new System.Drawing.Size(43, 13);
            this.m_labelStatus.TabIndex = 8;
            this.m_labelStatus.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(464, 205);
            this.ControlBox = false;
            this.Controls.Add(this.m_labelStatus);
            this.Controls.Add(this.m_buttonStart);
            this.Controls.Add(this.m_labelPath);
            this.Controls.Add(this.m_textBoxPath);
            this.Controls.Add(this.m_labelHeader);
            this.Controls.Add(this.m_pictureBox);
            this.Controls.Add(this.m_buttonExit);
            this.Controls.Add(this.m_progressBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Svg Color Corrector For Devexpress Map";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar m_progressBar;
        private System.Windows.Forms.Button m_buttonExit;
        private System.Windows.Forms.PictureBox m_pictureBox;
        private System.Windows.Forms.Label m_labelHeader;
        private System.Windows.Forms.TextBox m_textBoxPath;
        private System.Windows.Forms.Label m_labelPath;
        private System.Windows.Forms.Button m_buttonStart;
        private System.Windows.Forms.Label m_labelStatus;
    }
}

