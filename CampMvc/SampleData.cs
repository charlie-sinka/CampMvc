using LagerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagerMVC
{
    public class SampleData
    {
        public static void Initialize(CampContext context)
        {
            if (!context.Vouchers.Any())
            {
                context.Vouchers.AddRange(
                    new Voucher
                    {
                        Name = "Первая летняя смена",
                        StartDate = new DateTime(2021, 06, 01),
                        Price = 21000
                    },
                    new Voucher
                    {
                        Name = "Вторая летняя смена",
                        StartDate = new DateTime(2021, 07, 01),
                        Price = 26000
                    },
                    new Voucher
                    {
                        Name = "Третья летняя смена",
                        StartDate = new DateTime(2021, 08, 01),
                        Price = 18000
                    });
                context.SaveChanges();
            }
        }
    }
}
