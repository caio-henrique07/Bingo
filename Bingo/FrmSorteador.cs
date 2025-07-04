﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class FrmSorteador : Form
    {
        Form anterior;
        int qtd;
        bool[] sorteados;
        FrmCartela[] cartelas;

        public FrmSorteador(Form anterior, int qtd)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.qtd = qtd;

            sorteados = new bool[76];
            for (int i = 0; i < sorteados.Length; i++)
            {
                sorteados[i] = false;
            }

            cartelas = new FrmCartela[qtd];
            for (int i = 0; i < qtd; i++)
            {
                cartelas[i] = new FrmCartela(this, i);
                cartelas[i].Show();
            }
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            int num;
            do
            {
                num = R.Next(1, 76);
            } while (sorteados[num]);
            sorteados[num] = true;

            foreach (FrmCartela cartela in cartelas)
                cartela.ReceberNumero(num);

            lblNumero.Text = num.ToString();
        }

        public void AnunciarVitoria(FrmCartela cartela)
        {
            foreach (FrmCartela c in cartelas)
            {
                if (c != cartela)
                {
                    c.Close();
                }
            }

            cartela.Focus();
            btProximo.Enabled = false;
        }

        private void btHistorico_Click(object sender, EventArgs e)
        {
            FrmHistorico f = new FrmHistorico(sorteados);
            f.ShowDialog(this);
        }

        private void FrmSorteador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                        "Deseja mesmo encerrar o sorteio?",
                        "Bingo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                foreach (FrmCartela cartela in cartelas)
                {
                    cartela.Close();

                    anterior.Show();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
