namespace Assignment5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter individual digits to calculate the sum: ");
            string num = Console.ReadLine();

            Console.WriteLine(SumofNum(num));
        }
        static int SumofNum(string num)
        {
            int sum = 0; 
            for (int i = 0; i < num.Length; i++)
            {
                int numConverted = int.Parse(num[i].ToString());   //the int.Parse(...) function is used to convert the resulting string back to an integer. 

                sum += numConverted;

            }
            return sum;
        }
     
        

        
    }
}   
