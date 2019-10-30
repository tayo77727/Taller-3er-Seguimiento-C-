/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 30/10/2019
 * Time: 4:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n;
			Console.WriteLine("El numero devuelto es: "+pedir());
			
			Console.Write("\nDigite un numero para obtener el cubo: ");
			n = int.Parse(Console.ReadLine());
			
			Console.WriteLine("El cubo del numero es: "+triple(n));

			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static int pedir(){
			int num;
			Console.Write("Ingrese un numero: ");
			num=int.Parse(Console.ReadLine());
			return num;
		}
		
		public static int triple(int num){
			int resultado;
			resultado=num*num*num;
			return resultado;
		}
	}
}