using System.Collections.Generic;
public class StorFront
{
    public string name {get; set;}
    public string address {get; set;}
    public List<LineItems> inventory {get; set;}
    public List<Order> orders {get; set;}

    public StorFront()

    { }
}