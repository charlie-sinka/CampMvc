using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagerMVC.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; } // Имя
        public string LastName { get; set; } // Фамилия
        public string ContactPhone { get; set; } // Телефон

        public int VoucherId { get; set; } // Путевка
        public Voucher Voucher { get; set; }
    }
}
