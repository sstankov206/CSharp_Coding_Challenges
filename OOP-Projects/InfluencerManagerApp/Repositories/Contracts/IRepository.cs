using System;

namespace InfluencerManagerApp.Repositories.Contracts
{
   public interface IRepository<T> where T : class
    {
        IReadOnlyCollection<T> Models { get; }

        void AddModel(T model);
        void RemoveModel(T model);
        T FindByName(string name);

    }
}
