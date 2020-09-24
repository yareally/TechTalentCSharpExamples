using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;

using CSharpDataTypes.Events;
using CSharpDataTypes.Events.Photos;
using CSharpDataTypes.InterfacesExtensibility;
using CSharpDataTypes.Lambdas;
using CSharpDataTypes.Organisms;
using CSharpDataTypes.People;
using CSharpDataTypes.Vehicles;
using CSharpDataTypes.Vehicles.Enums;
using CSharpDataTypes.Vehicles.Interfaces;

namespace CSharpDataTypes
{
    class Program
    {
        const double TAX_RATE = 7.0;

        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Your Number is: {0}", userInput);
            
            var dictionary = new Dictionary<string, string>();
            dictionary["apple"] = "A fruit or a computer company";
            Console.WriteLine(dictionary["apple"]);

            var someList = new List<int>();
            someList.Add(1);
            someList.Add(2);
            someList.Add(3);
            someList.Add(5);
            someList.Add(8);
            someList.Add(11);

            someList.RemoveAt(0);
            someList.RemoveAt(2);

            for (int i = 0; i < someList.Count; i++) {
                Console.WriteLine(someList[i]);
            }

            foreach (int number in someList) {
                Console.WriteLine(number);
            }

            someList.ForEach(number => Console.WriteLine(number));
            someList.ForEach(Console.WriteLine);

            string[] names = { "John", "Daryl", "Mike", "Sarah", "Michele" };

            string[] moreNames = new string[5];
            moreNames[0] = "John";
            moreNames[1] = "Daryl";
            
            Console.WriteLine("Size of names: {0}\nSize of moreNames: {1}", names.Length, moreNames.Length);
            // and so on

            string student = "John Smith";

            char firstCharacter = student[1];

            // ---- Exercise for loops ----
            var animals = new List<string>();
            animals.Add("Lion");
            animals.Add("Tiger");
            animals.Add("Bird");
            animals.Add("Cat");
            animals.Add("Dog");
            animals.Add("Leopard");

            string favoriteAnimal = "Bird";

            foreach (string animal in animals) {
                Console.WriteLine(animal);
            }

            if (animals.Contains(favoriteAnimal)) {
                Console.WriteLine("I love {0} and also every other animal, including {1}", favoriteAnimal, animals[2]);
                // same as the above line, but without the placeholder
                Console.WriteLine("I love " + favoriteAnimal + "and also every other animal, including " + animals[2]);
            }
            else {
                Console.WriteLine("No, I don't care for those");
            }

            // dictionary looping
            var person = new Dictionary<string, int>();
            person.Add("Joan", 22);
            person.Add("Daniel", 42);
            person.Add("Anna", 34);

            // person = {Joan=22, Daniel=42, Anna=34}

            // loop through the hash map and return each key/value pair
            for (int i = 0; i < person.Count; i++) {
                Console.WriteLine("Key: {0}, Value: {1}",
                    person.Keys.ElementAt(i),
                    person[person.Keys.ElementAt(i)]);
            }

            foreach (var peep in person) {
                // print out the key (their name) and their value
                Console.WriteLine("Name: {0}, Age: {1}", peep.Key, peep.Value);
            }

            var studentData = new Dictionary<string, string>();
            studentData["name"] = "Fred";
            studentData["age"] = "20";
            studentData["hometown"] = "Seattle";
            studentData["favorite_food"] = "Pizza";


            Console.WriteLine("This is {0}", studentData["name"]);
            Console.WriteLine("They are {0} years old", studentData["age"]);
            Console.WriteLine("from {0}", studentData["hometown"]);
            Console.WriteLine("and their favorite food is {0}", studentData["favorite_food"]);

            var students = new Dictionary<string, Dictionary<string, string>>();
            students["Fred"] = new Dictionary<string, string>();
            students["Fred"].Add("name", "Fred");
            students["Fred"].Add("age", "20");
            students["Fred"].Add("hometown", "Seattle");
            students["Fred"].Add("favorite_food", "Pizza");

            Console.WriteLine("This is {0}", students["Fred"]["name"]);

            var students2 = new Dictionary<string, Student>();
            var someStudent = new Student("Fred", 20, "Seattle", "Pizza");
            students2.Add("Fred", someStudent);

            var anotherStudent = new Student("Sally", 21, "Columbus", "Pasta");
            students2.Add("Sally", anotherStudent);
            var studentWithNoData = new Student();

            var sedan = new Car("blue", 4);
            sedan.Start();
            sedan.Stop();
            sedan.Drive();

            Console.WriteLine("Car color: {0}", sedan.Color);
            Console.WriteLine("Number of Doors: {0}", sedan.NumberOfDoors);

            var coup = new Car("red", 2);
            var compact = new Car("blue");

            Car.Compare(sedan, new Car());
            int maxDoors = Car.MAX_DOORS;
            coup.Type = CarType.SPORTY;
            coup.NumberOfDoors = 4;

