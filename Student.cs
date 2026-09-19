namespace StudentManagement
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Gpa { get; set; }

        public Student() { }

        public Student(string id, string name, int age, double gpa)
        {
            Id = id;
            Name = name;
            Age = age;
            Gpa = gpa;
        }

        public override string ToString()
        {
            return $"ID: {Id,-8} | Tên: {Name,-20} | Tuổi: {Age,-5} | Điểm GPA: {Gpa:F2}";
        }
    }
}

