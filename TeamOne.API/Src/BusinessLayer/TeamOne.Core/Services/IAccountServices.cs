﻿namespace TeamOne.Core.Services;

public interface IAccountServices
{
    string BalanceEnquiry(string accountId, string accountName);
    string NameEnquiry(string accountId, string accountName);
}