using System.Reflection;
using UseReflection;

class Program
{
    static void Main(string[] args)
    {
        HasSecret keeper = new();
        FieldInfo[] fields = keeper.GetType().GetFields(
                        BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (FieldInfo field in fields)
        {
            Console.WriteLine(field.GetValue(keeper));
        }
    }
}