using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Practice
{
    public class Customer
    {
        //This is a field. You can use it to make lists, dictionaries etc that is accessible to your prorgam
        //You also have to instantiate the field using the new keyword bc it is also a class.

        private List<Trade> tradeList = new List<Trade>();
        // Declares rhe properites this customer has
        public int Id { get; set; }
        // public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Address { get; set; }

        // Methods - what can the customer do

        public void MakeTrade(Trade trade)
        {
            tradeList.Add(trade);
        }

        public int NumberOfTrades
        {
            get { return tradeList.Count; }
        }

        public string CustomerSummary
        {
            get { return $"{Id}, {Name}, {Address}"; }
        }
    }
}
