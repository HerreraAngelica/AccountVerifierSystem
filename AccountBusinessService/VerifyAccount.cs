using AccountBusinessService;
using AccountDataService;

namespace AccountBusinessService
{
    public class VerifyAccount
    {
        public bool VerifyStudent(string Username, string Password)
        {
            dataAccountService dataService = new dataAccountService();
            var result = dataService.GetAccount(Username, Password);

            return result != null ? true : false;
        }
    }
}
