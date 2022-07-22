// See https://aka.ms/new-console-template for more information

namespace EncapsulationAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation And Inheritance");
            Ford ford = new Ford();
            ford.marka = "Ford";
            ford.enModel = "Focus";
            ford.uretim_yil = 2012;
            ford.ArabaBilgiGoster();
            Console.ReadKey();
        }
    }
}