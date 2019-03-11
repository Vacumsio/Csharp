namespace lesson_6
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public string department;
        public int course;
        public int group;
        public int age;
        public string city;

        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course,  int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }

    }
}
