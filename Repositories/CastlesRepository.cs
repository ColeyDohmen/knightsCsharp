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
            string sql = @"
            INSERT INTO Castles
            (name, description)
            VALUES
            (@Name, @Description);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, newCastle);
            newCastle.Id = id;
            return newCastle;
        }

        internal Castle Get(int id)
        {
            string sql = "SELECT * FROM castles WHERE id = @id;";
            return _db.QueryFirstOrDefault<Castle>(sql, new { id });
        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM castles WHERE id = @id;";
            _db.Execute(sql, new { id });
            return;
        }
    }
}