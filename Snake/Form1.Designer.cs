namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbCanvas = new PictureBox();
            lblPuntuacion = new Label();
            lblPuntos = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            gameOver = new Label();
            restart = new Label();
            hardMode = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbCanvas).BeginInit();
            SuspendLayout();
            // 
            // pbCanvas
            // 
            pbCanvas.Location = new Point(12, 35);
            pbCanvas.Name = "pbCanvas";
            pbCanvas.Size = new Size(776, 403);
            pbCanvas.TabIndex = 0;
            pbCanvas.TabStop = false;
            pbCanvas.Click += pbCanvas_Click;
            pbCanvas.Paint += pbCanvas_Paint;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Font = new Font("Segoe UI", 10F);
            lblPuntuacion.Location = new Point(12, 9);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(97, 23);
            lblPuntuacion.TabIndex = 1;
            lblPuntuacion.Text = "Puntuacion";
            lblPuntuacion.Click += label1_Click_1;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Segoe UI", 10F);
            lblPuntos.Location = new Point(115, 9);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(0, 23);
            lblPuntos.TabIndex = 2;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            // 
            // gameOver
            // 
            gameOver.AutoSize = true;
            gameOver.Cursor = Cursors.No;
            gameOver.Font = new Font("Segoe UI", 50F);
            gameOver.Location = new Point(148, 135);
            gameOver.Name = "gameOver";
            gameOver.Size = new Size(504, 112);
            gameOver.TabIndex = 3;
            gameOver.Text = "GAME OVER";
            gameOver.Visible = false;
            gameOver.Click += label1_Click_2;
            // 
            // restart
            // 
            restart.AutoSize = true;
            restart.Location = new Point(324, 247);
            restart.Name = "restart";
            restart.Size = new Size(158, 20);
            restart.TabIndex = 4;
            restart.Text = "Press ENTER to restart!";
            restart.Visible = false;
            // 
            // hardMode
            // 
            hardMode.AutoSize = true;
            hardMode.Location = new Point(712, 8);
            hardMode.Name = "hardMode";
            hardMode.Size = new Size(76, 24);
            hardMode.TabIndex = 5;
            hardMode.Text = "HARD!";
            hardMode.UseVisualStyleBackColor = true;
            hardMode.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hardMode);
            Controls.Add(restart);
            Controls.Add(gameOver);
            Controls.Add(lblPuntos);
            Controls.Add(lblPuntuacion);
            Controls.Add(pbCanvas);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pbCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCanvas;
        private Label lblPuntuacion;
        private Label lblPuntos;
        private System.Windows.Forms.Timer gameTimer;
        private Label gameOver;
        private Label restart;
        private CheckBox hardMode;
    }
}
