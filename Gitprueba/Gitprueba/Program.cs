using System;

namespace Gitprueba
{
    class Program
    {
        static void Main(string[] args)
        {
            // la siguiente instrucción es para mandar numeros aleatorios
            Console.WriteLine(" Este progama dará como resultado un número aleatorio, es su deber adivinar qué número es ");

            Random numero = new Random();

            int numeroAleatorio = numero.Next(0, 100);

            Console.WriteLine("**************---------------------*****************");
            Console.WriteLine("**************---------------------*****************");
            Console.WriteLine(" Introduzca el número que cree que salió ");
            int num = 101;
            int contador = 0;

            do
            {
                //El Try catch es para excepciones 
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException ex) //PRIMERO VAN LAS EXCEPCIONES DE TIPO ESPECIFICO Y LUEGO LAS GENERICAS
                {
                    Console.WriteLine("  Se ha introducido un valor de tipo texto, por favor introducir un valor de tipo numerico ");
                    // este excepción es para validar una excepcion en especial pero tiene que ir delante de un EXCEPCTION en caso de que haya uno
                }
                catch (Exception ex) //este objeto resive como parametro un objeto de tipo excepcion  y la variable objeto que suele llamarse EX
                {
                    Console.WriteLine();
                    Console.WriteLine(" Ha habido un error. Por favor introduzca un valor comprendido entre el 0 y 100 ");
                    Console.WriteLine(ex.Message);
                }
                //catch (OverflowException ex) //
                //    Console.WriteLine();
                //    Console.WriteLine(" Has introducido un valor númerico fuera del rango ");
                //}


                if (num < numeroAleatorio)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Quizas un poco más alto ");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Quizas un poco más abajo ");
                }

                contador++;
            } while (num != numeroAleatorio);

            Console.WriteLine(" ¡Felicidades!, acertaste con el número. ");
            Console.WriteLine();
            Console.WriteLine(" Eres un genio, recuerda ser perseverante y podrás alcanzar tus sueños");
            Console.WriteLine();
            Console.WriteLine($" el número era: {numeroAleatorio}");
            Console.WriteLine($" Y te tomó {contador} intentos  ");
        }
    }
}
