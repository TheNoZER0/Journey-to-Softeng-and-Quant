namespace practice_project //this is the name space
{
    public class Program    // this is the class
    {
        /*
        //static void Main(string[] args) //this is the method
        {
            // these are called primitive data types (data types already provided by C#
            // a complex data type is something you create, with attributes

            // the variables below are explicitly defined
            float price = 100.4f;
            int number = 1000;
            string name = "Zain";
            bool toggle = true;
            char letter = 'a';

            //implicit data types (can only be done inside methods)
            // usually used with Var, changes depending on whats written
            var username = "Zain";
        }*/


        /*public static void Main()
        {
            int a = 5;
            int b = 6;

            //solution to programming problem (to make them swap)
            int temp = a; //5
            a = b; //6
            b = temp; //5

            Console.WriteLine("A is: " + a + "B is: " + b);




        }*/

        //argument exercise
        /*
        public static void Main()
        {
            WriteSomethingSpecific("This is an argument, called from a method");

        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }*/





        //public static void Main()
        //{//method 1
        //int result =  Add(15, 31);
        //Console.WriteLine(result);
        //Console.Read();

        //method 2

        /*
        public static int Mul(int num1, int num2) // these are parameters

        {// you need a return statement in every path we have

            return num1 * num2;

        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;

            //double is a return type that will return either integer or float in case thre are decimals
        }*/

        //input exercise
        /*public static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();

        }



        public static int Calculate()
        {
            Console.WriteLine("Please Enter your first number:");
            string N1Input = Console.ReadLine();
            Console.WriteLine("Please enter your second number:");
            string N2Input = Console.ReadLine();

            int num1 = int.Parse(N1Input);
            int num2 = int.Parse(N2Input);

            int result = num1 + num2;



            return (result);
           */
        //catching error exercise (an exception is another word for an error)
        /* public static void Main(String[] args)
         {
             Console.WriteLine("Please enter a Number");
             string userInput = Console.ReadLine();

             //try is basically trying code, catch displays the error, finally try regardless
             try
             {
                 int userInputAsInt = int.Parse(userInput);
                 int answer = int.Parse(userInput) / 0;
             }
             catch (FormatException)
             {
                 Console.WriteLine("Format Exception, Please enter the correct number");
             }
             catch(DivideByZeroException)
             {
                 Console.WriteLine("Cannot Divide by 0, Answer is Undefined");
             }
             finally
             {


             }
             Console.WriteLine();
             Console.ReadKey();
         }
        */

        //operators lesson

        
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 8;
            int num3 = 0;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0},", num3);

            bool isSunny = true;
            //the ! negates the expression, so if isSunny is true, then after adding ! it will be false
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            //increment operators
            int num = 0;
            num++;
            //the position of the ++ affects when does incrementation takes place
            Console.WriteLine("num is {0},", num);

            //pre increment operator
            Console.WriteLine("num is {0},", ++num);
           
            //post increment operator
            Console.WriteLine("num is {0},", num++);
           
            //decrement operator
            Console.WriteLine("num is {0},", num--);
            //multiplication
            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 and num2 is: {0}", result);

            //modular operator (divides the two numbers and outputs the remainder of the division)
            result = num1 % num2;
            Console.WriteLine("modular result of num 1 and num 2: {0}", result);
           

            //relational and type operatoes
            bool islower;
            islower = num1 < num2;
            Console.WriteLine("result of num1 being lower than num2: {0}", islower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 being eqaul to num2:{0}", isEqual);
            //inequality operator
            isEqual = num1 != num2;
            Console.WriteLine("result of num1 being ineqaul to num2:{0}", isEqual);

            //conditional operators
            bool isLowerAndSunny;
            //the && means "this AND condition 2"
            isLowerAndSunny = islower && isSunny;
            Console.WriteLine("result of isLower and isSunny: {0}", isLowerAndSunny);

            //OR Conditional Operator
            isLowerAndSunny = islower || isSunny;
            Console.WriteLine("result of isLower or isSunny: {0}", isLowerAndSunny);
            Console.ReadKey();

            //if statement strucure
            /*
             * if (condition){
             *what to do if condition is met
             *}
             */

  

        }


    }





}
