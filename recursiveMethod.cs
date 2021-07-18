using System;
namespace RecursiveMethod{
	public class factorial{
		
		public int fact(int num){
			if(num == 0){
				return 1;
			}
			return num * fact(num - 1);
		}
		
		public static void Main(string[] args){
			int result;
			factorial testFact = new factorial();
			
			result = testFact.fact(5);
			Console.WriteLine("The factorial is: {0}", result);
		}
	}
}

