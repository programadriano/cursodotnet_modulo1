using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class LifecycleService : ILifecycleService
    {
        private readonly DateTime _date = DateTime.Now;
        public DateTime DataAtual() => _date;

    }
}
