namespace GameCaro1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctAvatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLan = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.ptcbMark = new System.Windows.Forms.PictureBox();
            this.prcbCountdown = new System.Windows.Forms.ProgressBar();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.tmCountDown = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(690, 657);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pctAvatar);
            this.panel2.Location = new System.Drawing.Point(708, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 362);
            this.panel2.TabIndex = 1;
            // 
            // pctAvatar
            // 
            this.pctAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctAvatar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pctAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctAvatar.BackgroundImage")));
            this.pctAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctAvatar.InitialImage = null;
            this.pctAvatar.Location = new System.Drawing.Point(5, 10);
            this.pctAvatar.Name = "pctAvatar";
            this.pctAvatar.Size = new System.Drawing.Size(358, 349);
            this.pctAvatar.TabIndex = 0;
            this.pctAvatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnLan);
            this.panel3.Controls.Add(this.txtIP);
            this.panel3.Controls.Add(this.ptcbMark);
            this.panel3.Controls.Add(this.prcbCountdown);
            this.panel3.Controls.Add(this.txtPlayerName);
            this.panel3.Location = new System.Drawing.Point(717, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 253);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win";
            // 
            // btnLan
            // 
            this.btnLan.Location = new System.Drawing.Point(4, 121);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(187, 23);
            this.btnLan.TabIndex = 4;
            this.btnLan.Text = "Connect";
            this.btnLan.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(4, 95);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(187, 20);
            this.txtIP.TabIndex = 3;
            // 
            // ptcbMark
            // 
            this.ptcbMark.BackColor = System.Drawing.SystemColors.Control;
            this.ptcbMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptcbMark.Location = new System.Drawing.Point(213, 17);
            this.ptcbMark.Name = "ptcbMark";
            this.ptcbMark.Size = new System.Drawing.Size(131, 127);
            this.ptcbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcbMark.TabIndex = 2;
            this.ptcbMark.TabStop = false;
            // 
            // prcbCountdown
            // 
            this.prcbCountdown.Location = new System.Drawing.Point(4, 39);
            this.prcbCountdown.Name = "prcbCountdown";
            this.prcbCountdown.Size = new System.Drawing.Size(187, 49);
            this.prcbCountdown.TabIndex = 1;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(4, 13);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(187, 20);
            this.txtPlayerName.TabIndex = 0;
            // 
            // tmCountDown
            // 
            this.tmCountDown.Tick += new System.EventHandler(this.tmCountDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 713);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro From NDH";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctAvatar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLan;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox ptcbMark;
        private System.Windows.Forms.ProgressBar prcbCountdown;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmCountDown;
    }
}

