namespace TeamOne.Core.Services;

public interface IAccountServices
{
    string BalanceEnquiry(string accountId, string accountName);
    string NameEnquiry(string accountId, string accountName);
    string GetAccountDetails(string accountId, string accountName);
    string GetCustomerDetails(string accountId, string accountName);
    string GetBvn(string accountId, string accountName);
}