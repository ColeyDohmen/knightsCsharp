using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using knights.Models;

namespace knights.Repositories
{
    public class CastlesRepository
    {
        public readonly IDbConnection _db;

        public CastlesRepository(IDbConnection db)
        {
            _db = db;
        }
        internal IEnumerable<Castle> Get()
        {
            string sql = "SELECT * FROM castles;";
            return _db.Query<Castle>(sql);
        }
        internal Castle Create(Castle newCastle)
        {
            throw new NotImplementedException();
        }
    }
}