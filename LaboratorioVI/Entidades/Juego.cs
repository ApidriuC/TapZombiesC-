using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juego
    {
        private int Puntaje;
        private int Vidas;
        private int CantidadZombiesAplastados;
        private int Puntaje2;


        public Juego()
        {

        }
        public Juego(int puntaje, int vidas, int cantidadzombiesaplastados, int puntaje2)
        {
            Puntaje = puntaje;
            Vidas = vidas;
            CantidadZombiesAplastados = cantidadzombiesaplastados;
        }
        public void AsignarPuntaje(int puntaje)
        {
            Puntaje = puntaje;
        }
        public int ObtenerPuntaje()
        {
            return Puntaje;
        }
        public void AsignarVidas(int vidas)
        {
            Vidas = vidas;
        }
        public int ObtenerVidas()
        {
            return Vidas;
        }
        public void AsignarCantidad(int cantidadzombiesaplastados)
        {
            CantidadZombiesAplastados = cantidadzombiesaplastados;
        }
        public int ObtenerCantidad()
        {
            return CantidadZombiesAplastados;
        }
        public int ObtenerPuntaje2()
        {
            return Puntaje2;
        }
        public void AsignarPuntaje2(int puntaje2)
        {
            Puntaje2 = puntaje2;
        }
    }
}
