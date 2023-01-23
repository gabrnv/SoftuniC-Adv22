using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        public Clinic(int capacity)
        {
            Capacity = capacity;
            Pets = new List<Pet>();
        }
        public int Capacity { get; set; }
        private List<Pet> Pets;
        public int Count {get{return Pets.Count;} }

        public void Add(Pet pet)
        {
            if(Pets.Count <= Capacity)
            {
                Pets.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            foreach (var pet in Pets)
            {
                if(pet.Name == name)
                {
                    Pets.Remove(pet);
                    return true;
                }
            }
            return false;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in Pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return sb.ToString().Trim();
        }
        public Pet GetPet(string name, string owner)
        {
            return Pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
        }
        public Pet GetOldestPet()
        {
            Pet oldestPet = new Pet("",int.MinValue,"");
            foreach(var pet in Pets)
            {
                if(pet.Age > oldestPet.Age)
                {
                    oldestPet = pet;
                }
            }
            return oldestPet;
        }
    }
}
