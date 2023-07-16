namespace Test
{
    internal class Program
    {
        // simulirana baza podataka
        public static List<Person> people = new List<Person>()
        {
            new Person(1, "Petar", "Simic"),
            new Person(2, "Vukasin", "Simic"),
            new Person(3, "Tijana", "Stankovic")
        };
        static void Main(string[] args)
        {
            Marry(2, 3);

            //Console.WriteLine($"Prvi: {prvi.number}");
            //Console.WriteLine($"Drugi: {drugi.number}");

            // Test drugi = prvi;

            foreach(Person person in people)
            {
                Console.WriteLine($"Id:{person.Id}, Name: {person.Name}, Last name: {person.LastName}");
            }
            Console.ReadKey();
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public Person(int number, string name, string lastName)
            {
                this.Id = number;
                Name = name;
                LastName = lastName;
            }
        }

        // test je referenca na memoriju gde se nalazi 
        public static void Marry(int idMen, int idWomen)
        {
            var men = people.FirstOrDefault(x => x.Id == idMen);
            var women = people.FirstOrDefault(x => x.Id == idWomen);

            women.LastName += " " + men.LastName;

            // update database 
        }
    }
}