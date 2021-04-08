using System;
using knights.Models;

using System;
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
    }

}