using System;
namespace Prime{
class Program{
 static void Main(string[] args)
 {
   
     int n=Convert.ToInt32(Console.ReadLine());
      int[]prime= new prime[100]={0};
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

