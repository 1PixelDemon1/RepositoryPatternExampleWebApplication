using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime PublicationDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public GamePublisher? Publisher { get; set; }

        public Game() { }

        public Game(string Title, string Description, DateTime PublicationDate, string Genre, GamePublisher Publisher)
        {
            Id = 0;
            this.Title = Title;
            this.Description = Description;
            this.PublicationDate = PublicationDate;
            this.Genre = Genre;
            this.Publisher = Publisher;
        }

        public void Validate() 
        {
            if(string.IsNullOrEmpty(Title)) throw new ArgumentException("Title cannot be null or empty");
            if(string.IsNullOrEmpty(Genre)) throw new ArgumentException("Genre cannot be null or empty");
            if (Publisher != null) Publisher.Validate();
        }
    }
}