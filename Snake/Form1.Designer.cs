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
            pbCanvas.Location = new Point(10, 26);
            pbCanvas.Margin = new Padding(3, 2, 3, 2);
            pbCanvas.Name = "pbCanvas";
            pbCanvas.Size = new Size(679, 302);
            pbCanvas.TabIndex = 0;
            pbCanvas.TabStop = false;
            pbCanvas.Click += pbCanvas_Click;
            pbCanvas.Paint += pbCanvas_Paint;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Font = new Font("Segoe UI", 10F);
            lblPuntuacion.Location = new Point(10, 7);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(78, 19);
            lblPuntuacion.TabIndex = 1;
            lblPuntuacion.Text = "Puntuacion";
            lblPuntuacion.Click += label1_Click_1;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Segoe UI", 10F);
            lblPuntos.Location = new Point(101, 7);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(0, 19);
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
            gameOver.Location = new Point(130, 101);
            gameOver.Name = "gameOver";
            gameOver.Size = new Size(404, 89);
            gameOver.TabIndex = 3;
            gameOver.Text = "GAME OVER";
            gameOver.Visible = false;
            gameOver.Click += label1_Click_2;
            // 
            // restart
            // 
            restart.AutoSize = true;
            restart.Location = new Point(273, 212);
            restart.Name = "restart";
            restart.Size = new Size(125, 15);
            restart.TabIndex = 4;
            restart.Text = "Press ENTER to restart!";
            restart.Visible = false;
            restart.Click += restart_Click;
            // 
            // hardMode
            // 
            hardMode.AutoSize = true;
            hardMode.Location = new Point(623, 6);
            hardMode.Margin = new Padding(3, 2, 3, 2);
            hardMode.Name = "hardMode";
            hardMode.Size = new Size(61, 19);
            hardMode.TabIndex = 5;
            hardMode.Text = "HARD!";
            hardMode.UseVisualStyleBackColor = true;
            hardMode.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(hardMode);
            Controls.Add(restart);
            Controls.Add(gameOver);
            Controls.Add(lblPuntos);
            Controls.Add(lblPuntuacion);
            Controls.Add(pbCanvas);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
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
