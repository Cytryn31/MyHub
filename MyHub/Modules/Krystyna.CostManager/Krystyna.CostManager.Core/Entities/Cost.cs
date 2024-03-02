namespace Krystyna.CostManager.Core.Entities;

public class Cost
{
    public int Id { get; private set; }
    public CostDefinition CostDefinition { get; private set; }
    public int Month { get; private set; }
    public int Year { get; private set; }
    public List<Invoice> Invoices { get; set; } = new List<Invoice>();
    
    public static Cost Create(CostDefinition costDefinition, int month, int year)
    {
        var cost = new Cost
        {
            Month = month,
            Year = year,
            CostDefinition = costDefinition
        };

        var invoices = new List<Invoice>
        {
            new()
            {
                Cost = cost,
                InvoiceStatus = InvoiceStatus.New
            }
        };
        
        cost.Invoices = invoices;
        return cost;
    }
}