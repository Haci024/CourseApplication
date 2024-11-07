using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOS.Packets
{
    public class PacketListDTO
    {
        public int Id { get; set; }

        public string PacketName { get; set; }

        public string StudentAccounts { get; set; }

        public string TeacherAccounts { get; set; }

        public string AdminAccounts { get; set; }

        public string ReservatorAccountCount { get; set; }

        public decimal Price { get; set; }//standart qiymət

        public decimal DiscountPrice { get; set; }// endirim qiyməti

        public bool Status { get; set; }

        public bool MonthlyOrYearly { get; set; }// paket aylıq və ya illik olacaqsa

        public int FreeUseDay { get; set; }//7 və ya 14 gün pulsuz istifadə
    }
}
