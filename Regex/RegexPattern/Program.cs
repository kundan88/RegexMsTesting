namespace RegexPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC1
            Validation person = new Validation();
            Console.WriteLine("Enter The First Name: ");
            string firstName = Console.ReadLine();
            person.ValidateFirstName(firstName);

        }
    }
}