using BarAppAdam.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarAppAdam.Data
{
    public abstract class BaseRepository<TEntity> : IDisposable where TEntity : Entity
    {
        protected readonly SqlConnection _connection = new("Data Source=(local);Initial Catalog=BarApplication;Integrated Security=True;Pooling=False");

        public BaseRepository()
        {
            _connection.Open();
        }

        public TEntity Save(TEntity entity)
        {
            // Als de entity nog geen Id heeft is hij nog niet opgeslagen
            if (entity.Id is null)
            {
                entity = Insert(entity);
            }
            else
            {
                Update(entity);
            }

            return entity;
        }

        public abstract TEntity? GetEntity(int id);
        protected abstract TEntity Insert(TEntity entity);
        protected abstract void Update(TEntity entity);

        public void Dispose()
        {
            _connection.Close();
        }
    }
}
