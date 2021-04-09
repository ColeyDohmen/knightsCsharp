using System;
using System.Collections.Generic;
using knights.Models;
using knights.Repositories;

namespace knights.Services
{
    public class KnightsService
    {
        private readonly KnightsRepository _repo;

        public KnightsService(KnightsRepository repo)
        {
            _repo = repo;
        }
        internal IEnumerable<Knight> Get()
        {
            return _repo.Get();
        }

        internal Knight Create(Knight newKnight)
        {
            return _repo.Create(newKnight);
        }

        internal Knight Get(int id)
        {
            Knight knight = _repo.Get(id);
            if (knight == null)
            {
                throw new Exception("invalid id");
            }
            return knight;
        }


        internal Knight Delete(int id)
        {
            Knight original = Get(id);
            _repo.Delete(id);
            return original;
        }

    }
}