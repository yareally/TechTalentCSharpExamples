namespace CSharpDataTypes.People
{
    class Student : IPerson
    {
        /// <inheritdoc />
        public string Name { get; private set; }

        /// <inheritdoc />
        public int Age { get; private set; }

        public string Hometown { get; private set; }

        public string FavoriteFood { get; private set; }

        public Student(string name, int age, string hometown, string favoriteFood)
        {
            Name = name;
            Age = age;
            Hometown = hometown;
            FavoriteFood = favoriteFood;
        }

        public Student()
        {
            Name = null;
            Name = "";
        }

        public Student(string name)
        {
            Name = name;
        }

        public Student(int age)
        {
            Age = age;
        }
    }
}
