using System;
using knights.Models;
using knights.Repositories;
using System.Collections.Generic;

namespace knights.Services
{
    public class CastlesService
    {

        private readonly CastlesRepository _repo;

        public CastlesService(CastlesRepository repo)
        {
            _repo = repo;
        }
        internal IEnumerable<Castle> Get()
        {
            return _repo.Get();
        }

        internal Castle Create(Castle newCastle)
        {
            return _repo.Create(newCastle);
        }

        internal Castle Get(int id)
        {
            Castle castle = _repo.Get(id);
            if (castle == null)
            {
                throw new Exception("invalid id");
            }
            return castle;
        }

        internal Castle Delete(int id)
        {
            Castle original = Get(id);
            _repo.Delete(id);
            return original;
        }

        internal object Edit(Castle editCastle)
        {
            throw new NotImplementedException();
        }
    }

}