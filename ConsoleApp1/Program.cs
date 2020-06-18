using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IAnimal
    {
        string MakeNoise();
    }
    public class DogFamily
    {
        public virtual string MakeNoise() => "Aaooo";
    }

    public ref struct Coords
    {
        public double X;
        public double Y;
        public Coords(double Z, double O)
        {
            X = Z;
            Y = O;
        }
        public double Sum()
        {
            return X + Y;
        }
        public override string ToString() => $"({X}, {Y})";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Hello world");
            Console.ReadLine();
           
        }
    }
}
