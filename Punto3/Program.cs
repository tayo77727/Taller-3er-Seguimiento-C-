/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 30/10/2019
 * Time: 4:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite una cadena de texto");
			string cadena = Console.ReadLine();
			Console.WriteLine(strlen2(cadena));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int strlen2 (string cadena){
			int num=0;
			for (int i = 0; i < cadena.Length; i++) {
				num +=1;
			}
			return num;
		}
	}
}