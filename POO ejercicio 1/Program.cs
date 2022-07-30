using System;

namespace POO_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string  IncrementarValor = "I";
           const string RestablecerValor = "R";
           const string Salir = "S";
            string Opciones = "";
            Contador miContador = new Contador();
           
            do
            {
                Console.WriteLine("Eliga una opción");
                Console.WriteLine("I- Incrementa Valor en 1 ");
                Console.WriteLine("R- Restablece Valor a 0 ");
                Console.WriteLine("S- Salir");
                do
                {
                    Opciones = Console.ReadLine().ToUpper();
                    if (Opciones == "")
                    {
                        Console.WriteLine("Ingrese un valor ");
                    }
                    if (Opciones != "I" & Opciones != "R" & Opciones != "S")
                    {
                        Console.WriteLine("Ingrese un valor I,R,S");
                    }
                } while (Opciones != "I" & Opciones != "R" & Opciones != "S");

                switch (Opciones)
                {
                    case IncrementarValor:
                        miContador.Incrementar();
                        Console.WriteLine("Valor actual : "+miContador.GetValorActual());
                        break;
                    case RestablecerValor:
                        miContador.Resatablecer();
                        Console.WriteLine("Valor actual : " + miContador.GetValorActual());
                        break;
                    case Salir:
                        break;


                }
            } while (Opciones != Salir);
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();

        }
    }
    class Contador
    {
        private int contador = 0;
        public int GetValorActual()
        {
            return contador;
        }
        public void Incrementar()
        {
            contador++;
        }
        public void Resatablecer()
        {
            contador = 0;
        }
    }
}
