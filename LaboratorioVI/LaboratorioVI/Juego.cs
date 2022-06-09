using Entidades;
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


namespace LaboratorioVI
{
    public partial class Juego : Form
    {

        Entidades.Juego juego;
        Zombie zombie;
        Zombie2 zombie2;

        //Lista de botones Zombis
        private List<Button> botonesZombis = new List<Button>();
        private List<Button> botonesZombie2 = new List<Button>();

        


        public Juego()
        {
            InitializeComponent();

        }
        

            
       

        private void btnZombie_Click(object sender, EventArgs e)
        {
            int puntajeActual = juego.ObtenerPuntaje();

            puntajeActual += zombie.ObtenerPuntaje();
            juego.AsignarPuntaje(puntajeActual);
            Controls.Remove((Button)sender);
            ActualizarUI();

            int puntajeActual2 = juego.ObtenerPuntaje2();
            puntajeActual2 += zombie2.ObtenerPuntaje2();
            juego.AsignarPuntaje2(puntajeActual2);
            

            Controls.Remove((Button)sender);
            ActualizarUI();
        }

        private void ActualizarUI()
        {

            lblpuntajeobtener.Text = juego.ObtenerPuntaje().ToString();
            
            
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            juego = new Entidades.Juego();
            zombie = new Zombie(5, 10);
            zombie2 = new Zombie2(5, 30);


            



        }

        private void timerZombie_Tick(object sender, EventArgs e)
        {
            //Zombie2
            Button nuevoZombie2 = new Button();
            nuevoZombie2.Size = new Size(108, 172);
            nuevoZombie2.FlatAppearance.BorderSize = 0;
            nuevoZombie2.FlatStyle = FlatStyle.Popup;
            nuevoZombie2.BackgroundImage = Properties.Resources._047524076;
            nuevoZombie2.BackgroundImageLayout = ImageLayout.Zoom;
            nuevoZombie2.BackColor = Color.Transparent;
            nuevoZombie2.Cursor = Cursors.Hand;

            //Zombie1
            Button nuevoZombie = new Button();
            nuevoZombie.Size = new Size(108,172);
            nuevoZombie.FlatAppearance.BorderSize = 0;
            nuevoZombie.FlatStyle = FlatStyle.Popup;
            nuevoZombie.BackgroundImage = Properties.Resources.zombie_PNG51;
            nuevoZombie.BackgroundImageLayout = ImageLayout.Zoom;
            nuevoZombie.BackColor = Color.Transparent;
            nuevoZombie.Cursor = Cursors.Hand;
            

            Random rX = new Random();
            nuevoZombie.Location = new Point(rX.Next(0, Width - nuevoZombie.Width), rX.Next(0,Height-nuevoZombie.Height));
            nuevoZombie.Click += btnZombie_Click;
            Controls.Add(nuevoZombie);
            botonesZombis.Add(nuevoZombie);

            Random rY = new Random();
            nuevoZombie2.Location = new Point(rY.Next(0, Width - nuevoZombie2.Width), rY.Next(0, Height - nuevoZombie2.Height));
            nuevoZombie2.Click += btnZombie_Click;
            Controls.Add(nuevoZombie2);
            botonesZombie2.Add(nuevoZombie2);
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lblPuntaje_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //atributo
        int contador = 0;
        int contador2 = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Controls.Remove(botonesZombis[contador]);
            contador++;
            Controls.Remove(botonesZombie2[contador2]);
            contador2++;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void TimerZombie2_Tick(object sender, EventArgs e)
        {
            
            

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliste");

            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        int a = 30;
        private void TimerFinal_Tick(object sender, EventArgs e)
        {
            a = a - 1;
            this.label3.Text = a.ToString();

            if (a == 0)
            {
                MessageBox.Show("Tu puntaje final es: " + juego.ObtenerPuntaje().ToString());
                MessageBox.Show("Zombies Aplastados: " + juego.ObtenerPuntaje()/10);
                Application.Exit();
                


            }

        }
    }
}
