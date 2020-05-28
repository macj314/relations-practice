namespace RelationsPractice.Models
{
  public class BoardMember
  {
    public int BoardMemberId { get; set; }
    public string Name { get; set; }
    public int NonProfitId { get; set; }
    public virtual NonProfit NonProfit { get; set; }
  }
}