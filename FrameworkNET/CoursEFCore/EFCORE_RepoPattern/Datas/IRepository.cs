using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_RepoPattern.Datas
{
    // Dans le Repository Pattern, il y a également présence d'une interface générique qui forcera les repositories futurs
    // à implémenter les méthodes permettant la manipulation des données
    internal interface IRepository<T> where T : class
    {
        // La méthode pour INSERT
        public bool Add(T element);

        // La méthode pour DELETE
        public bool Delete(T element);

        // La méthode pour UPDATE
        public bool Update(T element);

        // La méthode pour SELECT un élément
        public T? GetById(int id);

        // La méthode pour SELECT tous les éléments
        public ICollection<T> GetAll();

        // La méthode pour SELECT plusieurs éléments basés sur un filtre
        public ICollection<T> Filter(Func<T, bool> predicate);
    }


    // Une autre version de la classe IRepository serait une version prenant en compte l'asynchronisme
    internal interface IRepositorySup<T> where T : class
    {
        // La méthode pour INSERT
        public Task<bool> AddAsync(T element);

        // La méthode pour DELETE
        public Task<bool> DeleteAsync(T element);

        // La méthode pour UPDATE
        public Task<bool> UpdateAsync(T element);

        // La méthode pour SELECT un élément
        public Task<T?> GetByIdAsync(int id);

        // La méthode pour SELECT tous les éléments
        public Task<ICollection<T>> GetAllAsync();

        // La méthode pour SELECT plusieurs éléments basés sur un filtre
        public Task<ICollection<T>> FilterAsync(Func<T, bool> predicate);
    }

    // Une version encore plus avancée serait une version prenant en compte les évènements
    internal interface IRepositorySupWEvents<T> where T : class
    {
        public event Action<string> ElementAdded;

        public event Action<string> ElementDeleted;

        public event Action<string> ElementUpdated;

        // La méthode pour INSERT
        public Task<bool> AddAsync(T element);

        // La méthode pour DELETE
        public Task<bool> DeleteAsync(T element);

        // La méthode pour UPDATE
        public Task<bool> UpdateAsync(T element);

        // La méthode pour SELECT un élément
        public Task<T?> GetByIdAsync(int id);

        // La méthode pour SELECT tous les éléments
        public Task<ICollection<T>> GetAllAsync();

        // La méthode pour SELECT plusieurs éléments basés sur un filtre
        public Task<ICollection<T>> FilterAsync(Func<T, bool> predicate);
    }
}
