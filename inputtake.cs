using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] prime =new int [100000];
      int n = Convert.ToInt32(Console.ReadLine());  
      
     for(int i=2;i<=n;i++)
       {
            if(prime[i]==0)
            {
               for(int j=i*i;j<=n;j+=i)
               {
                   prime[j]=1;
               }
            }
            
       }
       for(int i=2;i<=n;i++)
       {
            if(prime[i]==0)
            {
               Console.WriteLine(i);
            }
       }
       }
  }
}
