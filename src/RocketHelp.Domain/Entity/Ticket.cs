using RocketHelp.Domain.Enum;

namespace RocketHelp.Domain.Entity;

public class Ticket
{
    public int Patrimony { get; private set; }
    public string Description { get; private set; }
    public string Solution { get; private set; }
    public Status Status { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Ticket(int patrimony, string description, string solution, Status status = Status.InProgress, DateTime createdAt)
    {
        Patrimony = patrimony;
        Description = description;
        Solution = solution;
        Status = status;
        CreatedAt = createdAt;
    }

    public void Finish()
    {
        Status = Status.Finish;
    }

    public void InProgress()
    {
        Status = Status.InProgress;
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








