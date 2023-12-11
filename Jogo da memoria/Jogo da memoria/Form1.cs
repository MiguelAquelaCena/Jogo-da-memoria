using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jogo_da_memoria
{
    public partial class form1 : Form
    {

        static public bool login = false;
        const int ncartas = 20;
        int nCliques = 0;
        Button cartaAnterior;
        byte restanteCt = ncartas / 2;



        public form1()
        {
            InitializeComponent();
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
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.Tag = tags[i];
                    i++;
                }

            //for (int j = 0; j < ncartas; j++)
            // MessageBox.Show("tags[" + j + "]=" + tags[j]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ocultar();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;

        }

        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "c"))
                    x.Visible = false;
        }

        private void distribuircartas()
        {
            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "c"))
                {
                    x.BackgroundImage = Properties.Resources.icon_do_iconjpeg;
                    x.Visible = true;
                }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
            if (login)
            {
                distribuircartas();
                atribuirtags();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "_" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage =(System.Drawing.Image)o;

                }
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.icon_do_iconjpeg;

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button cartaAtual = sender as Button;
            string s = "_" + (cartaAtual).Tag.ToString();
            object o=Properties.Resources.ResourceManager.GetObject(s);
            cartaAtual.BackgroundImage = (System.Drawing.Image)o;


            if (nCliques == 0)
            {
                cartaAnterior = cartaAtual;
                nCliques++;
            }
            else
                CompararCartas(cartaAtual, cartaAnterior);
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

          private SoundPlayer playerMusicaFundo;

          private void Form1(object sender, EventArgs e)
    {
          Ocultar();
          toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
          toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
          timer1.Enabled = true;
          playerMusicaFundo = new SoundPlayer(Properties.Resources.musica);
          playerMusicaFundo.PlayLooping();
    }

        private void Form_Dificuldade_Click(object sender, EventArgs e)
        {
            
            FormDificuldade formDificuldade = new FormDificuldade();

            
            formDificuldade.ShowDialog();
        }

        private void Jogar_de_novo_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

