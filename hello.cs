using System;

namespace hello
{
  class Program
  {
    static void Main()
    {
      int[] a= new int [100];
      int [] prime=new int[100];
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
