using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class Lifecycle2Service : ILifecycleService
    {
        private readonly ILifecycleService _lifecycleService;

        public Lifecycle2Service(ILifecycleService lifecycleService)
        {
            _lifecycleService = lifecycleService;
        }

        public DateTime DataAtual() => _lifecycleService.DataAtual();

    }
}
