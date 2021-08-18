using System;
namespace CP380_B1_BlockList.Models
{
    public enum TransactionTypes
    {
        BUY, SELL, GRANT
    }

    public class Payload
    {
        public string User { get; set; }
        public TransactionTypes TransactionTypes { get; set; }
        public string Item { get; set; }
        public int Amount { get; set; }

        public Payload(string user, TransactionTypes tp, string item, int amount)
        {
            User = user;
            TransactionTypes = tp;
            Item = item;
            Amount = amount;
        }
        public Payload()
        {

        }
    }
}
