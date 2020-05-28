using System.Collections.Generic;

namespace RelationsPractice.Models
{
  public class NonProfit
    {
        public NonProfit()
        {
            this.BoardMembers = new HashSet<BoardMember>();
        }

        public int NonProfitId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<BoardMember> BoardMembers { get; set; }
    }
}