using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_memoria
{
    public partial class FormD_Chosen : Form
    {
        public FormD_Chosen()
        {
            InitializeComponent();
        }

        private void FormD_Chosen_Load(object sender, EventArgs e)
        {
            distribuircartas();
            atribuirtags();
        }
        const int ncartas = 50;
        int nCliques = 0;
        Button cartaAnterior;
        byte restanteCt = ncartas / 2;

        private void Form_Dificuldade_Click(object sender, EventArgs e)
        {
            FormDificuldade formDificuldade = new FormDificuldade();


            formDificuldade.ShowDialog();
        }

        private SoundPlayer playerMusicaFundo;

        private void MUSICA(object sender, EventArgs e)
        {
            playerMusicaFundo = new SoundPlayer(Properties.Resources.musica);
            playerMusicaFundo.PlayLooping();
        }

        private void Jogar_de_novo_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CompararCartas(Button cAnterior, Button cAtual)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            if (cAnterior == cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta");
                nCliques = 0;
                cAtual.BackgroundImage = Properties.Resources.icon_do_iconjpeg;
            }
            else
            {
                if (cAtual.Tag.ToString() == cAnterior.Tag.ToString())
                {
                    restanteCt--;
                    nCliques = 0;
                    cAnterior.Visible = false;
                    cAtual.Visible = false;
                    //VerificarSeGanhou();

                    //labelPontosN.Text = "" + zero2;

                    //zero2 += d10;
                }
                else
                {
                    nCliques = 0;
                    cAnterior.BackgroundImage = Properties.Resources.icon_do_iconjpeg;
                    cAtual.BackgroundImage = Properties.Resources.icon_do_iconjpeg;
                }
                SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.musica);
                sp.PlayLooping();

            }




        }
        private void atribuirtags()
        {
            int[] tags = new int[ncartas];
            Random rnd = new Random();

            int i = 0;
            int n;
            while (i < ncartas)
            {
                n = rnd.Next(1, ncartas + 1);
                if (Array.IndexOf(tags, n) == -1)
                {
                    tags[i] = n;
                    i++;
                }
            }
            for (int j = 0; j < ncartas; j++)
                if (tags[j] > (ncartas / 2)) tags[j] = tags[j] - (ncartas / 2);

            i = 0;
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "U")
                {
                    x.Tag = tags[i];
                    i++;
                }
        }
        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "U"))
                    x.Visible = false;
        }

        private void distribuircartas()
        {
            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "U"))
                {
                    x.BackgroundImage = Properties.Resources.icon_do_iconjpeg;
                    x.Visible = true;
                }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button cartaAtual = sender as Button;
            string s = "_" + (cartaAtual).Tag.ToString();
            object o = Properties.Resources.ResourceManager.GetObject(s);
            cartaAtual.BackgroundImage = (System.Drawing.Image)o;


            if (nCliques == 0)
            {
                cartaAnterior = cartaAtual;
                nCliques++;
            }
            else
                CompararCartas(cartaAtual, cartaAnterior);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ocultar();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void Mostrar_Click_1(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "L")
                {
                    string s = "_" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;

                }
            Application.DoEvents();
            System.Threading.Thread.Sleep(100);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "L")
                    x.BackgroundImage = Properties.Resources.icon_do_iconjpeg;
        }
    }
}
