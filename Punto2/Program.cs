/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 30/10/2019
 * Time: 4:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto2
{
	class Program
	{
		public static void Main(string[] args)
		{
			string cadena;
			Console.WriteLine("Digite una cadena de texto");
			cadena = Console.ReadLine();
			Console.WriteLine(ultima(cadena));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static string ultima(string cadena){
			string ultima1;
			
			
			if (cadena == "")
				 ultima1 = "Cadena vacia";
			else
				  ultima1 = cadena.Substring(cadena.Length-1);
			
			return ultima1;
			
		}
	}
}