using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro
{
    public partial class frm_Cadastro : Form
    {
        public frm_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_Concluido_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            if (txt_nome.Text == "" ||  txt_sobrenome.Text == "" || txt_idade.Text == "")
            {
                MessageBox.Show("Digite todas as informações!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {            
                p1.nome = txt_nome.Text;
                p1.sobrenome = txt_sobrenome.Text;
                p1.idade = Convert.ToInt32(txt_idade.Text);             
                
                lbl_nometela.Text = p1.nomeCompleto();

                p1.falar();

                MessageBox.Show(p1.Status(p1.idade));
            }  
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txt_idade.Text = "";
            txt_nome.Text = "";
            txt_sobrenome.Text = "";
            lbl_nometela.Text = "";
            txt_nome.Focus();
        }

        private void txt_idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_sobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
