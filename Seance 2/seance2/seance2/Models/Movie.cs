using System.ComponentModel.DataAnnotations;

namespace seance2.Models
{
    public class Movie
    {
       
		public int Id { get; set; }
        public string name { get; set; }

        public DateTime relatedate { get; set; }

        public Boolean withsubtitels { get; set; }


		public Movie() { }
        public Movie(int Id , string name,Boolean withsubtitels, DateTime relatedate) {
            this.Id = Id;
            this.name = name;
            this.relatedate = relatedate;
            this.withsubtitels= withsubtitels;
        }


       
    }
}
