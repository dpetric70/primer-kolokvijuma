using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VetBusiness
    {
        public readonly VetRepository vetRepository;

        public VetBusiness()
        {
            this.vetRepository = new VetRepository();

        }

        public List<Vet> GetAllVets()
        {
            return this.vetRepository.GetAllVets();
        }

        public bool insertVet(Vet insert)
        {
            if (this.vetRepository.InsertVet(insert) > 0)
            {
                return true;
            }
            return false;
        }
        public List<Vet> getVetsWithHigherExp(int value)
        {
            return this.vetRepository.GetAllVets()
                .Where(v => v.YearsExperience > value).ToList();

            

        }
    }
}
