using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioVI
{
    public partial class Menu : Form
    {

        

        public Menu()
        {
            
            InitializeComponent();
          
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Saliste!");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Tienes 30 segundos para matar la mayor cantidad de zombies!");
            this.Hide();
            Juego Ventana5 = new Juego();
            Ventana5.ShowDialog();
        }



        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
