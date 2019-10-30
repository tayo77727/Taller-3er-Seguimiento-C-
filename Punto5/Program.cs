/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 30/10/2019
 * Time: 4:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n1,n2,n3;
			Console.Write("Ingrese el primer numero: ");
			n1=int.Parse(Console.ReadLine());
			Console.Write("Ingrese el segundo numero: ");
			n2=int.Parse(Console.ReadLine());
			Console.Write("Ingrese el tercer numero: ");
			n3=int.Parse(Console.ReadLine());
			
			Console.WriteLine("El mayor es: "+calcularmayor(n1,n2,n3));
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int calcularmayor(int n1,int n2, int n3){
			int mayor=0;
			if(n1>n2 & n1>n3){
				mayor=n1;
			} else if(n2>n1 & n2>n3){
				mayor=n2;
			}else{
				mayor=n3;
			}
			return mayor;
		}
	}
}