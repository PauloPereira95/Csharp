using System.Reflection;
namespace HelloCS

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*System.Data.DataSet ds; HttpClient client;
            Assembly? assembly = Assembly.GetEntryAssembly();
            if (assembly == null) return;
            foreach (AssemblyName name in assembly.GetReferencedAssemblies())
            {
                Assembly a = Assembly.Load(name);
                int methodCount = 0;

                foreach (TypeInfo t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();   
                }
                Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", arg0: a.DefinedTypes.Count(),
                arg1: methodCount, arg2: name.Name);
            }
            */
            int ex1 = 1000000;
            double  ex2 = 100_00_999.2;
            Console.WriteLine(ex1);
            Console.WriteLine(ex2);
        }
    }
}