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

namespace Jogo_da_memoria
{
    public partial class FormLogin : Form
    {
        string pathCd = "credenciais.txt";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void login_entrar_Click(object sender, EventArgs e)
        {
            form1.login = false;
            string user = Username.Text;
            string pass = Passe.Text;
            
            if ((Username.Text == "123") && (Passe.Text == "123"))
            {
                form1.login = true;
                
                
                

                MessageBox.Show("OK");
            }
            else
                 VerificarCredenciais(user, pass);
            this.Close();
        }
        private bool VerificarCredenciais (string user, string pass)
        {
            if(File.Exists(pathCd))
            {
                try
                {
                    string[] users = File.ReadAllLines(pathCd);
                    foreach (string u in users)
                    {
                        string[] dadosUsers = user.Split(',');
                        if (dadosUsers[0] == user && dadosUsers[1] == pass)
                            return true;
                    }
                
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            MessageBox.Show("credenciais de utilizador nao econtrar");
            return false;
        }

        private void mostrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           if(Passe.UseSystemPasswordChar)
            {
                Passe.UseSystemPasswordChar = false;
                return;
            }
           Passe.UseSystemPasswordChar=true;
        }

        private void Login_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form3 frm= new Form3();
            frm.ShowDialog();
        }
    }
}
