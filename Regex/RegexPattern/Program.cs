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

            //UC2
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Last Name: ");
            string lastname = Console.ReadLine();
            person.ValidateLastName(lastname);

        }
    }
}