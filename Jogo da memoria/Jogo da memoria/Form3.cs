using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace Jogo_da_memoria
{
    public partial class Form3 : Form
    {
        string partcd = " credenciais.txt";
        public Form3()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Criar_Click(object sender, EventArgs e)
        {
            if (Username.Text != "" && Passe.Text != "")
            {
                if (Passe.Text == passe2.Text)
                {
                    if (!UtilizadorJaExistente(Username.Text))
                        RegistarDadosUtiliz(Username.Text, Passe.Text);
                    else
                        MessageBox.Show("utilizador ja existente!!");
                }
                    else
                        MessageBox.Show("as passowrds nao cooicidem!!");
                Passe.Text = "";
                passe2.Text = "";
                Passe.Focus();

            }
            
        }

        private bool UtilizadorJaExistente(string user)
        {
            if(File.Exists(partcd))
            {
                try
                {
                    string[] users = File.ReadAllLines(partcd);
                    foreach (string linhauser in users) 
                    {
                        string[] dadosUser = linhauser.Split(':');
                        if (dadosUser[0] == user) return true;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Text, ex.Message);
                }
            }
            return false;
            
        }
        private void RegistarDadosUtiliz(string user, string pass)
        {
            try
            {
                string texto = "\n" + user + "#" + pass;
                File.AppendAllText(partcd, texto);
                MessageBox.Show("Novo utilizador registado com suceso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

