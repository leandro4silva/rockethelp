
using RocketHelp.Domain.Enum;

namespace RocketHelp.Domain.Entity;

public class Ticket : SeedWork.Entity
{
    public int Patrimony { get; private set; }
    public string Description { get; private set; }
    public string Solution { get; private set; }
    public DeliveryStatus Status { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Ticket(int patrimony, string description, string solution, DeliveryStatus status = DeliveryStatus.InProgress) : base()
    {
        Patrimony = patrimony;
        Description = description;
        Solution = solution;
        Status = status;
        CreatedAt = DateTime.Now;
    }

    public void Finish()
    {
        Status = DeliveryStatus.Finish;
    }

    public void InProgress()
    {
        Status = DeliveryStatus.InProgress;
    }

    public void Update(int patrimony, string? description, string solution)
    {
        Patrimony = patrimony;
        Description = description ?? Description;
        Solution = solution;
    }

    private void Validate()
    {

    }
}








