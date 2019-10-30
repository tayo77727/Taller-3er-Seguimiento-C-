/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 30/10/2019
 * Time: 4:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("El diametro es: "+diametro()+"\n");
			Console.WriteLine("El area es: "+area()+"\n");
			Console.WriteLine("La circunferencia es: "+circunferencia()+"\n");
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static double diametro(){
			double radio,diame=0;
			Console.WriteLine("Funcion Diametro!\n");
			Console.Write("Digite el radio del circulo: ");
			radio=double.Parse(Console.ReadLine());
			diame=2*radio;
			return diame;
		}
		public static double area(){
			double radio,A=0;
			Console.WriteLine("Funcion Area!\n");
			Console.Write("Digite el radio del circulo: ");
			radio=double.Parse(Console.ReadLine());
			A=Math.PI*(Math.Pow(radio,2));
			return A;
		}
		public static double circunferencia(){
			double diametr, circun=0;
			Console.WriteLine("Funcion Circunferencia!\n");
			Console.Write("Digite el diametro del circulo: ");
			diametr=double.Parse(Console.ReadLine());
			circun= Math.PI*diametr;
			return circun;
		}
	}
}