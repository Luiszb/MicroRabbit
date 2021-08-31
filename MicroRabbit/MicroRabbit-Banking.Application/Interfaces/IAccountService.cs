using MicroRabbit.Banking.Domain.Models;
using MicroRabbit_Banking.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit_Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
