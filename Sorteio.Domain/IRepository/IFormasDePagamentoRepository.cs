﻿using Sorteio.Domain.IRepository.Base;
using Sorteio.Domain.Models.Body;
using Sorteio.Domain.Models.Common;
using Sorteio.Domain.Models.EntityDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio.Domain.IRepository
{
    public interface IFormasDePagamentoRepository : IRepositoryBase<FormasDePagamento>
    {
        Task<int> ExcluirFormaDePagamento(int idFormaDePagamento);
        Task<IEnumerable<FormaDePagamentoBody>> ObterTodasFormasDePagamentoAtivo();
    }
}
