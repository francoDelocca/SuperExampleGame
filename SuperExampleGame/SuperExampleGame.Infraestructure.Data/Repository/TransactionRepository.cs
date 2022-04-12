using SuperExampleGame.Domain;
using SuperExampleGame.Domain.Domain;
using SuperExampleGame.Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperExampleGame.Infraestructure.Data
{
    public class TransactionRepository : ITransactionRepository<Transaction>
    {
        private DatabaseContext _dbContext;

        public TransactionRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Transaction Create(Transaction entity)
        {
            entity.TransactionId = Guid.NewGuid();
            _dbContext.Add(entity);
            return entity;

        }
    }
}
