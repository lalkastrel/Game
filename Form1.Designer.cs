namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Fune = new System.Windows.Forms.PictureBox();
            this.LeftMove = new System.Windows.Forms.Timer(this.components);
            this.RightMove = new System.Windows.Forms.Timer(this.components);
            this.moveBulletsTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RestartText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fune)).BeginInit();
            this.SuspendLayout();
            // 
            // Fune
            // 
            this.Fune.BackgroundImage = global::Game.Properties.Resources.fune;
            this.Fune.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fune.Location = new System.Drawing.Point(455, 619);
            this.Fune.Name = "Fune";
            this.Fune.Size = new System.Drawing.Size(62, 82);
            this.Fune.TabIndex = 0;
            this.Fune.TabStop = false;
            this.Fune.Click += new System.EventHandler(this.Fune_Click);
            // 
            // LeftMove
            // 
            this.LeftMove.Enabled = true;
            this.LeftMove.Tick += new System.EventHandler(this.LeftMove_Tick);
            // 
            // RightMove
            // 
            this.RightMove.Enabled = true;
            this.RightMove.Tick += new System.EventHandler(this.RightMove_Tick);
            // 
            // moveBulletsTimer
            // 
            this.moveBulletsTimer.Enabled = true;
            this.moveBulletsTimer.Interval = 1;
            this.moveBulletsTimer.Tick += new System.EventHandler(this.moveBulletsTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Interval = 5;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.BackColor = System.Drawing.Color.Transparent;
            this.gameOver.Font = new System.Drawing.Font("Rubik", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameOver.Location = new System.Drawing.Point(221, 205);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(525, 114);
            this.gameOver.TabIndex = 1;
            this.gameOver.Text = "Game over";
            this.gameOver.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RestartText
            // 
            this.RestartText.AutoSize = true;
            this.RestartText.BackColor = System.Drawing.Color.Transparent;
            this.RestartText.Font = new System.Drawing.Font("Rubik", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RestartText.Location = new System.Drawing.Point(271, 319);
            this.RestartText.Name = "RestartText";
            this.RestartText.Size = new System.Drawing.Size(401, 42);
            this.RestartText.TabIndex = 4;
            this.RestartText.Text = "Press R to restart game";
            this.RestartText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.RestartText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.Fune);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Fune)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fune;
        private System.Windows.Forms.Timer LeftMove;
        private System.Windows.Forms.Timer RightMove;
        private System.Windows.Forms.Timer moveBulletsTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RestartText;
    }
}

