using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApp
{
    class Automovil
    {
        private int consumoLitro;
        private int litrosActuales;
        private int odometro;
        private int capacidad;
        private int reserva;

        //constructor
        public Automovil()
        {
            capacidad = 49;
            reserva = 5;
            litrosActuales = 0;
            consumoLitro = 11;
            odometro = 0;

        }

        public Automovil (int km, int lts)
        {
            odometro = km;
            litrosActuales = lts;
            capacidad = 49;
            reserva = 5;
        }

        //properties
        public int pConsumoLitro
        {

            get { return consumoLitro; }
            set { consumoLitro = value; }
        }
        

        public int pLitrosActuales
        {
            get { return litrosActuales; }
            set { litrosActuales = value; }
        }

        

        public int pOdometro
        {
            get { return odometro; }
            set { odometro = value; }
        }
        

        public int pCapacidad
        {
            get { return capacidad; }
            
        }
        

        public int pReserva
        {
            get { return reserva; }
           
        }
        //metodos de control

        
    }



}
