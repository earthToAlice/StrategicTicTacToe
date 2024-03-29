﻿namespace StrategicTTT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameScreen1 = new STTTBoard.GameScreen();
            this.winScreen1 = new STTTBoard.WinScreen();
            this.rulesScreen1 = new STTTBoard.RulesScreen();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gameScreen1);
            this.panel1.Controls.Add(this.winScreen1);
            this.panel1.Controls.Add(this.rulesScreen1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 461);
            this.panel1.TabIndex = 1;
            // 
            // gameScreen1
            // 
            this.gameScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.gameScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameScreen1.Location = new System.Drawing.Point(0, 0);
            this.gameScreen1.Name = "gameScreen1";
            this.gameScreen1.Size = new System.Drawing.Size(684, 461);
            this.gameScreen1.TabIndex = 2;
            this.gameScreen1.Turn = '\0';
            // 
            // winScreen1
            // 
            this.winScreen1.BackColor = System.Drawing.Color.SeaShell;
            this.winScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winScreen1.Location = new System.Drawing.Point(0, 0);
            this.winScreen1.Name = "winScreen1";
            this.winScreen1.Size = new System.Drawing.Size(684, 461);
            this.winScreen1.TabIndex = 1;
            // 
            // rulesScreen1
            // 
            this.rulesScreen1.BackColor = System.Drawing.Color.SeaShell;
            this.rulesScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesScreen1.Location = new System.Drawing.Point(0, 0);
            this.rulesScreen1.Name = "rulesScreen1";
            this.rulesScreen1.Size = new System.Drawing.Size(684, 461);
            this.rulesScreen1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strategic Tic-Tac-Toe";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private STTTBoard.WinScreen winScreen1;
        private STTTBoard.GameScreen gameScreen1;
        private STTTBoard.RulesScreen rulesScreen1;
    }
}

