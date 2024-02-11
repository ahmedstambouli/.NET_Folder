namespace seance2.Models
{
    public class Movie
    {
		public int Id { get; set; }
        public string name { get; set; }
		public Movie() { }
        public Movie(int Id , string name) {
            this.Id = Id;
            this.name = name;
        }


       
    }
}
