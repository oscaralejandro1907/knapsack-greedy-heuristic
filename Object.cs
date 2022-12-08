using System;

namespace Knapsack{
    public class Object
    {
        private static int _indexgen=0;
        public int Id {get;set;}
        public double Peso {get; set;}
        public double Precio{get;set;}
        public string Description {get; set;}
        public double Ratio { get; set; }

        public Object(double peso, double precio)
        {
            Id = _indexgen++;
            this.Peso = peso;
            this.Precio = precio;
            this.Description = "";
            this.Ratio = precio / peso;
        }
    }
}