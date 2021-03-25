using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagerMVC.Models
{
    public class Voucher
    {
        public int VoucherId { get; set; }
        public string Name { get; set; } // Наименование смены
        public DateTime StartDate { get; set; } // Дата начала смены
        public int Price { get; set; }
        public string PathToImg { get; set; }
    }
}
