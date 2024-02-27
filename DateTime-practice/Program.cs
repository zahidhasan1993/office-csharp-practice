using System;


namespace DateTime_practice {
    
    class Sample
    {
        struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
        }
        enum Days
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
        }
        static void Main()
        {
         //   DateTime myBirthday = new DateTime(1997, 12, 14);
           // Console.WriteLine(myBirthday.AddDays(10));
            //Console.WriteLine(Days.Friday);
            

            Books book1 = new Books();
            Books book2 = new Books();
            Animal lion = new Animal() { name = "Lion", sound = "Roar" };
            Animal dog = new Animal() { name = "dog", sound = "Bark" };
            Animal cat = new Animal() { name = "Cat", sound = "Meow" };
            int? nullValue = null;

            book1.title = "C-Sharp";
            book1.author = "Jovern Lee";
            book1.subject = "Programming";
            book1.book_id = 1;


            book2.title = "javaScript";
            book2.author = "Mern Lee";
            book2.subject = "Programming";
            book2.book_id = 2;

            if (!nullValue.HasValue)
            {
                Console.WriteLine("It is a null value");
            }
            Console.WriteLine("This {0} book is written by {1} and the topic of this book is on {2}",book1.title,book1.author,book1.subject);
            Console.WriteLine("This {0} book is written by {1} and the topic of this book is on {2}", book2.title, book2.author, book2.subject);
            Console.WriteLine("The {0} sound is {1}", lion.name,lion.sound);
            Console.WriteLine("The {0} sound is {1}", dog.name,dog.sound);
            Console.WriteLine("The {0} sound is {1}", cat.name,cat.sound);
            Console.WriteLine("Total Animal : {0}", Animal.TotalAnimals());
            lion.MakeSound();
            Console.Write("Enter your first integer number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Second integer number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Calculator calculator = new Calculator();
            Console.Write("/ : Divide\n");
            Console.Write("* : Multiple\n");
            Console.Write("+ : Addition\n");
            Console.Write("- : Substruction\n");

            Console.Write("What do you want to execute : ");
            string? sign = Console.ReadLine();

            switch (sign)
            {
                case "+": calculator.Sum(num1, num2); break;
                case "-": calculator.Sub(num1, num2); break;
                case "*": calculator.Mul(num1, num2); break;
                case "/": calculator.div(num1, num2); break;

            }


           

        }
    }
}
