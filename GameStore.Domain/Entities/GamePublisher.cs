using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities
{
    public class GamePublisher
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public GamePublisher? MotherCompany { get; set; }
        public IEnumerable<Game>? Games { get; set; }
        public bool IsIndieDeveloper { get; set; }

        public GamePublisher() {}
        
        public GamePublisher(string Name, GamePublisher? MotherCompany, IEnumerable<Game>? Games, bool IsIndieDeveloper)
        {
            this.Id = 0;
            this.Name = Name;
            this.MotherCompany = MotherCompany;
            this.Games = Games;
            this.IsIndieDeveloper = IsIndieDeveloper;
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Name)) throw new ArgumentException("Name cannot be null or empty");
            if (MotherCompany != null) MotherCompany.Validate();
        }
    }
}
