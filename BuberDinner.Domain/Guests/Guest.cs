using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain;

public sealed class Guest : AggregateRoot<GuestId, Guid>
{
    public Guest(GuestId id) : base(id)
    {
    }
 
    private Guest() { }
 
}