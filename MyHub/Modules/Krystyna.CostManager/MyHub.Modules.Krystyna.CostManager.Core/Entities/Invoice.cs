namespace MyHub.Modules.Krystyna.CostManager.Core.Entities;

public class Invoice
{
    public int Id { get; set; }
    public int CostId { get; set; }
    public Cost Cost { get; set; }
    public InvoiceStatus InvoiceStatus { get; set; }
}