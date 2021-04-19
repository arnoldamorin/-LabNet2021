using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioExtensionesExcepciones.Exceptions;
using EjercicioExtensionesExcepciones.Extensions;
using System.Windows.Forms;


namespace EjercicioExtensionesExcepciones
{
   
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("***********  Ejercicio 1  ***********");
                try
                {
                    Console.WriteLine("Ingrese un valor");
                    int i = Convert.ToInt32(Console.ReadLine());
                    int dividir = i.Dividir(0);                    
                    Console.WriteLine($"División exitosa, el resultado es : {dividir}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"La operacion no ha sido exitosa, Mensaje de la excepcion: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("-----La operacion ha finalizado-----");
                    Console.WriteLine("pulse cualquier tecla para continuar");
                    Console.ReadKey();
                }
                Console.WriteLine("***********  Ejercicio 2  ***********");
                try
                {
                    Console.WriteLine("Ingrese el dividendo");
                    double i = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el divisor");
                    double j = Convert.ToDouble(Console.ReadLine());                                   
                    Console.WriteLine($"El resultado es : {i.Dividir(j)}");                    
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Solo keanu reeves puede dividir por cero");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("La operacion no ha sido exitosa, seguro no ingreso nada o una letra");
                    Console.WriteLine($"Mensaje: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("-----La operacion ha finalizado-----");
                    Console.WriteLine("pulse cualquier tecla para continuar");
                    Console.ReadKey();
                }
                Console.WriteLine("***********  Ejercicio 3  ***********");

                try
                {
                    Logic.Ejercicio3();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Mensaje: {ex.Message}");
                    Console.WriteLine($"Type: {ex.GetType()}");
                }
                finally
                {
                    Console.WriteLine("-----La operacion ha finalizado-----");
                    Console.WriteLine("pulse cualquier tecla para continuar");
                    Console.ReadKey();
                }

                Console.WriteLine("***********  Ejercicio 4  ***********");

                try
                {
                Logic.Ejercicio4();
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    MessageBox.Show($"{ex.Message}","Exception Message");
                }
                finally
                {
                    Console.WriteLine("-----La operacion ha finalizado-----");
                    Console.WriteLine("pulse cualquier tecla para continuar");
                    Console.ReadKey();
                }
            
            }
        }
    }


