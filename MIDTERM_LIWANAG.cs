/*
 * Created by SharpDevelop.
 * User: JLight
 * Date: 28/10/2022
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace stacklol
{
	class Program
	{
		public static void Main(string[] args)
		{
			Stack myStack = new Stack();
			
			Console.WriteLine("1. Add an element\n2. See the Top Element\n3. Remove the Top Element\n4. Display Stack Elements\n5. Exit");
			
			
			while (true) {
				Console.Write("\ninput: ");
				try {
					switch (int.Parse(Console.ReadLine())) {
						case 1:
							Console.Write("\nEnter element:");
							myStack.Push(int.Parse(Console.ReadLine()));
							Console.WriteLine("item pushed");
							break;
						case 2:
							Console.Write("\ntop element is "+myStack.Peek());
							break;
						case 3:
							myStack.Pop();
							Console.WriteLine("poped");
							break;
						case 4:
							int i = myStack.Count;
							foreach (int element in myStack) {
								Console.WriteLine("item#"+i+": "+element);
								i--;
							}
							
							break;
						case 5:
							goto end;
						default:
							Console.WriteLine("invalid input");
							break;
					}
				}
				catch (InvalidOperationException) {
					Console.WriteLine("invalid input or stack is empty");
				}
				
			}
		end:
			Console.WriteLine("press any key to close...");
			Console.ReadKey();
		}
	}
}
