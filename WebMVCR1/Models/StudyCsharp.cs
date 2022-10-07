using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCR1.Models
{
    public enum AccountType
    {
        Checking, Deposit
    }
    public struct BankAccount 
    { 
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    public class StudyCsharp
    {
    }
}