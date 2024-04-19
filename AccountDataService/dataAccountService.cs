using ModelServices;

namespace AccountDataService
{
    public class dataAccountService
    {
        List<ModelAccount> dummyAccount = new List<ModelAccount>();

        public dataAccountService()
        {
            CreateDummyAccount();
        }

        private void CreateDummyAccount()
        {
            ModelAccount dummyAccount1 = new ModelAccount
            {
                Username = "Gel",
                Password = "123456789",
            };
            ModelAccount dummyAccount2 = new ModelAccount
            {
                Username = "Anji",
                Password = "10022003",
            };
            ModelAccount dummyAccount3 = new ModelAccount
            {
                Username = "Angge",
                Password = "200302",
            };

            dummyAccount.Add(dummyAccount1);
            dummyAccount.Add(dummyAccount2);
            dummyAccount.Add(dummyAccount3);
        }

        public ModelAccount GetAccount(string Username, string password)
        {
            ModelAccount FoundAccount = new ModelAccount();
            foreach(var dummy in dummyAccount)
            {
                if (Username == dummy.Username)
                {
                    FoundAccount = dummy;
                }
            }
            return FoundAccount;
        }
    }
}
