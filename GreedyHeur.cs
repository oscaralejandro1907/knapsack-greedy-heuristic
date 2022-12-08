using System;
using System.Linq;

namespace Knapsack
{
    public class GreedyHeur
    {
        protected Instance I;
        public List<Object> ListObjects { get; set; }
        public List<Object> Solution { get; set; }

        public GreedyHeur(Instance I){
            this.I = I;
            this.ListObjects = new(I.ListObjects);
            this.Solution = new();
        }

        public void SolveHeuristic()
        {                   
            //Create Ratios
            foreach (var obj in ListObjects)
            {
                obj.Ratio = obj.Precio/obj.Peso;
            }

            ListObjects = ListObjects.OrderByDescending(o => o.Ratio).ToList();
            
            //Enter objects to the knapsack
            double usedcap=0.0;
            List<Object> listEnteredItems = new();
            foreach (var obj in ListObjects)
            {
                Object candidate = obj;
                listEnteredItems.Add(candidate);
                usedcap += candidate.Peso;
                if (usedcap > I.PesoMochila)
                {
                    listEnteredItems.Remove(candidate);
                    usedcap -= candidate.Peso;
                }
            }
            
            //Make solution
            Solution = listEnteredItems;
            double used = listEnteredItems.Sum(o=>o.Peso);
            double fitness = listEnteredItems.Sum(o => o.Precio);
        }
    }
    
}