using System;

namespace Knapsack{
    public class Instance
    {
        public double PesoMochila {get;set;}
        public int NObjects {get; set;}
        public List<Object> ListObjects {get; set;}

        public Instance(){
            this.PesoMochila = 15;
            this.NObjects = 5;
            this.ListObjects = new();
            
            AddData();
        }

        public void AddData()
        {
            Object a = new(12,4);
            Object b = new(4,10);
            Object c = new(2,2);
            Object d = new(1,2);
            Object e = new(1,1);
            Object f = new(7, 2);
            
            ListObjects.Add(a);
            ListObjects.Add(b);
            ListObjects.Add(c);
            ListObjects.Add(d);
            ListObjects.Add(e);
            ListObjects.Add(f);
        }

        public void Print(){

            foreach (var obj in ListObjects)
            {
                Console.WriteLine("Item " + obj.Id + " has a weight of " + obj.Peso + " and its value is " + obj.Precio);
            }
            
            Console.WriteLine("Knapsack has a total capacity of " + PesoMochila);
        }
        
    }
}