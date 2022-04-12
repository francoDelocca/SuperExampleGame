using SuperExampleGame.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperExampleGame.Domain
{
    public interface ITransactionRepository<TEntity> : ICreate<TEntity>
    {
    }
}
