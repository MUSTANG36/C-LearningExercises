using System;


namespace cSharpLearningExercises
{
    class Prime
    {   
       //Write a C# program to compute the sum of the first 500 prime numbers. 
        static void Main(string[] args)
        {
            sumPrime(500);
        }

        public static bool isPrime(int num){
            //A prime number has only two factors 1 x 13
            if(num <= 1){
                Console.WriteLine("false1");
                return false;
            }

            //check from 2 to n-1
            for(int i = 2; i < num; i++)
                if(num % i == 0 ){
                    Console.WriteLine("false2");
                    return false;
                }   
            return true;
            
            

            
        }

        public static void sumPrime(int num){
            int counter = 2;
            int totalPrime=0;
            for(int i = 2;  i <= num; i++){
               // Console.WriteLine("try");
                if(isPrime(counter)){
                    counter++;
                    totalPrime += i;
                    //Console.WriteLine("catch");
                }

            }
            Console.WriteLine("wtf");
            Console.WriteLine(totalPrime);
        }
    }
}
