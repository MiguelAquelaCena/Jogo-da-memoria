using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_memoria
{
    public partial class FormDificuldade : Form
    {
        public FormDificuldade()
        {
            InitializeComponent();
        }

        private void FormDificuldade_Load(object sender, EventArgs e)
        {

        }

        private void Dif_Facil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dif_media_Click(object sender, EventArgs e)
        {
            if (form1.login)
            {
                FormDMedia frm = new FormDMedia();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Por favor faça o login!");

        }

        private void Def_Dificil_Click(object sender, EventArgs e)
        {
            if (form1.login)
            {
                FormD_Dificil frm = new FormD_Dificil();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Por favor faça o login!");
        }

        private void Dif_Chosen_Click(object sender, EventArgs e)
        {
            if (form1.login)
            {
                FormD_Chosen frm = new FormD_Chosen();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Por favor faça o login!");
        }
    }
}
