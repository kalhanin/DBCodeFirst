namespace DBCodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string City { get; set; }
        
        public string Region { get; set; }
        public int Age { get; set; }

        public Student() { }
        public Student(int id, string name, string city, string region, int age)
        {
            Id = id;
            Name = name;
            City = city;
            Region = region;
            Age = age;
        }
    }
}
