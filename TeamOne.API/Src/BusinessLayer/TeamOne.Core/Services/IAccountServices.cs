namespace TeamOne.Core.Services;

public interface IAccountServices
{
    string BalanceEnquiry(string accountId, string accountName);
    string NameEnquiry(string accountId, string accountName);
    string GetAccountDetails(string accountId, string accountName);
<<<<<<< HEAD
    string GetCustomerDetails(string accountId, string accountName);
=======
    string GetBvn(string accountId, string accountName);
>>>>>>> fdaa1468f2a01a9d4311fc6b241121bcdd5fd8b3
}