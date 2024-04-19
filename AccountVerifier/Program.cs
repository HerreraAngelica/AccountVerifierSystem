using AccountBusinessService;

namespace AccountVerifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username: ");
            string user = Console.ReadLine();

            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            VerifyAccount verifyAccount = new VerifyAccount();
            if(verifyAccount.VerifyStudent(user, password))
            {
                Console.WriteLine("Sucess Login");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
