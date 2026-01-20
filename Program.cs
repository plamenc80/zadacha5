using System.Numerics;

namespace _3DVektori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi broq vektori");
            int n = int.Parse(Console.ReadLine());
            List<Vector3> vectors = new List<Vector3>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"vetor {i+1}: vuvedi 3 chisla za vektor razdeleni s space ");
                var p = Console.ReadLine().Split();
                vectors.Add(new Vector3(
                    float.Parse(p[0]),
                     float.Parse(p[1]),
                      float.Parse(p[2])));

            }
            var minVector = vectors.MinBy(v => v.Length());
            Vector3 minV = vectors.Where(minV => minV.Length() > 0).FirstOrDefault();
            Console.WriteLine($"Nai kusiq vektor e ({minV.X},{minV.Y},{minV.Z} )");
            Console.WriteLine("Nai kusiq vektor e "+ minVector.Length());
        }
    }
}
