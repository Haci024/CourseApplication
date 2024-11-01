using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Payments
    {
        public int Id { get; set; }

        public decimal MonthlyPayment { get; set; }

        public DateTime AddedDate { get; set; }

        public Students Students { get; set; }

        public int StudentId { get; set; }

        public bool Status { get; set; }

        public decimal PaidedMoney { get; set; }
    }
}
