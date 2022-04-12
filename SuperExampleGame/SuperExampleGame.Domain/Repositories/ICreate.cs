using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperExampleGame.Domain.Repositories
{
    public interface ICreate<TEntity>
    {
        TEntity Create(TEntity entity);
    }
}
