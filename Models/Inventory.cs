using System.Collections.Generic;

namespace Assignment02.Models
{
    public class Inventory
    {
        public List<Equipment> Equipments = new List<Equipment>();

        public List<Member> Members = new List<Member>();
       
        public Dictionary<string,string> EquippedMembers = new Dictionary<string, string>();

       public Inventory() 
       {
            Equipments.Add(new Equipment { Name = "Gun Powder",Price = 150});
            Equipments.Add(new Equipment { Name = "Resin", Price = 100 });
            Equipments.Add(new Equipment { Name = "Phenol", Price = 90 });
            Equipments.Add(new Equipment { Name = "Carbon", Price = 300 });


            Members.Add(new Member { FirstName = "John", LastName = "Doe" });
            Members.Add(new Member { FirstName = "Peter", LastName = "Parker" });
            Members.Add(new Member { FirstName = "Omar", LastName = "Omor" });
            Members.Add(new Member { FirstName = "Abir", LastName = "Das" });


            EquippedMembers.Add(Members[0].FirstName, Equipments[0].Name);
            EquippedMembers.Add(Members[1].FirstName, Equipments[1].Name);
            EquippedMembers.Add(Members[2].FirstName, Equipments[2].Name);
            EquippedMembers.Add(Members[3].FirstName, Equipments[3].Name);
       }


    }
}
