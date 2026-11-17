namespace SisPadoca.View
{
    partial class FrmSplash
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            LblTitulo = new Label();
            LblMensagem = new Label();
            LblPercentual = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(255, 255, 128);
            progressBar1.Location = new Point(-9, 299);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(638, 30);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 20.25F);
            LblTitulo.Location = new Point(276, 31);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(367, 37);
            LblTitulo.TabIndex = 1;
            LblTitulo.Text = "Sistema de gestão de padaria";
            // 
            // LblMensagem
            // 
            LblMensagem.AutoSize = true;
            LblMensagem.Font = new Font("Segoe UI", 20.25F);
            LblMensagem.Location = new Point(369, 143);
            LblMensagem.Name = "LblMensagem";
            LblMensagem.Size = new Size(184, 37);
            LblMensagem.TabIndex = 2;
            LblMensagem.Text = "Inicializando...";
            // 
            // LblPercentual
            // 
            LblPercentual.AutoSize = true;
            LblPercentual.Font = new Font("Segoe UI", 20.25F);
            LblPercentual.Location = new Point(296, 259);
            LblPercentual.Name = "LblPercentual";
            LblPercentual.Size = new Size(54, 37);
            LblPercentual.TabIndex = 3;
            LblPercentual.Text = "0%";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.group;
            pictureBox1.Location = new Point(29, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(666, 321);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(LblPercentual);
            Controls.Add(LblMensagem);
            Controls.Add(LblTitulo);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sispadoca";
            Load += FrmSplash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label LblTitulo;
        private Label LblMensagem;
        private Label LblPercentual;
        private PictureBox pictureBox1;
    }
}