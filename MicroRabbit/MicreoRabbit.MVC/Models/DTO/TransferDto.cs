using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicreoRabbit.MVC.Models.DTO
{
    public class TransferDto
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
