using System;
using System.Collections;
using System.Collections.Generic;
 
class Solution{
	static void Main(){
		Sol mySol =new Sol();
		mySol.Solve();
	}
}

class Sol{
	public void Solve(){
		
		for(;Te>0;Te--){
			String S=rs();
			String T=rs();


			// Hashsets are being used here to prevent duplicates from being entered.

			HashSet<char> H1=new HashSet<char>();
			HashSet<char> H2=new HashSet<char>();
			
			// APPEND Elements into the HashSet.
			
			for(int i=0;i<S.Length;i++)
            {
                H1.Add(S[i]);
            }
			for(int i=0;i<T.Length;i++)
            {
                H2.Add(T[i]);
            }

			// Create a flag called check and set value to false.

			bool chk=false;

			// Check the two HashSets for any common character.

			foreach(char c in H1){
				if(H2.Contains(c))

                {
                    chk=true;
                }
			}

			// True then YES, else NO.
            
			Console.WriteLine(chk?"YES":"NO");
			
			
		}
		
		
		
	}
	int Te;
	public Sol(){
		Te=ri();
	}




	static String rs(){return Console.ReadLine();}
	static int ri(){return int.Parse(Console.ReadLine());}
	static long rl(){return long.Parse(Console.ReadLine());}
	static double rd(){return double.Parse(Console.ReadLine());}
	static String[] rsa(){return Console.ReadLine().Split(' ');}
	static int[] ria(){return Array.ConvertAll(Console.ReadLine().Split(' '),e=>int.Parse(e));}
	static long[] rla(){return Array.ConvertAll(Console.ReadLine().Split(' '),e=>long.Parse(e));}
	static double[] rda(){return Array.ConvertAll(Console.ReadLine().Split(' '),e=>double.Parse(e));}
}