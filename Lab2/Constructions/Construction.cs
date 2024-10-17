using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Constructions
{
    internal class Construction
    {
        public Construction(float height, float width, float entrances, float humanCapicity, float buildMaterial) 
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapicity;
            BuildMaterial = buildMaterial;
        }


        public float Height { get; set; }
        public float Width { get; set; }
        public float Entrances { get; set; }
        public float HumanCapacity { get; set; }
        public float BuildMaterial { get; set; }
    }
}
