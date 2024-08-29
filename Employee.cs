using System.ComponentModel.DataAnnotations;

namespace CRUD.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Date { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string Veg { get; set; }
        public string Fruit { get; set; }
        public byte[] Photo { get; set; }

        

        

        public byte[] Pdf { get; set; }


        public List<string> Options = new List<string> { "Male", "Female" };

        public List<Item> items = new List<Item>
        {
          new Item { Id = 1, Name = "Mango", IsSelected = false },
          new Item { Id = 2, Name = "Apple", IsSelected = false }
        };
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}
