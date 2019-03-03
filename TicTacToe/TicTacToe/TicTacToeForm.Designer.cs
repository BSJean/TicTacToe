namespace TicTacToe
{
    partial class TicTacToeForm
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
            this.button00 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelDraw = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button00
            // 
            this.button00.Location = new System.Drawing.Point(12, 12);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(75, 75);
            this.button00.TabIndex = 0;
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 93);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 75);
            this.button10.TabIndex = 0;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(12, 174);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 75);
            this.button20.TabIndex = 0;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button_Click);
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(93, 12);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(75, 75);
            this.button01.TabIndex = 0;
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(93, 93);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 75);
            this.button11.TabIndex = 0;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(93, 174);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 75);
            this.button21.TabIndex = 0;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button_Click);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(174, 12);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(75, 75);
            this.button02.TabIndex = 0;
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(174, 93);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 75);
            this.button12.TabIndex = 0;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(174, 174);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 75);
            this.button22.TabIndex = 0;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 294);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(110, 51);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(139, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 51);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(331, 74);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(40, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X won:";
            // 
            // labelDraw
            // 
            this.labelDraw.AutoSize = true;
            this.labelDraw.Location = new System.Drawing.Point(331, 137);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(40, 13);
            this.labelDraw.TabIndex = 2;
            this.labelDraw.Text = "Draws:";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(331, 105);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(41, 13);
            this.labelO.TabIndex = 2;
            this.labelO.Text = "O won:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit game";
            this.btnExit.UseMnemonic = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 371);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelDraw);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button00);
            this.Name = "TicTacToeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelDraw;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Button btnExit;
    }
}

