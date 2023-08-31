namespace oop_1
{
    using static System.Math;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Nummer eingeben");
            int inpurNumber = int.Parse(Console.ReadLine());
            int squareNumber = (int)Sqrt(inpurNumber);
            Console.WriteLine("Die Wurzel von " + inpurNumber + " ist: " + squareNumber);


            
        }
    }
}