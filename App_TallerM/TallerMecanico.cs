using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace App_TallerM
{
    class TallerMecanico
    {
        ConsoleKeyInfo Opcion = new ConsoleKeyInfo();
        //Cola para dueños
        public Queue<string> Dueños = new Queue<string>();
        //Cola para autos
        public Queue<string> Autos = new Queue<string>();
        //Listas
        public ArrayList Lista_Dueños = new ArrayList();
        public ArrayList Lista_Cobros = new ArrayList();
        public ArrayList Lista_Autos = new ArrayList();
       
        //-----Atributos
        int capacidad, autos_atendidos;
        double cobro = 0;
        //----Propiedades
        public int CAPACIDAD
        {
            get { return this.capacidad; }
            set { this.capacidad = value; }
        }
        public double COBRO
        {
            get { return this.cobro; }
            set { this.cobro = value; }
        }
        public int AUTOS_ATENDIDOS
        {
            get { return this.autos_atendidos; }
            set { this.autos_atendidos = value; }
        }
        
    }
}
