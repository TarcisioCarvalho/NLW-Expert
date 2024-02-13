namespace RocketseatAuction.API.Entities;

public class Auction
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; }

    public Auction() { }
    public Auction(int id,string name,DateTime starts, DateTime ends)
    {
        Id = id;
        Name = name;
        Starts = starts;
        Ends = ends;
    }
}
