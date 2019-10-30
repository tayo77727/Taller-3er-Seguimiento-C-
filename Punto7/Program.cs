/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 30/10/2019
 * Time: 4:41 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			Console.Write("Ingrese un numero: ");
			num=int.Parse(Console.ReadLine());
			Console.WriteLine("");
			mostrartabla(num);
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void mostrartabla(int num){
			
			for (int i = 1; i <= 10 ; i++) {
				Console.WriteLine(num+" X "+i+" = "+(num*i));
				
			}
			
			
		}
	}
}