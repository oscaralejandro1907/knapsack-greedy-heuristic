// See https://aka.ms/new-console-template for more information

namespace Knapsack
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Instance data = new();
            data.Print();
            GreedyHeur method = new(data);
            method.SolveHeuristic();
        }
    }
}



