using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperExampleGame.Domain.Repositories;
using SuperExampleGame.Domain.Domain;
namespace SuperExampleGame.Application.Interfaces
{
    public interface IBuyService : ICreate<Transaction>
    {
    }
}
