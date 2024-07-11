using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoApp
{
    internal class NewBusinessLogic
    {
        private PetsRepository? _repo;
        private DisplayPets? _stdout;

        // Constructor to initialize _repo and _stdout
        public NewBusinessLogic(PetsRepository repo, DisplayPets stdout)
        {
            _repo = repo;
            _stdout = stdout;
        }

        public void ProvideUserAllItems()
        {
            if (_repo == null || _stdout == null) return;

            foreach (var animal in _repo.GetAllPets())
            {
                _stdout.DisplayPetInformation(animal);
            }
        }

        /*public Pet ProvideUserAllItems()
        {
            if (_repo == null) return null;
            if (_stdout == null) return null;

            foreach(Pet animal in _repo.GetAllPets())
            {
                _stdout.DisplayPetInformation(animal);
                return animal;
            }
            return null;
        }*/

    }
}
