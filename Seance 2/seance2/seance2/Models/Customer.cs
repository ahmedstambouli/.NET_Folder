namespace seance2.Models
{
	public class Customer
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public Customer() { }
		public Customer(int id ,string name) {
		this.Id = id;
		this.Name = name;
		}
	}
}
