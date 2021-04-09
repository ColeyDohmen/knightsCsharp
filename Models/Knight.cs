namespace knights.Models
{
    public class Knight
    {
        internal int Id;
         public Knight()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CastleId {get; set;}
    }
}