using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Zombie
    {
        private float Tiempo;
        private int Puntaje;
        
        public Zombie()
        {
        }
        public Zombie(float tiempo, int puntaje)
        {
            Tiempo = tiempo;
            Puntaje = puntaje;
        }
        public void AsignarTiempo(float tiempo)
        {
            Tiempo = tiempo;
        }

        public float ObtenerTiempo()
        {
            return Tiempo;
        }
        public void AsignarPuntaje(int puntaje)
        {
            Puntaje = puntaje;
        }
        public int ObtenerPuntaje()
        {
            return Puntaje;
        }
       
    }
    public class Zombie2
    {
        private float Tiempo2;
        private int Puntaje2;

        public Zombie2()
        {

        }

        public Zombie2(float tiempo2, int puntaje2)
        {
            Tiempo2 = tiempo2;
            Puntaje2 = puntaje2;
        }

        public float ObtenerTiempo2()
        {
            return Tiempo2;
        }
        public void AsignarTiempo2(float tiempo2)
        {
            Tiempo2 = tiempo2;
        }
        public int ObtenerPuntaje2()
        {
            return Puntaje2;
        }
        public void AsignaraPuntaje2(int puntaje2)
        {
            Puntaje2 = puntaje2;
        }


    }


}
