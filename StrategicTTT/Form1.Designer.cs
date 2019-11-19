namespace StrategicTTT
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.playGrid = new System.Windows.Forms.TableLayoutPanel();
            this.tile9 = new System.Windows.Forms.Label();
            this.tile8 = new System.Windows.Forms.Label();
            this.tile7 = new System.Windows.Forms.Label();
            this.tile6 = new System.Windows.Forms.Label();
            this.tile5 = new System.Windows.Forms.Label();
            this.tile4 = new System.Windows.Forms.Label();
            this.tile3 = new System.Windows.Forms.Label();
            this.tile2 = new System.Windows.Forms.Label();
            this.tile1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.playGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.player1Label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.player2Label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.playGrid, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.player1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(481, 150);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(200, 75);
            this.player1Label.TabIndex = 1;
            this.player1Label.Text = "Player 1";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(481, 225);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(200, 75);
            this.player2Label.TabIndex = 2;
            this.player2Label.Text = "Player 2";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playGrid
            // 
            this.playGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playGrid.ColumnCount = 3;
            this.playGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.playGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.playGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.playGrid.Controls.Add(this.tile9, 2, 2);
            this.playGrid.Controls.Add(this.tile8, 1, 2);
            this.playGrid.Controls.Add(this.tile7, 0, 2);
            this.playGrid.Controls.Add(this.tile6, 2, 1);
            this.playGrid.Controls.Add(this.tile5, 1, 1);
            this.playGrid.Controls.Add(this.tile4, 0, 1);
            this.playGrid.Controls.Add(this.tile3, 2, 0);
            this.playGrid.Controls.Add(this.tile2, 1, 0);
            this.playGrid.Controls.Add(this.tile1, 0, 0);
            this.playGrid.Location = new System.Drawing.Point(38, 10);
            this.playGrid.Margin = new System.Windows.Forms.Padding(10);
            this.playGrid.Name = "playGrid";
            this.playGrid.RowCount = 3;
            this.tableLayoutPanel1.SetRowSpan(this.playGrid, 4);
            this.playGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33533F));
            this.playGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.playGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.playGrid.Size = new System.Drawing.Size(430, 430);
            this.playGrid.TabIndex = 3;
            // 
            // tile9
            // 
            this.tile9.AutoSize = true;
            this.tile9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile9.Location = new System.Drawing.Point(286, 286);
            this.tile9.Margin = new System.Windows.Forms.Padding(0);
            this.tile9.Name = "tile9";
            this.tile9.Size = new System.Drawing.Size(144, 144);
            this.tile9.TabIndex = 8;
            this.tile9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile8
            // 
            this.tile8.AutoSize = true;
            this.tile8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile8.Location = new System.Drawing.Point(143, 286);
            this.tile8.Margin = new System.Windows.Forms.Padding(0);
            this.tile8.Name = "tile8";
            this.tile8.Size = new System.Drawing.Size(143, 144);
            this.tile8.TabIndex = 7;
            this.tile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile7
            // 
            this.tile7.AutoSize = true;
            this.tile7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile7.Location = new System.Drawing.Point(0, 286);
            this.tile7.Margin = new System.Windows.Forms.Padding(0);
            this.tile7.Name = "tile7";
            this.tile7.Size = new System.Drawing.Size(143, 144);
            this.tile7.TabIndex = 6;
            this.tile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile6
            // 
            this.tile6.AutoSize = true;
            this.tile6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile6.Location = new System.Drawing.Point(286, 143);
            this.tile6.Margin = new System.Windows.Forms.Padding(0);
            this.tile6.Name = "tile6";
            this.tile6.Size = new System.Drawing.Size(144, 143);
            this.tile6.TabIndex = 5;
            this.tile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile5
            // 
            this.tile5.AutoSize = true;
            this.tile5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile5.Location = new System.Drawing.Point(143, 143);
            this.tile5.Margin = new System.Windows.Forms.Padding(0);
            this.tile5.Name = "tile5";
            this.tile5.Size = new System.Drawing.Size(143, 143);
            this.tile5.TabIndex = 4;
            this.tile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile4
            // 
            this.tile4.AutoSize = true;
            this.tile4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile4.Location = new System.Drawing.Point(0, 143);
            this.tile4.Margin = new System.Windows.Forms.Padding(0);
            this.tile4.Name = "tile4";
            this.tile4.Size = new System.Drawing.Size(143, 143);
            this.tile4.TabIndex = 3;
            this.tile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile3
            // 
            this.tile3.AutoSize = true;
            this.tile3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile3.Location = new System.Drawing.Point(286, 0);
            this.tile3.Margin = new System.Windows.Forms.Padding(0);
            this.tile3.Name = "tile3";
            this.tile3.Size = new System.Drawing.Size(144, 143);
            this.tile3.TabIndex = 2;
            this.tile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile2
            // 
            this.tile2.AutoSize = true;
            this.tile2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile2.Location = new System.Drawing.Point(143, 0);
            this.tile2.Margin = new System.Windows.Forms.Padding(0);
            this.tile2.Name = "tile2";
            this.tile2.Size = new System.Drawing.Size(143, 143);
            this.tile2.TabIndex = 1;
            this.tile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile1
            // 
            this.tile1.AutoSize = true;
            this.tile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile1.Location = new System.Drawing.Point(0, 0);
            this.tile1.Margin = new System.Windows.Forms.Padding(0);
            this.tile1.Name = "tile1";
            this.tile1.Size = new System.Drawing.Size(143, 143);
            this.tile1.TabIndex = 0;
            this.tile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile1.Click += new System.EventHandler(this.tile1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Strategic Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.playGrid.ResumeLayout(false);
            this.playGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.TableLayoutPanel playGrid;
        private System.Windows.Forms.Label tile1;
        private System.Windows.Forms.Label tile2;
        private System.Windows.Forms.Label tile9;
        private System.Windows.Forms.Label tile8;
        private System.Windows.Forms.Label tile7;
        private System.Windows.Forms.Label tile6;
        private System.Windows.Forms.Label tile5;
        private System.Windows.Forms.Label tile4;
        private System.Windows.Forms.Label tile3;
    }
}

