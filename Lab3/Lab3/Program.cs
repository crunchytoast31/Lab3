namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {





            bool goOn = false;


            Console.WriteLine("What number would you like to learn how to cube and square first?");
            double num = double.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                double square = i * i;
                double cube = i * i * i;
                Console.WriteLine("The number you chose was: " + i + " that number squared is: " + square + " and cubed is: " + cube);


                {
                    while (goOn == true) ;
                    Console.WriteLine("Would you like to input another number y/n?");
                    string input = Console.ReadLine();
                    {

                        if (input == "y") ;
                        goOn = true;


                        if (input == "n") ; goOn = false;
                    }
                }







            }





        }



    }
}