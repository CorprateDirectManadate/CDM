using AutoNise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Domain
{
    public class Invoice: BaseEntity<int>
    {
        public DateTime InvoiceDate { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get { return Quantity * Rate; } }
        public Organization Organization { get; set; }
        public string InvoiceNumber { get; set; }
        public bool InvoicedOnBDA { get; set; }
        public bool Paid { get; set; }
        public Currency Currency { get; set; }
        
    }
}
