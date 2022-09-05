namespace Grupo6TP1
{
    class Program
    {
        //GENERALIDADES

        //Ejercicio 1
        static int Suma(int a, int b)
        {
            int c = a + b;
            return c;
        }

        //Ejercicio 2
        static string CortarString(string arg)
        {
            string cadena = arg;
            string cadenaCortada = cadena.Substring(0, 4);
            return cadenaCortada;
        }

        //Ejercicio 3
        static string FechaHoraActual()
        {
            DateTime fecha = DateTime.Now;
            string impFecha = "";
            return fecha.ToString(impFecha);
        }

        //Ejercicio 4

        /* Ejercicio
        5 */

        // ENUMERACIONES

        // Ejercicio 1
        enum DiasSemana
        {
            Domingo,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado
        }

        //Ejercicio 2
        static DiasSemana TextoDia(int a)
        {
            DiasSemana texto = (DiasSemana)a;
            return texto;
        }

        // CONVERSIONES

        // Ejercicio 1
        static int ConvertirANum1(bool str)
        {
            int num = System.Convert.ToInt32(str);
            return num;
        }

        static void checkParse(string input)
        {
            bool val;
            val = bool.Parse(input);
            Console.WriteLine("'{0}' parsed as {1}", input, val);
        }

        // Ejercicio 2
        static short casteo(int a)
        {
            short b = (short)a;
            return b;
        }

        // Ejercicio 3
        enum Color
        {
            blanco,
            azul,
            negro
        }

        static void EnumColor(int a)
        {
            Color texto = (Color)a;
            switch (texto)
            {
                case Color.azul:
                    Console.WriteLine("Azul");
                    break;

                case Color.blanco:
                    Console.WriteLine("Blanco");
                    break;

                case Color.negro:
                    Console.WriteLine("Negro");
                    break;
            }
        }

        //Ejercicio 4

        static void EvalNum(int a)
        {
            if (a > 10)
            {
                Console.WriteLine("El numero ingresado es mayor a 10");
            }
            else
            {
                Console.WriteLine("El numero ingresado es menor o igual a 10");
            }
        }

        //Ejercicio 7

        static void Hasta50()
        {
            int a = 0;
            while (a < 50)
            {
                a += 5;
            }
            Console.WriteLine("Finaliza bucle while por llegar a 50");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Suma(2, 1)); //Ejercicio 1
            Console.WriteLine(CortarString("Programacion")); //Ejercicio 2
            Console.WriteLine(FechaHoraActual()); //Ejercicio 3

            //ENUMERACIONES

            Console.WriteLine(TextoDia(Convert.ToInt32(Console.ReadLine()))); // Ejercicio 1 y 2

            //CONVERSIONES
            Console.WriteLine("Ingrese la palabra true o false: ");
            Console.WriteLine("El booleano ingresado con Convert corresponde al numero: "
                + ConvertirANum1(Convert.ToBoolean(Console.ReadLine())));
            Console.WriteLine("Ingrese la palabra true o false: ");
            Console.WriteLine("El booleano ingresado con bool.Parse corresponde al numero: "
                + ConvertirANum1(Convert.ToBoolean(Console.ReadLine()))); // Ejercicio 1
            Console.WriteLine("Ingrese 0 para color Blanco, 1 para Azul o 2 para Negro: ");
            EnumColor(Convert.ToInt32(Console.ReadLine())); // Ejercicio 3
            Console.WriteLine("Ingrese un numero entero: ");
            EvalNum(Convert.ToInt32(Console.ReadLine())); // Ejercicio 4 y 5
            Hasta50(); // Ejercicio 7

        }
    }
}