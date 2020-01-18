namespace TicTacToe
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
            this.StartGameBTN = new System.Windows.Forms.Button();
            this.Player2Name = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.Label();
            this.TileParentBox = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerSignBox = new System.Windows.Forms.GroupBox();
            this.playerSignSwapBox = new System.Windows.Forms.PictureBox();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.pictureBoxSelect1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSelect2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gameControl = new System.Windows.Forms.TabControl();
            this.TileParentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PlayerSignBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSignSwapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelect2)).BeginInit();
            this.gameControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartGameBTN
            // 
            this.StartGameBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartGameBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartGameBTN.Location = new System.Drawing.Point(2, 57);
            this.StartGameBTN.Name = "StartGameBTN";
            this.StartGameBTN.Size = new System.Drawing.Size(100, 36);
            this.StartGameBTN.TabIndex = 17;
            this.StartGameBTN.TabStop = false;
            this.StartGameBTN.Text = "Start";
            this.StartGameBTN.UseVisualStyleBackColor = false;
            // 
            // Player2Name
            // 
            this.Player2Name.AutoSize = true;
            this.Player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Player2Name.Location = new System.Drawing.Point(233, 0);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(62, 24);
            this.Player2Name.TabIndex = 16;
            this.Player2Name.Text = "Player";
            // 
            // Player1Name
            // 
            this.Player1Name.AutoSize = true;
            this.Player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Player1Name.Location = new System.Drawing.Point(2, 0);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(93, 24);
            this.Player1Name.TabIndex = 15;
            this.Player1Name.Text = "Computer";
            // 
            // TileParentBox
            // 
            this.TileParentBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TileParentBox.Controls.Add(this.pictureBox4);
            this.TileParentBox.Controls.Add(this.pictureBox0);
            this.TileParentBox.Controls.Add(this.pictureBox7);
            this.TileParentBox.Controls.Add(this.pictureBox5);
            this.TileParentBox.Controls.Add(this.pictureBox6);
            this.TileParentBox.Controls.Add(this.pictureBox3);
            this.TileParentBox.Controls.Add(this.pictureBox2);
            this.TileParentBox.Controls.Add(this.pictureBox8);
            this.TileParentBox.Controls.Add(this.pictureBox1);
            this.TileParentBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TileParentBox.Enabled = false;
            this.TileParentBox.Location = new System.Drawing.Point(0, 131);
            this.TileParentBox.Name = "TileParentBox";
            this.TileParentBox.Size = new System.Drawing.Size(363, 158);
            this.TileParentBox.TabIndex = 1;
            this.TileParentBox.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(152, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "4";
            // 
            // pictureBox0
            // 
            this.pictureBox0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox0.Location = new System.Drawing.Point(101, -1);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(50, 50);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox0.TabIndex = 0;
            this.pictureBox0.TabStop = false;
            this.pictureBox0.Tag = "0";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(152, 101);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "7";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(203, 50);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "5";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(101, 101);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "6";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(101, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(203, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(203, 101);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(152, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            // 
            // PlayerSignBox
            // 
            this.PlayerSignBox.Controls.Add(this.playerSignSwapBox);
            this.PlayerSignBox.Controls.Add(this.ResetBTN);
            this.PlayerSignBox.Controls.Add(this.StartGameBTN);
            this.PlayerSignBox.Controls.Add(this.Player2Name);
            this.PlayerSignBox.Controls.Add(this.Player1Name);
            this.PlayerSignBox.Controls.Add(this.pictureBoxSelect1);
            this.PlayerSignBox.Controls.Add(this.pictureBoxSelect2);
            this.PlayerSignBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayerSignBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerSignBox.Location = new System.Drawing.Point(0, 31);
            this.PlayerSignBox.Name = "PlayerSignBox";
            this.PlayerSignBox.Size = new System.Drawing.Size(363, 95);
            this.PlayerSignBox.TabIndex = 18;
            this.PlayerSignBox.TabStop = false;
            // 
            // playerSignSwapBox
            // 
            this.playerSignSwapBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playerSignSwapBox.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.playerSignSwapBox.Image = global::TicTacToe.Properties.Resources.swap2;
            this.playerSignSwapBox.Location = new System.Drawing.Point(181, 0);
            this.playerSignSwapBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerSignSwapBox.Name = "playerSignSwapBox";
            this.playerSignSwapBox.Size = new System.Drawing.Size(33, 33);
            this.playerSignSwapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerSignSwapBox.TabIndex = 19;
            this.playerSignSwapBox.TabStop = false;
            // 
            // ResetBTN
            // 
            this.ResetBTN.Enabled = false;
            this.ResetBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResetBTN.Location = new System.Drawing.Point(259, 57);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(100, 36);
            this.ResetBTN.TabIndex = 18;
            this.ResetBTN.TabStop = false;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.UseVisualStyleBackColor = false;
            // 
            // pictureBoxSelect1
            // 
            this.pictureBoxSelect1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxSelect1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSelect1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxSelect1.Image = global::TicTacToe.Properties.Resources.oh;
            this.pictureBoxSelect1.Location = new System.Drawing.Point(101, 0);
            this.pictureBoxSelect1.Name = "pictureBoxSelect1";
            this.pictureBoxSelect1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxSelect1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelect1.TabIndex = 13;
            this.pictureBoxSelect1.TabStop = false;
            this.pictureBoxSelect1.Tag = "O";
            // 
            // pictureBoxSelect2
            // 
            this.pictureBoxSelect2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxSelect2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSelect2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxSelect2.Image = global::TicTacToe.Properties.Resources.ex;
            this.pictureBoxSelect2.Location = new System.Drawing.Point(309, 0);
            this.pictureBoxSelect2.Name = "pictureBoxSelect2";
            this.pictureBoxSelect2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxSelect2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelect2.TabIndex = 14;
            this.pictureBoxSelect2.TabStop = false;
            this.pictureBoxSelect2.Tag = "X";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(344, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multi Player";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(355, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Player";
            // 
            // gameControl
            // 
            this.gameControl.Controls.Add(this.tabPage1);
            this.gameControl.Controls.Add(this.tabPage2);
            this.gameControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gameControl.Location = new System.Drawing.Point(0, 0);
            this.gameControl.Name = "gameControl";
            this.gameControl.SelectedIndex = 0;
            this.gameControl.Size = new System.Drawing.Size(363, 31);
            this.gameControl.TabIndex = 0;
            this.gameControl.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(363, 289);
            this.Controls.Add(this.PlayerSignBox);
            this.Controls.Add(this.TileParentBox);
            this.Controls.Add(this.gameControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TileParentBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PlayerSignBox.ResumeLayout(false);
            this.PlayerSignBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSignSwapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelect2)).EndInit();
            this.gameControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox TileParentBox;
        private System.Windows.Forms.Label Player2Name;
        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.PictureBox pictureBoxSelect2;
        private System.Windows.Forms.PictureBox pictureBoxSelect1;
        private System.Windows.Forms.Button StartGameBTN;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox PlayerSignBox;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl gameControl;
        private System.Windows.Forms.PictureBox playerSignSwapBox;
    }
}

