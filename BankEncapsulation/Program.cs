namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            double deposit;
            bool conBanking;

            Console.WriteLine($"Your current balance is: ");
            account1.GetBalance();
            Console.WriteLine("Would you like to make a deposit? (yes or no)");
            Console.WriteLine("If not, your account balance will be given.");
            conBanking = Console.ReadLine() == "yes";
            while ( conBanking )
            {
                Console.WriteLine("How much would you like to deposit?");
                while (double.TryParse(Console.ReadLine(), out deposit) != true)
                {
                    Console.WriteLine("Not a valid amount to add.");
                }
                account1.Deposit(deposit);
                Console.WriteLine("Okay, your new balance is: ");
                account1.GetBalance();
                Console.WriteLine("Would you like to make another deposit? (yes or no).");
                conBanking = Console.ReadLine() == "yes";
            }
                
            Console.WriteLine($"Okay, your account balance is shown below. Bye!");
            account1.GetBalance();
            
        }
    }
}
