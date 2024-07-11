using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoApp
{
   public record struct PetWithID(string Id, Pet Pet);
}
