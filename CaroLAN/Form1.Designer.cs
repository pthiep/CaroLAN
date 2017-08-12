namespace CaroLAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBAvatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txtBIP = new System.Windows.Forms.TextBox();
            this.picBMark = new System.Windows.Forms.PictureBox();
            this.txtBPlayerName = new System.Windows.Forms.TextBox();
            this.progBCoolDown = new System.Windows.Forms.ProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBAvatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(510, 537);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.picBAvatar);
            this.panel2.Location = new System.Drawing.Point(528, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 279);
            this.panel2.TabIndex = 1;
            // 
            // picBAvatar
            // 
            this.picBAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBAvatar.Image = global::CaroLAN.Properties.Resources.caro;
            this.picBAvatar.Location = new System.Drawing.Point(3, 3);
            this.picBAvatar.Name = "picBAvatar";
            this.picBAvatar.Size = new System.Drawing.Size(275, 273);
            this.picBAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBAvatar.TabIndex = 0;
            this.picBAvatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.txtBIP);
            this.panel3.Controls.Add(this.picBMark);
            this.panel3.Controls.Add(this.txtBPlayerName);
            this.panel3.Controls.Add(this.progBCoolDown);
            this.panel3.Location = new System.Drawing.Point(528, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 252);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win";
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(14, 97);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(75, 23);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // txtBIP
            // 
            this.txtBIP.Location = new System.Drawing.Point(14, 71);
            this.txtBIP.Name = "txtBIP";
            this.txtBIP.Size = new System.Drawing.Size(100, 20);
            this.txtBIP.TabIndex = 3;
            this.txtBIP.Text = "127.0.0.1";
            // 
            // picBMark
            // 
            this.picBMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBMark.Location = new System.Drawing.Point(149, 16);
            this.picBMark.Name = "picBMark";
            this.picBMark.Size = new System.Drawing.Size(115, 86);
            this.picBMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMark.TabIndex = 2;
            this.picBMark.TabStop = false;
            // 
            // txtBPlayerName
            // 
            this.txtBPlayerName.Location = new System.Drawing.Point(14, 16);
            this.txtBPlayerName.Name = "txtBPlayerName";
            this.txtBPlayerName.ReadOnly = true;
            this.txtBPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtBPlayerName.TabIndex = 1;
            // 
            // progBCoolDown
            // 
            this.progBCoolDown.Location = new System.Drawing.Point(14, 42);
            this.progBCoolDown.Name = "progBCoolDown";
            this.progBCoolDown.Size = new System.Drawing.Size(100, 23);
            this.progBCoolDown.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Caro LAN C#";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBAvatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBAvatar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txtBIP;
        private System.Windows.Forms.PictureBox picBMark;
        private System.Windows.Forms.TextBox txtBPlayerName;
        private System.Windows.Forms.ProgressBar progBCoolDown;
    }
}

