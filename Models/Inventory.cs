using System.Collections.Generic;

namespace Assignment02.Models
{
    public class Inventory
    {
        public Dictionary<string,int> Equipments = new Dictionary<string,int>();

        public List<Member> Members = new List<Member>();
       

       public Inventory() 
       {
            Equipments.Add("Gun Powder", 50);
            Equipments.Add("Resin", 100);
            Equipments.Add("Phenol", 90);
            Equipments.Add("Carbon", 300);

            Members.Add(new Member { FirstName = "John", LastName = "Doe" });
            Members.Add(new Member { FirstName = "Peter", LastName = "Parker" });
            Members.Add(new Member { FirstName = "Omar", LastName = "Omor" });

       }


    }
}
