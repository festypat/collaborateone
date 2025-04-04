using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOne.Core.Services;

public class AccountServices : IAccountServices
{
    public AccountServices()
    {

    }

    public string BalanceEnquiry(string accountId, string accountName)
    {
        return string.Empty;
    }

    public string GetAccountDetails(string accountId, string accountName)
    {
        throw new NotImplementedException();
    }

    public string GetCustomerDetails(string accountId, string accountName)
    {
        throw new NotImplementedException();
    }
    public string GetBvn(string accountId, string accountName)
    {
        throw new NotImplementedException();
    }

    public string NameEnquiry(string accountId, string accountName)
    {
        return string.Empty;
    }

    public string NameEnquiryByPhone(string phoneNumber)
    {
        return string.Empty;
    }

    public string NameEnquiryByWallet(string walletId)
    {
        return string.Empty;
    }
}
