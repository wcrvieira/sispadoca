using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisPadoca.View
{
    public partial class FrmSplash : Form
    {
        int progresso = 0;
        public FrmSplash()
        {
            InitializeComponent();
            timer1.Interval = 50;
            timer1.Start();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progresso < 100)
            {
                progresso += 2;

                if (progresso > 100)
                {
                    progresso = 100;
                }

                progressBar1.Value = progresso;

                LblPercentual.Text = progresso + "%";

                if (progresso < 30)
                {
                    LblMensagem.Text = "Inicializando...";
                }
                else if (progresso < 70)
                {
                    LblMensagem.Text = "Carregando módulos...";
                }
                else
                {
                    LblMensagem.Text = "Finalizando...";
                }
            }

            if (progresso >= 100)
            {
                timer1.Stop();                

                this.Hide();                
            }
        }
    }
}
