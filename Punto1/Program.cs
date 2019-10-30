/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 30/10/2019
 * Time: 4:38 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto1
{
	class Program
	{
		public static void Main(string[] args)
		{
			double peso, altura;
			Console.WriteLine("Digite su peso en kg");
			peso= double.Parse(Console.ReadLine());
			Console.WriteLine("Digite su altura en Metros");
			altura =double.Parse(Console.ReadLine());
			Console.WriteLine("Su IMC es: "+calcularMasaCorporal(peso,altura));
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static double calcularMasaCorporal(double peso, double altura){
			double mc;
			mc = peso/(altura*altura);
			return mc;
		}
	}
}