            if (coup == sedan) {
                Console.WriteLine("not sure how, but a coup and sedan are the same?");
            }

            if (coup.Equals(sedan)) {
                Console.WriteLine("");
            }

            Console.WriteLine(coup.ToString());

            var vehicle = new Vehicle();
            
            var genericAnimal = new Animal(0, "amoeba");
            genericAnimal.Announce();

            var bear = new Bear(1, "Yogi", 9999);
            bear.Announce();

            var vehicles = new List<Vehicle>();
            vehicles.Add(new Truck());
            vehicles.Add(sedan);
            vehicles.Add(coup);
            vehicles.Add(compact);


            var vehicles2 = new List<IVehicle>();
            var rallyCar = new RallyCar();
            vehicles2.Add(new Truck());
            vehicles2.Add(new Motorcycle());
            vehicles2.Add(sedan);
            vehicles2.Add(coup);
            vehicles2.Add(compact);
            vehicles2.Add(rallyCar);

            var crossOver = new CrossOver();

            // this won't work, because crossover doesn't implement
            // the IVehicle interface
            //vehicles2.Add(crossOver);

            foreach (var v in vehicles2) {
                v.Accelerate(10);
            }

            Drive(rallyCar);

            Drive(sedan);
            Drive(new Truck());

            var pupil = new Student("John Smith", 19, "Columbus", "Pizza");
            var teacher = new Teacher("Jane Doe", 31);

            PrintInfo(pupil);
            PrintInfo(teacher);

            // Page 21 in interfaces and extension methods example

            Console.WriteLine("-----------------------");
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator2 = new DbMigrator(new FileLogger("migrator.log"));
            dbMigrator.Migrate();
            dbMigrator2.Migrate();

            Console.WriteLine("-----------------------");
            // event stuff (week 6 day 2)

            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.ProcessCompleted += bl_ProcessUpdated;
            bl.StartProcess();

            var myProcess = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyContrast;
            filterHandler += filters.ApplyBrightness;
            filterHandler += RemoveRedEyeFilter;
            myProcess.Process("pic.jpg", filterHandler);

            // lambda function takes in a number and then squares it
            Func<int, int> squareFunction = num => num * num;
            // in our case, it passes in 3 and returns 9
            Console.WriteLine(squareFunction(3));

            const int factor = 5;
            Func<int, int> multiplier = num => num * factor;
            int result = multiplier(10);
            Console.WriteLine(multiplier(6));
            Console.WriteLine(result);


            Func<int, int, int, double> pythagoreanTheorem 
                = (a, b, c) => Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);
            double result2 = pythagoreanTheorem(1, 2, 3);
            Console.WriteLine(pythagoreanTheorem(2, 3, 4));
            Console.WriteLine(result2);


            var library = new BookRepository();
            List<Book> books = library.Books;
            List<Book> cheapBooks = books.FindAll(book => book.Price < 10);

            foreach (var book in cheapBooks) {
                Console.WriteLine(book.Title);
            }
            Console.ReadKey();
        }

        public static void RemoveRedEyeFilter(Photo photo) {
            Console.WriteLine("Remove Red Eye was added here by the consumer!");
        }

        // event handler
        public static void bl_ProcessCompleted(object sender, ProcessEventArgs e) {
            Console.WriteLine($"Process {(e.IsSuccessful ? "Completed Successfully" : "failed")}");
            Console.WriteLine($"Completion Time: {e.CompletionTime.ToLongDateString()}");
        }

        public static void bl_ProcessUpdated(object sender, ProcessEventArgs e)
        {
            Console.WriteLine($"Process {(e.IsSuccessful ? "Updated Successfully" : "failed")}");
            Console.WriteLine($"Completion Time: {e.CompletionTime.ToLongDateString()}");
        }

        static void PrintInfo(IPerson person)
        {   // pass objects as references to the interface
            Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
        }

        static void PrintInfo(Teacher teacher)
        {   // pass objects as references to the interface
            Console.WriteLine("Name: {0}, Age: {1}", teacher.Name, teacher.Age);
        }

        static void PrintInfo(Student student)
        {   // pass objects as references to the interface
            Console.WriteLine(
                "Name: {0}, " + 
                "Age: {1}, " + 
                "Hometown: {2}, " + 
                "Favorite Food: {3}",
                student.Name,
                student.Age,
                student.Hometown,
                student.FavoriteFood);
        }

        static void Drive(IVehicle vehicle) {
            vehicle.Accelerate(10);
            vehicle.Brake(10);
            vehicle.ChangeGear(1);
        }

        static void Drive(RallyCar rallyCar) {
            rallyCar.Accelerate(10);
            rallyCar.Brake(10);
            rallyCar.DisplayStatus();
        }

        static void Drive(Car car) {
            Console.WriteLine($"Current Gear: {car.CurrentGear}");
            car.Accelerate(10);
        }
    }
}
