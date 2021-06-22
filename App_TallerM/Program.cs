using System;
using System.Collections;

namespace App_TallerM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se utilizó un objeto de la clase consoleKeyInfo para el menú
            ConsoleKeyInfo menu = new ConsoleKeyInfo();
            //Instancia
            TallerMecanico objTallerM = new TallerMecanico();
            double Cobro;
            objTallerM.CAPACIDAD = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elige una opción: ");
                Console.WriteLine("a) Ingresar Auto");
                Console.WriteLine("b) Aplicar cobro y sacar Auto");
                Console.WriteLine("c) Mostrar Lista de Autos");
                Console.WriteLine("d) Salir");
                menu = Console.ReadKey(true);
                switch (menu.Key)
                {
                    case ConsoleKey.A:
                        {
                            Console.Clear();
                            //Este if nos evitará exeder de la capacidad del taller
                            if (objTallerM.CAPACIDAD > 4)
                            {
                                Console.WriteLine("¡El taller se encuentra lleno!");
                                Console.ReadKey(); break;
                            }
                            Console.WriteLine("♦♦♦ REGISTRO ♦♦♦");
                            Console.Write("►►Dueño: ");
                            //Se añade en la cola
                            objTallerM.Dueños.Enqueue(Console.ReadLine());
                            Console.Write("►►Placas: ");
                            //Se añade en la cola
                            objTallerM.Autos.Enqueue(Console.ReadLine());
                            //Se aumenta 1 a la capacidad y a los autos atendidos
                            objTallerM.CAPACIDAD++;
                            objTallerM.AUTOS_ATENDIDOS++;
                        }
                        break;
                    case ConsoleKey.B:
                        {
                            Console.Clear();
                            if (objTallerM.CAPACIDAD == 0)
                            {
                                Console.WriteLine("♦ EL TALLER ESTÁ VACIO ♦");
                                Console.ReadKey(); break;
                            }
                            Console.Write("►►COBRO: ");
                            Cobro = Convert.ToDouble(Console.ReadLine());
                            objTallerM.COBRO = objTallerM.COBRO + Cobro;
                            //Se agregan a la lista de los cobros
                            objTallerM.Lista_Cobros.Add(Cobro);
                            //Agregar a la lista de autos atendidos y sacar del taller.
                            objTallerM.Lista_Autos.Add(objTallerM.Autos.Dequeue());
                            //Se agrega a la lista propietarios
                            objTallerM.Lista_Dueños.Add(objTallerM.Dueños.Dequeue());
                            //Se disminuye a la capacidad para poder ingresar otro auto
                            objTallerM.CAPACIDAD--;
                        }
                        break;
                    case ConsoleKey.C:
                        {
                            Console.Clear();
                            //Se muestra el total de los autos atendidos
                            Console.WriteLine($"AUTOS ATENDIDOS: {objTallerM.AUTOS_ATENDIDOS}");
                            for (int i = 0; i < objTallerM.AUTOS_ATENDIDOS; i++)
                            {
                                Console.WriteLine("************************************");
                                Console.WriteLine($"►Placas: {objTallerM.Lista_Autos[i]}");
                                Console.WriteLine($"►Propietario: {objTallerM.Lista_Dueños[i]}");
                                Console.WriteLine($"►Cobro: {objTallerM.Lista_Cobros[i]}");
                                Console.WriteLine();
                            }
                            Console.WriteLine("*******************************************");
                            //Se muestra el total de lo que se cobró en todo el día
                            Console.WriteLine($"Cantidad total: $ {objTallerM.COBRO}");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (menu.Key != ConsoleKey.D);

        }
    }
}
