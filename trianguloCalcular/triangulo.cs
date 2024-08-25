/* Dado un conjunto de datos representando las dimensiones de triángulos, 
 * calcular y contar aquellos cuya área excede un valor límite.*/

namespace trianguloCalcular
{
    public class triangulo
    {
        public void contar()
        {
            int triangulo = 0;
            double valorlimite = 0;
            double semiperimetro = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            int i= 1;
            int contador = 0;
            double area = 0;
            try
            {
                Console.WriteLine("ingrese la cantidad de trianguo a procesar");
                triangulo = Convert.ToInt32(Console.ReadLine());

             

                for (i = 0; i < triangulo; i++)
                {
                      Console.WriteLine("ingrese el valor limite ");
                valorlimite = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"ingrse el lado a del triangulo # {i}");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"ingrse el lado b del triangulo # {i}");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"ingrse el lado c del triangulo # {i}");
                    c = Convert.ToInt32(Console.ReadLine());



                    semiperimetro = (a + b + c) / 2;
                    Console.WriteLine($"semiperimetro: {semiperimetro}");
                    area = Math.Sqrt((a + b + c) * semiperimetro);
                    Console.WriteLine($"AREA: {area}");

                    if (area > valorlimite)
                    {

                        contador++;
                    }

                }




                Console.WriteLine($"tringulo con una area mayor a : {valorlimite} es {contador} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error {ex.Message}");
            }
           
        }
    }
}
