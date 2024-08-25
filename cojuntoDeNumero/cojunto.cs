/*  Crear un programa que cuente cuántos números,
   de un conjunto de 10, son divisibles por 3 o por 5.
 */
namespace cojuntoDeNumero
{
    public  class cojunto
    {
        public void  divible()
        {
            int numero = 0;
            int i = 0;
            int divisible = 0;
            int divisible1 = 0;
            try
            {
                Console.WriteLine(" saludo porfavor ingrese 10 numero");
                for (i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"ingrese el numero : # {i}");
                    numero = Convert.ToInt32( Console.ReadLine() );
                    if (numero % 5 == 0)
                    {
                        divisible++;
                    } else if (numero % 3 == 0)
                    { 
                        divisible1++;
                    }
                    
                }
                Console.WriteLine($"numero divible por 5 {divisible}");
                Console.WriteLine($"numero divible por 3 {divisible1}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"error { e.Message}");
            }

            
            
        }
    }
}
