using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoApp
{
    public class Pet
    {
        // Defining private properties to encapsulate the data accessibility
        public string? AnimalID { get; set; }
        public string? AnimalSpecies { get; set; }
        public string? AnimalAge { get; set; }
        public string? AnimalPhysicalDescription { get; set; }
        public string? AnimalPersonalityDescription { get; set; }
        public string? AnimalNickname { get; set; }

        public override string ToString() => $"{AnimalID} {AnimalSpecies} {AnimalAge} {AnimalPhysicalDescription} {AnimalPersonalityDescription} {AnimalNickname}";
      
    }
}
