using System; 
namespace Watermelon{
class Car 
{
  public static void Main(string[] args)
  {
    
    int n = Convert.ToInt32(Console.ReadLine()); 
    for(int i=0;i<n;i++)
    {
       string s=Console.ReadLine();
       if(s.length>10)
       {
         Console.WriteLine(s[0]);
       }
       else
       {
         Console.WriteLine(s);
       }
    }
    
  }
}
}

