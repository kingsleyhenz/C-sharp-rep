namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(String[] args)
        {
            /*Console.WriteLine("Hello, World!");
            int a = 10;
            int b = 20;
            int sum = a + b;
            Console.WriteLine(a + " " + b + " =" + sum);*/

            /* Console.WriteLine("Enter Your Name");
             String name = "";
             name = Console.ReadLine();
             Console.WriteLine("Your Name is " + name);*/

            /* Console.WriteLine("Enter Your First Name");
             String firsname = "";
             firsname = Console.ReadLine();
             Console.WriteLine("Enter Your Last Name");
             String lastname = "";
             lastname = Console.ReadLine();

             string remchar = "";
             remchar = lastname.Substring(1);
             string laschar = lastname.Substring(0, 1).ToUpper();
             Console.WriteLine("Congratulations Your FullName is " + firsname.ToUpper() + " " + laschar+remchar);*/


            /*Console.WriteLine("Enter First Number");
            int firstnum;
            firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondnum;
            secondnum = Convert.ToInt32(Console.ReadLine());
            int sum = firstnum + secondnum;
            Console.WriteLine("The answer of " + firstnum + " and " + secondnum + " is " + sum);*/

            /*Console.WriteLine(AddTwo(3,3));*/
            /*Console.WriteLine(Fac(10));*/
            /* Console.WriteLine("Please select from option: \n 1: Add \n 2: Subtract \n 3: Multiply \n 4: Divide \n 5: Exit");
             int operate = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter first number: ");
             int firstnum = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter second number: ");
             int secondnum = Convert.ToInt32(Console.ReadLine());


             Console.WriteLine(Calc(firstnum, operate, secondnum));
             Console.ReadLine();
         }

         static int Calc(int a, int choice, int b)
         {
             String messages = "Goodbye";
             switch (choice)
             {
                 case 1:
                     return a + b;
                     break;
                 case 2:
                     return a - b;
                     break;
                 case 3:
                     return a * b;
                     break;
                 case 4:
                     return a / b;
                     break;
                 case 5:
                     break;
                 default:
                     break;
             }
             {

             }

        /* static int Fac(int num)
         {
             if(num <= 2)
             {
                 return num;
             }
             else
             {
                 return num * Fac(num - 1);
             }
         }*/

            /*static int AddTwo(int a, int b)
            {
                return a + b;
            }*/
            /* static int ValidAge(int age)
                 {
                     if(age < 18)
                     {
                         Console.WriteLine("Age Cannot Below 18");
                     }
                 }*/

            String S1 = "hello";
            char[] nm = { 's', 'o', 'p', 'h', 'i', 'a' };
            String S2 = new(nm);
            Console.WriteLine(S2);

            String st2 = "dwz";
            String st1 = "abc";
            Console.WriteLine(String.Compare(st1, st2));

            String fname = "sophia";
            String lname = "okosodo";
            String fullname = String.Concat(fname, lname);
            Console.WriteLine(fullname);

            String msg = "success requires dedication";
            int index = msg.IndexOf("r");
            Console.WriteLine(index);
        }
    }
}
