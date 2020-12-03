using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Vet
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Speciality { get; set;}
        public int YearsExperience { get; set; }

        public Vet(int Id, string FullName,string Speciality, int YearsExperience)
        {
            this.Id = Id;
            this.FullName = FullName;
            this.Speciality = Speciality;
            this.YearsExperience = YearsExperience;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} ({2}) -{3}", this.Id, this.FullName, this.Speciality, this.YearsExperience);
        }
    }
}
