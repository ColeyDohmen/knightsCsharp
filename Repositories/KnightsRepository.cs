using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using knights.Models;

namespace knights.Repositories
{
    public class KnightsRepository
    {
        public readonly IDbConnection _db;

        public KnightsRepository(IDbConnection db)
        {
            _db = db;
        }
        internal IEnumerable<Knight> Get()
        {
            string sql = "SELECT * FROM knights;";
            return _db.Query<Knight>(sql);
        }

        internal Knight Create(Knight newKnight)
        {
            string sql = @"
            INSERT INTO knights
            (name, description, KnightId)
            VALUES
            (@Name, @Description, @KnightId);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, newKnight);
            newKnight.Id = id;
            return newKnight;
        }

        internal Knight Get(int id)
        {
            string sql = "SELECT * FROM knights WHERE id = @id;";
            return _db.QueryFirstOrDefault<Knight>(sql, new { id });
        }


        internal void Delete(int id)
        {
            string sql = "DELETE FROM knights WHERE id = @id;";
            _db.Execute(sql, new { id });
            return;
        }
    }
}