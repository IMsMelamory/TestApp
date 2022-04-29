using System;
using System.Collections.Generic;
using System.Linq;
using TestApp.JsonProvider;
using TestApp.Model;

namespace TestApp.Repository
{
    public class CardRepository
    {
        public event Action OnRepositoryUpdate;
        private readonly JsonProvider<Card> _jsonProvider;
        protected List<Card> _entities;

        public CardRepository(JsonProvider<Card> jsonProvider)
        {
            _jsonProvider = jsonProvider;
        }

        public List<Card> GetAll()
        {
            UpdateDataIfNotExist();
            return _entities;
        }

        public void Add(Card entity)
        {
            UpdateDataIfNotExist();
            _entities.Add(entity);
            ForceUpdate();
        }

        public void Remove(Card entity)
        {
            UpdateDataIfNotExist();
            _entities.Remove(entity);
            ForceUpdate();
        }

        public void RemoveById(int id)
        {
            UpdateDataIfNotExist();
            var entityToRemove = _entities.FirstOrDefault(x => x.ID == id);
            _entities.Remove(entityToRemove);
            ForceUpdate();
        }
        public void EditById(int id, Card entity)
        {
            UpdateDataIfNotExist();
            var oldEntity = _entities.FirstOrDefault(x => x.ID == id);
            _entities.Remove(oldEntity);
            _entities.Add(entity);
            ForceUpdate();
        }

        public void ForceUpdate()
        {
            _jsonProvider.WriteAll(_entities);
            OnOnRepositoryUpdate();
        }

        protected void UpdateDataIfNotExist()
        {
            _entities ??= _jsonProvider.GetAll();
        }
        protected virtual void OnOnRepositoryUpdate()
        {
            OnRepositoryUpdate?.Invoke();
        }
    }
}
