/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 30/10/2019
 * Time: 4:41 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
/*8) 	A un trabajador le pagan según sus horas y una tarifa de pago por horas. Si la
		cantidad de horas trabajadas es mayor a 44 horas, la tarifa se incrementa en
		un 25% para las horas extras. Hacer un algoritmo que calcule el salario del
		trabajador dadas las horas trabajadas y la tarifa. Una función debe realizar el
		calculo del salario del empleado. La función debe ser void y debe tener como
		parámetros el nombre del trabajado y la cantidad de horas trabajadas.*/
namespace Punto8
{
	class Program
	{
		public static void Main(string[] args)
		{
			String nombre;
			int horas;
			
			Console.Write("Ingrese su nombre: ");
			nombre=Console.ReadLine();
			Console.Write("Ingrese la cantidad de horas trabajadas: ");
			horas=int.Parse(Console.ReadLine());
			
			salario(nombre,horas);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public  static void  salario (String nombre, int horas){
            
            Console.WriteLine("Digite El valor de la hora");
            int valor = int.Parse(Console.ReadLine());
            double valortotal;
            int tarifa = horas -44;
            if (horas > 44){
                
                valortotal = ((horas -44)*(valor*0.25+valor))+(horas-tarifa)*valor;
                Console.WriteLine(nombre+" Usted trabajo mas de 44 horas por lo cual tiene horas extras su salario es: "+ valortotal);
            }else {
                valortotal = horas * valor;
                Console.WriteLine(nombre+" Usted trabajo " +horas+ " horas su salario es: "+ valortotal);
            }
            
            
        }
	}
}