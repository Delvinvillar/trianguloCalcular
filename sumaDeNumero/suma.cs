/*  Desarrollar un programa que permita ingresar 10 números
 *  y luego muestre la suma de los últimos 5 números ingresados.*/

namespace sumaDeNumero
{
  public class suma
    {
        public void ultimo5()
        {
            double numero = 0;
            double suma = 0;
            int i = 0;
            try
            {
                Console.WriteLine("ingrese 10 numero porfavor ");
                for (i = 1; i <= 5; i++)
                { 
                    Console.WriteLine($"numero: # {i}");
                 numero = Convert.ToDouble(Console.ReadLine());

                }
                for (i = 6; i <= 10; i++)
                {
                    Console.WriteLine($"numero: # {i}");
                    numero = Convert.ToDouble(Console.ReadLine());
                    suma += numero;
                }
                Console.WriteLine($"esta es la suma de los ultimo 5 numero: # {suma}");

            }
            catch (Exception ex) 
            { Console.WriteLine(ex.Message); 
            }
        }
    }
}
