using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoApp
{
    internal class DisplayPets
    {
        public void DisplayPetInformation(Pet pet) => Console.WriteLine(pet.ToString());
    }
}
