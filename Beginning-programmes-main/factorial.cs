int number;
            Console.WriteLine("inter an integer number to calculate its factorial");
            number= int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("invalid.. please enter a positive number");
                return;
            }
            int counter = 1;
            long fact = 1;
            while (counter<=number)
            {
                fact *= counter++;
            }
            Console.WriteLine("factorial of" + number + "is" + fact);
                Console.Read();
