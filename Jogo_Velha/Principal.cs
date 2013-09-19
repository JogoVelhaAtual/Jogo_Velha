using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_Velha
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show("O tabuleiro é uma matriz de três linhas por três colunas\n"+
                            "Dois jogadores escolhem uma marcação cada um, geralmente um círculo (O) e um xis (X)"+
                            "\nOs jogadores jogam alternadamente, uma marcação por vez, numa lacuna que esteja vazia"+
                            "\nO objetivo é conseguir três círculos ou três xis em linha, quer horizontal, vertical ou diagonal , e ao mesmo tempo, quando possível, impedir o adversário de ganhar na próxima jogada"+
                           "\nQuando um jogador conquista o objetivo, costuma-se riscar os três símbolos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Nform = new Form1();
            Nform.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Deseja Sair do Jogo ?", "****FINALIZANDO****", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
