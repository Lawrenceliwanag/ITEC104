using System;
using System.Collections;

class Program
{
        static void Main() {
		
        int i=0;
      	int[] even = new int[0],
      		  odd = new int[0],
      		  num = new int[5];
        
        while(i!=num.Length){
            Console.Write("input number: ");
            num[i] = Convert.ToInt32(Console.ReadLine());
            
	            if(num[i]%2==0){
            	Array.Resize(ref even, even.Length+1);
            	even[even.Length-1] = num[i];
	            }
	            else{
            	Array.Resize(ref odd, odd.Length+1);
	            odd[odd.Length-1] = num[i];	
	            }
            Console.Clear();
            i++;
        }
      	Console.Write("Even: ");
      	foreach(int item in even){
      		Console.Write(item+" ");
      	}
      	Console.Write("Odd: ");
      	foreach(int item in odd){
      		Console.Write(item+" ");
      	}
      	
      	Console.ReadLine();
    }
}
