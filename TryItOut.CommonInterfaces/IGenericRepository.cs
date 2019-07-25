using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.CommonInterfaces
{
    /* ******************** */
    /* generic CRUD actions */
    /* ******************** */

    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /* a single update method */
        void update(TEntity entity);

        /* two delete methods */
        bool Delete(TEntity entity);

        bool Delete(int identifier);

        /* two read methods, single entity, list of entities */
        TEntity Read(int identifier);

        IList<TEntity> Read();

        /* a single update method */
        bool Save(TEntity entity);

    }
}
