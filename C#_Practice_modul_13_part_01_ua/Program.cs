namespace C__Practice_modul_13_part_01_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>
            {
            new Student { FirstName = "John", LastName = "Doe", Age = 20, SchoolName = "MIT" },
            new Student { FirstName = "Jane", LastName = "Smith", Age = 22, SchoolName = "Oxford" },
            new Student { FirstName = "Boris", LastName = "Johnson", Age = 19, SchoolName = "Harvard" },
            new Student { FirstName = "Anna", LastName = "Brown", Age = 21, SchoolName = "MIT" },
            new Student { FirstName = "Brody", LastName = "Brooks", Age = 18, SchoolName = "Oxford" },
            new Student { FirstName = "Bella", LastName = "Turner", Age = 23, SchoolName = "Cambridge"}
            };

            List<string> citiesList = new List<string>
            {
                "Londonm", "Paris", "ANew York", "Tokyo", "Los Angeles",
                "Sydney", "Moscow", "Berlinm", "NeToronto", "NRomek"
            };
            var numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int c = int.Parse(Console.ReadLine());
            switch (c) { 
                case 0:
                    var allNumbers = numbersList.ToList();
                    var evenNumbers = numbersList.Where(num => num % 2 == 0).ToList();
                    var oddNumbers = numbersList.Where(num => num % 2 != 0).ToList();
                    var greaterThanFive = numbersList.Where(num => num > 5).ToList();
                    var numbersInRange = numbersList.Where(num => num >= 3 && num <= 7).ToList();
                    var multiplesOfSeven = numbersList.Where(num => num % 7 == 0).OrderBy(num => num).ToList();
                    var multiplesOfEight = numbersList.Where(num => num % 8 == 0).OrderByDescending(num => num).ToList();

                    Console.Write("All numbers: ");PrintList(allNumbers);                    
                    Console.Write("Even numbers: ");PrintList(evenNumbers);                   
                    Console.Write("Odd numbers: ");PrintList(oddNumbers);                 
                    Console.Write("Numbers greater than 5: ");PrintList(greaterThanFive);                   
                    Console.Write("Numbers in range [3, 7]: ");PrintList(numbersInRange);                
                    Console.Write("Multiples of seven (ascending): ");PrintList(multiplesOfSeven);                 
                    Console.Write("Multiples of eight (descending): ");PrintList(multiplesOfEight);
                    break;

                case 1:
                    Console.Write("Enter num: ");
                    int num = int.Parse(Console.ReadLine());

                    var allCities = citiesList;
                    var citiesWithLength = citiesList.Where(str => str.Length == 5).ToList();
                    var citiesStartingWithA = citiesList.Where(str => str[0] == 'A').ToList();
                    var citiesEndingWithM = citiesList.Where(str => str[str.Length -1] == 'm').ToList();
                    var citiesStartingWithNEndingWithK = citiesList.Where(str => str[0] == 'N' && str[str.Length - 1] == 'k').ToList();
                    var citiesStartingWithNe = citiesList.Where(str => str[0] == 'N' && str[1] == 'e').OrderByDescending(_=>_).ToList();

                    Console.WriteLine("All cities:"); PrintList(allCities);
                    Console.WriteLine("Cities with length 5:"); PrintList(citiesWithLength);
                    Console.WriteLine("Cities starting with 'A':"); PrintList(citiesStartingWithA);
                    Console.WriteLine("Cities ending with 'm':"); PrintList(citiesEndingWithM);
                    Console.WriteLine("Cities starting with 'N' and ending with 'K':"); PrintList(citiesStartingWithNEndingWithK);
                    Console.WriteLine("Cities starting with 'Ne' :"); PrintList(citiesStartingWithNe);
                    break;

                case 2:
                    Console.WriteLine("All students:");
                    PrintStudents(studentsList);

                    var studentsWithFirstNameBoris = studentsList.Where(str => str.FirstName == "Boris").ToList();
                    Console.WriteLine("\nStudents with first name Boris:");
                    PrintStudents(studentsWithFirstNameBoris);

                    var studentsWithLastNameBro = studentsList.Where(str => str.LastName.StartsWith("Bro")).ToList();
                    Console.WriteLine("\nStudents with last name starting with Bro:");
                    PrintStudents(studentsWithLastNameBro);

                    var studentsOlderThan19 = studentsList.Where(str => str.Age > 19).ToList();
                    Console.WriteLine("\nStudents older than 19:");
                    PrintStudents(studentsOlderThan19);

                    var studentsBetween20And23 = studentsList.Where(str => str.Age >= 20 && str.Age <= 23).ToList();
                    Console.WriteLine("\nStudents between 20 and 23 years old:");
                    PrintStudents(studentsBetween20And23);

                    var studentsFromMIT = studentsList.Where(str => str.SchoolName == "MIT").ToList();
                    Console.WriteLine("\nStudents from MIT:");
                    PrintStudents(studentsFromMIT);

                    var studentsFromOxfordAbove18 = studentsList.Where(str => str.SchoolName == "Oxford" && str.Age > 18).OrderByDescending(str => str.Age).ToList();

                    Console.WriteLine("\nStudents from Oxford above 18 years old:");
                    PrintStudents(studentsFromOxfordAbove18);
                    break;

            }
        }

        static void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintStudents(List<Student> students)
        {
            foreach (Student item in students)
            {
                item.DisplayStudentInfo();
            }
        }
    }
}
