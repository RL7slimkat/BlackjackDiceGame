using System;

namespace Blackjack21
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.handTimer = new System.Windows.Forms.Timer(this.components);
            this.diceThrowTimer = new System.Windows.Forms.Timer(this.components);
            this.dicePickupTimer = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.diceBox2 = new System.Windows.Forms.PictureBox();
            this.diceBox1 = new System.Windows.Forms.PictureBox();
            this.handGif = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(742, 111);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BlackJack Dice";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(-4, 554);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(769, 69);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.Button1_Click);
            // 
            // handTimer
            // 
            this.handTimer.Enabled = true;
            this.handTimer.Interval = 5200;
            this.handTimer.Tick += new System.EventHandler(this.handTimer_Tick);
            // 
            // diceThrowTimer
            // 
            this.diceThrowTimer.Enabled = true;
            this.diceThrowTimer.Interval = 2000;
            this.diceThrowTimer.Tick += new System.EventHandler(this.diceThrowTimer_Tick);
            // 
            // dicePickupTimer
            // 
            this.dicePickupTimer.Enabled = true;
            this.dicePickupTimer.Interval = 3425;
            this.dicePickupTimer.Tick += new System.EventHandler(this.dicePickupTimer_Tick);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblResult.Location = new System.Drawing.Point(12, 172);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(267, 223);
            this.lblResult.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.btnExit.Location = new System.Drawing.Point(-4, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 69);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.YellowGreen;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(690, 554);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 69);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // diceBox2
            // 
            this.diceBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diceBox2.BackgroundImage = global::Blackjack21.Properties.Resources.transparent;
            this.diceBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.diceBox2.Image = global::Blackjack21.Properties.Resources.rightDice6;
            this.diceBox2.Location = new System.Drawing.Point(419, 445);
            this.diceBox2.Name = "diceBox2";
            this.diceBox2.Size = new System.Drawing.Size(82, 100);
            this.diceBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceBox2.TabIndex = 5;
            this.diceBox2.TabStop = false;
            // 
            // diceBox1
            // 
            this.diceBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diceBox1.BackgroundImage = global::Blackjack21.Properties.Resources.transparent;
            this.diceBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.diceBox1.Image = global::Blackjack21.Properties.Resources.leftDice6;
            this.diceBox1.InitialImage = null;
            this.diceBox1.Location = new System.Drawing.Point(320, 427);
            this.diceBox1.Name = "diceBox1";
            this.diceBox1.Size = new System.Drawing.Size(93, 100);
            this.diceBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceBox1.TabIndex = 4;
            this.diceBox1.TabStop = false;
            // 
            // handGif
            // 
            this.handGif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.handGif.Image = global::Blackjack21.Properties.Resources.RlY0;
            this.handGif.InitialImage = global::Blackjack21.Properties.Resources.RlY0;
            this.handGif.Location = new System.Drawing.Point(285, 65);
            this.handGif.Name = "handGif";
            this.handGif.Size = new System.Drawing.Size(480, 480);
            this.handGif.TabIndex = 2;
            this.handGif.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(766, 621);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.diceBox2);
            this.Controls.Add(this.diceBox1);
            this.Controls.Add(this.handGif);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Blackjack Dice";
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private void DicePickupTimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DiceThrowTimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HandTimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox handGif;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox diceBox1;
        private System.Windows.Forms.PictureBox diceBox2;
        private System.Windows.Forms.Timer handTimer;
        private System.Windows.Forms.Timer diceThrowTimer;
        private System.Windows.Forms.Timer dicePickupTimer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
    }
}

