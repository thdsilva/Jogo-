using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedra_Papel_Tesoura
{
    public partial class Form1 : Form
    {
        int pontosJogador, pontosCPU;
        enum Escolhas { Pedra, Papel, Tesoura }
        Escolhas[] escolhas = { Escolhas.Pedra, Escolhas.Papel, Escolhas.Tesoura };
        Escolhas jogadorEscolha, IAEscolha;
        bool proximo = false;

        public Form1()
        {
            InitializeComponent();
            bool proximo = false; PbIA.Image = null; PbJogador.Image = null;
        }

        private void Escolhas_Click(object sender, EventArgs e)
        {
            
            PictureBox imagemI = (PictureBox)sender;
            bool proximo = true;

            if (proximo)
            {

                switch (imagemI.Tag.ToString())
                {
                    case "pedra": jogadorEscolha = Escolhas.Pedra; PbJogador.Image = Properties.Resources.pedra_long; break;
                    case "papel": jogadorEscolha = Escolhas.Papel; PbJogador.Image = Properties.Resources.papel_long; break;
                    case "tesoura": jogadorEscolha = Escolhas.Tesoura; PbJogador.Image = Properties.Resources.tesoura_long; break;
                }
                proximo = false;
                JogadaIA();
            }
        }

               private void ChecarPedra()
        {
            switch (IAEscolha.ToString())
            {
                case "Pedra": MessageBox.Show("Empate!"); break;
                case "Papel": MessageBox.Show("Você Perdeu!");
                    pontosCPU++; lblIA.Text = "CPU: " + pontosCPU.ToString(); break;
                case "Tesoura": MessageBox.Show("Você Ganhou!");
                    pontosJogador++; lblJogador.Text = "Jogador: " + pontosJogador.ToString(); break;
            }
            proximo = true; PbIA.Image = null; PbJogador.Image = null;
        }

        private void ChecarPapel()
        {
            switch (IAEscolha.ToString())
            {
                case "Pedra": MessageBox.Show("Você Ganhou!");
                    pontosJogador++; lblJogador.Text = "Jogador: " + pontosJogador.ToString(); break;
                case "Papel":
                    MessageBox.Show("Você Empate!"); break;                
                case "Tesoura":
                    MessageBox.Show("Você Perdeu!");
                    pontosCPU++; lblIA.Text = "CPU: " + pontosCPU.ToString(); break;
            }
            proximo = true; PbIA.Image = null; PbJogador.Image = null;
        }

        private void ChecarTesoura()
        {
            switch (IAEscolha.ToString())
            {
                case "Pedra":
                    MessageBox.Show("Você Perdeu!");
                    pontosCPU++; lblIA.Text = "CPU: " + pontosCPU.ToString(); break;                   
                case "Papel":
                    MessageBox.Show("Você Ganhou!");
                    pontosJogador++; lblJogador.Text = "Jogador: " + pontosJogador.ToString(); break;
                case "Tesoura":
                    MessageBox.Show("Empate!"); break;  
                    
            }
            proximo = true; PbIA.Image = null; PbJogador.Image = null;
        }

        private void JogadaIA()
        {

            Random aleartorio = new Random();
            IAEscolha = escolhas[aleartorio.Next(0, escolhas.Length)];

            switch (IAEscolha.ToString())
            {
                case "Pedra": PbIA.Image = Properties.Resources.pedra_long2; break;
                case "Papel": PbIA.Image = Properties.Resources.papel_long2; break;
                case "Tesoura": PbIA.Image = Properties.Resources.tesoura_long2; break;
            }


            switch (jogadorEscolha.ToString())
            {
                case "Pedra": ChecarPedra(); break;
                case "Papel": ChecarPapel(); break;
                case "Tesoura": ChecarTesoura(); break;
            }


        }

    }
}