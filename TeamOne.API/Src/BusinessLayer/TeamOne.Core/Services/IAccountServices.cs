﻿namespace TeamOne.Core.Services
{
    public interface IAccountServices
    {
        string BalanceEnquiry(string accountId, string accountName);
        string AccountValidation(string accountId, string accountName);
    }
}