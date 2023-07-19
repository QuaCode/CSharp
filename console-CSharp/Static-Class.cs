namespace console_CSharp;

public class Normal_Class
{ 
   public int age { get; set; }
   public string name { get; set; }

   public string showMe()
   {
      return $"{age} and your {name}";
   }
}

public static class Static_Class
{
   public static int age { get; set; }
   public static string name { get; set; }
   
   public static string showMe()
   {
      return $"{age} and your {name}";
   }
}